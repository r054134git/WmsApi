using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Wms.Telegram;
using WmsApi;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlTruckLoadListController : EntityControllerBase<TPlTruckLoadList, TPlTruckLoadListReadModel, TPlTruckLoadListCreateModel, TPlTruckLoadListUpdateModel>
    {
        public TPlTruckLoadListController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckLoadListCreateModel> createValidator, IValidator<TPlTruckLoadListUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 移库/发货单列表
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlTruckLoadListReadModel>>> GetAllLoadingNos_old([FromQuery] PageParam pageParam, string vehicleNo, [FromQuery] int[] resolveState, [FromQuery] string[] sourceHouse)
        {
            var repoPlLoadList = DataContext.Set<TPlTruckLoadList>();

            var predicate = ExpressionBuilder.True<TPlTruckLoadList>();
            predicate = predicate.And(t => t.IsFinished == 0 && t.IsEnable == 1);
            if (!string.IsNullOrEmpty(vehicleNo))
            {
                predicate = predicate.And(t => t.VehicleNo.Contains(vehicleNo));
            }
            if (resolveState != null && resolveState.Count() < 2)
            {
                if (resolveState.Contains(0))
                {
                    predicate = predicate.And(t => t.ResolveState == 0 || t.ResolveState == null);
                }
                if (resolveState.Contains(1))
                {
                    predicate = predicate.And(t => t.ResolveState == 1);
                }
            }

            if (sourceHouse != null && sourceHouse.Length > 0)
            {
                predicate = predicate.And(t => sourceHouse.Contains(t.SourceHouse));
            }

            var query = GetQueryOrderByIdAsc(predicate).OrderByDescending(t => t.ResolveState);

            var listResult = await QueryPageModel(query, pageParam);
            return Ok(listResult);
        }


        /// <summary>
        /// 移库/发货单列表
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlTruckLoadListReadModel>>> GetAllLoadingNos([FromQuery] PageParam pageParam, string where, string orders)
        {
            var repoPlLoadList = DataContext.Set<TPlTruckLoadList>();
            var predicate = ExpressionBuilder.True<TPlTruckLoadList>();
            predicate = predicate.And(t => t.IsFinished == 0 && t.IsEnable == 1);
            var query = repoPlLoadList.AsNoTracking();
            query = query.Where(predicate);
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }
            var listResult = await QueryPageModel(query, pageParam);
            return Ok(listResult);
        }


        /// <summary>
        /// 移库/发货 未挑库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<List<VPlMaterialReadModel>>>>
            GetAllUnpicked_old(string vehicleNo, string truckLoadingNo, string detailNo)
        {
            List<VPlMaterialReadModel> result = new List<VPlMaterialReadModel>();
            var plLoadList = await DataContext.Set<TPlTruckLoadList>()
                .FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                return new OperationResult<List<VPlMaterialReadModel>>(false, $"装车清单号{truckLoadingNo}不存在", new List<VPlMaterialReadModel>());
            }
            var repoPlDelivery = DataContext.Set<TPlTruckDelivery>();
            var repoPlDeliveryDetail = DataContext.Set<TPlTruckDeliveryDetail>();
            var repoMaterial = DataContext.Set<VPlMaterial>();

            var orderNo = plLoadList.OrderNo + plLoadList.DetailNo;
            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };
            var delivery = repoPlDelivery.Where(t => t.DeliveryOrderNo == plLoadList.DeliveryOrderNo && t.OrderNo == plLoadList.OrderNo && t.DetailNo == plLoadList.DetailNo).FirstOrDefault();

            //按件挑库 按量挑库公共条件，
            //材料状态码为{“33”}其中一项，未挑库状态，有主，判定代码为complexDecideCodes其中一项
            //未封锁，已包装
            var predicate = ExpressionBuilder.True<VPlMaterial>();
            predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) &&
                                  t.OrderNo == orderNo &&
                                  matStatusList.Contains(t.MatStatus) &&
                                  t.PickState == (int)PickStateOfCoil.DeliveryPrePicked &&
                                  t.TruckLoadListId == plLoadList.Id &&
                                  t.IsOrdered == 1 &&
                                  complexDecideCodes.Contains(t.ComplexDecideCode) &&
                  t.HoldFlag == "0" && t.ProductPackFlag == "1");
            if (delivery != null && delivery.IsSpecifyCoilNo == "Y")
            {
                //钢卷在detail表中，订单号为装车清单中的订单号和明细号之和，
                var details = repoPlDeliveryDetail.Where(t => t.OwnerId == delivery.Id).Select(t => t.CoilNo).ToList();
                predicate = predicate.And(t => details.Contains(t.No));
            }
            var trs = repoMaterial.Where(predicate).ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider).ToList();
            result.AddRange(trs);

            return new OperationResult<List<VPlMaterialReadModel>>(true, "", result);
        }

        /// <summary>
        /// 移库/发货 未挑库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<List<VPlMaterialReadModel>>>>
            GetAllUnpicked(string vehicleNo, string truckLoadingNo, string detailNo, string where, string orders, CancellationToken cancellationToken)
        {
            List<VPlMaterialReadModel> result = new List<VPlMaterialReadModel>();
            var plLoadList = await DataContext.Set<TPlTruckLoadList>()
                .FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                return new OperationResult<List<VPlMaterialReadModel>>(false, $"装车清单号{truckLoadingNo}不存在", new List<VPlMaterialReadModel>());
            }
            var repoPlDelivery = DataContext.Set<TPlTruckDelivery>();
            var repoPlDeliveryDetail = DataContext.Set<TPlTruckDeliveryDetail>();
            var repoMaterial = DataContext.Set<VPlMaterial>();

            var orderNo = plLoadList.OrderNo + plLoadList.DetailNo;
            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };
            var delivery = repoPlDelivery.Where(t => t.DeliveryOrderNo == plLoadList.DeliveryOrderNo && t.OrderNo == plLoadList.OrderNo && t.DetailNo == plLoadList.DetailNo).FirstOrDefault();

            //按件挑库 按量挑库公共条件，
            //材料状态码为{“33”}其中一项，未挑库状态，有主，判定代码为complexDecideCodes其中一项
            //未封锁，已包装
            var predicate = ExpressionBuilder.True<VPlMaterial>();
            predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
                                  t.OrderNo == orderNo &&
                                  matStatusList.Contains(t.MatStatus) &&
                                  t.PickState == (int)PickStateOfCoil.DeliveryPrePicked &&
                                  t.TruckLoadListId == plLoadList.Id &&
                                  t.IsOrdered == 1 &&
                                  complexDecideCodes.Contains(t.ComplexDecideCode) &&
                  t.HoldFlag == "0" && t.ProductPackFlag == "1");
            if (delivery != null && delivery.IsSpecifyCoilNo == "Y")
            {
                //钢卷在detail表中，订单号为装车清单中的订单号和明细号之和，
                var details = repoPlDeliveryDetail.Where(t => t.OwnerId == delivery.Id).Select(t => t.CoilNo).ToList();
                predicate = predicate.And(t => details.Contains(t.No));
            }
            var query = repoMaterial.AsNoTracking();
            query = query.Where(predicate);
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }
            var trs = await query.ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            result.AddRange(trs);

            return new OperationResult<List<VPlMaterialReadModel>>(true, "", result);
        }

        /// <summary>
        /// 移库/发货 已挑库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<VPlMaterialReadModel>>> GetAllPicked_old(string vehicleNo, string truckLoadingNo, string detailNo)
        {
            List<VPlMaterialReadModel> result = new List<VPlMaterialReadModel>();
            var plLoadList = await DataContext.Set<TPlTruckLoadList>().
                FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                return new PageResult<VPlMaterialReadModel>();
            }

            var plMaterials = await DataContext.Set<VPlMaterial>()
                .Where(t => t.TruckLoadListId == plLoadList.Id && t.PickState == (int)PickStateOfCoil.Picked)
                .ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync();
            result.AddRange(plMaterials);
            return new PageResult<VPlMaterialReadModel>
            {
                Data = result
            };
        }

        /// <summary>
        /// 移库/发货 已挑库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<VPlMaterialReadModel>>> GetAllPicked(string vehicleNo, string truckLoadingNo, string detailNo,
            string where, string orders, CancellationToken cancellationToken)
        {
            List<VPlMaterialReadModel> result = new List<VPlMaterialReadModel>();
            var plLoadList = await DataContext.Set<TPlTruckLoadList>().
                FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                return new PageResult<VPlMaterialReadModel>();
            }
            var plMaterials = DataContext.Set<VPlMaterial>();
            var query = plMaterials.AsNoTracking();
            query = query.Where(t => t.TruckLoadListId == plLoadList.Id && t.PickState == (int)PickStateOfCoil.Picked && t.Type != 1);
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }
            var tpl = await query.ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            result.AddRange(tpl);
            return new PageResult<VPlMaterialReadModel>
            {
                Data = result
            };
        }

        /// <summary>
        /// 移库/发货挑库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Pick(string vehicleNo, string truckLoadingNo, string detailNo, string materialNo, CancellationToken cancellationToken)
        {
            var plLoadList = await DataContext.Set<TPlTruckLoadList>().
                FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                return new OperationResult(false, $"装车清单号{truckLoadingNo}/{detailNo}不存在");
            }

            //锁定挑库
            var plMaterial = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == materialNo);
            var trLoc = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == materialNo);
            if (plMaterial != null)
            {
                plMaterial.TruckLoadListId = plLoadList.Id;
                plMaterial.PickState = (int)PickStateOfCoil.Picked;
            }
            if (trLoc != null)
            {
                trLoc.TruckLoadListId = plLoadList.Id;
                trLoc.PickState = (int)PickStateOfCoil.Picked;
            }
            await DataContext.SaveChangesAsync(cancellationToken);

            //发送汽车终端挑库装车信息
            var trTruck = await DataContext.Set<TTrTruck>().FirstOrDefaultAsync(t => t.TruckNo == plLoadList.VehicleNo && t.MainTruckLoadingNo == plLoadList.MainTruckLoadingNo);
            if (trTruck != null)
            {
                string bayCode = trTruck.ParkingNoCurrent?.Substring(0, 2);
                var loadListIds = DataContext.Set<TPlTruckLoadList>().Where(t => t.IsEnable == 1 && t.VehicleNo == trTruck.TruckNo && t.MainTruckLoadingNo == trTruck.MainTruckLoadingNo).Select(t => t.Id);
                if (loadListIds != null && loadListIds.Count() > 0)
                {
                    //当前库所有发货的
                    var deliveryMats = DataContext.Set<VPlMaterial>().Where(t => loadListIds.Contains(t.TruckLoadListId) && t.BayCode == bayCode);

                    if (deliveryMats != null && deliveryMats.Count() > 0)
                    {
                        CoilStateDetail[] coilStateDetail = new CoilStateDetail[30];

                        for (var i = 0; i < 30; i++)
                        {
                            coilStateDetail[i] = new CoilStateDetail();

                        }
                    }
                }
            }
            //发送MES挑库信息
            List<CoilOrderDetail> pickMatNos = new List<CoilOrderDetail>();
            pickMatNos.Add(new CoilOrderDetail { CoilNo = plMaterial.No, OrderNo = plMaterial.OrderNo });
            await SendPickedToMes(plLoadList, pickMatNos, "3");
            return new OperationResult(true, $"装车清单号{truckLoadingNo},卷号{materialNo}挑库完成");
        }

        /// <summary>
        /// 移库/发货挑库取消
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Unpick(string vehicleNo, string truckLoadingNo, string detailNo, string materialNo, CancellationToken cancellationToken)
        {
            var plLoadList = await DataContext.Set<TPlTruckLoadList>().
                FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                return new OperationResult(false, $"装车清单号{truckLoadingNo}/{detailNo}不存在");
            }
            //var plDelivery = await DataContext.Set<TPlTruckDelivery>().FirstOrDefaultAsync(t => t.DeliveryOrderNo == plLoadList.DeliveryOrderNo);
            //if (plDelivery == null)
            //{
            //    return new OperationResult(false, $"装车清单号{truckLoadingNo}的发货通知单号不存在");
            //}

            //锁定预挑库
            var plMaterial = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == materialNo);
            var trLoc = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == materialNo);
            if (trLoc == null || trLoc.Type != 2 || (!trLoc.AreaCode.Contains("PM") && trLoc.Type != 2))
            {
                return new OperationResult(true, $"钢卷{materialNo}不在库，无法取消挑库，请先入库！");
            }

            if (plMaterial != null)
            {
                //plMaterial.TruckLoadListId = "";
                plMaterial.PickState = (int)PickStateOfCoil.DeliveryPrePicked;
            }
            if (trLoc != null)
            {
                //trLoc.TruckLoadListId = "";
                trLoc.PickState = (int)PickStateOfCoil.DeliveryPrePicked;
            }

            List<CoilOrderDetail> pickMatNos = new List<CoilOrderDetail>();
            pickMatNos.Add(new CoilOrderDetail { CoilNo = plMaterial.No, OrderNo = plMaterial.OrderNo });
            await SendPickedToMes(plLoadList, pickMatNos, "4");
            await Task.Delay(500);
            var mbs = ServiceProvider.GetService<MbsProxy>();
            TeleWMBM01 tele01 = new TeleWMBM01
            {
                Payload = new CoilLocationChanged
                {
                    CoilNo = plMaterial.No,
                    House = trLoc.OwnerBussinessName,
                    Area = trLoc.BayCode + trLoc.AreaCode,
                    Column = trLoc.ColNo.ToString(),
                    Row = trLoc.RowNo.ToString(),
                    Tier = trLoc.FloorNo.ToString(),
                    ChangeType = "0",
                    Operator = MesUser.GetUserName(trLoc.OwnerBussinessName),
                    OperationTime = DateTime.Now
                }
            };
            await mbs.Publish(tele01);
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();
            var record = new TRcMaterialEvent
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                MaterialId = plMaterial.Id,
                MaterialNo = plMaterial.No,
                Dt = DateTime.Now,
                OperationType = "人工",
                ContentType = "取消挑库",
                FromLocationName = trLoc.LocationName,
                ToLocationName = "",
                Description = $"汽运车号/装车单号/明细号：{plLoadList.VehicleNo}/{plLoadList.TruckLoadingNo}/{plLoadList.DetailNo}进行取消挑库，人工取消",
                FromPosition = $"",
                ToPosition = $"",
                Result = "成功",
                Remark = "",
            };
            repoMatEv.Add(record);

            #region old 代码
            //var repoMessage = DataContext.Set<TTrMessageSend>();
            //var messageSend = new TTrMessageSend()
            //{
            //    Id = IdWorkerGenerator.Instance.NextId().ToString(),
            //    MessageId = "WMBM01",
            //    MaterialNo = plMaterial.No,
            //    DestLocation = trLoc.LocationName,
            //    BayCode = trLoc.BayCode,
            //    Area = trLoc.BayCode + trLoc.AreaCode,
            //    BusinessName = trLoc.OwnerBussinessName,
            //    Floor = trLoc.FloorNo.ToString(),
            //    Col = trLoc.ColNo.ToString(),
            //    Row = trLoc.RowNo.ToString(),
            //    Type = "0",
            //    IsEnable = 1,
            //    CreateTime = DateTime.Now,
            //    CreateUser = "API",
            //    UpdateTime = DateTime.Now,
            //    UpdateUser = "API",
            //    Operator = MesUser.GetUserName(trLoc.OwnerBussinessName),
            //};
            //repoMessage.Add(messageSend);
            #endregion

            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, $"装车清单号{truckLoadingNo},卷号{materialNo}取消挑库完成");
        }

        /// <summary>
        /// 一键整车入库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> CarloadIn(string vehicleNo, string mainTruckLoadingNo, CancellationToken cancellationToken)
        {
            var plLoadLists = DataContext.Set<TPlTruckLoadList>()
                .Where(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.MainTruckLoadingNo == mainTruckLoadingNo).ToList();
            if (plLoadLists.Count <= 0)
            {
                return new OperationResult(false, $"主装车清单号{mainTruckLoadingNo}数据不存在");
            }

            var loadListIds = plLoadLists.Select(t => t.Id).ToList();
            var pickMatList = DataContext.Set<VPlMaterial>().Where(t => loadListIds.Contains(t.TruckLoadListId) && t.PickState == 3).ToList();
            if (pickMatList.Count <= 0)
            {
                return new OperationResult(true, $"车号{vehicleNo}未曾挑库，无需一键入库");
            }
            var pickMatNos = pickMatList.Select(t => t.No);
            var pickHisLocs = DataContext.Set<TRcMaterialEvent>().Where(t => pickMatNos.Contains(t.MaterialNo) && t.Description.Contains(vehicleNo));
            var inPLocs = new List<string>();
            var dicBayMat = new Dictionary<string, List<VPlMaterial>>();
            foreach (var mat in pickMatList)
            {
                //if (!string.IsNullOrEmpty(mat.LocationName) && mat.LocationName.Contains("P"))
                //{
                //    var pN = mat.LocationName.Substring(2, 2);
                //    inPLocs.Add(mat.LocationName.Replace(pN, "PM"));
                //}
                var pickHisLoc = pickHisLocs.OrderByDescending(t => t.Dt).FirstOrDefault(t => t.MaterialNo == mat.No);
                if (pickHisLoc != null)
                {
                    string curBay = pickHisLoc.FromLocationName.Substring(0, 2);
                    if (dicBayMat.TryGetValue(curBay, out List<VPlMaterial> matNos))
                    {
                        matNos.Add(mat);
                    }
                    else
                    {
                        dicBayMat.TryAdd(curBay, new List<VPlMaterial> { mat });
                    }
                }
            }
            var bayKeys = dicBayMat.Keys;
            if (bayKeys.Count > 0)
            {
                foreach (var bay in bayKeys)
                {
                    var inMats = dicBayMat[bay];
                    for (int i = 0; i < inMats.Count; i++)
                    {
                        var mat = inMats[i];
                        if (!string.IsNullOrEmpty(mat.LocationName) && mat.LocationName.Contains("P"))
                        {
                            var clearLoc = DataContext.Set<TTrLocationMaterial>().FirstOrDefault(t => t.LocationName == mat.LocationName);
                            if (clearLoc != null)
                            {
                                CommClearLocMat(clearLoc);
                            }
                            var clearWhLoc = DataContext.Set<TWhLocation>().FirstOrDefault(t => t.Name == mat.LocationName);
                            if (clearWhLoc != null)
                            {
                                clearWhLoc.PointX = 0;
                                clearWhLoc.PointY = 0;
                            }
                        }
                        var inLoc = DataContext.Set<TTrLocationMaterial>().FirstOrDefault(t => t.LocationName == $"{bay}PM01{(i + 1).ToString().PadLeft(2, '0')}1");
                        if (inLoc != null)
                        {
                            CommUpdateMatToLoc(inLoc, mat);
                        }
                    }
                }
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, $"车号{vehicleNo},整车入库完成");
        }

        /// <summary>
        /// 移库/发货出库确认
        /// </summary>
        [HttpPost("")]
        [TokenActionFilter]
        public async Task<ActionResult<OperationResult>> Confirm(string vehicleNo, string mainTruckLoadingNo, string sourceHouse, CancellationToken cancellationToken)
        {
            var identityName = MesUser.GetUserName(sourceHouse);

            //确认装车清单状态
            var plLoadLists = DataContext.Set<TPlTruckLoadList>()
                .Where(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.MainTruckLoadingNo == mainTruckLoadingNo && t.SourceHouse == sourceHouse).ToList();
            if (plLoadLists == null || plLoadLists.Count == 0)
            {
                return new OperationResult(false, $"车号{vehicleNo}不存在");
            }
            foreach (var plLoadList in plLoadLists)
            {
                plLoadList.IsFinished = 1;
            }

            var confirmLoad = plLoadLists.FirstOrDefault();
            var truckTran = await DataContext.Set<TPlTruckTransfer>().FirstOrDefaultAsync(t => confirmLoad.DeliveryOrderNo.Contains(t.TransferNo));
            if (truckTran != null)
            {
                truckTran.PickState = 3;
            }

            await DataContext.SaveChangesAsync(cancellationToken);

            var mbs = ServiceProvider.GetService<MbsProxy>();
            var teleWMBM12 = new TeleWMBM12
            {
                Payload = new TruckOutBound
                {
                    OperationMark = "N",
                    Card = confirmLoad.CardNo,
                    MainTruckLoadingNo = confirmLoad.MainTruckLoadingNo,
                    TruckLoadingNo = confirmLoad.TruckLoadingNo,
                    OrderInformNo = confirmLoad.DeliveryOrderNo,
                    OrderNo = confirmLoad.OrderNo,
                    DetailNo = confirmLoad.DetailNo,
                    TruckNo = confirmLoad.VehicleNo,
                    SourceHouse = confirmLoad.SourceHouse,
                    Operator = identityName
                }
            };
            await mbs.Publish(teleWMBM12);

            return new OperationResult(true, $"车牌号{vehicleNo}出库完成");
        }

        /// <summary>
        /// 移库/发货出库撤销
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Cancel(string vehicleNo, string mainTruckLoadingNo, string sourceHouse, CancellationToken cancellationToken)
        {
            var identityName = MesUser.GetUserName(sourceHouse);
            //确认装车清单状态
            var plLoadLists = DataContext.Set<TPlTruckLoadList>()
                .Where(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.MainTruckLoadingNo == mainTruckLoadingNo && t.SourceHouse == sourceHouse).ToList();
            if (plLoadLists == null || plLoadLists.Count == 0)
            {
                return new OperationResult(false, $"车号{vehicleNo}不存在");
            }
            foreach (var plLoadList in plLoadLists)
            {
                plLoadList.IsFinished = 0;
            }

            var confirmLoad = plLoadLists.FirstOrDefault();
            var truckTran = await DataContext.Set<TPlTruckTransfer>().FirstOrDefaultAsync(t => confirmLoad.DeliveryOrderNo.Contains(t.TransferNo));
            if (truckTran != null)
            {
                truckTran.PickState = 2;
            }
            await DataContext.SaveChangesAsync(cancellationToken);

            var mbs = ServiceProvider.GetService<MbsProxy>();
            var teleWMBM12 = new TeleWMBM12
            {
                Payload = new TruckOutBound
                {
                    OperationMark = "R",
                    Card = confirmLoad.CardNo,
                    MainTruckLoadingNo = confirmLoad.MainTruckLoadingNo,
                    TruckLoadingNo = confirmLoad.TruckLoadingNo,
                    OrderInformNo = confirmLoad.DeliveryOrderNo,
                    OrderNo = confirmLoad.OrderNo,
                    DetailNo = confirmLoad.DetailNo,
                    TruckNo = confirmLoad.VehicleNo,
                    SourceHouse = confirmLoad.SourceHouse,
                    Operator = identityName
                }
            };
            await mbs.Publish(teleWMBM12);

            //撤销发货实绩成功，
            return new OperationResult(true, $"车牌号{vehicleNo}撤销出库完成");
        }

        /// <summary>
        /// 挑库/取消挑库 发送MES
        /// </summary>
        /// <param name="loadList"></param>
        /// <param name="pickMatNos"></param>
        /// <param name="pickType"></param>
        /// <returns></returns>
        private async Task SendPickedToMes(TPlTruckLoadList loadList, List<CoilOrderDetail> pickMatNos, string pickType, string userAccount = "")
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();
            var identityName = userAccount;
            var teleWMBM09 = new TeleWMBM09
            {
                Payload = new TruckPickCoilInfo
                {
                    TruckNo = loadList.VehicleNo,
                    OrderInformNo = loadList.DeliveryOrderNo,
                    MainTruckLoadingNo = loadList.MainTruckLoadingNo,
                    TruckLoadingNo = loadList.TruckLoadingNo,
                    PickType = pickType,
                    Operator = identityName
                    //Details = pickMatNos.ToArray()
                }
            };
            teleWMBM09.Payload.Details[0].OrderNo = pickMatNos.FirstOrDefault().OrderNo;
            teleWMBM09.Payload.Details[0].CoilNo = pickMatNos.FirstOrDefault().CoilNo;
            await mbs.Publish(teleWMBM09);
        }

        /// <summary>
        /// 按主装单号查询已预挑/已挑库卷信息
        /// </summary>
        /// <param name="truckLoadingNo"></param>
        /// <param name="pickState"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<List<HoldPickModel>>> GetAllLoadInfo(string truckLoadingNo, int pickState)
        {
            var repoPlDelivery = DataContext.Set<TPlTruckDelivery>();
            var repoPlDeliveryDetail = DataContext.Set<TPlTruckDeliveryDetail>();
            var repoMaterial = DataContext.Set<TPlMaterial>();
            var repoVMaterial = DataContext.Set<VPlMaterial>();
            var repotrLM = DataContext.Set<TTrLocationMaterial>();
            var plLoadList = DataContext.Set<TPlTruckLoadList>()
                .Where(t => t.MainTruckLoadingNo == truckLoadingNo && t.IsEnable == 1).ToList();
            if (plLoadList == null || plLoadList.Count == 0)
            {
                return new List<HoldPickModel>();
            }
            var pickList = new List<HoldPickModel>();
            foreach (var item in plLoadList)
            {
                var pls = repoMaterial.Where(t => t.TruckLoadListId == item.Id).ToList();
                foreach (var pl in pls)
                {
                    var trlm = repotrLM.Where(t => t.MaterialNo == pl.No && t.Type == 2).FirstOrDefault();
                    if (trlm != null && !trlm.LocationName.Contains("88"))
                    {
                        var model = new HoldPickModel
                        {
                            LocationName = trlm.LocationName,
                            MaterialNo = pl.No,
                            Weight = pl.Weight,
                            VehicleNo = item.VehicleNo,
                            PickState = pl.PickState,
                            MainTruckLoadingNo = item.MainTruckLoadingNo,
                            //Width = pl.Width,
                            Width = $"{pl.Width}*{pl.Thick}",
                            MatDisposeCode = pl.MatDisposeCode,
                            SteelGrade = pl.SteelGrade,
                            Thick = pl.Thick
                            //ColorDemand = pl.ColorDemand,
                            //PackingTypeCode = pl.PackingTypeCode
                        };
                        pickList.Add(model);
                    }
                    else
                    {
                        var model = new HoldPickModel
                        {
                            LocationName = "null",
                            MaterialNo = pl.No,
                            Weight = pl.Weight,
                            VehicleNo = item.VehicleNo,
                            PickState = pl.PickState,
                            MainTruckLoadingNo = item.MainTruckLoadingNo,
                            //Width= pl.Width,
                            Width = $"{pl.Width}*{pl.Thick}",
                            MatDisposeCode = pl.MatDisposeCode,
                            SteelGrade = pl.SteelGrade,
                            Thick = pl.Thick
                        };
                        pickList.Add(model);
                    }
                }
            }
            DataContext.SaveChanges();
            return pickList;
        }


        /// <summary>
        /// 手持挑库
        /// </summary>
        /// <returns></returns>
        [TokenActionFilter]
        [HttpPut("")]
        public async Task<ActionResult<OperationResult<TPlTruckLoadListReadModel>>> UpdateCoilPick(string materialNo, string account, string orderNo, string vehicleNo, CancellationToken cancellationToken, bool pick = false)
        {
            var repoMaterial = DataContext.Set<TPlMaterial>();
            var repotrLM = DataContext.Set<TTrLocationMaterial>();
            var repoLog = DataContext.Set<TRcLog>();
            var repoPlLoadList = DataContext.Set<TPlTruckLoadList>();
            var pls = await repoMaterial.Where(t => t.No == materialNo).FirstOrDefaultAsync();
            if (pls != null)
            {

                var log1 = new TRcLog
                {
                    Id = DateTime.Now.ToFileTime().ToString(),
                    Dt = DateTime.Now,
                    EventNo = "1000",
                    WarningLevel = "INFO",
                    Message = $"{pls.No}准备挑库 pickState：{pls.PickState}",
                    Source = "API"
                };
                repoLog.Add(log1);
                if (pls.PickState == 3)
                {
                    //var log = new TRcLog
                    //{
                    //    Id = DateTime.Now.ToFileTime().ToString(),
                    //    Dt = DateTime.Now,
                    //    EventNo = "1000",
                    //    WarningLevel = "INFO",
                    //    Message = $"挑库用户：{account}，手持发送MES{pls.No}挑库信息",
                    //    Source = "API"
                    //};
                    //repoLog.Add(log);
                    //await DataContext.SaveChangesAsync(cancellationToken);
                    //var plLoadList = repoPlLoadList.Where(t => t.Id == pls.TruckLoadListId).FirstOrDefault();
                    ////发送MES挑库信息
                    //List<CoilOrderDetail> pickMatNos = new List<CoilOrderDetail>
                    //{
                    //    new CoilOrderDetail { CoilNo = pls.No, OrderNo = pls.OrderNo }
                    //};
                    //await SendPickedToMes(plLoadList, pickMatNos, "3", account);
                    var data = repoPlLoadList.Where(t => t.Id == pls.TruckLoadListId).ProjectTo<TPlTruckLoadListReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                    return new OperationResult<TPlTruckLoadListReadModel>(false, $"{materialNo}已挑库", data);
                }
                if (pls.PickState == 2 || pick)
                {
                    pls.PickState = 3;
                    var log = new TRcLog
                    {
                        Id = DateTime.Now.ToFileTime().ToString(),
                        Dt = DateTime.Now,
                        EventNo = "1000",
                        WarningLevel = "INFO",
                        Message = $"挑库用户：{account}，手持发送MES {pls.No}挑库信息",
                        Source = "API"
                    };
                    repoLog.Add(log);
                    var count = await DataContext.SaveChangesAsync(cancellationToken);
                    var plLoadList = repoPlLoadList.Where(t => t.Id == pls.TruckLoadListId).FirstOrDefault();
                    if (count >= 2)
                    {
                        //发送MES挑库信息
                        List<CoilOrderDetail> pickMatNos = new List<CoilOrderDetail>
                    {
                        new CoilOrderDetail { CoilNo = pls.No, OrderNo = pls.OrderNo }
                    };
                        await SendPickedToMes(plLoadList, pickMatNos, "3", account);
                        var data = repoPlLoadList.Where(t => t.Id == pls.TruckLoadListId).ProjectTo<TPlTruckLoadListReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                        return new OperationResult<TPlTruckLoadListReadModel>(true, $"{materialNo}挑库成功", data);
                    }
                    return new OperationResult<TPlTruckLoadListReadModel>(false, $"{materialNo}挑库未成功，请重新挑库", null);
                }
                else if (pls.PickState == 1)
                {
                    return new OperationResult<TPlTruckLoadListReadModel>(false, $"移库预挑库", null);
                }
                else if (pls.PickState == null || pls.PickState == 0)
                {
                    if (orderNo == null || orderNo == "")
                    {
                        return new OperationResult<TPlTruckLoadListReadModel>(false, $"{materialNo}未预挑库", null);
                    }
                    else
                    {
                        var plLoadLists = repoPlLoadList.Where(t => t.MainTruckLoadingNo == orderNo && t.IsEnable == 1).ToList();
                        if (plLoadLists != null || plLoadLists.Count != 0)
                        {
                            foreach (var item in plLoadLists)
                            {
                                var plmaterials = repoMaterial.Where(t => t.TruckLoadListId == item.Id).ToList();
                                foreach (var pl in plmaterials)
                                {
                                    if (pl.PickState == 3)
                                    {
                                        pl.PickState = 2;
                                    }
                                }
                            }
                            DataContext.SaveChanges();
                            return new OperationResult<TPlTruckLoadListReadModel>(false, $"{materialNo}未预挑库,为确保{vehicleNo}信息无误，请重新挑库", null);
                        }
                    }
                }
            }

            return NotFound();
        }

        /// <summary>
        /// 手持出库确认
        /// </summary>
        [HttpPost("")]
        [TokenActionFilter]
        public async Task<ActionResult<OperationResult>> HoldConfirm(string mainTruckLoadingNo, string sourceHouse, CancellationToken cancellationToken)
        {
            var identityName = MesUser.GetUserName(sourceHouse);
            var mbs = ServiceProvider.GetService<MbsProxy>();

            string bayCode = "";

            //确认装车清单状态
            var repoPl = DataContext.Set<TPlMaterial>();
            var repoTrParking = DataContext.Set<TTrParkingPlace>();
            var repotrLM = DataContext.Set<TTrLocationMaterial>();
            var repoEvent = DataContext.Set<TRcMaterialEvent>();
            var repoRc = DataContext.Set<TRcLog>();
            var repoQueue = DataContext.Set<TTrTruckBayQueue>();
            var repoRcQueue = DataContext.Set<TRcTruckBayQueue>();
            var plLoadLists = DataContext.Set<TPlTruckLoadList>()
                .Where(t => t.MainTruckLoadingNo == mainTruckLoadingNo && t.SourceHouse == sourceHouse && t.IsEnable == 1).ToList();
            var confirmLoad = plLoadLists.FirstOrDefault();
            //if (plLoadLists.Any(t => t.IsFinished == 1))
            //{
            //    return new OperationResult(true, $"已出库成功，无需重复操作");
            //}
            if (plLoadLists == null || plLoadLists.Count == 0)
            {
                return new OperationResult(false, $"出库失败，请检查装车单号");
            }
            var trTruck = await DataContext.Set<TTrTruck>().OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync(t => t.MainTruckLoadingNo == confirmLoad.MainTruckLoadingNo && t.TruckNo == confirmLoad.VehicleNo);
            if (trTruck != null)
            {
                if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList) && trTruck.LoadBayCodeList.Length > 2)
                {
                    var trQueueInfo = DataContext.Set<TTrTruckBayQueue>().FirstOrDefault(t => t.BayCode == bayCode && t.TruckNo == trTruck.TruckNo && t.MainLoadingNo == t.MainLoadingNo);
                    if (trQueueInfo != null && trQueueInfo.DispatchStepState != 4)
                    {
                        trQueueInfo.DispatchStepState = 4;
                        trQueueInfo.IsEnable = 0;
                        var wmbm17 = new TeleWMBM17
                        {
                            //Payload = new TruckInOutInfo
                            //{
                            //    OperationMark = "G",
                            //    MainTruckLoadingNo = trQueueInfo.MainLoadingNo,
                            //    VehicleNo = trQueueInfo.TruckNo,
                            //    BayNo = trQueueInfo.BayCode,
                            //    House = sourceHouse
                            //}
                        };
                        //await mbs.Publish(wmbm17);
                        return new OperationResult(true, $"出库成功，当前是多库房装车，请前往下一库房装车");
                    }
                }
            }

            foreach (var item in plLoadLists)
            {
                var pls = repoPl.Where(t => t.TruckLoadListId == item.Id && t.PickState != 3).ToList();
                if (pls.Count != 0)
                {
                    return new OperationResult(false, $"出库失败，该库房还存在未挑库物料");
                }
            }
            foreach (var plLoadList in plLoadLists)
            {
                plLoadList.IsFinished = 1;
            }

            var truckTran = await DataContext.Set<TPlTruckTransfer>().FirstOrDefaultAsync(t => confirmLoad.DeliveryOrderNo.Contains(t.TransferNo));
            if (truckTran != null)
            {
                truckTran.PickState = 3;
            }

            var teleWMBM12 = new TeleWMBM12
            {
                Payload = new TruckOutBound
                {
                    OperationMark = "N",
                    Card = confirmLoad.CardNo,
                    MainTruckLoadingNo = confirmLoad.MainTruckLoadingNo,
                    TruckLoadingNo = confirmLoad.TruckLoadingNo,
                    OrderInformNo = confirmLoad.DeliveryOrderNo,
                    OrderNo = confirmLoad.OrderNo,
                    DetailNo = confirmLoad.DetailNo,
                    TruckNo = confirmLoad.VehicleNo,
                    SourceHouse = confirmLoad.SourceHouse,
                    Operator = identityName,
                }
            };
            await mbs.Publish(teleWMBM12);

            var log1 = new TRcLog
            {
                Id = DateTime.Now.ToFileTime().ToString(),
                Dt = DateTime.Now,
                EventNo = "1000",
                WarningLevel = "INFO",
                Message = $"主装车单/装车单{confirmLoad.MainTruckLoadingNo}/{confirmLoad.TruckLoadingNo}装车单出库完成",
                Source = "API"
            };
            repoRc.Add(log1);
            foreach (var item in plLoadLists)
            {
                var plMaterials = repoPl.Where(t => t.TruckLoadListId == item.Id).ToList();
                foreach (var pl in plMaterials)
                {
                    var trlm = repotrLM.Where(t => t.MaterialNo == pl.No && t.Type == 2).FirstOrDefault();
                    if (trlm != null)
                    {
                        var rcRecord = new TRcMaterialEvent
                        {
                            Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                            MaterialId = pl.Id,
                            Dt = DateTime.Now,
                            MaterialNo = pl.No,
                            OperationType = "人工",
                            ContentType = "手持机出库",
                            FromLocationName = trlm.LocationName,
                            ToLocationName = "",
                            Description = $"手持机出库，清空库存",
                            FromPosition = "",
                            ToPosition = "",
                            Result = "成功"
                        };
                        repoEvent.Add(rcRecord);

                        trlm.BillOfLadingNo = null;
                        trlm.ComplexDecideCode = null;
                        trlm.Description = null;
                        trlm.Diameter = null;
                        trlm.HeadDirection = null;
                        trlm.HoldCauseCode = null;
                        trlm.HoldFlag = null;
                        trlm.HoldRemark = null;
                        trlm.InnerDiameter = null;
                        //trlm.IsLoadEnable = null;
                        trlm.IsOrdered = null;
                        trlm.Length = null;
                        trlm.MaterialId = null;
                        trlm.MaterialNo = null;
                        trlm.MatDirection = null;
                        trlm.MatDisposeCode = null;
                        trlm.MaterialOwner = null;
                        trlm.MatStatus = null;
                        trlm.MaxZ = 0;
                        trlm.NextProcessCode = null;
                        trlm.OrderName = null;
                        trlm.OrderNo = null;
                        trlm.PickState = null;
                        trlm.TruckLoadListId = null;
                        trlm.PrepickTransferNo = null;
                        trlm.ProcessCode = null;
                        trlm.ProdTime = null;
                        trlm.ProductPackFlag = null;
                        trlm.RelMaker = null;
                        trlm.RelRemark = null;
                        trlm.RelTime = null;
                        trlm.SgSign = null;
                        trlm.SgStd = null;
                        trlm.SourceType = null;
                        trlm.Status = 0;
                        trlm.SteelGrade = null;
                        trlm.Thick = null;
                        trlm.Type = (int)LocationMaterialTypes.None;
                        trlm.Weight = null;
                        trlm.Width = null;
                        trlm.LockMark = null;
                        trlm.LockReason = null;
                        trlm.IsDistributionShip = null;
                        trlm.TrimFlag = null;
                        trlm.ProductPackTime = null;
                        trlm.DecideThick = null;
                        trlm.DecideWidth = null;
                        trlm.BundlePackageNo = null;
                        trlm.Terminal = null;
                        trlm.PackingTypeCode = null;
                        trlm.PortLotNumber = null;
                        trlm.TrnpModeCode = null;
                        trlm.UpdateTime = DateTime.Now;
                        trlm.UpdateUser = "API";
                    }
                }
            }

            #region old 代码
            //清空等候列表车牌号
            //var trParkingPlace = repoTrParking.Where(t => t.CandidateTruck.Contains(confirmLoad.VehicleNo)).FirstOrDefault();
            //if (trParkingPlace != null)
            //{
            //    var candidatestr = trParkingPlace.CandidateTruck;
            //    if (candidatestr != null && candidatestr != "")
            //    {
            //        var vehicleNoList = candidatestr.Split(",").ToList();
            //        var vehicleNoToRemove = new List<string>();
            //        foreach (var vehicleNo in vehicleNoList)
            //        {
            //            if (confirmLoad.VehicleNo == vehicleNo)
            //            {
            //                vehicleNoToRemove.Add(vehicleNo);
            //            }
            //        }
            //        foreach (var materialNo in vehicleNoToRemove)
            //        {
            //            vehicleNoList.Remove(materialNo);
            //        }
            //        if (vehicleNoList.Count > 0)
            //        {
            //            trParkingPlace.CandidateTruck = string.Join(",", vehicleNoList);
            //        }
            //        trParkingPlace.UpdateUser = "API";
            //        trParkingPlace.UpdateTime = DateTime.Now;
            //    }
            //}

            //var queueBayList = repoQueue.Where(t => t.IsEnable == 1 && t.HouseNo == sourceHouse && t.MainLoadingNo == mainTruckLoadingNo).ToList();
            //if (queueBayList.Count > 0)
            //{
            //    foreach (var queueInfo in queueBayList)
            //    {
            //        var rcQueueInfo = TransReflection<TTrTruckBayQueue, TRcTruckBayQueue>(queueInfo);
            //        rcQueueInfo.Id = IdWorkerGenerator.Instance.NextId().ToString();
            //        rcQueueInfo.UpdateTime = DateTime.Now;
            //        rcQueueInfo.Remark = $"已离库";
            //        repoRcQueue.Add(rcQueueInfo);
            //        repoQueue.Remove(queueInfo);
            //    }

            //    //var updateBayQueues = queueBayList.Select(t => t.BayCode);
            //    //var curStockDataList = repoQueue.Where(t => t.IsEnable == 1 && updateBayQueues.Contains(t.BayCode) && t.MainLoadingNo != mainTruckLoadingNo && t.CreateTime > DateTime.Now.AddHours(-5)).ToList();
            //    //foreach (var queueBayCode in updateBayQueues)
            //    //{
            //    //    var curInStockCount = curStockDataList.Count(t => t.BayCode == queueBayCode && t.DispatchStepState == 3);
            //    //    if (curInStockCount < 2)
            //    //    {
            //    //        var awaitInStockList = curStockDataList.Where(t => t.BayCode == queueBayCode && t.DispatchStepState != 3).OrderBy(t => t.CreateTime).Take(2 - curInStockCount).ToList();
            //    //        foreach (var awaitInfo in awaitInStockList)
            //    //        {
            //    //            awaitInfo.DispatchStepState = 2;
            //    //            awaitInfo.UpdateTime = DateTime.Now;
            //    //            var wmbm17 = new TeleWMBM17
            //    //            {
            //    //                Payload = new TruckInOutInfo
            //    //                {
            //    //                    MainTruckLoadingNo = awaitInfo.MainLoadingNo,
            //    //                    VehicleNo = awaitInfo.TruckNo,
            //    //                    InformInfo = $"车辆已叫号，请5分钟内到{GetBayDoor(awaitInfo.BayCode)}装车，超时将重新排队"
            //    //                }
            //    //            };
            //    //            await mbs.Publish(wmbm17);
            //    //        }
            //    //    }
            //    //}
            //}
            #endregion

            var queueList = repoQueue.Where(t => t.MainLoadingNo == mainTruckLoadingNo && t.HouseNo == sourceHouse).ToList();
            if (queueList != null && queueList.Count > 0)
            {
                foreach (var queue in queueList)
                {
                    queue.DispatchStepState = 4;
                    queue.ConfirmOutTime = DateTime.Now;
                    if (queue.OutBayTime == null)
                    {
                        queue.OutBayTime = DateTime.Now;
                    }
                    var rcQueueInfo = TransReflection<TTrTruckBayQueue, TRcTruckBayQueue>(queue);
                    rcQueueInfo.Id = IdWorkerGenerator.Instance.NextId().ToString();
                    repoRcQueue.Add(rcQueueInfo);
                    repoQueue.Remove(queue);
                }
            }
            var rcQueueList = repoRcQueue.Where(t => t.MainLoadingNo == mainTruckLoadingNo && t.HouseNo == sourceHouse).ToList();
            if (rcQueueList != null && rcQueueList.Count > 0)
            {
                foreach (var rcQueue in rcQueueList)
                {
                    rcQueue.ConfirmOutTime = DateTime.Now;
                    rcQueue.UpdateTime = DateTime.Now;
                    if (rcQueue.OutBayTime == null)
                    {
                        rcQueue.OutBayTime = DateTime.Now;
                    }
                }
            }

            await DataContext.SaveChangesAsync(cancellationToken);

            return new OperationResult(true, $"{confirmLoad.VehicleNo}出库完成");
        }

        /// <summary>
        /// 二代库手持机抵库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> ArriveHouse(string mainTruckLoadingNo, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlMaterial>();
            var plLoadLists = DataContext.Set<TPlTruckLoadList>();
            var loadList = await plLoadLists.Where(t => t.MainTruckLoadingNo == mainTruckLoadingNo).ToListAsync();
            if (loadList == null || loadList.Count <= 0)
            {
                return new OperationResult(false, $"抵库失败，无装车单信息");
            }
            var loadListIds = loadList.Select(t => t.Id).ToList();
            var materialList = repoPl.Where(t => !string.IsNullOrEmpty(t.TruckLoadListId) && loadListIds.Contains(t.TruckLoadListId)).ToList();

            if (materialList == null || materialList.Count <= 0)
            {
                return new OperationResult(false, $"抵库失败，未找到预挑库卷信息");
            }
            //开始打标记
            foreach (var upMat in materialList)
            {
                upMat.DefectRecorder = loadList.FirstOrDefault().VehicleNo;
                upMat.DefectRecordTime = DateTime.Now;
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, $"抵库成功");
        }


        /// <summary>
        /// 手持出库确认
        /// </summary>
        [HttpPost("")]
        [TokenActionFilter]
        public async Task<ActionResult<OperationResult>> ConfirmOutStore(string bayCode, string vehicleNo, string mainTruckLoadingNo, CancellationToken cancellationToken)
        {
            return new OperationResult(true, $"{vehicleNo}离库成功");
        }

        private static string GetBayDoor(string bayCode)
        {
            if (bayCode == "16" || bayCode == "17")
            {
                return $"1号门{bayCode}库";
            }
            if (bayCode == "21" || bayCode == "22")
            {
                return $"6号门{bayCode}库";
            }
            if (bayCode == "23")
            {
                return $"8号门{bayCode}库";
            }
            if (bayCode == "24")
            {
                return $"10号门{bayCode}库";
            }
            return $"11号门{bayCode}库";
        }

        private static TOut TransReflection<TIn, TOut>(TIn tIn)
        {
            TOut tOut = Activator.CreateInstance<TOut>();
            var tInType = tIn.GetType();
            foreach (var itemOut in tOut.GetType().GetProperties())
            {
                var itemIn = tInType.GetProperty(itemOut.Name); ;
                if (itemIn != null)
                {
                    itemOut.SetValue(tOut, itemIn.GetValue(tIn));
                }
            }
            return tOut;
        }

        public static void CommUpdateMatToLoc(TTrLocationMaterial trLocMat, VPlMaterial material)
        {
            trLocMat.BillOfLadingNo = material.BillOfLadingNo;
            trLocMat.ComplexDecideCode = material.ComplexDecideCode;
            trLocMat.Description = material.Description;
            trLocMat.Diameter = material.Diameter;
            trLocMat.HeadDirection = material.HeadDirection;
            trLocMat.HoldCauseCode = material.HoldCauseCode;
            trLocMat.HoldFlag = material.HoldFlag;
            trLocMat.HoldRemark = material.HoldRemark;
            trLocMat.InnerDiameter = material.InnerDiameter;
            //trLocMat.IsLoadEnable = material.IsLoadEnable;
            trLocMat.IsOrdered = material.IsOrdered;
            trLocMat.Length = material.Length;
            trLocMat.MaterialId = material.Id;
            trLocMat.MaterialNo = material.No;
            trLocMat.MatDirection = material.MatDirection;
            trLocMat.MatDisposeCode = material.MatDisposeCode;
            trLocMat.MaterialOwner = material.MaterialLocationOwner;
            trLocMat.MatStatus = material.MatStatus;

            trLocMat.NextProcessCode = material.NextProcessCode;
            trLocMat.OrderName = material.OrderName;
            trLocMat.OrderNo = material.OrderNo;
            trLocMat.PickState = material.PickState;
            trLocMat.TruckLoadListId = material.TruckLoadListId;
            trLocMat.PrepickTransferNo = material.PrepickTransferNo;
            trLocMat.ProcessCode = material.ProcessCode;
            trLocMat.ProdTime = material.ProdTime;
            trLocMat.ProductPackFlag = material.ProductPackFlag;
            trLocMat.RelMaker = material.RelMaker;
            trLocMat.RelRemark = material.RelRemark;
            trLocMat.RelTime = material.RelTime;
            trLocMat.SgSign = material.SgSign;
            trLocMat.SgStd = material.SgStd;
            trLocMat.SourceType = material.SourceType;
            trLocMat.Status = material.Status;
            trLocMat.SteelGrade = material.SteelGrade;
            trLocMat.Thick = material.Thick;
            trLocMat.Type = (int)LocationMaterialTypes.InStock;
            trLocMat.Weight = material.Weight;
            trLocMat.Width = material.Width;
            trLocMat.CustomerCode = material.CustomerCode;
            trLocMat.CustomerName = material.CustomerName;
            trLocMat.LockMark = material.LockMark;
            trLocMat.LockReason = material.LockReason;
            trLocMat.IsDistributionShip = material.IsDistributionShip;

            //trLocMat.MaxZ = CalcMaxZ(trLocMat.BayId, trLocMat.LocationName, trLocMat.Diameter ?? 2000);
            //trLocMat.TrimFlag = material.TrimFlag;
            //trLocMat.ProductPackTime = material.ProductPackTime;
            trLocMat.DecideThick = material.DecideThick;
            trLocMat.DecideWidth = material.DecideWidth;
            trLocMat.BundlePackageNo = material.BundlePackageNo;
            trLocMat.Terminal = material.Terminal;
            trLocMat.PackingTypeCode = material.PackingTypeCode;
            trLocMat.PortLotNumber = material.PortLotNumber;
            trLocMat.TrnpModeCode = material.TrnpModeCode;

            trLocMat.UpdateTime = DateTime.Now;
            trLocMat.UpdateUser = "API";
        }

        public static void CommClearLocMat(TTrLocationMaterial trLocMat)
        {
            trLocMat.PointX = 0;
            trLocMat.PointY = 0;
            trLocMat.BillOfLadingNo = null;
            trLocMat.ComplexDecideCode = null;
            trLocMat.Description = null;
            trLocMat.Diameter = null;
            trLocMat.HeadDirection = null;
            trLocMat.HoldCauseCode = null;
            trLocMat.HoldFlag = null;
            trLocMat.HoldRemark = null;
            trLocMat.InnerDiameter = null;
            //trLocMat.IsLoadEnable = null;
            trLocMat.IsOrdered = null;
            trLocMat.Length = null;
            trLocMat.MaterialId = null;
            trLocMat.MaterialNo = null;
            trLocMat.MatDirection = null;
            trLocMat.MatDisposeCode = null;
            trLocMat.MaterialOwner = null;
            trLocMat.MatStatus = null;
            trLocMat.MaxZ = 0;
            trLocMat.NextProcessCode = null;
            trLocMat.OrderName = null;
            trLocMat.OrderNo = null;
            trLocMat.PickState = null;
            trLocMat.TruckLoadListId = null;
            trLocMat.PrepickTransferNo = null;
            trLocMat.ProcessCode = null;
            trLocMat.ProdTime = null;
            trLocMat.ProductPackFlag = null;
            trLocMat.RelMaker = null;
            trLocMat.RelRemark = null;
            trLocMat.RelTime = null;
            trLocMat.SgSign = null;
            trLocMat.SgStd = null;
            trLocMat.SourceType = null;
            trLocMat.Status = 0;
            trLocMat.SteelGrade = null;
            trLocMat.Thick = null;
            trLocMat.Type = (int)LocationMaterialTypes.None;
            trLocMat.Weight = null;
            trLocMat.Width = null;
            trLocMat.LockMark = null;
            trLocMat.LockReason = null;
            trLocMat.IsDistributionShip = null;
            trLocMat.TrimFlag = null;
            trLocMat.ProductPackTime = null;
            trLocMat.DecideThick = null;
            trLocMat.DecideWidth = null;
            trLocMat.BundlePackageNo = null;
            trLocMat.Terminal = null;
            trLocMat.PackingTypeCode = null;
            trLocMat.PortLotNumber = null;
            trLocMat.TrnpModeCode = null;

            trLocMat.UpdateTime = DateTime.Now;
            if (string.IsNullOrEmpty(trLocMat.UpdateUser))
            {
                trLocMat.UpdateUser = "API";
            }
        }
    }
}
