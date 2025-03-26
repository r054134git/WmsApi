using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using Contracts;
using FluentValidation;
using Kaos.Combinatorics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
    public class TPlTruckLoadListPreController : EntityControllerBase<TPlTruckLoadList, TPlTruckLoadListReadModel, TPlTruckLoadListCreateModel, TPlTruckLoadListUpdateModel>
    {
        private readonly IHubContext<ChatHub> _hubContext;
        public TPlTruckLoadListPreController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckLoadListCreateModel> createValidator, IValidator<TPlTruckLoadListUpdateModel> updateValidator, IHubContext<ChatHub> hubContext)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
            _hubContext = hubContext;
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

            var query = GetQueryOrderByIdDesc(predicate);

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
                                  t.OwnerBussinessName == plLoadList.SourceHouse &&
                                  (t.PickState == (int)PickStateOfCoil.None || t.PickState == null) &&
                                  t.IsOrdered == 1 &&
                                  complexDecideCodes.Contains(t.ComplexDecideCode) &&
                  t.HoldFlag == "0" && t.ProductPackFlag == "1");
            if (delivery != null && delivery.IsSpecifyCoilNo == "Y")
            {
                //钢卷在detail表中，订单号为装车清单中的订单号和明细号之和，
                var details = repoPlDeliveryDetail.Where(t => t.OwnerId == delivery.Id).Select(t => t.CoilNo).ToList();
                predicate = predicate.And(t => details.Contains(t.No));
            }
            if (plLoadList.DeliveryOrderNo.StartsWith("W"))
            {
                predicate = predicate.And(t => t.PickState == (int)PickStateOfCoil.TransferPrePicked);
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
            var repoLoadListDetail = DataContext.Set<TPlTruckLoadListDetail>();

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
                                  t.OwnerBussinessName == plLoadList.SourceHouse &&
                                  (t.PickState == (int)PickStateOfCoil.None || t.PickState == null) &&
                                  t.IsOrdered == 1 &&
                                  complexDecideCodes.Contains(t.ComplexDecideCode)
                                  //&& t.LockMark != 1 
                                  && t.ProductPackFlag == "1");
            if (delivery != null && delivery.IsSpecifyCoilNo == "Y")
            {
                //钢卷在detail表中，订单号为装车清单中的订单号和明细号之和，
                var details = repoPlDeliveryDetail.Where(t => t.OwnerId == delivery.Id).Select(t => t.CoilNo).ToList();
                predicate = predicate.And(t => details.Contains(t.No));
            }
            //装车清单材料范围筛选
            var loadListDetails = repoLoadListDetail.Where(t => t.TruckLoadingNo == plLoadList.TruckLoadingNo);
            if (loadListDetails != null && loadListDetails.Count() > 0)
            {
                var loadListCoilNos = loadListDetails.Select(t => t.CoilNo).ToList();
                predicate = predicate.And(t => loadListCoilNos.Contains(t.No));
            }

            if (plLoadList.DeliveryOrderNo.StartsWith("W"))
            {
                predicate = predicate.And(t => t.PickState == (int)PickStateOfCoil.TransferPrePicked);
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
            var trs = await query.ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider)
                                           .ToListAsync(cancellationToken);
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
                .Where(t => t.TruckLoadListId == plLoadList.Id)
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
            query = query.Where(t => t.TruckLoadListId == plLoadList.Id && t.Type != 1);
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
        /// 移库/发货预挑库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Pick(string vehicleNo, string truckLoadingNo, string detailNo, [FromQuery] string[] materialNos, CancellationToken cancellationToken)
        {
            var plLoadList = await DataContext.Set<TPlTruckLoadList>().
                FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                return new OperationResult(false, $"装车清单号{truckLoadingNo}/{detailNo}不存在");
            }
            //var plDelivery = await DataContext.Set<TPlTruckDelivery>().FirstOrDefaultAsync(t => t.DeliveryOrderNo == plLoadList.DeliveryOrderNo && t.OrderNo == plLoadList.OrderNo && t.DetailNo == plLoadList.DetailNo);
            //if (plDelivery == null)
            //{
            //    return new OperationResult(false, $"装车清单号{truckLoadingNo}的发货通知单号不存在");
            //}

            //锁定预挑库
            var plMaterialList = DataContext.Set<TPlMaterial>().Where(t => materialNos.Contains(t.No));
            var trLocMatList = DataContext.Set<TTrLocationMaterial>().Where(t => materialNos.Contains(t.MaterialNo));
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();
            List<CoilOrderDetail> pickMatNos = new List<CoilOrderDetail>();
            if (plMaterialList.Any(t=> t.PickState != (int)PickStateOfCoil.None && t.PickState != null)) 
            {
                return new OperationResult(true, $"装车清单号{truckLoadingNo}，已有卷被其他车预挑，请先刷新数据");
            }

            foreach (var material in plMaterialList)
            {
                material.TruckLoadListId = plLoadList.Id;
                material.PickState = (int)PickStateOfCoil.DeliveryPrePicked;
                pickMatNos.Add(new CoilOrderDetail { CoilNo = material.No, OrderNo = material.OrderNo });
            }
            foreach (var locMat in trLocMatList)
            {
                locMat.TruckLoadListId = plLoadList.Id;
                locMat.PickState = (int)PickStateOfCoil.DeliveryPrePicked;

                var record = new TRcMaterialEvent
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    MaterialId = locMat.MaterialId,
                    MaterialNo = locMat.MaterialNo,
                    Dt = DateTime.Now,
                    OperationType = "人工",
                    ContentType = "预挑库",
                    FromLocationName = locMat.LocationName,
                    ToLocationName = "",
                    Description = $"汽运车号/装车单号/明细号：{plLoadList.VehicleNo}/{plLoadList.TruckLoadingNo}/{plLoadList.DetailNo}进行预挑库，人工预挑",
                    FromPosition = $"",
                    ToPosition = $"",
                    Result = "成功",
                    Remark = plLoadList.AutoPreHint,
                };
                repoMatEv.Add(record);
            }
            
            await DataContext.SaveChangesAsync(cancellationToken);
            await SendPickedToMes(plLoadList, pickMatNos, "1");
            return new OperationResult(true, $"装车清单号{truckLoadingNo},挑库完成");
        }

        /// <summary>
        /// 移库/发货预挑库取消
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Unpick(string vehicleNo, string truckLoadingNo, string detailNo, [FromQuery] string[] materialNos, CancellationToken cancellationToken)
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
            var plMaterialList = DataContext.Set<TPlMaterial>().Where(t => materialNos.Contains(t.No));
            var trLocMatList = DataContext.Set<TTrLocationMaterial>().Where(t => materialNos.Contains(t.MaterialNo));
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();

            List<CoilOrderDetail> pickMatNos = new List<CoilOrderDetail>();
            foreach (var material in plMaterialList)
            {
                material.TruckLoadListId = "";
                if (plLoadList.DeliveryOrderNo.StartsWith("F") || string.IsNullOrEmpty(material.PrepickTransferNo))
                {
                    material.PickState = (int)PickStateOfCoil.None;
                    material.PrepickTransferNo = "";
                }
                else
                {
                    material.PickState = (int)PickStateOfCoil.TransferPrePicked;
                }
                pickMatNos.Add(new CoilOrderDetail { CoilNo = material.No, OrderNo = material.OrderNo });
            }

            foreach (var locMat in trLocMatList)
            {
                locMat.TruckLoadListId = "";
                if (plLoadList.DeliveryOrderNo.StartsWith("F") || string.IsNullOrEmpty(locMat.PrepickTransferNo))
                {
                    locMat.PickState = (int)PickStateOfCoil.None;
                    locMat.PrepickTransferNo = "";
                }
                else
                {
                    locMat.PickState = (int)PickStateOfCoil.TransferPrePicked;
                }

                var record = new TRcMaterialEvent
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    MaterialId = locMat.Id,
                    MaterialNo = locMat.MaterialNo,
                    Dt = DateTime.Now,
                    OperationType = "人工",
                    ContentType = "取消",
                    FromLocationName = locMat.LocationName,
                    ToLocationName = "",
                    Description = $"汽运车号/装车单号/明细号：{plLoadList.VehicleNo}/{plLoadList.TruckLoadingNo}/{plLoadList.DetailNo}取消预挑库，人工取消",
                    FromPosition = $"",
                    ToPosition = $"",
                    Result = "成功",
                    Remark = plLoadList.AutoPreHint,
                };
                repoMatEv.Add(record);
            }

            await DataContext.SaveChangesAsync(cancellationToken);

            await SendPickedToMes(plLoadList, pickMatNos, "2");
            return new OperationResult(true, $"装车清单号{truckLoadingNo},取消挑库完成");
        }

        /// <summary>
        /// 移库/发货预挑库确认
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Confirm(string vehicleNo, string truckLoadingNo, string detailNo, CancellationToken cancellationToken)
        {
            //确认装车清单状态
            var plLoadList = await DataContext.Set<TPlTruckLoadList>()
                .FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                var plLoadLists = DataContext.Set<TPlTruckLoadList>()
                .Where(t => t.IsEnable != 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo).ToList();
                if (plLoadLists.Count > 0)
                {
                    foreach (var plLoad in plLoadLists)
                    {
                        NoticeIconItem delNoticeIconItem = new()
                        {
                            Id = IdWorkerGenerator.Instance.NextId().ToString(),
                            Avatar = "",
                            Title = $"装车清单{truckLoadingNo}，MES已删除",
                            Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            Read = true,
                            Type = MessageType.AutoPrePickCoils.ToString(),
                            Data = new AutoPrePickConfirm { Id = plLoad.Id },
                        };
                        await _hubContext.Clients.All.SendAsync("PrePickConfirmDel", delNoticeIconItem);
                        plLoadList.ResolveState = 1;
                        plLoadList.UpdateTime = DateTime.Now;
                        plLoadList.Remark = "MES已删单";
                    }
                    await DataContext.SaveChangesAsync(cancellationToken);
                }
                return new OperationResult(true, $"装车清单号{truckLoadingNo}不存在，MES已删除");
            }

            //已配载/挑库
            plLoadList.ResolveState = 1;
            plLoadList.UpdateTime = DateTime.Now;
            //根据挑库钢卷信息首次推送停车位并更新TrTruck装载库房列表
            var plMaterials = await DataContext.Set<VPlMaterial>()
              .Where(t => t.TruckLoadListId == plLoadList.Id).ToListAsync();
            string parkingSpace = "";
            if (plMaterials != null && plMaterials.Count > 0)
            {
                var bayList = plMaterials.Select(t => t.BayCode).Distinct().ToList();
                var parkingList = DataContext.Set<TTrParkingPlace>().Where(t => bayList.Contains(t.BayCode) && t.IsUsing == 0).ToList();
                if (parkingList != null && parkingList.Count > 0)
                {
                    parkingSpace = parkingList.OrderBy(t => t.BayCode).FirstOrDefault().ParkingPlaceId;
                }

                var trTruck = await DataContext.Set<TTrTruck>()
                .FirstOrDefaultAsync(t => t.TruckNo == vehicleNo && t.MainTruckLoadingNo == plLoadList.MainTruckLoadingNo);
                if (trTruck != null)
                {
                    if (!string.IsNullOrEmpty(trTruck.LoadBayCodeList))
                    {
                        foreach (var bay in bayList)
                        {
                            if (bay != null && !trTruck.LoadBayCodeList.Contains(bay))
                            {
                                trTruck.LoadBayCodeList = trTruck.LoadBayCodeList + "," + bay;
                            }
                        }
                    }
                    else
                    {
                        trTruck.LoadBayCodeList = string.Join(",", bayList);
                    }
                    trTruck.ParkingNoSuggest = parkingSpace;
                    trTruck.EnterTime = DateTime.Now;  //此处由于存在持卡开单没有入厂时间，默认预挑库完成后即入厂
                    trTruck.DispatchState = 1;
                }
            }
            await DataContext.SaveChangesAsync(cancellationToken);


            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Title = $"装车清单{truckLoadingNo}，人工已确认",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = true,
                Type = MessageType.AutoPrePickCoils.ToString(),
                Data = new AutoPrePickConfirm { Id = plLoadList.Id },
            };
            await _hubContext.Clients.All.SendAsync("PrePickConfirmDel", noticeIconItem);


            //根据MES业务移库装车清单无需发送MES
            if (!plLoadList.DeliveryOrderNo.StartsWith("W"))
            {
                var mbs = ServiceProvider.GetService<MbsProxy>();
                var teleWMBM10 = new TeleWMBM10
                {
                    Payload = new ParkingSpaceInfo
                    {
                        MainTruckLoadingNo = plLoadList.MainTruckLoadingNo,
                        TruckLoadingNo = plLoadList.TruckLoadingNo,
                        OrderNo = plLoadList.OrderNo,
                        DetailNo = plLoadList.DetailNo,
                        VehicleNo = plLoadList.VehicleNo,
                        House = plLoadList.SourceHouse,
                        ParkingSpace = parkingSpace  //根据挑库钢卷bay排序后第一个车位
                    }
                };
                await mbs.Publish(teleWMBM10);
            }

            return new OperationResult(true, $"装车清单号{truckLoadingNo}配载完成");
        }


        /// <summary>
        /// 移库/发货预挑库取消   【暂时没有取消】
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Cancel(string truckLoadingNo, string detailNo)
        {
            //确认装车清单状态
            var plLoadList = await DataContext.Set<TPlTruckLoadList>()
                .Where(t => t.IsEnable == 1 && t.TruckLoadingNo == truckLoadingNo &&
                            t.DetailNo == detailNo).ToListAsync();
            if (plLoadList == null || !plLoadList.Any())
            {
                return new OperationResult(false, $"装车清单号{truckLoadingNo}不存在");
            }
            foreach (var item in plLoadList)
            {
                //未配载
                item.ResolveState = 0;
            }

            foreach (var item in plLoadList)
            {
                //锁定预挑库
                var plMaterials = await DataContext.Set<TPlMaterial>()
                    .Where(t => t.TruckLoadListId == item.Id).ToListAsync();
                var trLocs = await DataContext.Set<TTrLocationMaterial>()
                    .Where(t => t.TruckLoadListId == item.Id).ToListAsync();

                foreach (var pm in plMaterials)
                {
                    pm.PickState = 0;
                    pm.TruckLoadListId = "";
                }

                foreach (var tr in trLocs)
                {
                    tr.PickState = 0;
                    tr.TruckLoadListId = "";
                }
            }

            await DataContext.SaveChangesAsync();

            //取消装车清单状态，
            return new OperationResult(false, $"装车清单号{truckLoadingNo}不存在");
        }

        /// <summary>
        /// 挑库/取消挑库
        /// </summary>
        /// <param name="loadList"></param>
        /// <param name="pickMatNos"></param>
        /// <param name="pickType"></param>
        /// <returns></returns>
        private async Task SendPickedToMes(TPlTruckLoadList loadList, List<CoilOrderDetail> pickMatNos, string pickType)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();

            var teleWMBM09 = new TeleWMBM09
            {
                Payload = new TruckPickCoilInfo
                {
                    TruckNo = loadList.VehicleNo,
                    OrderInformNo = loadList.DeliveryOrderNo,
                    MainTruckLoadingNo = loadList.MainTruckLoadingNo,
                    TruckLoadingNo = loadList.TruckLoadingNo,
                    PickType = pickType
                    //Details = pickMatNos.ToArray()
                }
            };
            for (int i = 0; i < pickMatNos.Count; i++)
            {
                teleWMBM09.Payload.Details[i].OrderNo = pickMatNos[i].OrderNo;
                teleWMBM09.Payload.Details[i].CoilNo = pickMatNos[i].CoilNo;
            }

            await mbs.Publish(teleWMBM09);
        }

        #region 自动预挑库算法
        /// <summary>
        /// 自动预挑库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> AutoPrePick(string vehicleNo, string truckLoadingNo, string detailNo)
        {
            //if (loadList.OperationMark == "D" || string.IsNullOrEmpty(loadList.SourceHouse) || !loadList.SourceHouse.Contains("P"))
            //{
            //    return new OperationResult(false, "装车清单删除或装车库房不正确");
            //}

            var repo = DataContext.Set<TPlTruckLoadList>();
            var preLoadList = repo.FirstOrDefault(t => t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo && t.IsEnable == 1);
            if (preLoadList == null)
            {
                return new OperationResult(false, "装车清单信息不存在，自动预挑库失败"); ;
            }
            string truckNoLoadNo = $"车号/装车单号：{preLoadList.VehicleNo}/{preLoadList.TruckLoadingNo}";

            var repoPlDelivery = DataContext.Set<TPlTruckDelivery>();
            var repoPlDeliveryDetail = DataContext.Set<TPlTruckDeliveryDetail>();
            var repoMat = DataContext.Set<VPlMaterial>();
            var repoPlMat = DataContext.Set<TPlMaterial>();
            var repoLocMat = DataContext.Set<TTrLocationMaterial>();
            var delivery = repoPlDelivery.Where(t => t.DeliveryOrderNo == preLoadList.DeliveryOrderNo && t.OrderNo == preLoadList.OrderNo && t.DetailNo == preLoadList.DetailNo).FirstOrDefault();
            //查询条件
            var orderNo = preLoadList.OrderNo + preLoadList.DetailNo;
            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };

            var predicate = ExpressionBuilder.True<VPlMaterial>();
            predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
                              t.OrderNo == orderNo &&
                              matStatusList.Contains(t.MatStatus) &&
                              t.OwnerBussinessName == preLoadList.SourceHouse &&
                              (t.PickState == (int)PickStateOfCoil.None || t.PickState == null || t.TruckLoadListId == preLoadList.Id) &&
                              t.IsOrdered == 1 &&
                              complexDecideCodes.Contains(t.ComplexDecideCode) 
                              //&& t.LockMark != 1 
                              && t.ProductPackFlag == "1");

            //满足条件的预挑卷
            var satisfyPreMats = repoMat.Where(predicate).ToList();

            //var satisfyPreMats = repoMat.Where(t => t.BayCode == "25" && t.FloorNo == 2 && t.Type == 2).ToList();

            if (satisfyPreMats.Count <= 0)
            {
                return new OperationResult(false, $"{truckNoLoadNo}待预挑库卷不存在，预挑库失败");
            }

            //自动预挑的卷
            var autoPrePickMats = new List<VPlMaterial>();
            var planCount = Convert.ToInt32(preLoadList.Count); //计划出库件数
            var planWeight = Convert.ToDecimal(preLoadList.PlanOutBoundWeight); //计划出库重量
            if (planWeight > 150)
            {
                return new OperationResult(false, $"{truckNoLoadNo}计划重量不符合要求，预挑库失败");
            }
            if (planCount > satisfyPreMats.Count())
            {
                return new OperationResult(false, $"{truckNoLoadNo}计划件数大于预挑库件数，不符合要求");
            }

            //if (satisfyPreMats.Count > 30)
            //{
            //    return new OperationResult(false, $"{truckNoLoadNo}预挑库失败,请人工挑库");
            //}

            var repoLoadListDetail = DataContext.Set<TPlTruckLoadListDetail>();

            string msg = string.Empty;
            //装车清单材料范围筛选
            var loadListDetails = repoLoadListDetail.Where(t => t.TruckLoadingNo == preLoadList.TruckLoadingNo);
            if (loadListDetails != null && loadListDetails.Count() > 0)
            {
                var loadListCoilNos = loadListDetails.Select(t => t.CoilNo).ToList();
                var directFetchMats = satisfyPreMats.Where(t => loadListCoilNos.Contains(t.No)).ToList();
                msg = "【岚北直取】";
                var prePickResult = GetMeasuredPrePickMats(planCount, planWeight, preLoadList.SourceHouse, directFetchMats);
                if (prePickResult.Item1)
                {
                    autoPrePickMats = prePickResult.Item3;
                }
                else
                {
                    msg += prePickResult.Item2;
                }
            }
            else if (delivery != null && delivery.IsSpecifyCoilNo == "Y")    //按件挑库
            {
                var details = repoPlDeliveryDetail.Where(t => t.OwnerId == delivery.Id).Select(t => t.CoilNo).ToList();
                autoPrePickMats = satisfyPreMats.Where(t => details.Contains(t.No)).ToList();
                msg = "【按件挑库】";
            }
            else // 按量挑库
            {
                msg = "【按量挑库】";
                var prePickResult = GetMeasuredPrePickMats(planCount, planWeight, preLoadList.SourceHouse, satisfyPreMats);
                if (prePickResult.Item1)
                {
                    autoPrePickMats = prePickResult.Item3;
                }
                else
                {
                    msg += prePickResult.Item2;
                }
            }


            if (autoPrePickMats.Count != planCount)
            {
                return new OperationResult(false, $"{truckNoLoadNo} {msg}自动预挑库件数与计划件数不一致，预挑库失败，计划/预挑：{planCount}/{autoPrePickMats.Count}");
            }

            var teleWMBM09 = new TeleWMBM09
            {
                Payload = new TruckPickCoilInfo
                {
                    TruckNo = preLoadList.VehicleNo,
                    OrderInformNo = preLoadList.DeliveryOrderNo,
                    MainTruckLoadingNo = preLoadList.MainTruckLoadingNo,
                    TruckLoadingNo = preLoadList.TruckLoadingNo,
                    PickType = "1"
                }
            };
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();
            for (int i = 0; i < autoPrePickMats.Count(); i++)
            {
                var plMat = repoPlMat.FirstOrDefault(t => t.No == autoPrePickMats[i].No);
                if (plMat.TruckLoadListId == preLoadList.Id)
                {
                    continue;
                }
                teleWMBM09.Payload.Details[i].OrderNo = autoPrePickMats[i].OrderNo;
                teleWMBM09.Payload.Details[i].CoilNo = autoPrePickMats[i].No;

                if (plMat != null)
                {
                    plMat.PickState = 2;
                    plMat.TruckLoadListId = preLoadList.Id;
                }
                var trLocMat = repoLocMat.FirstOrDefault(t => t.MaterialNo == autoPrePickMats[i].No);
                if (trLocMat != null)
                {
                    trLocMat.PickState = 2;
                    trLocMat.TruckLoadListId = preLoadList.Id;

                    var record = new TRcMaterialEvent
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        MaterialId = trLocMat.Id,
                        MaterialNo = trLocMat.MaterialNo,
                        Dt = DateTime.Now,
                        OperationType = "自动",
                        ContentType = "预挑库",
                        FromLocationName = trLocMat.LocationName,
                        ToLocationName = "",
                        Description = $"汽运车号/装车单号/明细号：{preLoadList.VehicleNo}/{preLoadList.TruckLoadingNo}/{preLoadList.DetailNo}进行预挑库，自动配载",
                        FromPosition = $"",
                        ToPosition = $"",
                        Result = "成功"
                    };
                    repoMatEv.Add(record);
                }
            }
            var mbs = ServiceProvider.GetService<MbsProxy>();
            await mbs.Publish(teleWMBM09);
            await DataContext.SaveChangesAsync();
            return new OperationResult(true, $"{truckNoLoadNo} {msg}自动预挑成功");
        }
        /// <summary>
        /// 获取按量预挑卷信息
        /// </summary>
        /// <returns></returns>
        private (bool, string, List<VPlMaterial>) GetMeasuredPrePickMats(int planCount, decimal planWeight, string houseName, List<VPlMaterial> satisfyPreMats)
        {
            var resultList = new List<VPlMaterial>();
            var bayCodes = satisfyPreMats.Select(t => t.BayCode).Distinct().ToList();
            //在预配前，将二层被压卷处理成二层，将一层未被压的卷处理成二层
            var repoLocMat = DataContext.Set<TTrLocationMaterial>();
            var inStockFloorList = repoLocMat.Where(t => t.Type == 2 && bayCodes.Contains(t.BayCode) && t.FloorNo == 2).ToList();
            var newPreMatList = GetOptimalList(satisfyPreMats, planCount, inStockFloorList);

            //先预配一个库的二层是否满足
            foreach (var bayCode in bayCodes)
            {
                var bayMatList = newPreMatList.Where(t => t.BayCode == bayCode && t.FloorNo == 2).ToList();
                if (bayMatList.Count >= planCount)
                {
                    var towFloorList = GetCombinationList(planCount, planWeight, bayMatList);
                    if (towFloorList.Count > 0)
                    {
                        return (true, "", towFloorList.FirstOrDefault());
                    }
                }
            }
            var autoList = new List<List<VPlMaterial>>();
            //其次预配一个库的一二层是否满足，并找到二层最多库房
            foreach (var bayCode in bayCodes)
            {
                var bayMatList = newPreMatList.Where(t => t.BayCode == bayCode).ToList();
                if (bayMatList.Count >= planCount)
                {
                    var comBayMatList = GetCombinationList(planCount, planWeight, bayMatList);
                    if (comBayMatList.Count > 0)
                    {
                        //当前库二层最多
                        int maxFloor = comBayMatList.Max(t => t.Count(t => t.FloorNo == 2));
                        var curBayList = comBayMatList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
                        autoList.Add(curBayList);
                    }
                }
            }
            if (autoList.Count > 0)
            {
                int maxFloor = autoList.Max(t => t.Count(t => t.FloorNo == 2));
                resultList = autoList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
                return (true, "", resultList);
            }

            //最后所有库房自由选配
            var list = GetCombinationList(planCount, planWeight, newPreMatList);
            if (list.Count <= 0)
            {
                return (false, "重量不匹配", null);
            }

            //自动挑库优先级划分 1、优先一个库房，2、优先二层
            int bayNum = 2;
            if (houseName == "P8")
                bayNum = 3;
            else if (houseName == "P6")
                bayNum = 4;
            //for (int i = 1; i <= bayNum; i++)
            //{
            //    for (int j = planCount; j >= 0; j--)
            //    {
            //        resultList = GetExcellentPrePickMats(list, j, i);
            //        if (resultList != null)
            //        {
            //            goto prePickSuc;
            //        }
            //    }
            //}
            for (int j = planCount; j >= 0; j--)
            {
                for (int i = 1; i <= bayNum; i++)
                {
                    resultList = GetExcellentPrePickMats(list, j, i);
                    if (resultList != null)
                    {
                        goto prePickSuc;
                    }
                }
            }
            prePickSuc:
            return (true, "", resultList);
        }
        /// <summary>
        /// 将二层下的卷与一层上面的卷处理成二层，优先装
        /// </summary>
        /// <param name="list"></param>
        /// <param name="pickNum"></param>
        /// <param name="trList"></param>
        /// <returns></returns>
        private List<VPlMaterial> GetOptimalList(List<VPlMaterial> list, int pickNum, List<TTrLocationMaterial> trList)
        {
            var satisfyList = list.Where(t => t.FloorNo == 2).ToList();

            foreach (var floor in satisfyList) //查找二层下的一层是否在其中
            {
                var left = floor.ColNo;
                var right = floor.ColNo + 1;
                var belowOneList = list.Where(t => t.AreaCode == floor.AreaCode &&
                                            t.BayCode == floor.BayCode &&
                                            t.RowNo == floor.RowNo &&
                                            t.FloorNo == 1 &&
                                            (t.ColNo == left || t.ColNo == right)).ToList();
                if (belowOneList.Count > 0)
                {
                    belowOneList.ForEach(t => { t.FloorNo = 2; });// 将二层压的一层卷认为是二层来处理
                    satisfyList = satisfyList.Concat(belowOneList).ToList();
                }
                //if (satisfyList.Count >= pickNum)
                //{
                //    return satisfyList.Take(pickNum).ToList();
                //}
            }
            //未预配的一层卷，检查一层卷上方是否存在二层卷信息
            var noPickList = list.Except(satisfyList).ToList();
            foreach (var noPick in noPickList)
            {
                var left = noPick.ColNo;
                var right = noPick.ColNo - 1;
                var belowTwoList = trList.Where(t => t.AreaCode == noPick.AreaCode &&
                                            t.RowNo == noPick.RowNo &&
                                            (t.ColNo == left || t.ColNo == right)).ToList();
                if (belowTwoList.Count == 0)
                {
                    noPick.FloorNo = 2;   //将未被压的一层卷认为是二层卷处理
                }
                satisfyList.Add(noPick);
            }
            return satisfyList;
        }

        private static List<VPlMaterial> GetExcellentPrePickMats(List<List<VPlMaterial>> satisfyPreMats, int tierNum, int bayNum)
        {
            foreach (var preList in satisfyPreMats)
            {
                //是否全部是二层卷
                bool isAllTier = preList.Count(t => t.FloorNo == 2) == tierNum;
                //是否在一个库
                bool isAllOne = preList.Select(t => t.BayCode).Distinct().Count() == bayNum;
                if (isAllTier && isAllOne)
                {
                    return preList;
                }
            }
            return null;
        }

        /// <summary>
        /// 根据计划数量获取所有排列组合
        /// </summary>
        /// <param name="planCount"></param>
        /// <param name="planWeight"></param>
        /// <param name="satisfyPreMats"></param>
        /// <returns></returns>
        private static List<List<VPlMaterial>> GetCombinationList(int planCount, decimal planWeight, List<VPlMaterial> satisfyPreMats)
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            var cn = new Combination(satisfyPreMats.Count, planCount);
            var autoList = new List<List<VPlMaterial>>();
            Task.Factory.StartNew(() =>
            {
                foreach (var row in cn.GetRows())
                {
                    var cnList = Combination.Permute(row, satisfyPreMats);
                    var totalWeight = cnList.Sum(t => t.Weight / 1000M);
                    if (planWeight - 1 < totalWeight && totalWeight < planWeight + 1)
                    {
                        autoList.Add(cnList);
                        var twoTierNum = cnList.Count(t => t.FloorNo == 2);
                        if (twoTierNum == planCount && cnList.Select(t => t.BayCode).Distinct().Count() == 1)
                        {
                            autoList.Clear();
                            autoList.Add(cnList);
                            break;
                        }
                    }
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }
                }
            }, token).Wait(3000);
            cts.Cancel();
            return autoList;

            #region old 代码
            //List<VPlMaterial> preMats = satisfyPreMats;
            //int n = planCount;
            //List<List<VPlMaterial>> resultList = new List<List<VPlMaterial>>();
            //foreach (var preMat in preMats)
            //{
            //    List<List<VPlMaterial>> lastList = resultList.Where(t => t.Count < n).ToList();
            //    List<VPlMaterial> singleList = new List<VPlMaterial> { preMat };
            //    resultList.Add(singleList);
            //    foreach (List<VPlMaterial> addList in lastList)
            //    {
            //        resultList.Add(addList.Concat(singleList).ToList());
            //    }
            //}
            //resultList = resultList.Where(t => t.Count == n).ToList();
            //return resultList;
            #endregion
        }
        #endregion

        /// <summary>
        /// 按时间段查询自动配载佰能/赛迪系统的配载次数
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<int>>> GetTheAutomaticLoadingRatio([FromQuery] string[] time)
        {
            var repoPlLoadList = DataContext.Set<TPlTruckLoadList>();
            var predicate = ExpressionBuilder.True<TPlTruckLoadList>();
            predicate = predicate.And(t => t.IsFinished == 0 && t.IsEnable == 1 && t.ResolveState == 1);
            var query = repoPlLoadList.AsNoTracking();
            query = query.Where(predicate);
            if (time.Length > 0 && time != null)
            {
                var Bstartime = Convert.ToDateTime(time[0]);
                var Bendtime = Convert.ToDateTime(time[1]);
                query = query.Where(t => t.CreateTime > Bstartime && t.CreateTime < Bendtime);
            }
            else
            {
                var startime = DateTime.Now.ToString("yyyy-MM-dd");
                var endtime = DateTime.Now.ToString("yyyy-MM-dd");
                var Bstartime = Convert.ToDateTime($"{startime} 09:00:00");
                var Bendtime = Convert.ToDateTime($"{endtime} 18:00:00");
                query = query.Where(t => t.CreateTime > Bstartime && t.CreateTime < Bendtime);
            }
            var sd = await query.Where(t => t.AutoPreHint.Contains("通过赛迪配载信息自动预挑成功")).CountAsync();
            var bn = await query.CountAsync() - sd;
            var result = new PageResult<int>();
            var datas = new List<int>
            {
                sd,
                bn
            };
            result.Data = datas;
            result.Success = true;
            result.Message = "查询统计成功！";
            return result;
        }
    }
}
