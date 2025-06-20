using AutoMapper;
using AutoMapper.QueryableExtensions;
using Contracts;
using FluentValidation;
using Kaos.Combinatorics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.IO;
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
    public class TPlTruckTransferController : EntityControllerBase<TPlTruckTransfer, TPlTruckTransferReadModel, TPlTruckTransferCreateModel, TPlTruckTransferUpdateModel>
    {
        private readonly ILogger<TPlTruckTransferController> _logger;
        public TPlTruckTransferController(ILogger<TPlTruckTransferController> logger, IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckTransferCreateModel> createValidator, IValidator<TPlTruckTransferUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
            _logger = logger;
        }

        /// <summary>
        /// ��ѯ�Ѿ��������ƿⵥ��Ϣ 
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlTruckTransferReadModel>>> GetAllTruckNos_old([FromQuery] PageParam pageParam, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlTruckTransfer>();
            predicate = predicate.And(t => t.IsEnable == 1);
            //��ѯ�Ѿ������ƿⵥ���ƿ�δ��ɵ���Ϣ
            predicate = predicate.And(t => t.PickState != 3 && t.TransferNo != null && t.TransferNo != "");
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// ��ѯ�Ѿ��������ƿⵥ��Ϣ 
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlTruckTransferReadModel>>> GetAllTruckNos(string where, string orders, CancellationToken cancellationToken)
        {
            var dbSet = DataContext.Set<TPlTruckTransfer>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TPlTruckTransfer>();
            predicate = predicate.And(t => t.IsEnable == 1);
            //��ѯ�Ѿ������ƿⵥ���ƿ�δ��ɵ���Ϣ
            predicate = predicate.And(t => t.PickState != 3 && t.TransferNo != null && t.TransferNo != "");
            predicate = predicate.And(t => t.CreateTimeTransfer > DateTime.Now.Date.AddHours(-5));  //��ʱ���
            query = query.Where(predicate).OrderByDescending(t => t.CreateTime);
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// ��ȫ�ƿⵥ
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> CompleTransfer(TPlTruckTransferUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var truckTran = await DataContext.Set<TPlTruckTransfer>()
               .FirstOrDefaultAsync(t => t.TruckNo == updateModel.TruckNo && t.FakeLoadingNo == updateModel.FakeLoadingNo && t.IsEnable == 1);
            if (truckTran == null)
            {
                return new OperationResult(false, $"������Ϣ{updateModel.TruckNo}������");
            }
            var sql = "SELECT F_PL_AUTO_CODE('TRANSFER_NO','WMS') FROM DUAL";
            var transferNo = SqlQuery(sql, (t) => (string)t[0]).First();
            truckTran.OperationMark = "N";
            truckTran.IsEnable = 1;
            truckTran.TransferNo = transferNo;
            truckTran.DestHouse = updateModel.DestHouse;
            truckTran.WeightMax = updateModel.WeightMax;
            truckTran.CreateTimeTransfer = DateTime.Now;

            //�����ƿⵥ��ɷ���MES
            await SendTransferToMes(truckTran);

            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, "�ƿⵥ�����ɹ�");
        }

        /// <summary>
        /// ��ѯ��Ҫ��ȫ���ƿ⳵����Ϣ 
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlTruckTransferReadModel>>> GetTruckInfo(string truckNo)
        {
            var predicate = ExpressionBuilder.True<TPlTruckTransfer>();
            predicate = predicate.And(t => t.IsEnable == 1);
            //��ѯ�Ѿ������ƿⵥ���ƿ�δ��ɵ���Ϣ
            if (!string.IsNullOrEmpty(truckNo))
            {
                predicate = predicate.And(t => t.TruckNo == truckNo);
            }
            predicate = predicate.And(t => (t.TransferNo == null || t.TransferNo == "") && t.SourceHouse != "P7" && t.CreateTime > DateTime.Now.AddHours(-2));
            var query = GetQueryOrderByIdDesc(predicate).OrderByDescending(t => t.CreateTime);
            var listResult = await QueryPageModel(query);
            return Ok(listResult);
        }

        /// <summary>
        /// �ƿⵥ ��ȡδ����־�
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<PageResult<VPlMaterialReadModel>>>> GetAllUnpicked_old([FromQuery] PageParam pageParam, string transferNo, string materialNo)
        {
            var repoVMaterial = DataContext.Set<VPlMaterial>();
            var repoTransfer = DataContext.Set<TPlTruckTransfer>();
            var plTransfer = await repoTransfer.FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult<PageResult<VPlMaterialReadModel>>
                    (false, $"�ƿⵥ��{transferNo}������", new PageResult<VPlMaterialReadModel>());
            }
            var sourceHouse = plTransfer.SourceHouse;

            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };
            //�������⣬
            //������Ϊװ���嵥�еĶ����ź���ϸ��֮�ͣ�
            //����״̬��Ϊ{��33��}����һ�δ����״̬���������ж�����ΪcomplexDecideCodes����һ��
            //δ�������Ѱ�װ
            //δ�䴬
            var predicate = ExpressionBuilder.True<VPlMaterial>();
            if (!string.IsNullOrEmpty(materialNo))
            {
                predicate = predicate.And(t => t.No.Contains(materialNo));
            }
            //predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && (t.PickState == (int)PickStateOfCoil.None || t.PickState == null));
            predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
                         matStatusList.Contains(t.MatStatus) &&
                         (t.PickState == (int)PickStateOfCoil.None || t.PickState == null) &&
                         t.MatDirection == "U127" &&
                         t.OwnerBussinessName == sourceHouse &&
                         t.IsOrdered == 1 && (t.IsDistributionShip == 0 || t.IsDistributionShip == null) &&
                         complexDecideCodes.Contains(t.ComplexDecideCode) &&
                         t.HoldFlag == "0" && t.ProductPackFlag == "1");

            var query = repoVMaterial.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderByDescending(t => t.Id);
            }
            var total = query.Count();
            query = query.Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize);

            var result = await query.ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync();
            var ret = new PageResult<VPlMaterialReadModel>
            {
                Data = result,
                Success = true,
                Total = total
            };
            return new OperationResult<PageResult<VPlMaterialReadModel>>(true, "", ret);
        }


        /// <summary>
        /// �ƿⵥ ��ȡδ����־�
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<PageResult<VPlMaterialReadModel>>>> GetAllUnpicked([FromQuery] PageParam pageParam, string transferNo, string materialNo, string where, string orders)
        {
            var repoVMaterial = DataContext.Set<VPlMaterial>();
            var repoTransfer = DataContext.Set<TPlTruckTransfer>();
            var plTransfer = await repoTransfer.FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult<PageResult<VPlMaterialReadModel>>
                    (false, $"�ƿⵥ��{transferNo}������", new PageResult<VPlMaterialReadModel>());
            }
            var sourceHouse = plTransfer.SourceHouse;

            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };
            //�������⣬
            //������Ϊװ���嵥�еĶ����ź���ϸ��֮�ͣ�
            //����״̬��Ϊ{��33��}����һ�δ����״̬���������ж�����ΪcomplexDecideCodes����һ��
            //δ�������Ѱ�װ
            //δ�䴬      
            var predicate = ExpressionBuilder.True<VPlMaterial>();
            if (!string.IsNullOrEmpty(materialNo))
            {
                predicate = predicate.And(t => t.No.Contains(materialNo));
            }
            //predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && (t.PickState == (int)PickStateOfCoil.None || t.PickState == null));
            predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
                         matStatusList.Contains(t.MatStatus) &&
                         (t.PickState == (int)PickStateOfCoil.None || t.PickState == null) &&
                         (t.MatDirection == "U127" || t.TrnpModeCode == "A") &&
                         t.OwnerBussinessName == sourceHouse &&
                         t.IsOrdered == 1 && (t.IsDistributionShip == 0 || t.IsDistributionShip == null) &&
                         complexDecideCodes.Contains(t.ComplexDecideCode)
                         && t.LockMark != 1
                         && t.ProductPackFlag == "1");


            var query = repoVMaterial.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }
            var total = query.Count();
            query = query.Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize);

            var result = await query.ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync();
            var ret = new PageResult<VPlMaterialReadModel>
            {
                Data = result,
                Success = true,
                Total = total
            };
            return new OperationResult<PageResult<VPlMaterialReadModel>>(true, "", ret);
        }

        /// <summary>
        /// �����ƿⵥ��ȡ ������ĸ־�
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<VPlMaterialReadModel>>> GetAllPicked_old(string transferNo)
        {
            List<VPlMaterialReadModel> result = new List<VPlMaterialReadModel>();
            var transferPickedList = await DataContext.Set<VPlMaterial>()
                                            .Where(t => t.PrepickTransferNo == transferNo && t.Type == 2)
                                            .ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider)
                                            .ToListAsync();
            if (transferPickedList == null || transferPickedList.Count == 0)
            {
                return new PageResult<VPlMaterialReadModel>();
            }
            result.AddRange(transferPickedList);
            return new PageResult<VPlMaterialReadModel>
            {
                Data = result
            };
        }

        /// <summary>
        /// �����ƿⵥ��ȡ ������ĸ־�
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<VPlMaterialReadModel>>> GetAllPicked(string transferNo, string where, string orders, CancellationToken cancellationToken)
        {
            var repoVMaterial = DataContext.Set<VPlMaterial>();
            var query = repoVMaterial.AsNoTracking();
            query = query.Where(t => t.PrepickTransferNo == transferNo && t.Type == 2);
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }
            var listResult = await query.ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider)
                                            .ToListAsync(cancellationToken);

            return new PageResult<VPlMaterialReadModel>
            {
                Data = listResult,
                Success = true,
            };
        }

        /// <summary>
        /// �ƿ�Ԥ����
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Pick(string transferNo, string materialNo, CancellationToken cancellationToken)
        {
            var plTransfer = await DataContext.Set<TPlTruckTransfer>()
                                              .FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult(false, $"�ƿⵥ��{transferNo}������");
            }
            //����Ԥ����
            var plMaterial = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == materialNo);
            var trLoc = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == materialNo);
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();
            if (plMaterial != null)
            {
                plMaterial.PrepickTransferNo = transferNo;
                plMaterial.PickState = (int)PickStateOfCoil.TransferPrePicked;
            }
            if (trLoc != null)
            {
                trLoc.PrepickTransferNo = transferNo;
                trLoc.PickState = (int)PickStateOfCoil.TransferPrePicked;

                var record = new TRcMaterialEvent
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    MaterialId = trLoc.Id,
                    MaterialNo = trLoc.MaterialNo,
                    Dt = DateTime.Now,
                    OperationType = "�˹�",
                    ContentType = "�ƿ�Ԥ����",
                    FromLocationName = trLoc.LocationName,
                    ToLocationName = "",
                    Description = $"�ƿ⳵��/���ţ�{plTransfer.TruckNo}/{plTransfer.TransferNo}����Ԥ���⣬�˹�Ԥ��",
                    FromPosition = $"",
                    ToPosition = $"",
                    Result = "�ɹ�"
                };
                repoMatEv.Add(record);
            }

            await DataContext.SaveChangesAsync(cancellationToken);

            //����MES
            List<CoilOrderDetail> pickMatNos = new();
            pickMatNos.Add(new CoilOrderDetail { CoilNo = plMaterial.No, OrderNo = plMaterial.OrderNo });
            await SendPickedToMes(plTransfer, pickMatNos, "5");

            return new OperationResult(true, $"�ƿⵥ��{transferNo},���{materialNo}�������");
        }

        /// <summary>
        /// �ƿ�Ԥ����ȡ��
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Unpick(string transferNo, string materialNo, [FromQuery] string[] materialNos, CancellationToken cancellationToken)
        {
            var plTransfer = await DataContext.Set<TPlTruckTransfer>()
                                              .FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult(false, $"�ƿⵥ��{plTransfer}/{materialNo}������");
            }
            if (plTransfer.PickState == 1)
            {
                return new OperationResult(false, $"�ƿⵥ���·���������ȡ������");
            }

            if (materialNos == null || materialNos.Length == 0)
            {
                return new OperationResult(false, $"��ѡ����Ҫȡ������ľ�");
            }

            //����Ԥ����

            var plMaterialList = DataContext.Set<TPlMaterial>().Where(t => materialNos.Contains(t.No)).ToList();
            var trLocMatList = DataContext.Set<TTrLocationMaterial>().Where(t => materialNos.Contains(t.MaterialNo)).ToList();
            //var plMaterialList = DataContext.Set<TPlMaterial>().Where(t => materialNo == t.No).ToList();
            //var trLocMatList = DataContext.Set<TTrLocationMaterial>().Where(t => t.MaterialNo == materialNo).ToList();
            foreach (var plMaterial in plMaterialList)
            {
                if (plMaterial != null)
                {
                    plMaterial.PrepickTransferNo = "";
                    plMaterial.TruckLoadListId = "";
                    plMaterial.PickState = (int)PickStateOfCoil.None;
                }
            }
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();
            foreach (var trLocMat in trLocMatList)
            {
                if (trLocMat != null)
                {
                    trLocMat.PrepickTransferNo = "";
                    trLocMat.TruckLoadListId = "";
                    trLocMat.PickState = (int)PickStateOfCoil.None;

                    var record = new TRcMaterialEvent
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        MaterialId = trLocMat.Id,
                        MaterialNo = trLocMat.MaterialNo,
                        Dt = DateTime.Now,
                        OperationType = "�˹�",
                        ContentType = "�ƿ�ȡ��",
                        FromLocationName = trLocMat.LocationName,
                        ToLocationName = "",
                        Description = $"�ƿ⳵��/���ţ�{plTransfer.TruckNo}/{plTransfer.TransferNo}ȡ��Ԥ���⣬�˹�ȡ��",
                        FromPosition = $"",
                        ToPosition = $"",
                        Result = "�ɹ�"
                    };
                    repoMatEv.Add(record);
                }
            }
            await DataContext.SaveChangesAsync(cancellationToken);

            //����MES
            List<CoilOrderDetail> pickMatNos = new();
            plMaterialList.ForEach(t =>
            {
                pickMatNos.Add(new CoilOrderDetail { CoilNo = t.No, OrderNo = t.OrderNo });
            });

            await SendPickedToMes(plTransfer, pickMatNos, "6");

            return new OperationResult(true, $"�ƿⵥ��{transferNo},���{materialNo}ȡ���������");
        }

        /// <summary>
        /// �ƿ�Ԥ���� �·�
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Confirm(string transferNo, CancellationToken cancellationToken)
        {
            //ȷ���ƿⵥ״̬
            var plTransfer = await DataContext.Set<TPlTruckTransfer>()
                                              .FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult(false, $"�ƿⵥ��{plTransfer}������");
            }
            if (plTransfer.IsDirectTruck == 1)
            {
                var trLocMatList = DataContext.Set<TTrLocationMaterial>().Where(t => t.PrepickTransferNo == transferNo).ToList();
                var plMatList = DataContext.Set<TPlMaterial>().Where(t => t.PrepickTransferNo == transferNo).ToList();
                if (trLocMatList.Count == plMatList.Count && trLocMatList.Count(t => t.LocationName.Contains("P")) == trLocMatList.Count) //˵���Ѿ�װ�����
                {

                }
                List<CoilOrderDetail> pickMatNos = new();
                return new OperationResult(false, $"�ƿⵥ��{plTransfer}Ϊֱװ��������װ����ɲ����·�");
            }
            plTransfer.OperationMark = "C";
            plTransfer.PickState = 1;
            await DataContext.SaveChangesAsync(cancellationToken);

            //�����ƿⵥ��ɷ���MES
            await SendTransferToMes(plTransfer);

            return new OperationResult(true, $"�ƿⵥ��{transferNo}�·����");
        }

        /// <summary>
        /// �ƿⵥȡ��/����
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Cancel(string transferNo, CancellationToken cancellationToken)
        {
            //�����ƿⵥ״̬
            var plTransfer = await DataContext.Set<TPlTruckTransfer>()
                                              .FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult(false, $"�ƿⵥ��{plTransfer}������");
            }
            plTransfer.OperationMark = "F";
            plTransfer.PickState = 0;  //���Ϻ�״̬Ϊ��ʼ��
            plTransfer.UpdateTime = DateTime.Now;
            plTransfer.Remark = "�ƿⵥ����";
            var transferLoadLists = DataContext.Set<TPlTruckLoadList>().Where(t => t.DeliveryOrderNo.Contains(plTransfer.TransferNo));
            if (transferLoadLists != null && transferLoadLists.Any())
            {
                foreach (var loadList in transferLoadLists)
                {
                    loadList.IsEnable = 0;
                    loadList.Remark = "�ƿⵥ����";
                    loadList.UpdateTime = DateTime.Now;
                }
            }

            await DataContext.SaveChangesAsync(cancellationToken);

            //�����ƿⵥ��ɷ���MES
            await SendTransferToMes(plTransfer);

            return new OperationResult(true, $"�ƿⵥ��{transferNo}�������");
        }

        /// <summary>
        /// �ƿⵥɾ��
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> DeleteTransfer(string transferNo, CancellationToken cancellationToken)
        {
            //�����ƿⵥ״̬
            var plTransfer = await DataContext.Set<TPlTruckTransfer>()
                                              .FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult(false, $"�ƿⵥ{plTransfer.TransferNo}������");
            }

            if (plTransfer.OperationMark != "F")
            {
                return new OperationResult(false, $"�ƿⵥ{plTransfer.TransferNo}δ���ϣ�������ɾ��");
            }

            plTransfer.OperationMark = "D";
            plTransfer.IsEnable = 0;

            //�ƿⵥɾ���൱��ɾ��,����ά���ƿ�װ���嵥
            var transferLoadLists = DataContext.Set<TPlTruckLoadList>().Where(t => t.DeliveryOrderNo.Contains(plTransfer.TransferNo));
            if (transferLoadLists != null && transferLoadLists.Any())
            {
                foreach (var loadList in transferLoadLists)
                {
                    loadList.IsEnable = 0;
                    loadList.Remark = "�ƿⵥɾ��";
                    loadList.UpdateTime = DateTime.Now;
                }
            }

            //�ƿⵥɾ���� ��Ҫά��tr_truck ������Ϣ
            var trTruck = await DataContext.Set<TTrTruck>().FirstOrDefaultAsync(t => t.TruckNo == plTransfer.TruckNo && (t.MainTruckLoadingNo == plTransfer.FakeLoadingNo || t.MainTruckLoadingNo == plTransfer.TransferNo));
            if (trTruck != null)
            {
                DataContext.Remove(trTruck);
            }

            await DataContext.SaveChangesAsync(cancellationToken);

            //ɾ���ƿⵥ��ɷ���MES
            await SendTransferToMes(plTransfer);
            //ȡ���ƿⵥ״̬��
            return new OperationResult(true, $"�ƿⵥ��{transferNo}ɾ���ɹ�");
        }

        /// <summary>
        /// ����/ȡ������
        /// </summary>
        /// <param name="truckTran"></param>
        /// <param name="pickMatNos"></param>
        /// <param name="pickType"></param>
        /// <returns></returns>
        private async Task SendPickedToMes(TPlTruckTransfer truckTran, List<CoilOrderDetail> pickMatNos, string pickType)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();

            var teleWMBM09 = new TeleWMBM09
            {
                Payload = new TruckPickCoilInfo
                {
                    TruckNo = truckTran.TruckNo,
                    OrderInformNo = truckTran.TransferNo,
                    MainTruckLoadingNo = "",
                    TruckLoadingNo = "",
                    PickType = pickType
                }
            };
            for (int i = 0; i < pickMatNos.Count(); i++)
            {
                teleWMBM09.Payload.Details[i].OrderNo = pickMatNos[i].OrderNo;
                teleWMBM09.Payload.Details[i].CoilNo = pickMatNos[i].CoilNo;
            }

            await mbs.Publish(teleWMBM09);
        }

        /// <summary>
        /// �����ƿⵥ״̬
        /// </summary>
        /// <param name="truckTran"></param>
        /// <returns></returns>
        private async Task SendTransferToMes(TPlTruckTransfer truckTran)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();

            var teleWMBM14 = new TeleWMBM14
            {
                Payload = new TruckTransfer
                {
                    OperationMark = truckTran.OperationMark,
                    TransferNo = truckTran.TransferNo,
                    CardNo = truckTran.CardNo,
                    TruckNo = truckTran.TruckNo,
                    SourceHouse = truckTran.SourceHouse,
                    DestinationHouse = truckTran.DestHouse,
                    OrderNo = ""
                }
            };
            await mbs.Publish(teleWMBM14);
        }



        /// <summary>
        /// ����������־�ģ��
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> ImportPickModel()
        {
            var ss = new PageResult<TPlTruckTransfer>
            {
                Data = null,
            };
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate(@"excel/ImportPickModel.xlsx", ss);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = "ImportPickModel.xlsx"
            };
        }

        /// <summary>
        /// ����������־���Ϣ
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> ImportPickData(string transferNo, IFormFile file, CancellationToken cancellationToken)
        {
            var plTransfer = await DataContext.Set<TPlTruckTransfer>()
                                              .FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult(false, $"�ƿⵥ��{transferNo}������");
            }
            if (plTransfer.PickState == 1)
            {
                return new OperationResult(false, $"�ƿⵥ���·�����������");
            }
            //����ǰ��ȡ����������
            //var clearPlMaterial = DataContext.Set<TPlMaterial>().Where(t => t.PrepickTransferNo == transferNo);
            //foreach (var cMat in clearPlMaterial) 
            //{

            //}
            var clearTrLoc = DataContext.Set<TTrLocationMaterial>().Where(t => t.PrepickTransferNo == transferNo);
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();
            try
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream).ConfigureAwait(false);
                    var rows = stream.Query(useHeaderRow: true).ToList();
                    if (rows != null && rows.Count > 0)
                    {
                        int[] states = { 1, 2, 3 };
                        List<CoilOrderDetail> pickMatNos = new();
                        for (int i = 0; i < rows.Count; i++)
                        {
                            string matNo = rows[i].MaterialNo;
                            if (string.IsNullOrEmpty(matNo))
                                continue;
                            var plMaterial = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == matNo.Trim());

                            if (plMaterial.PickState != null && plMaterial.PickState != 0)
                            {
                                return new OperationResult(false, $"����ľ��{matNo}��Ԥ�䣬��ȷ��");
                            }
                            if (plMaterial.LockMark == 1)
                            {
                                return new OperationResult(false, $"����ľ��{matNo}�ѱ���������ȷ��");
                            }
                            var trLoc = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.Type == 2 && t.MaterialNo == matNo.Trim());
                            if (plMaterial != null)
                            {
                                plMaterial.PrepickTransferNo = transferNo;
                                plMaterial.PickState = (int)PickStateOfCoil.TransferPrePicked;
                            }
                            if (trLoc != null)
                            {
                                if (trLoc.OwnerBussinessName == "P4")
                                {
                                    return new OperationResult(false, $"����ľ��{matNo}���ڳ�Ʒ������P4�⣬��ȷ��");
                                }

                                trLoc.PrepickTransferNo = transferNo;
                                trLoc.PickState = (int)PickStateOfCoil.TransferPrePicked;

                                var record = new TRcMaterialEvent
                                {
                                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                                    MaterialId = plMaterial.Id,
                                    MaterialNo = plMaterial.No,
                                    Dt = DateTime.Now,
                                    OperationType = "�˹�",
                                    ContentType = "�ƿ�Ԥ����",
                                    FromLocationName = trLoc.LocationName,
                                    ToLocationName = "",
                                    Description = $"�ƿ⳵��/���ţ�{plTransfer.TruckNo}/{plTransfer.TransferNo}����Ԥ���⣬�˹�����",
                                    FromPosition = $"",
                                    ToPosition = $"",
                                    Result = "�ɹ�"
                                };
                                repoMatEv.Add(record);
                            }
                            else
                            {
                                return new OperationResult(false, $"����ľ��{matNo}���ڿ⣬��ȷ��");
                            }
                            pickMatNos.Add(new CoilOrderDetail { CoilNo = plMaterial.No, OrderNo = plMaterial.OrderNo });
                        }
                        await DataContext.SaveChangesAsync(cancellationToken);
                        await SendPickedToMes(plTransfer, pickMatNos, "5");
                    }
                    return new OperationResult(true, $"{transferNo}����ɹ�{rows.Count}��");
                }
            }
            catch (Exception ex)
            {
                return new OperationResult(true, $"����ʧ��{ex.Message}");
            }
        }

        #region �Զ�Ԥ�����㷨
        ///// <summary>
        ///// �Զ�Ԥ����
        ///// </summary>
        //[HttpPost("")]
        //public async Task<ActionResult<OperationResult>> AutoTransferPick([FromQuery] int?[] pickTypes, [FromQuery] string[] bayCodes, string transferNo, int isDirectTruck)
        //{
        //    var repo = DataContext.Set<TPlTruckTransfer>();
        //    var plTransfer = await repo.FirstOrDefaultAsync(t => t.TransferNo == transferNo);
        //    if (plTransfer == null)
        //    {
        //        return new OperationResult(false, $"�ƿⵥ��{transferNo}������");
        //    }
        //    //return new OperationResult(false, $"����");

        //    string truckNoTranNo = $"����/�ƿⵥ�ţ�{plTransfer.TruckNo}/{plTransfer.TransferNo}";
        //    var repoMat = DataContext.Set<VPlMaterial>();
        //    var repoPlMat = DataContext.Set<TPlMaterial>();
        //    var repoLocMat = DataContext.Set<TTrLocationMaterial>();
        //    //��ѯ����
        //    var matStatusList = new[] { "33", "34", "36", "39" };
        //    var complexDecideCodes = new[] { "1", "M", "A" };
        //    var sourceHouse = plTransfer.SourceHouse;
        //    var predicate = ExpressionBuilder.True<VPlMaterial>();
        //    predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
        //                matStatusList.Contains(t.MatStatus) &&
        //                (t.MatDirection == "U127" || t.TrnpModeCode == "A") &&
        //                (t.PickState == (int)PickStateOfCoil.None || t.PickState == null || t.PrepickTransferNo == transferNo) &&
        //                t.OwnerBussinessName == sourceHouse &&
        //                t.IsOrdered == 1 &&
        //                complexDecideCodes.Contains(t.ComplexDecideCode) &&
        //                t.LockMark != 1 && t.ProductPackFlag == "1");

        //    var scTerminalCodes = DataContext.Set<TScTransferTerminal>().Where(t => t.IsEnable == 0).Select(t => t.Code).ToList();
        //    if (scTerminalCodes != null && scTerminalCodes.Count > 0)
        //    {
        //        predicate = predicate.And(t => !scTerminalCodes.Contains(t.Terminal));
        //    }
        //    //����������Ԥ����
        //    var satisfyPreMats = repoMat.Where(predicate).ToList();
        //    //1�����䷽ʽ ��Ϊ������ˮ������
        //    //���˷�Ϊ��ó����ó  ��ó����ó�����ö�����ͷ��ĸ����ʶ D������ó E������ó �������յ�����ʶ �յ�Ϊ�մ�����ó ��Ϊ�մ�����ó  ��ó��ó��������U127��ۿ�����  ����ó����ʱ�ۿ�������������  ���װ14���� ������130t��150t
        //    // ˮ�����ˣ����յ� ������ۿ������ǿհ�

        //    //�Զ�Ԥ���ľ�
        //    var autoPrePickMats = new List<VPlMaterial>();
        //    string msg = string.Empty;

        //    var pickTypeList = pickTypes;
        //    if (pickTypeList == null || pickTypeList.Length == 0)
        //    {
        //        return new OperationResult(false, $"��ѡ����������");
        //    }

        //    var prewiredList = DataContext.Set<TRlTransferPrewired>().Where(t => pickTypeList.Contains(t.StowageType)).ToList();
        //    var prePickResult = (false, "", new List<VPlMaterial>());
        //    var prePickType = 0;
        //    //���ⷿԤ��
        //    foreach (var prewired in prewiredList)
        //    {
        //        if (prewired.WeightLimit <= 0)
        //        {
        //            prewired.WeightLimit = 135;
        //        }

        //        if (prewired.IsDistributionShip == 2)
        //        {
        //            satisfyPreMats = satisfyPreMats.Where(t => t.IsDistributionShip == 0 || t.IsDistributionShip == null).ToList();
        //        }
        //        else if (prewired.IsDistributionShip == 1)
        //        {
        //            satisfyPreMats = satisfyPreMats.Where(t => t.IsDistributionShip == 1).ToList();
        //        }
        //        //if (prewired.PortLotNumber == null || prewired.PortLotNumber <= 0) prewired.PortLotNumber = 100;  //��ʾ������
        //        if (prewired.StowageType == 1) //��ó ��Ҫɸѡ���� �ϲ���ͷ����
        //        {
        //            var scSpecList = DataContext.Set<TScTransferSpec>().Where(t => t.SpecWidth > 0 && t.BelongSpecWidth > 0).ToList();
        //            var scTerminalList = DataContext.Set<TScTransferTerminal>().Where(t => !string.IsNullOrEmpty(t.BelongCityName) && !string.IsNullOrEmpty(t.Code)).ToList();
        //            var insideList = satisfyPreMats.Where(t => t.OrderNo.StartsWith("D") && t.TrnpModeCode == "T").ToList();//��ó

        //            if (scSpecList.Count > 0 || scTerminalList.Count > 0)
        //            {
        //                foreach (var inside in insideList)
        //                {
        //                    var scSpec = scSpecList.FirstOrDefault(t => t.SpecWidth == inside.DecideWidth);
        //                    if (scSpec != null)
        //                    {
        //                        inside.BelongDecideWidth = scSpec.BelongSpecWidth;
        //                    }
        //                    var scTerminal = scTerminalList.FirstOrDefault(t => t.Code == inside.Terminal);
        //                    if (scTerminal != null)
        //                    {
        //                        inside.BelongTerminal = scTerminal.BelongCityName;
        //                    }
        //                }
        //            }

        //            prePickResult = GetInMeasuredPrePickMats(insideList, prewired, bayCodes, prewired.WeightLimit);
        //            prePickType = 1;
        //        }
        //        else if (prewired.StowageType == 2) //��ó ��Ҫɸѡ���� ���
        //        {
        //            var outerList = satisfyPreMats.Where(t => t.OrderNo.StartsWith("E") && t.TrnpModeCode == "T").ToList(); //��ó
        //            prePickResult = GetOutMeasuredPrePickMats(outerList, prewired, bayCodes, prewired.WeightLimit);
        //            prePickType = 1;
        //        }
        //        else
        //        {
        //            var scTerminalList = DataContext.Set<TScTransferTerminal>().Where(t => !string.IsNullOrEmpty(t.BelongCityName) && !string.IsNullOrEmpty(t.Code)).ToList();
        //            var moistureList = satisfyPreMats.Where(t => t.TrnpModeCode == "A").ToList();  //ˮ������
        //            if (scTerminalList.Count > 0)
        //            {
        //                foreach (var moisture in moistureList)
        //                {
        //                    var scTerminal = scTerminalList.FirstOrDefault(t => t.Code == moisture.Terminal);
        //                    if (scTerminal != null)
        //                    {
        //                        moisture.BelongTerminal = scTerminal.BelongCityName;
        //                    }
        //                }
        //            }

        //            prePickResult = GetWaterMeasuredPrePickMats(moistureList, prewired, bayCodes, prewired.WeightLimit);
        //            prePickType = 3;
        //        }
        //        if (prePickResult.Item1)
        //        {
        //            autoPrePickMats = prePickResult.Item3;
        //            goto prePickSuc;
        //        }
        //    }

        //    prePickSuc:
        //    if (autoPrePickMats == null || autoPrePickMats.Count == 0)
        //    {
        //        return new OperationResult(false, $"{truckNoTranNo} {prePickResult.Item2}���޿���������");
        //    }

        //    plTransfer.PrepickType = prePickType;

        //    var teleWMBM09 = new TeleWMBM09
        //    {
        //        Payload = new TruckPickCoilInfo
        //        {
        //            TruckNo = plTransfer.TruckNo,
        //            OrderInformNo = plTransfer.TransferNo,
        //            MainTruckLoadingNo = "",
        //            TruckLoadingNo = "",
        //            PickType = "5"
        //        }
        //    };
        //    var repoMatEv = DataContext.Set<TRcMaterialEvent>();
        //    for (int i = 0; i < autoPrePickMats.Count(); i++)
        //    {
        //        teleWMBM09.Payload.Details[i].OrderNo = autoPrePickMats[i].OrderNo;
        //        teleWMBM09.Payload.Details[i].CoilNo = autoPrePickMats[i].No;

        //        var plMat = repoPlMat.FirstOrDefault(t => t.No == autoPrePickMats[i].No);
        //        if (plMat != null)
        //        {
        //            plMat.PrepickTransferNo = transferNo;
        //            plMat.PickState = (int)PickStateOfCoil.TransferPrePicked;
        //        }
        //        var trLocMat = repoLocMat.FirstOrDefault(t => t.MaterialNo == autoPrePickMats[i].No);
        //        if (trLocMat != null)
        //        {
        //            trLocMat.PrepickTransferNo = transferNo;
        //            trLocMat.PickState = (int)PickStateOfCoil.TransferPrePicked;

        //            var record = new TRcMaterialEvent
        //            {
        //                Id = IdWorkerGenerator.Instance.NextId().ToString(),
        //                MaterialId = trLocMat.Id,
        //                MaterialNo = trLocMat.MaterialNo,
        //                Dt = DateTime.Now,
        //                OperationType = "�Զ�",
        //                ContentType = "�ƿ�Ԥ����",
        //                FromLocationName = trLocMat.LocationName,
        //                ToLocationName = "",
        //                Description = $"�ƿ⳵��/���ţ�{plTransfer.TruckNo}/{plTransfer.TransferNo}����Ԥ���⣬�Զ�����",
        //                FromPosition = $"",
        //                ToPosition = $"",
        //                Result = "�ɹ�"
        //            };
        //            repoMatEv.Add(record);
        //        }
        //    }
        //    var mbs = ServiceProvider.GetService<MbsProxy>();
        //    await mbs.Publish(teleWMBM09);
        //    await DataContext.SaveChangesAsync();
        //    return new OperationResult(true, $"{truckNoTranNo} �Զ�Ԥ���ɹ�");
        //}

        #region ��óԤ���߼�

        //private (bool, string, List<VPlMaterial>) GetInMeasuredPrePickMats(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, string[] bayCodes, int? weightLimit)
        //{
        //    var resultList = new List<VPlMaterial>();
        //    var autoList = new List<List<VPlMaterial>>();
        //    //�������ͷ���ó����ó��ˮ������
        //    //��ó����ͷ��������ϲ���ȡ���ñ�������������(����)
        //    //��ó��û����ͷ�������ǹ��ֻ������������(����)
        //    //ˮ�����ˣ�����ͷ���ϲ��������ǹ��û�иۿ�����
        //    try
        //    {
        //        var pickArr = new int[8] { 14, 13, 12, 11, 10, 9, 7, 6 };  //��Ԥ������
        //        var bayCodeList = new List<string>();
        //        if (bayCodes != null && bayCodes.Length > 0)
        //        {
        //            bayCodeList = bayCodes.ToList();
        //        }
        //        else
        //        {
        //            bayCodeList = satisfyPreMats.Select(t => t.BayCode).Distinct().ToList();// bayList
        //        }

        //        var allTwoFloorList = DataContext.Set<TTrLocationMaterial>().Where(t => t.IsEnable == 1 && bayCodes.Contains(t.BayCode) && t.Type == 2 && t.FloorNo == 2).ToList();

        //        foreach (var pickNum in pickArr)
        //        {
        //            foreach (var bayCode in bayCodes)
        //            {
        //                var curBayFloorList = allTwoFloorList.Where(t => t.BayCode == bayCode).ToList();

        //                var bayDiameterList = satisfyPreMats.Where(t => t.BayCode == bayCode && t.Diameter > 1500).ToList();
        //                if (pickNum >= 9)
        //                {
        //                    bayDiameterList = satisfyPreMats.Where(t => t.BayCode == bayCode && t.Diameter <= 1500).ToList();
        //                }
        //                var terminalList = bayDiameterList.Select(t => t.BelongTerminal).Distinct().ToList();// �յ���ͷList
        //                foreach (var terminal in terminalList)
        //                {
        //                    var widths = bayDiameterList.Where(t => t.BelongTerminal == terminal).Select(t => t.BelongDecideWidth).Distinct().ToList();

        //                    var bayTerminalList = bayDiameterList.Where(t => t.BelongTerminal == terminal).ToList();
        //                    foreach (var width in widths)
        //                    {
        //                        var byTermAndWidthList = bayTerminalList.Where(t => t.BelongTerminal == terminal && t.BelongDecideWidth == width).ToList();

        //                        if (byTermAndWidthList.Count < pickNum) //����������������������
        //                        {
        //                            continue;
        //                        }

        //                        if (prewired.PortLotNumber > 0)
        //                        {
        //                            var portLotNumbers = byTermAndWidthList.Select(t => t.PortLotNumber).Distinct().ToList();
        //                            if (portLotNumbers.Count <= prewired.PortLotNumber)
        //                            {
        //                                var sucPreMats = GetOptimalList(byTermAndWidthList, pickNum, curBayFloorList);
        //                                autoList.Add(sucPreMats);
        //                            }
        //                            else
        //                            {
        //                                var num = Convert.ToInt32(prewired.PortLotNumber);
        //                                var portLotCombinationList = GetCombinationList(num, portLotNumbers);
        //                                var sucPreMats = GetHavePortOptimalList(portLotCombinationList, byTermAndWidthList, pickNum, curBayFloorList, weightLimit);
        //                                if (sucPreMats != null)
        //                                {
        //                                    autoList.Add(sucPreMats);
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            var sucPreMats = GetOptimalList(byTermAndWidthList, pickNum, curBayFloorList);
        //                            autoList.Add(sucPreMats);
        //                        }
        //                    }
        //                }
        //            }
        //            if (autoList.Count <= 0)
        //            {
        //                continue;
        //            }
        //            //�ж϶������ֱ�ӷ���
        //            int maxFloor = autoList.Max(t => t.Count(t => t.FloorNo == 2));
        //            resultList = autoList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
        //            if (resultList.Sum(t => t.Weight / 1000d) >= weightLimit)
        //            {
        //                autoList.Clear();
        //                continue;
        //            }
        //            return (true, "", resultList);
        //        }
        //        return (false, "�Զ�����ʧ�ܣ����ֶ�Ԥ��", resultList);
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, $"�Զ������쳣������ϵ�п�,�쳣:{ex.Message}", resultList);
        //    }
        //}

        #endregion

        #region ��óԤ���߼�

        //private (bool, string, List<VPlMaterial>) GetOutMeasuredPrePickMats(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, string[] bayCodes, int? weightLimit)
        //{
        //    var resultList = new List<VPlMaterial>();
        //    var autoList = new List<List<VPlMaterial>>();
        //    //�������ͷ���ó����ó��ˮ������
        //    //��ó����ͷ��������ϲ���ȡ���ñ�������������(����)
        //    //��ó��û����ͷ�������ǹ��ֻ������������(����)4
        //    //ˮ�����ˣ�����ͷ�ϲ��������ǹ��û�иۿ����� ������ͷ��֧�ֵ�ᰱ�
        //    try
        //    {
        //        var pickArr = new int[8] { 14, 13, 12, 11, 10, 9, 7, 6 };  //��Ԥ������

        //        var bayCodeList = new List<string>();
        //        if (bayCodes != null && bayCodes.Length > 0)
        //        {
        //            bayCodeList = bayCodes.ToList();
        //        }
        //        else
        //        {
        //            bayCodeList = satisfyPreMats.Select(t => t.BayCode).Distinct().ToList();// bayList
        //        }

        //        var allTwoFloorList = DataContext.Set<TTrLocationMaterial>().Where(t => t.IsEnable == 1 && bayCodes.Contains(t.BayCode) && t.Type == 2 && t.FloorNo == 2).ToList();
        //        foreach (var pickNum in pickArr)
        //        {
        //            foreach (var bayCode in bayCodes)
        //            {
        //                var curBayFloorList = allTwoFloorList.Where(t => t.BayCode == bayCode).ToList();

        //                var byDiameterList = satisfyPreMats.Where(t => t.Diameter > 1500 && t.BayCode == bayCode).ToList();
        //                if (pickNum >= 9)
        //                {
        //                    byDiameterList = satisfyPreMats.Where(t => t.Diameter <= 1500 && t.BayCode == bayCode).ToList();
        //                }

        //                if (byDiameterList.Count < pickNum)
        //                {
        //                    continue;
        //                }

        //                if (prewired.PortLotNumber > 0)
        //                {
        //                    var portLotNumbers = byDiameterList.Select(t => t.PortLotNumber).Distinct().ToList();
        //                    if (portLotNumbers.Count <= prewired.PortLotNumber)
        //                    {
        //                        var sucPreMats = GetOptimalList(byDiameterList, pickNum, curBayFloorList);
        //                        autoList.Add(sucPreMats);
        //                    }
        //                    else
        //                    {
        //                        var num = Convert.ToInt32(prewired.PortLotNumber);
        //                        var portLotCombinationList = GetCombinationList(num, portLotNumbers);
        //                        var sucPreMats = GetHavePortOptimalList(portLotCombinationList, byDiameterList, pickNum, curBayFloorList, weightLimit);
        //                        if (sucPreMats != null)
        //                        {
        //                            autoList.Add(sucPreMats);
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    var sucPreMats = GetOptimalList(byDiameterList, pickNum, curBayFloorList);
        //                    autoList.Add(sucPreMats);
        //                }
        //            }

        //            if (autoList.Count <= 0)
        //            {
        //                continue;
        //            }
        //            //�ж϶������ֱ�ӷ���
        //            int maxFloor = autoList.Max(t => t.Count(t => t.FloorNo == 2));
        //            resultList = autoList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
        //            if (resultList.Sum(t => t.Weight / 1000d) >= weightLimit)
        //            {
        //                autoList.Clear();
        //                continue;
        //            }
        //            return (true, "", resultList);

        //        }
        //        return (false, "�Զ�����ʧ�ܣ����ֶ�Ԥ��", resultList);
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, $"�Զ������쳣������ϵ�п�,�쳣:{ex.Message}", resultList);
        //    }
        //}
        #endregion

        #region ˮ������Ԥ���߼�

        //private (bool, string, List<VPlMaterial>) GetWaterMeasuredPrePickMats(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, string[] bayCodes, int? weightLimit)
        //{
        //    var resultList = new List<VPlMaterial>();
        //    var autoList = new List<List<VPlMaterial>>();
        //    //�������ͷ���ó����ó��ˮ������
        //    //��ó����ͷ��������ϲ���ȡ���ñ�������������(����)
        //    //��ó��û����ͷ�������ǹ��ֻ������������(����)
        //    //ˮ�����ˣ�����ͷ���ϲ��������ǹ��û�иۿ�����
        //    try
        //    {
        //        var pickArr = new int[8] { 14, 13, 12, 11, 10, 9, 7, 6 };  //��Ԥ������

        //        var bayCodeList = new List<string>();
        //        if (bayCodes != null && bayCodes.Length > 0)
        //        {
        //            bayCodeList = bayCodes.ToList();
        //        }
        //        else
        //        {
        //            bayCodeList = satisfyPreMats.Select(t => t.BayCode).Distinct().ToList();// bayList
        //        }

        //        var allTwoFloorList = DataContext.Set<TTrLocationMaterial>().Where(t => t.IsEnable == 1 && bayCodes.Contains(t.BayCode) && t.Type == 2 && t.FloorNo == 2).ToList();
        //        foreach (var pickNum in pickArr)
        //        {
        //            foreach (var bayCode in bayCodes)
        //            {
        //                var curBayFloorList = allTwoFloorList.Where(t => t.BayCode == bayCode).ToList();

        //                var byDiameterList = satisfyPreMats.Where(t => t.Diameter > 1500 && t.BayCode == bayCode).ToList();
        //                if (pickNum >= 9)
        //                {
        //                    byDiameterList = satisfyPreMats.Where(t => t.Diameter <= 1500 && t.BayCode == bayCode).ToList();
        //                }

        //                var terminalList = byDiameterList.Select(t => t.BelongTerminal).Distinct().ToList();// �յ���ͷList
        //                foreach (var terminal in terminalList)
        //                {
        //                    var byTerminalList = byDiameterList.Where(t => t.BelongTerminal == terminal).ToList();
        //                    if (byTerminalList.Count < pickNum) //����������������������
        //                    {
        //                        continue;
        //                    }
        //                    if (prewired.PortLotNumber > 0)
        //                    {
        //                        var portLotNumbers = byTerminalList.Select(t => t.PortLotNumber).Distinct().ToList();
        //                        if (portLotNumbers.Count <= prewired.PortLotNumber)
        //                        {
        //                            var sucPreMats = GetOptimalList(byTerminalList, pickNum, curBayFloorList);
        //                            autoList.Add(sucPreMats);
        //                        }
        //                        else
        //                        {
        //                            var num = Convert.ToInt32(prewired.PortLotNumber);
        //                            var portLotCombinationList = GetCombinationList(num, portLotNumbers);
        //                            var sucPreMats = GetHavePortOptimalList(portLotCombinationList, byTerminalList, pickNum, curBayFloorList, weightLimit);
        //                            if (sucPreMats != null)
        //                            {
        //                                autoList.Add(sucPreMats);
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        var sucPreMats = GetOptimalList(byTerminalList, pickNum, curBayFloorList);
        //                        autoList.Add(sucPreMats);
        //                    }
        //                }
        //            }

        //            if (autoList.Count <= 0)
        //            {
        //                continue;
        //            }
        //            //�ж϶������ֱ�ӷ���
        //            int maxFloor = autoList.Max(t => t.Count(t => t.FloorNo == 2));
        //            resultList = autoList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
        //            if (resultList.Sum(t => t.Weight / 1000d) >= weightLimit)
        //            {
        //                autoList.Clear();
        //                continue;
        //            }
        //            return (true, "", resultList);
        //        }

        //        return (false, "�Զ�����ʧ�ܣ����ֶ�Ԥ��", resultList);
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, $"�Զ������쳣������ϵ�п�,�쳣:{ex.Message}", resultList);
        //    }
        //}

        #endregion

        /// <summary>
        /// ���ۿ�������ϻ�ȡ������ŷ���
        /// </summary>
        /// <param name="portComList"></param>
        /// <param name="list"></param>
        /// <param name="pickNum"></param>
        /// <param name="trList"></param>
        /// <param name="weightLimit"></param>
        /// <returns></returns>
        private List<VPlMaterial> GetHavePortOptimalList(List<List<string>> portComList, List<VPlMaterial> list, int pickNum, List<TTrLocationMaterial> trList, int? weightLimit)
        {
            var autoList = new List<List<VPlMaterial>>();
            foreach (var ports in portComList)
            {
                var portList = list.Where(t => ports.Contains(t.PortLotNumber)).ToList();
                if (portList.Count < pickNum)
                {
                    continue;
                }
                var sucList = GetOptimalList(portList, pickNum, trList, weightLimit);
                var totalWeight = sucList.Sum(t => t.Weight / 1000M);
                if (sucList.Count(t => t.FloorNo == 2) == pickNum && totalWeight > 100 && totalWeight <= weightLimit)
                {
                    return sucList;
                }

                //if (sucList.Count(t => t.FloorNo == 2) == pickNum && totalWeight <= weightLimit)
                //{
                //    return sucList;
                //}
                if (totalWeight > 100 && totalWeight <= weightLimit)
                {
                    autoList.Add(sucList);
                }
            }
            if (autoList.Count > 0)
            {
                //�ж϶������ֱ�ӷ���
                int maxFloor = autoList.Max(t => t.Count(t => t.FloorNo == 2));
                return autoList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
            }
            return null;
        }

        /// <summary>
        /// ��ȡ����ѹһ���һ���Ϸ��޶������ŷ���
        /// </summary>
        /// <param name="list">���������ļ���</param>
        /// <param name="pickNum">Ԥ������</param>
        /// <param name="trList">��ǰ����ڿ����</param>
        /// <param name="weightLimit">���Ƶ�����</param>
        /// <returns></returns>
        private List<VPlMaterial> GetOptimalList(List<VPlMaterial> list, int pickNum, List<TTrLocationMaterial> trList, int? weightLimit = 0)
        {
            if (list.Count < pickNum || pickNum <= 0)
            {
                return new List<VPlMaterial>();
            }
            list = list.OrderByDescending(t => t.Weight).ToList();
            var satisfyList = list.Where(t => t.FloorNo == 2).ToList();
            if (satisfyList.Count >= pickNum)
            {
                if (weightLimit == 0)
                {
                    return satisfyList.OrderByDescending(t => t.Weight).Take(pickNum).ToList();
                }
                var orderByList = satisfyList.OrderByDescending(t => t.Weight).ToList();
                for (int i = 0; i < orderByList.Count; i++)
                {
                    var results = orderByList.GetRange(i, orderByList.Count - i).Take(pickNum).ToList();
                    if (results.Count != pickNum)
                    {
                        break;
                    }
                    var totalWeight = results.Sum(t => t.Weight / 1000d);
                    if (totalWeight > 100 && totalWeight <= weightLimit)
                    {
                        return results;
                    }
                }
            }

            foreach (var floor in satisfyList) //���Ҷ����µ�һ���Ƿ�������
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
                    belowOneList.ForEach(t => { t.FloorNo = 2; });// ������ѹ��һ�����Ϊ�Ƕ���������
                    satisfyList = satisfyList.Concat(belowOneList).ToList();
                }
                if (satisfyList.Count >= pickNum)
                {
                    if (weightLimit == 0)
                    {
                        return satisfyList.OrderByDescending(t => t.Weight).Take(pickNum).ToList();
                    }
                    var orderByList = satisfyList.OrderByDescending(t => t.Weight).ToList();
                    for (int i = 0; i < orderByList.Count; i++)
                    {
                        var results = orderByList.GetRange(i, orderByList.Count - i).Take(pickNum).ToList();
                        if (results.Count != pickNum)
                        {
                            break;
                        }
                        var totalWeight = results.Sum(t => t.Weight / 1000d);
                        if (totalWeight > 100 && totalWeight <= weightLimit)
                        {
                            return results;
                        }
                        //if (results.Sum(t => t.Weight / 1000d) <= weightLimit)
                        //{
                        //    return results;
                        //}
                    }
                }
            }
            //δԤ���һ������һ����Ϸ��Ƿ���ڶ������Ϣ
            var noPickList = list.Except(satisfyList).ToList();
            var noPickListToRemove = new List<VPlMaterial>(noPickList);
            foreach (var noPick in noPickList)
            {
                var left = noPick.ColNo;
                var right = noPick.ColNo - 1;
                var belowOneList = trList.Where(t => t.AreaCode == noPick.AreaCode &&
                                            t.RowNo == noPick.RowNo &&
                                            (t.ColNo == left || t.ColNo == right)).ToList();
                if (belowOneList.Count == 0)
                {
                    noPick.FloorNo = 2;   //��δ��ѹ��һ�����Ϊ�Ƕ������
                    satisfyList.Add(noPick);
                    noPickListToRemove.Remove(noPick);
                }
                if (satisfyList.Count >= pickNum)
                {
                    if (weightLimit == 0)
                    {
                        return satisfyList.OrderByDescending(t => t.Weight).Take(pickNum).ToList();
                    }
                    var orderByList = satisfyList.OrderBy(t => t.Weight).ToList();
                    for (int i = 0; i < orderByList.Count; i++)
                    {
                        var results = orderByList.GetRange(i, orderByList.Count - i).Take(pickNum).ToList();
                        if (results.Count != pickNum)
                        {
                            break;
                        }
                        var totalWeight = results.Sum(t => t.Weight / 1000d);
                        if (totalWeight > 100 && totalWeight <= weightLimit)
                        {
                            return results;
                        }
                        //if (results.Sum(t => t.Weight / 1000d) <= weightLimit)
                        //{
                        //    return results;
                        //}
                    }
                }
            }

            return satisfyList.Concat(noPickListToRemove).Take(pickNum).ToList();
        }

        /// <summary>
        /// �ۿ��������
        /// </summary>
        /// <param name="planCount">�ۿ���������</param>
        /// <param name="satisfyPreMats"></param>
        private static List<List<string>> GetCombinationList(int planCount, List<string> satisfyPreMats)
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            var autoList = new List<List<string>>();
            var cn = new Combination(satisfyPreMats.Count, planCount);
            Task.Factory.StartNew(() =>
            {
                foreach (var row in cn.GetRows())
                {
                    var cnList = Combination.Permute(row, satisfyPreMats);
                    autoList.Add(cnList);
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }
                }
            }, token).Wait(3000);
            cts.Cancel();
            return autoList;
        }

        /// <summary>
        /// ��ȡ�ַ����������
        /// </summary>
        /// <param name="satisfyPreMats"></param>
        private static List<List<string>> GetAllCombinationList(List<string> satisfyPreMats)
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            var autoList = new List<List<string>>();
            var cn = new Combination(satisfyPreMats.Count);
            Task.Factory.StartNew(() =>
            {
                foreach (var row in cn.GetRowsForAllPicks())
                {
                    var cnList = Combination.Permute(row, satisfyPreMats);
                    autoList.Add(cnList);
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }
                }
            }, token).Wait(3000);
            cts.Cancel();
            return autoList;
        }

        #endregion

        /// <summary>
        /// ��ȡ��ǰ������óˮ������������
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<List<int>>>> GetPickTypeNum([FromQuery] string[] bayCodes, string transferNo, CancellationToken cancellationToken)
        {
            List<int> numList = new List<int>();
            var plTransfer = await DataContext.Set<TPlTruckTransfer>()
                                              .FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult<List<int>>(false, $"�ƿⵥ��{transferNo}������", numList);
            }

            var repoMat = DataContext.Set<VPlMaterial>();
            var repoPlMat = DataContext.Set<TPlMaterial>();
            var repoLocMat = DataContext.Set<TTrLocationMaterial>();
            //��ѯ����
            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };
            var sourceHouse = plTransfer.SourceHouse;
            var predicate = ExpressionBuilder.True<VPlMaterial>();
            predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
                        matStatusList.Contains(t.MatStatus) &&
                        (t.MatDirection == "U127" || t.TrnpModeCode == "A") &&
                        (t.PickState == (int)PickStateOfCoil.None || t.PickState == null) &&
                        t.OwnerBussinessName == sourceHouse &&
                        t.IsOrdered == 1 &&
                        complexDecideCodes.Contains(t.ComplexDecideCode)
                        && t.LockMark != 1
                        && t.ProductPackFlag == "1");

            var scTerminalCodes = DataContext.Set<TScTransferTerminal>().Where(t => t.IsEnable == 0).Select(t => t.Code).ToList();
            if (scTerminalCodes != null && scTerminalCodes.Count > 0)
            {
                predicate = predicate.And(t => !scTerminalCodes.Contains(t.Terminal));
            }
            if (bayCodes != null && bayCodes.Length > 0)
            {
                predicate = predicate.And(t => bayCodes.Contains(t.BayCode));
            }
            //����������Ԥ����
            var satisfyPreMats = repoMat.Where(predicate).ToList();
            var insideList = satisfyPreMats.Where(t => t.OrderNo.StartsWith("D") && t.TrnpModeCode == "T").ToList();//��ó
            var outerList = satisfyPreMats.Where(t => t.OrderNo.StartsWith("E") && t.TrnpModeCode == "T").ToList(); //��ó
            var moistureList = satisfyPreMats.Where(t => t.TrnpModeCode == "A").ToList();  //ˮ������
            numList.Add(insideList.Count);
            numList.Add(outerList.Count);
            numList.Add(moistureList.Count);
            return new OperationResult<List<int>>(true, "", numList);
        }

        /// <summary>
        /// ��ȡ��ǰ������óˮ����װ�߿���������
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<List<int>>>> GetPickTypeLineNum([FromQuery] string[] bayCodes, string transferNo, CancellationToken cancellationToken)
        {
            List<int> numList = new List<int>();
            var plTransfer = await DataContext.Set<TPlTruckTransfer>()
                                              .FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult<List<int>>(false, $"�ƿⵥ��{transferNo}������", numList);
            }

            var repoMat = DataContext.Set<VPlMaterial>();
            var repoPlMat = DataContext.Set<TPlMaterial>();
            var repoLocMat = DataContext.Set<TTrLocationMaterial>();
            //��ѯ����
            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };
            var sourceHouse = plTransfer.SourceHouse;
            var predicate = ExpressionBuilder.True<VPlMaterial>();
            predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
                        matStatusList.Contains(t.MatStatus) &&
                        (t.MatDirection == "U127" || t.TrnpModeCode == "A") &&
                        (t.PickState == (int)PickStateOfCoil.None || t.PickState == null)
                        && (t.AreaCode == "0X" || t.AreaCode == "0Y")
                        && t.OwnerBussinessName == "P4");

            var scTerminalCodes = DataContext.Set<TScTransferTerminal>().Where(t => t.IsEnable == 0).Select(t => t.Code).ToList();
            if (scTerminalCodes != null && scTerminalCodes.Count > 0)
            {
                predicate = predicate.And(t => !scTerminalCodes.Contains(t.Terminal));
            }
            if (bayCodes != null && bayCodes.Length > 0)
            {
                predicate = predicate.And(t => bayCodes.Contains(t.BayCode));
            }
            //����������Ԥ����
            var satisfyPreMats = repoMat.Where(predicate).ToList();
            var insideList = satisfyPreMats.Where(t => t.OrderNo.StartsWith("D") && t.TrnpModeCode == "T").ToList();//��ó
            var outerList = satisfyPreMats.Where(t => t.OrderNo.StartsWith("E") && t.TrnpModeCode == "T").ToList(); //��ó
            var moistureList = satisfyPreMats.Where(t => t.TrnpModeCode == "A").ToList();  //ˮ������
            numList.Add(insideList.Count);
            numList.Add(outerList.Count);
            numList.Add(moistureList.Count);
            return new OperationResult<List<int>>(true, "", numList);
        }

        #region �ƿ�����������-ֱװ
        /// <summary>
        /// �Զ�Ԥ����
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> AutoTransferPickDirect([FromQuery] int?[] pickTypes, [FromQuery] string[] bayCodes, string transferNo, int isDirectTruck)
        {
            var repo = DataContext.Set<TPlTruckTransfer>();
            var plTransfer = await repo.FirstOrDefaultAsync(t => t.TransferNo == transferNo);
            if (plTransfer == null)
            {
                return new OperationResult(false, $"�ƿⵥ��{transferNo}������");
            }

            string truckNoTranNo = $"����/�ƿⵥ�ţ�{plTransfer.TruckNo}/{plTransfer.TransferNo}";
            var repoMat = DataContext.Set<VPlMaterial>();
            var repoPlMat = DataContext.Set<TPlMaterial>();
            var repoLocMat = DataContext.Set<TTrLocationMaterial>();
            //��ѯ����
            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };
            var sourceHouse = plTransfer.SourceHouse;

            if (bayCodes == null || bayCodes.Length == 0)
            {
                bayCodes = new string[4] { "21", "22", "23", "24" };
                if (sourceHouse == "P5")
                {
                    bayCodes = new string[2] { "16", "17" };
                }
                else if (sourceHouse == "P8")
                {
                    bayCodes = new string[3] { "25", "26", "27" };
                }
            }

            var predicate = ExpressionBuilder.True<VPlMaterial>();
            //predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
            //            matStatusList.Contains(t.MatStatus) &&
            //            (t.MatDirection == "U127" || t.TrnpModeCode == "A") 
            //             && (t.PickState == (int)PickStateOfCoil.None || t.PickState == null || t.PrepickTransferNo == transferNo)
            //             && (t.BayCode == "0M" || t.BayCode == "0N")
            //             //&& bayCodes.Contains(t.BayCode)
            //             && t.OwnerBussinessName == "P4");
            //var proLinePreMats = repoMat.Where(predicate).ToList();


            predicate = predicate.And(t => !string.IsNullOrEmpty(t.No) && t.Type == 2 &&
                        matStatusList.Contains(t.MatStatus) &&
                        (t.MatDirection == "U127" || t.TrnpModeCode == "A") &&
                        (t.PickState == (int)PickStateOfCoil.None || t.PickState == null || t.PrepickTransferNo == transferNo));
            if (isDirectTruck == 1)
            {
                predicate = predicate.And(t => (t.OwnerBussinessName == sourceHouse
                        && t.IsOrdered == 1
                        && complexDecideCodes.Contains(t.ComplexDecideCode)
                        && t.LockMark != 1
                        && t.ProductPackFlag == "1") || ((t.AreaCode == "0X" || t.AreaCode == "0Y")
                        && t.OwnerBussinessName == "P4"));
            }
            else
            {
                predicate = predicate.And(t => t.OwnerBussinessName == sourceHouse
                        && t.IsOrdered == 1
                        && complexDecideCodes.Contains(t.ComplexDecideCode)
                        && t.LockMark != 1
                        && t.ProductPackFlag == "1");
            }

            var scTerminalCodes = DataContext.Set<TScTransferTerminal>().Where(t => t.IsEnable == 0).Select(t => t.Code).ToList();
            if (scTerminalCodes != null && scTerminalCodes.Count > 0)
            {
                predicate = predicate.And(t => !scTerminalCodes.Contains(t.Terminal));
            }
            //����������Ԥ����
            var satisfyPreMats = repoMat.Where(predicate).ToList();
            //1�����䷽ʽ ��Ϊ������ˮ������
            //���˷�Ϊ��ó����ó  ��ó����ó�����ö�����ͷ��ĸ����ʶ D������ó E������ó �������յ�����ʶ �յ�Ϊ�մ�����ó ��Ϊ�մ�����ó  ��ó��ó��������U127��ۿ�����  ����ó����ʱ�ۿ�������������  ���װ14���� ������130t��150t
            // ˮ�����ˣ����յ� ������ۿ������ǿհ�

            //�Զ�Ԥ���ľ�
            var autoPrePickMats = new List<VPlMaterial>();
            string msg = string.Empty;

            var pickTypeList = pickTypes;
            if (pickTypeList == null || pickTypeList.Length == 0)
            {
                return new OperationResult(false, $"��ѡ����������");
            }

            var prewiredList = DataContext.Set<TRlTransferPrewired>().Where(t => pickTypeList.Contains(t.StowageType)).ToList();
            var prePickResult = (false, "", new List<VPlMaterial>());
            var prePickType = 0;

            var blackWhiteList = new List<List<VPlMaterial>>();
            var blackList = satisfyPreMats.Where(t => t.SteelGrade.Contains("���")).ToList();
            var whiteList = satisfyPreMats.Except(blackList).ToList();
            if (blackList.Count > 0) blackWhiteList.Add(blackList);
            if (whiteList.Count > 0) blackWhiteList.Add(whiteList);

            var bayCodesList = new List<List<string>>();
            if (bayCodes.Length == 1)
            {
                bayCodesList.Add(bayCodes.ToList());
            }
            else
            {
                bayCodesList = GetAllCombinationList(bayCodes.ToList());
            }

            if (blackWhiteList.Count > 0)
            {
                blackWhiteList = blackWhiteList.OrderByDescending(t => t.Count).ToList();
                foreach (var conPickList in blackWhiteList)
                {
                    //���ⷿԤ��
                    foreach (var prewired in prewiredList)
                    {
                        if (prewired.WeightLimit <= 0)
                        {
                            prewired.WeightLimit = 135;
                        }
                        var shipSatisfyPreMats = new List<VPlMaterial>();
                        if (prewired.IsDistributionShip == 2)
                        {
                            shipSatisfyPreMats = conPickList.Where(t => t.IsDistributionShip == 0 || t.IsDistributionShip == null).ToList();
                        }
                        else if (prewired.IsDistributionShip == 1)
                        {
                            shipSatisfyPreMats = conPickList.Where(t => t.IsDistributionShip == 1).ToList();
                        }
                        //if (prewired.PortLotNumber == null || prewired.PortLotNumber <= 0) prewired.PortLotNumber = 100;  //��ʾ������
                        if (prewired.StowageType == 1) //��ó ��Ҫɸѡ���� �ϲ���ͷ����
                        {
                            var scSpecList = DataContext.Set<TScTransferSpec>().Where(t => t.SpecWidth > 0 && t.BelongSpecWidth > 0).ToList();
                            var scTerminalList = DataContext.Set<TScTransferTerminal>().Where(t => !string.IsNullOrEmpty(t.BelongCityName) && !string.IsNullOrEmpty(t.Code)).ToList();
                            var insideList = shipSatisfyPreMats.Where(t => t.OrderNo.StartsWith("D") && t.TrnpModeCode == "T").ToList();//��ó

                            if (scSpecList.Count > 0 || scTerminalList.Count > 0)
                            {
                                foreach (var inside in insideList)
                                {
                                    var scSpec = scSpecList.FirstOrDefault(t => t.SpecWidth == inside.DecideWidth);
                                    if (scSpec != null)
                                    {
                                        inside.BelongDecideWidth = scSpec.BelongSpecWidth;
                                    }
                                    var scTerminal = scTerminalList.FirstOrDefault(t => t.Code == inside.Terminal);
                                    if (scTerminal != null)
                                    {
                                        inside.BelongTerminal = scTerminal.BelongCityName;
                                    }
                                }
                            }

                            prePickResult = GetInMeasuredPrePickMatsDirect(insideList, prewired, bayCodesList, prewired.WeightLimit, prewired.NumberLimit);
                            prePickType = 1;
                        }
                        else if (prewired.StowageType == 2) //��ó ��Ҫɸѡ���� ���
                        {
                            var outerList = shipSatisfyPreMats.Where(t => t.OrderNo.StartsWith("E") && t.TrnpModeCode == "T").ToList(); //��ó
                            prePickResult = GetOutMeasuredPrePickMatsDirect(outerList, prewired, bayCodesList, prewired.WeightLimit, prewired.NumberLimit);
                            prePickType = 1;
                        }
                        else
                        {
                            var scTerminalList = DataContext.Set<TScTransferTerminal>().Where(t => !string.IsNullOrEmpty(t.BelongCityName) && !string.IsNullOrEmpty(t.Code)).ToList();
                            var moistureList = shipSatisfyPreMats.Where(t => t.TrnpModeCode == "A").ToList();  //ˮ������
                            if (scTerminalList.Count > 0)
                            {
                                foreach (var moisture in moistureList)
                                {
                                    var scTerminal = scTerminalList.FirstOrDefault(t => t.Code == moisture.Terminal);
                                    if (scTerminal != null)
                                    {
                                        moisture.BelongTerminal = scTerminal.BelongCityName;
                                    }
                                }
                            }

                            prePickResult = GetWaterMeasuredPrePickMatsDirect(moistureList, prewired, bayCodesList, prewired.WeightLimit, prewired.NumberLimit);
                            prePickType = 3;
                        }
                        if (prePickResult.Item1)
                        {
                            autoPrePickMats = prePickResult.Item3;
                            goto prePickSuc;
                        }
                    }
                }
            }

            prePickSuc:
            if (autoPrePickMats == null || autoPrePickMats.Count == 0)
            {
                return new OperationResult(false, $"{truckNoTranNo} {prePickResult.Item2}���޿���������");
            }
            //�˴���֤�����Ԥ���������װ���ϵľ�˵����ֱװ
            string parkNo = "";
            if (autoPrePickMats.Exists(t => t.AreaCode == "0X" || t.AreaCode == "0Y"))
            {
                plTransfer.IsDirectTruck = 1;
                var repoTruck = DataContext.Set<TTrTruck>();
                var repoPark = DataContext.Set<TTrParkingPlace>();
                var trTruck = repoTruck.FirstOrDefault(item => item.CardNo == plTransfer.CardNo && item.TruckNo == plTransfer.TruckNo && item.MainTruckLoadingNo == plTransfer.TransferNo && item.IsEnable == 1);
                if (trTruck != null)
                {
                    trTruck.EnterTime = DateTime.Now;
                }
                else
                {
                    var trBayCodes = autoPrePickMats.Select(t => t.BayCode).Distinct();
                    var addTrTruck = new TTrTruck()
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        CardNo = plTransfer.CardNo,
                        TruckNo = plTransfer.TruckNo,
                        MainTruckLoadingNo = plTransfer.TransferNo,
                        EnterTime = DateTime.Now,
                        DispatchState = 1,
                        ArriveTime = null,
                        SortIndex = -1,
                        HasPicked = 0,
                        PositionState = 0,
                        InboundCheckState = 0,
                        IsDriverCheckIn = 0,
                        IsLoadPlansConfirmed = 0,
                        IsPickedCoilConfirmed = 0,
                        LoadBayCodeList = string.Join(",", trBayCodes),
                        LoadBussinessNameList = plTransfer.SourceHouse,
                        IsEnable = 1,
                        CreateTime = DateTime.Now,
                        CreateUser = "Xcom-CDS",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "Xcom-CDS"
                    };
                    var parkPlace = repoPark.FirstOrDefault(t => trBayCodes.Contains(t.BayCode));
                    if (parkPlace != null)
                    {
                        parkNo = parkPlace.ParkingPlaceId;
                    }
                    repoTruck.Add(addTrTruck);
                }
            }
            else
            {
                plTransfer.IsDirectTruck = 0;
            }

            plTransfer.PrepickType = prePickType;

            var teleWMBM09 = new TeleWMBM09
            {
                Payload = new TruckPickCoilInfo
                {
                    TruckNo = plTransfer.TruckNo,
                    OrderInformNo = plTransfer.TransferNo,
                    MainTruckLoadingNo = "",
                    TruckLoadingNo = "",
                    PickType = "5"
                }
            };
            var repoMatEv = DataContext.Set<TRcMaterialEvent>();
            for (int i = 0; i < autoPrePickMats.Count(); i++)
            {
                teleWMBM09.Payload.Details[i].OrderNo = autoPrePickMats[i].OrderNo;
                teleWMBM09.Payload.Details[i].CoilNo = autoPrePickMats[i].No;

                var plMat = repoPlMat.FirstOrDefault(t => t.No == autoPrePickMats[i].No);
                if (plMat != null)
                {
                    plMat.PrepickTransferNo = transferNo;
                    plMat.PickState = (int)PickStateOfCoil.TransferPrePicked;
                }
                var trLocMat = repoLocMat.FirstOrDefault(t => t.MaterialNo == autoPrePickMats[i].No && t.Type == 2);
                if (trLocMat != null)
                {
                    trLocMat.PrepickTransferNo = transferNo;
                    trLocMat.PickState = (int)PickStateOfCoil.TransferPrePicked;

                    var record = new TRcMaterialEvent
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        MaterialId = trLocMat.Id,
                        MaterialNo = trLocMat.MaterialNo,
                        Dt = DateTime.Now,
                        OperationType = "�Զ�",
                        ContentType = "�ƿ�Ԥ����",
                        FromLocationName = trLocMat.LocationName,
                        ToLocationName = "",
                        Description = $"�ƿ⳵��/���ţ�{plTransfer.TruckNo}/{plTransfer.TransferNo}����Ԥ���⣬�Զ�����",
                        FromPosition = $"",
                        ToPosition = $"",
                        Result = "�ɹ�"
                    };
                    repoMatEv.Add(record);
                }
            }
            var mbs = ServiceProvider.GetService<MbsProxy>();
            if (plTransfer.IsDirectTruck != 1)
            {
                await mbs.Publish(teleWMBM09);
            }
            else if (plTransfer.IsDirectTruck == 1)  //����˾���ֻ�APP��Ϣ��ʾ����
            {
                var teleWMBM10 = new TeleWMBM10
                {
                    Payload = new ParkingSpaceInfo
                    {
                        MainTruckLoadingNo = plTransfer.FakeLoadingNo,
                        TruckLoadingNo = plTransfer.FakeLoadingNo,
                        OrderNo = "",
                        DetailNo = "",
                        VehicleNo = plTransfer.TruckNo,
                        House = plTransfer.SourceHouse,
                        Area = "",
                        ParkingSpace = parkNo,
                        Remark = $"ֱװ��������ֱ��ǰ��{parkNo}����װ��"
                    }
                };
                await mbs.Publish(teleWMBM10);
            }
            await DataContext.SaveChangesAsync();
            return new OperationResult(true, $"{truckNoTranNo} �Զ�Ԥ���ɹ�");
        }
        #endregion

        #region ��óԤ���߼�-ֱװ

        private (bool, string, List<VPlMaterial>) GetInMeasuredPrePickMatsDirect(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, List<List<string>> bayCodes, int? weightLimit, int? numLimit)
        {
            var autoList = new List<List<VPlMaterial>>();
            var resultList = new List<VPlMaterial>();
            try
            {
                for (int i = 1; i <= bayCodes.Select(t => t.Count).Max(); i++)
                {
                    var seleBayCodes = bayCodes.Where(t => t.Count == i).ToList();
                    var lessThan1500List = GetInMeasuredDiffDiameterPrePickList(satisfyPreMats, prewired, seleBayCodes, weightLimit, numLimit);
                    if (lessThan1500List != null)
                    {
                        autoList.Add(lessThan1500List);
                    }
                    var greaterThan1500List = GetInMeasuredDiffDiameterPrePickList(satisfyPreMats, prewired, seleBayCodes, weightLimit, numLimit, true);
                    if (greaterThan1500List != null)
                    {
                        autoList.Add(greaterThan1500List);
                    }
                }
                if (autoList.Count > 0)
                {
                    int maxFloor = autoList.Max(t => t.Count(t => t.FloorNo == 2));
                    resultList = autoList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
                    int maxLine = autoList.Max(t => t.Count(t => t.OwnerBussinessName == "P4"));
                    if (maxLine > 0)
                    {
                        resultList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    }
                    return (true, "", resultList);
                }
                return (false, "�Զ�����ʧ�ܣ����ֶ�Ԥ��", resultList);
            }
            catch (Exception ex)
            {
                return (false, $"�Զ������쳣������ϵ�п�,�쳣:{ex.Message}", resultList);
            }
        }

        private List<VPlMaterial> GetInMeasuredDiffDiameterPrePickList(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, List<List<string>> bayCodes, int? weightLimit, int? numLimit, bool isGreaterThan1500 = false)
        {
            var resultList = new List<VPlMaterial>();
            var autoList = new List<List<VPlMaterial>>();
            //�������ͷ���ó����ó��ˮ������
            //��ó����ͷ��������ϲ���ȡ���ñ�������������(����)
            //��ó��û����ͷ�������ǹ��ֻ������������(����)4
            //ˮ�����ˣ�����ͷ�ϲ��������ǹ��û�иۿ����� ������ͷ��֧�ֵ�ᰱ�
            var pickArr = new int[2];
            if (isGreaterThan1500)
            {
                //pickArr = new int[4] { 7, 6, 5, 4 };
                pickArr = new int[2] { 7, 6 };
            }
            else
            {
                //pickArr = new int[4] { 12, 11, 10, 9 };
                pickArr = new int[3] { 12, 11, 10, };
                int conNumLimit = Convert.ToInt32(numLimit);
                if (numLimit >= 7)
                {
                    //pickArr = new int[4] { conNumLimit, conNumLimit - 1, conNumLimit - 2, conNumLimit - 3 };
                    pickArr = new int[3] { conNumLimit, conNumLimit - 1, conNumLimit - 2 };
                }
            }

            //var bayCodeList = new List<string>();
            //if (bayCodes != null && bayCodes.Length > 0)
            //{
            //    bayCodeList = bayCodes.ToList();
            //}
            //else
            //{
            //    bayCodeList = satisfyPreMats.Select(t => t.BayCode).Distinct().ToList();// bayList
            //}
            var bayCodeList = bayCodes;
            var conBayCodes = new List<string>();
            bayCodeList.ForEach(t =>
            {
                conBayCodes.AddRange(t);
            });
            conBayCodes = conBayCodes.Distinct().ToList();
            var allTwoFloorList = DataContext.Set<TTrLocationMaterial>().Where(t => t.IsEnable == 1 && conBayCodes.Contains(t.BayCode) && t.Type == 2 && t.FloorNo == 2).ToList();

            foreach (var pickNum in pickArr)
            {
                foreach (var bayCode in bayCodeList)
                {
                    var curBayFloorList = allTwoFloorList.Where(t => bayCode.Contains(t.BayCode)).ToList();

                    var byAllDiameterList = satisfyPreMats.Where(t => t.Diameter <= 1500 && bayCode.Contains(t.BayCode)).ToList();
                    if (isGreaterThan1500)
                    {
                        byAllDiameterList = satisfyPreMats.Where(t => t.Diameter > 1500 && bayCode.Contains(t.BayCode)).ToList();
                    }

                    if (byAllDiameterList.Count < pickNum)
                    {
                        continue;
                    }

                    var terminalList = byAllDiameterList.Select(t => t.BelongTerminal).Distinct().ToList();// �յ���ͷList

                    var byDiameterList = byAllDiameterList.Where(t => t.OwnerBussinessName != "P4").ToList();
                    var byLineDiameterList = byAllDiameterList.Where(t => t.OwnerBussinessName == "P4").ToList();

                    foreach (var terminal in terminalList)
                    {
                        var byTermLineDiameterList = byLineDiameterList.Where(t => t.BelongTerminal == terminal).ToList();
                        var byTermDiameterList = byDiameterList.Where(t => t.BelongTerminal == terminal).ToList();
                        if ((byTermLineDiameterList.Count + byTermDiameterList.Count) < pickNum)
                        {
                            continue;
                        }
                        if (prewired.PortLotNumber > 0)
                        {
                            if (byTermLineDiameterList.Count > 0)
                            {
                                var portLotNumbers = byAllDiameterList.Select(t => t.PortLotNumber).Distinct().ToList();
                                if (portLotNumbers.Count <= prewired.PortLotNumber)
                                {
                                    var sucPreMats = GetOptimalList(byTermDiameterList, pickNum - byTermLineDiameterList.Count, curBayFloorList);
                                    sucPreMats.AddRange(byTermLineDiameterList);
                                    autoList.Add(sucPreMats);
                                }
                                else
                                {
                                    var lineAutoList = new List<List<VPlMaterial>>();
                                    var linePortNums = byTermLineDiameterList.Select(t => t.PortLotNumber).Distinct().ToList();
                                    var linePortCount = linePortNums.Count;
                                    var combNum = prewired.PortLotNumber;
                                    if (linePortCount < prewired.PortLotNumber)
                                    {
                                        combNum = linePortCount;
                                    }
                                    var linePortLotComList = GetCombinationList(Convert.ToInt32(combNum), linePortNums);
                                    var lineComPortList = new List<List<VPlMaterial>>();
                                    linePortLotComList.ForEach(ts =>
                                    {
                                        lineComPortList.Add(byTermLineDiameterList.Where(t => ts.Contains(t.PortLotNumber)).ToList());
                                    });
                                    lineComPortList.OrderByDescending(t => t.Count);

                                    foreach (var preLineMatList in lineComPortList)
                                    {
                                        if (preLineMatList.Count >= pickNum)
                                        {
                                            return (preLineMatList.Take(pickNum).ToList());
                                        }
                                        var portLotCombinationList = new List<List<string>>();
                                        var portNums = preLineMatList.Select(t => t.PortLotNumber).Distinct().ToList();
                                        if (prewired.PortLotNumber == combNum)
                                        {
                                            portLotCombinationList.Add(portNums);
                                        }
                                        else
                                        {
                                            var num = Convert.ToInt32(prewired.PortLotNumber - combNum);
                                            portLotCombinationList = GetCombinationList(num, portLotNumbers);
                                            portLotCombinationList.ForEach(t =>
                                            {
                                                t.AddRange(portNums);
                                            });
                                        }
                                        var sucPreMats = GetHavePortOptimalList(portLotCombinationList, byTermDiameterList, pickNum - preLineMatList.Count, curBayFloorList, weightLimit - preLineMatList.Sum(t => t.Weight / 1000));
                                        if (sucPreMats != null)
                                        {
                                            sucPreMats.AddRange(preLineMatList);
                                            autoList.Add(sucPreMats);
                                            //break;
                                            //return (true, "", sucPreMats);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                var portLotNumbers = byTermDiameterList.Select(t => t.PortLotNumber).Distinct().ToList();
                                if (portLotNumbers.Count <= prewired.PortLotNumber)
                                {
                                    var sucPreMats = GetOptimalList(byTermDiameterList, pickNum, curBayFloorList, weightLimit);
                                    autoList.Add(sucPreMats);
                                }
                                else
                                {
                                    var num = Convert.ToInt32(prewired.PortLotNumber);
                                    var portLotCombinationList = GetCombinationList(num, portLotNumbers);
                                    var sucPreMats = GetHavePortOptimalList(portLotCombinationList, byTermDiameterList, pickNum, curBayFloorList, weightLimit);
                                    if (sucPreMats != null)
                                    {
                                        autoList.Add(sucPreMats);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (byTermLineDiameterList.Count > 0)
                            {
                                var sucPreMats = GetOptimalList(byTermDiameterList, pickNum - byTermLineDiameterList.Count, curBayFloorList);
                                sucPreMats.AddRange(byTermLineDiameterList);
                                autoList.Add(sucPreMats);
                            }
                            else
                            {
                                var sucPreMats = GetOptimalList(byTermDiameterList, pickNum, curBayFloorList, weightLimit);
                                autoList.Add(sucPreMats);
                            }
                        }
                    }
                }

                if (autoList.Count <= 0)
                {
                    continue;
                }
                //�ж϶������ֱ�ӷ���
                var accordWeightList = autoList.Where(t => t.Sum(i => i.Weight / 1000d) > 100 && t.Sum(i => i.Weight / 1000d) <= weightLimit).ToList();
                if (accordWeightList.Count <= 0)
                {
                    autoList.Clear();
                    continue;
                }

                int maxFloor = accordWeightList.Max(t => t.Count(t => t.FloorNo == 2));
                resultList = accordWeightList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
                int maxLine = accordWeightList.Max(t => t.Count(t => t.OwnerBussinessName == "P4"));
                if (maxLine > 0)
                {
                    resultList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    //var resultLineList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    //var floorNum = resultLineList.Count(t => t.FloorNo == 2);
                    //var lineNum = resultList.Count(t => t.OwnerBussinessName == "P4");
                }

                return resultList;
            }

            return null;
        }

        #endregion

        #region ��óԤ���߼�-ֱװ

        private (bool, string, List<VPlMaterial>) GetOutMeasuredPrePickMatsDirect(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, List<List<string>> bayCodes, int? weightLimit, int? numLimit)
        {
            var autoList = new List<List<VPlMaterial>>();
            var resultList = new List<VPlMaterial>();
            try
            {
                for (int i = 1; i <= bayCodes.Select(t => t.Count).Max(); i++)
                {
                    var seleBayCodes = bayCodes.Where(t => t.Count == i).ToList();
                    var lessThan1500List = GetDiffDiameterPrePickList(satisfyPreMats, prewired, seleBayCodes, weightLimit, numLimit);
                    if (lessThan1500List != null)
                    {
                        autoList.Add(lessThan1500List);
                    }
                    var greaterThan1500List = GetDiffDiameterPrePickList(satisfyPreMats, prewired, seleBayCodes, weightLimit, numLimit, true);
                    if (greaterThan1500List != null)
                    {
                        autoList.Add(greaterThan1500List);
                    }
                }
                if (autoList.Count > 0)
                {
                    int maxFloor = autoList.Max(t => t.Count(t => t.FloorNo == 2));
                    resultList = autoList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
                    int maxLine = autoList.Max(t => t.Count(t => t.OwnerBussinessName == "P4"));
                    if (maxLine > 0)
                    {
                        resultList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    }
                    return (true, "", resultList);
                }
                return (false, "�Զ�����ʧ�ܣ����ֶ�Ԥ��", resultList);
            }
            catch (Exception ex)
            {
                return (false, $"�Զ������쳣������ϵ�п�,�쳣:{ex.Message}", resultList);
            }
        }

        private List<VPlMaterial> GetDiffDiameterPrePickList(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, List<List<string>> bayCodes, int? weightLimit, int? numLimit, bool isGreaterThan1500 = false)
        {
            var resultList = new List<VPlMaterial>();
            var autoList = new List<List<VPlMaterial>>();
            //�������ͷ���ó����ó��ˮ������
            //��ó����ͷ��������ϲ���ȡ���ñ�������������(����)
            //��ó��û����ͷ�������ǹ��ֻ������������(����)4
            //ˮ�����ˣ�����ͷ�ϲ��������ǹ��û�иۿ����� ������ͷ��֧�ֵ�ᰱ�

            var pickArr = new int[2];
            if (isGreaterThan1500)
            {
                //pickArr = new int[4] { 7, 6, 5, 4 };
                pickArr = new int[2] { 7, 6 };
            }
            else
            {
                //pickArr = new int[4] { 12, 11, 10, 9 };
                pickArr = new int[3] { 12, 11, 10, };
                int conNumLimit = Convert.ToInt32(numLimit);
                if (numLimit >= 7)
                {
                    //pickArr = new int[4] { conNumLimit, conNumLimit - 1, conNumLimit - 2, conNumLimit - 3 };
                    pickArr = new int[3] { conNumLimit, conNumLimit - 1, conNumLimit - 2 };
                }
            }

            //var bayCodeList = new List<string>();
            //if (bayCodes != null && bayCodes.Length > 0)
            //{
            //    bayCodeList = bayCodes.ToList();
            //}
            //else
            //{
            //    bayCodeList = satisfyPreMats.Select(t => t.BayCode).Distinct().ToList();// bayList
            //}

            var bayCodeList = bayCodes;
            var conBayCodes = new List<string>();
            bayCodeList.ForEach(t =>
            {
                conBayCodes.AddRange(t);
            });
            conBayCodes = conBayCodes.Distinct().ToList();
            var allTwoFloorList = DataContext.Set<TTrLocationMaterial>().Where(t => t.IsEnable == 1 && conBayCodes.Contains(t.BayCode) && t.Type == 2 && t.FloorNo == 2).ToList();

            foreach (var pickNum in pickArr)
            {
                foreach (var bayCode in bayCodes)
                {
                    var curBayFloorList = allTwoFloorList.Where(t => bayCode.Contains(t.BayCode)).ToList();

                    var byAllDiameterList = satisfyPreMats.Where(t => t.Diameter <= 1500 && bayCode.Contains(t.BayCode)).ToList();
                    if (isGreaterThan1500)
                    {
                        byAllDiameterList = satisfyPreMats.Where(t => t.Diameter > 1500 && bayCode.Contains(t.BayCode)).ToList();
                    }

                    if (byAllDiameterList.Count < pickNum)
                    {
                        continue;
                    }

                    var byDiameterList = byAllDiameterList.Where(t => t.OwnerBussinessName != "P4").ToList();
                    var byLineDiameterList = byAllDiameterList.Where(t => t.OwnerBussinessName == "P4").ToList();

                    if (prewired.PortLotNumber > 0)
                    {
                        if (byLineDiameterList.Count > 0)
                        {
                            var portLotNumbers = byAllDiameterList.Select(t => t.PortLotNumber).Distinct().ToList();
                            if (portLotNumbers.Count <= prewired.PortLotNumber)
                            {
                                var sucPreMats = GetOptimalList(byDiameterList, pickNum - byLineDiameterList.Count, curBayFloorList);
                                sucPreMats.AddRange(byLineDiameterList);
                                autoList.Add(sucPreMats);
                            }
                            else
                            {
                                var lineAutoList = new List<List<VPlMaterial>>();
                                var linePortNums = byLineDiameterList.Select(t => t.PortLotNumber).Distinct().ToList();
                                var linePortCount = linePortNums.Count;
                                var combNum = prewired.PortLotNumber;
                                if (linePortCount < prewired.PortLotNumber)
                                {
                                    combNum = linePortCount;
                                }
                                var linePortLotComList = GetCombinationList(Convert.ToInt32(combNum), linePortNums);
                                var lineComPortList = new List<List<VPlMaterial>>();
                                linePortLotComList.ForEach(ts =>
                                {
                                    lineComPortList.Add(byLineDiameterList.Where(t => ts.Contains(t.PortLotNumber)).ToList());
                                });
                                lineComPortList.OrderByDescending(t => t.Count);

                                foreach (var preLineMatList in lineComPortList)
                                {
                                    if (preLineMatList.Count >= pickNum)
                                    {
                                        return (preLineMatList.Take(pickNum).ToList());
                                    }
                                    var portLotCombinationList = new List<List<string>>();
                                    var portNums = preLineMatList.Select(t => t.PortLotNumber).Distinct().ToList();
                                    if (prewired.PortLotNumber == combNum)
                                    {
                                        portLotCombinationList.Add(portNums);
                                    }
                                    else
                                    {
                                        var num = Convert.ToInt32(prewired.PortLotNumber - combNum);
                                        portLotCombinationList = GetCombinationList(num, portLotNumbers);
                                        portLotCombinationList.ForEach(t =>
                                        {
                                            t.AddRange(portNums);
                                        });
                                    }
                                    var sucPreMats = GetHavePortOptimalList(portLotCombinationList, byDiameterList, pickNum - preLineMatList.Count, curBayFloorList, weightLimit - preLineMatList.Sum(t => t.Weight / 1000));
                                    if (sucPreMats != null)
                                    {
                                        sucPreMats.AddRange(preLineMatList);
                                        autoList.Add(sucPreMats);
                                        //break;
                                        //return (true, "", sucPreMats);
                                    }
                                }
                            }
                        }
                        else
                        {
                            var portLotNumbers = byDiameterList.Select(t => t.PortLotNumber).Distinct().ToList();
                            if (portLotNumbers.Count <= prewired.PortLotNumber)
                            {
                                var sucPreMats = GetOptimalList(byDiameterList, pickNum, curBayFloorList, weightLimit);
                                autoList.Add(sucPreMats);
                            }
                            else
                            {
                                var num = Convert.ToInt32(prewired.PortLotNumber);
                                var portLotCombinationList = GetCombinationList(num, portLotNumbers);
                                var sucPreMats = GetHavePortOptimalList(portLotCombinationList, byDiameterList, pickNum, curBayFloorList, weightLimit);
                                if (sucPreMats != null)
                                {
                                    autoList.Add(sucPreMats);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (byLineDiameterList.Count > 0)
                        {
                            var sucPreMats = GetOptimalList(byDiameterList, pickNum - byLineDiameterList.Count, curBayFloorList);
                            sucPreMats.AddRange(byLineDiameterList);
                            autoList.Add(sucPreMats);
                        }
                        else
                        {
                            var sucPreMats = GetOptimalList(byDiameterList, pickNum, curBayFloorList, weightLimit);
                            autoList.Add(sucPreMats);
                        }
                    }
                }

                if (autoList.Count <= 0)
                {
                    continue;
                }

                //�ж϶������ֱ�ӷ���
                var accordWeightList = autoList.Where(t => t.Sum(i => i.Weight / 1000d) > 100 && t.Sum(i => i.Weight / 1000d) <= weightLimit).ToList();
                if (accordWeightList.Count <= 0)
                {
                    autoList.Clear();
                    continue;
                }

                //�ж϶������ֱ�ӷ���
                int maxFloor = accordWeightList.Max(t => t.Count(t => t.FloorNo == 2));
                resultList = accordWeightList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
                int maxLine = accordWeightList.Max(t => t.Count(t => t.OwnerBussinessName == "P4"));
                if (maxLine > 0)
                {
                    resultList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    //var resultLineList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    //var floorNum = resultLineList.Count(t => t.FloorNo == 2);
                    //var lineNum = resultList.Count(t => t.OwnerBussinessName == "P4");
                }
                return resultList;
            }

            return null;
        }

        #endregion

        #region ˮ������Ԥ���߼�-ֱװ

        private (bool, string, List<VPlMaterial>) GetWaterMeasuredPrePickMatsDirect(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, List<List<string>> bayCodes, int? weightLimit, int? numLimit)
        {
            var autoList = new List<List<VPlMaterial>>();
            var resultList = new List<VPlMaterial>();
            try
            {
                for (int i = 1; i <= bayCodes.Select(t => t.Count).Max(); i++)
                {
                    var seleBayCodes = bayCodes.Where(t => t.Count == i).ToList();
                    var lessThan1500List = GetWaterDiffDiameterPrePickList(satisfyPreMats, prewired, seleBayCodes, weightLimit, numLimit);
                    if (lessThan1500List != null)
                    {
                        autoList.Add(lessThan1500List);
                    }
                    var greaterThan1500List = GetWaterDiffDiameterPrePickList(satisfyPreMats, prewired, seleBayCodes, weightLimit, numLimit, true);
                    if (greaterThan1500List != null)
                    {
                        autoList.Add(greaterThan1500List);
                    }
                }
                if (autoList.Count > 0)
                {
                    int maxFloor = autoList.Max(t => t.Count(t => t.FloorNo == 2));
                    resultList = autoList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
                    int maxLine = autoList.Max(t => t.Count(t => t.OwnerBussinessName == "P4"));
                    if (maxLine > 0)
                    {
                        resultList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    }
                    return (true, "", resultList);
                }
                return (false, "�Զ�����ʧ�ܣ����ֶ�Ԥ��", resultList);
            }
            catch (Exception ex)
            {
                return (false, $"�Զ������쳣������ϵ�п�,�쳣:{ex.Message}", resultList);
            }
        }


        private List<VPlMaterial> GetWaterDiffDiameterPrePickList(List<VPlMaterial> satisfyPreMats, TRlTransferPrewired prewired, List<List<string>> bayCodes, int? weightLimit, int? numLimit, bool isGreaterThan1500 = false)
        {
            var resultList = new List<VPlMaterial>();
            var autoList = new List<List<VPlMaterial>>();
            //�������ͷ���ó����ó��ˮ������
            //��ó����ͷ��������ϲ���ȡ���ñ�������������(����)
            //��ó��û����ͷ�������ǹ��ֻ������������(����)4
            //ˮ�����ˣ�����ͷ�ϲ��������ǹ��û�иۿ����� ������ͷ��֧�ֵ�ᰱ�

            var pickArr = new int[2];
            if (isGreaterThan1500)
            {
                //pickArr = new int[4] { 7, 6, 5, 4 };
                pickArr = new int[2] { 7, 6 };
            }
            else
            {
                //pickArr = new int[4] { 12, 11, 10, 9 };
                pickArr = new int[3] { 12, 11, 10, };
                int conNumLimit = Convert.ToInt32(numLimit);
                if (numLimit >= 7)
                {
                    //pickArr = new int[4] { conNumLimit, conNumLimit - 1, conNumLimit - 2, conNumLimit - 3 };
                    pickArr = new int[3] { conNumLimit, conNumLimit - 1, conNumLimit - 2 };
                }
            }

            //var bayCodeList = new List<string>();
            //if (bayCodes != null && bayCodes.Length > 0)
            //{
            //    bayCodeList = bayCodes.ToList();
            //}
            //else
            //{
            //    bayCodeList = satisfyPreMats.Select(t => t.BayCode).Distinct().ToList();// bayList
            //}

            var bayCodeList = bayCodes;
            var conBayCodes = new List<string>();
            bayCodeList.ForEach(t =>
            {
                conBayCodes.AddRange(t);
            });
            conBayCodes = conBayCodes.Distinct().ToList();

            var allTwoFloorList = DataContext.Set<TTrLocationMaterial>().Where(t => t.IsEnable == 1 && conBayCodes.Contains(t.BayCode) && t.Type == 2 && t.FloorNo == 2).ToList();

            foreach (var pickNum in pickArr)
            {
                foreach (var bayCode in bayCodes)
                {
                    var curBayFloorList = allTwoFloorList.Where(t => bayCode.Contains(t.BayCode)).ToList();

                    var byAllDiameterList = satisfyPreMats.Where(t => t.Diameter <= 1500 && bayCode.Contains(t.BayCode)).ToList();
                    if (isGreaterThan1500)
                    {
                        byAllDiameterList = satisfyPreMats.Where(t => t.Diameter > 1500 && bayCode.Contains(t.BayCode)).ToList();
                    }

                    if (byAllDiameterList.Count < pickNum)
                    {
                        continue;
                    }
                    var terminalList = byAllDiameterList.Select(t => t.BelongTerminal).Distinct().ToList();// �յ���ͷList

                    var byDiameterList = byAllDiameterList.Where(t => t.OwnerBussinessName != "P4").ToList();
                    var byLineDiameterList = byAllDiameterList.Where(t => t.OwnerBussinessName == "P4").ToList();
                    foreach (var terminal in terminalList)
                    {
                        var byTermLineDiameterList = byLineDiameterList.Where(t => t.BelongTerminal == terminal).ToList();
                        var byTermDiameterList = byDiameterList.Where(t => t.BelongTerminal == terminal).ToList();
                        if ((byTermLineDiameterList.Count + byTermDiameterList.Count) < pickNum)
                        {
                            continue;
                        }
                        if (byTermLineDiameterList.Count > 0)
                        {
                            var sucPreMats = GetOptimalList(byTermDiameterList, pickNum - byTermLineDiameterList.Count, curBayFloorList);
                            sucPreMats.AddRange(byTermLineDiameterList);
                            autoList.Add(sucPreMats);
                        }
                        else
                        {
                            var sucPreMats = GetOptimalList(byTermDiameterList, pickNum, curBayFloorList, weightLimit);
                            autoList.Add(sucPreMats);
                        }
                    }
                }

                if (autoList.Count <= 0)
                {
                    continue;
                }
                //�ж϶������ֱ�ӷ���
                var accordWeightList = autoList.Where(t => t.Sum(i => i.Weight / 1000d) > 100 && t.Sum(i => i.Weight / 1000d) <= weightLimit).ToList();
                if (accordWeightList.Count <= 0)
                {
                    autoList.Clear();
                    continue;
                }
                //�ж϶������ֱ�ӷ���
                int maxFloor = accordWeightList.Max(t => t.Count(t => t.FloorNo == 2));
                resultList = accordWeightList.FirstOrDefault(t => t.Count(t => t.FloorNo == 2) == maxFloor);
                int maxLine = accordWeightList.Max(t => t.Count(t => t.OwnerBussinessName == "P4"));
                if (maxLine > 0)
                {
                    resultList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    //var resultLineList = autoList.FirstOrDefault(t => t.Count(t => t.OwnerBussinessName == "P4") == maxLine);
                    //var floorNum = resultLineList.Count(t => t.FloorNo == 2);
                    //var lineNum = resultList.Count(t => t.OwnerBussinessName == "P4");
                }
                return resultList;
            }

            return null;
        }

        #endregion









        #region �ƿ⻻������

        /// <summary>
        /// �����߷�æ����ᰱ�ֱȡװ���滻������ĸ־�
        /// </summary>
        /// <param name="truckNo"></param>
        /// <param name="replaceMatList"></param>
        /// <returns></returns>
        private List<VPlMaterial> PrePickReplace(string truckNo, List<string> replaceMatList)
        {
            //�������ͷ���ó����ó��ˮ������
            //��ó����ͷ��������ϲ���ȡ���ñ�������������(����)
            //��ó��û����ͷ�������ǹ��ֻ������������(����)
            //ˮ�����ˣ�����ͷ���ϲ��������ǹ��û�иۿ�����

            //��ȡ����װ���־���Ϣ
            var repo = DataContext.Set<TPlTruckTransfer>();
            var repoLocMat = DataContext.Set<TTrLocationMaterial>();
            var repoVMat = DataContext.Set<VPlMaterial>();
            var tranTruck = repo.Where(t => t.TruckNo == truckNo && t.IsEnable == 1).OrderByDescending(t => t.CreateTime).FirstOrDefault();
            string errorMsg = string.Empty;
            if (tranTruck == null)
            {
                errorMsg = "�ƿ�װ����Ϣ������";
            }
            var prePickList = repoVMat.Where(t => t.PrepickTransferNo == tranTruck.TransferNo).ToList();
            if (prePickList.Count <= 0)
            {
                errorMsg = "�ƿ�װ���־���Ϣ������";
            }
            var matStatusList = new[] { "33", "34", "36", "39" };
            var complexDecideCodes = new[] { "1", "M", "A" };
            //�ж��滻���Ƿ����װ��Ҫ��
            var replaceMats = repoVMat.Where(t => replaceMatList.Contains(t.No) && t.Type == 2 &&
                          matStatusList.Contains(t.MatStatus) &&
                          (t.MatDirection == "U127" || t.TrnpModeCode == "A") &&
                          (t.PickState == (int)PickStateOfCoil.None || t.PickState == null || t.PrepickTransferNo == tranTruck.TransferNo) &&
                          complexDecideCodes.Contains(t.ComplexDecideCode)
                          && t.LockMark != 1
                          && t.ProductPackFlag == "1").ToList();
            if (replaceMats.Count <= 0)
            {
                errorMsg = "�滻�ĸ־���Ϣ������װ��Ҫ��";
            }

            var scSpecList = DataContext.Set<TScTransferSpec>().Where(t => t.SpecWidth > 0 && t.BelongSpecWidth > 0).ToList();
            var scTerminalList = DataContext.Set<TScTransferTerminal>().Where(t => !string.IsNullOrEmpty(t.BelongCityName) && !string.IsNullOrEmpty(t.Code)).ToList();
            if (scSpecList.Count > 0 || scTerminalList.Count > 0)
            {
                //Ϊ�滻�ľ�ϲ���ͷ����
                foreach (var inside in replaceMats)
                {
                    var scSpec = scSpecList.FirstOrDefault(t => t.SpecWidth == inside.DecideWidth);
                    if (scSpec != null)
                    {
                        inside.BelongDecideWidth = scSpec.BelongSpecWidth;
                    }
                    var scTerminal = scTerminalList.FirstOrDefault(t => t.Code == inside.Terminal);
                    if (scTerminal != null)
                    {
                        inside.BelongTerminal = scTerminal.BelongCityName;
                    }
                }
                //Ϊ������ľ�ϲ���ͷ����
                foreach (var prePick in prePickList)
                {
                    var scSpec = scSpecList.FirstOrDefault(t => t.SpecWidth == prePick.DecideWidth);
                    if (scSpec != null)
                    {
                        prePick.BelongDecideWidth = scSpec.BelongSpecWidth;
                    }
                    var scTerminal = scTerminalList.FirstOrDefault(t => t.Code == prePick.Terminal);
                    if (scTerminal != null)
                    {
                        prePick.BelongTerminal = scTerminal.BelongCityName;
                    }
                }
            }

            var curPrewired = DataContext.Set<TRlTransferPrewired>().FirstOrDefault(t => t.StowageType == tranTruck.PrepickType);
            var portLotNumbers = new List<string>();
            if (curPrewired.PortLotNumber > 0)  //�Ƿ��޸ۿ�����  
            {
                portLotNumbers = prePickList.Select(t => t.PortLotNumber).Distinct().ToList();
            }

            //�Ƿ������䴬 0=������ 1=�䴬 2=���䴬
            int isDistributionShip = Convert.ToInt32(curPrewired.IsDistributionShip);
            if (isDistributionShip == 1)
            {
                prePickList = prePickList.Where(t => t.IsDistributionShip == 1).ToList();
            }
            if (isDistributionShip == 2)
            {
                prePickList = prePickList.Where(t => t.IsDistributionShip == 0 || t.IsDistributionShip == null).ToList();
            }

            if (curPrewired.StowageType == 1) //��ó �ϲ���ͷ�������Ƹۿ����� 
            {
                //��֤�滻��������
                prePickList = prePickList.Where(t => t.OrderNo.StartsWith("D") && t.TrnpModeCode == "T").ToList();

                if (prePickList.Count <= 0)
                {
                    errorMsg = "�滻�ĸ־���Ϣ������װ��Ҫ����ó����Ϊ��";
                }

                var prePickWidths = prePickList.FirstOrDefault().BelongDecideWidth;
                var replaceWidthMats = replaceMats.Where(t => t.BelongDecideWidth == t.BelongDecideWidth).ToList();
                if (replaceWidthMats == null || replaceWidthMats.Count <= 0)
                {
                    errorMsg = "�滻�ĸ־���Ϣ�������װ��Ҫ��";
                }
                //��֤�滻���յ���ͷ����
                var prePickTerminal = prePickList.FirstOrDefault().BelongTerminal;
                var replaceTerminals = replaceWidthMats.Where(t => t.BelongTerminal == prePickTerminal).ToList();
                if (replaceTerminals == null || replaceTerminals.Count <= 0)
                {
                    errorMsg = "�滻�ĸ־���Ϣ��ͷ������װ��Ҫ��";
                }
                //��֤�滻��ۿ�������������
                var groupPortLotList = new List<List<VPlMaterial>>();
                var prePickPortLotNumbers = prePickList.Select(t => t.PortLotNumber).Distinct().ToList();
                prePickPortLotNumbers.ForEach(t =>
                {
                    groupPortLotList.Add(prePickList.Where(i => i.PortLotNumber == t).ToList());
                });
                var prePickNewList = new List<VPlMaterial>();  //��Ԥ�����
                foreach (var groupMats in groupPortLotList)
                {
                    replaceTerminals = replaceTerminals.Except(prePickNewList).ToList();

                    var truckLoadList = groupMats.Where(t => t.AreaCode.Contains("P")).ToList(); //�������Ѿ�װ������Ϣ
                    if (truckLoadList.Count == groupMats.Count) //˵����ȫ��װ��
                    {
                        prePickNewList = prePickNewList.Concat(truckLoadList).ToList();
                        continue;
                    }
                    var noTruckLoadList = groupMats.Except(truckLoadList);//δװ��
                    var replaceCount = noTruckLoadList.Count();  //��Ҫ�滻������
                    if (replaceCount == groupMats.Count)  //˵��ȫ��δװ��
                    {
                        var replacePortList = replaceTerminals.Select(t => t.PortLotNumber).Distinct();
                        var replaceNewList = new List<VPlMaterial>();
                        foreach (var replacePort in replacePortList)
                        {
                            var replacePortMats = replaceTerminals.Where(t => t.PortLotNumber == replacePort).OrderByDescending(t => t.FloorNo).ToList();
                            if (replacePortMats.Count >= replaceCount)
                            {
                                replaceNewList = replacePortMats.Take(replaceCount).ToList();
                                break;
                            }
                        }
                        if (replaceNewList.Count > 0)  //���������滻
                        {
                            prePickNewList = prePickNewList.Concat(replaceNewList).ToList();
                        }
                        else //��ǰ�����滻
                        {
                            var replacePortLot = noTruckLoadList.FirstOrDefault().PortLotNumber;
                            var needReplaceMats = replaceTerminals.Where(t => t.PortLotNumber == replacePortLot).OrderByDescending(t => t.FloorNo).ToList();
                            if (needReplaceMats.Count > 0)
                            {
                                prePickNewList = prePickNewList.Concat(needReplaceMats.Concat(noTruckLoadList).Take(replaceCount)).ToList();
                            }
                            else
                            {
                                prePickNewList = prePickNewList.Concat(noTruckLoadList).ToList();
                            }
                        }
                    }
                    else  //����δװ�� 
                    {
                        var replacePortLot = noTruckLoadList.FirstOrDefault().PortLotNumber;
                        var needReplaceMats = replaceTerminals.Where(t => t.PortLotNumber == replacePortLot).OrderByDescending(t => t.FloorNo).ToList();
                        if (needReplaceMats.Count > 0)
                        {
                            prePickNewList = prePickNewList.Concat(needReplaceMats.Concat(noTruckLoadList).Take(replaceCount)).ToList();
                        }
                        else
                        {
                            prePickNewList = prePickNewList.Concat(noTruckLoadList).ToList();
                        }
                    }
                }
            }
            else if (curPrewired.StowageType == 2) //��ó û����ͷ�����޹�����Ƹۿ�����)
            {
                prePickList = prePickList.Where(t => t.OrderNo.StartsWith("E") && t.TrnpModeCode == "T").ToList();

                if (prePickList.Count <= 0)
                {
                    errorMsg = "�滻�ĸ־���Ϣ������װ��Ҫ����ó����Ϊ��";
                }
            }
            else //ˮ������ ����ͷ���ϲ������޹��û�иۿ�����
            {
                prePickList = prePickList.Where(t => t.TrnpModeCode == "A").ToList();

                if (prePickList.Count <= 0)
                {
                    errorMsg = "�滻�ĸ־���Ϣ������װ��Ҫ����ó����Ϊ��";
                }
            }

            return null;
        }

        #endregion
    }
}
