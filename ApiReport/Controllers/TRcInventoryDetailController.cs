using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Ucp.Contracts;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;


namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcInventoryDetailController : EntityControllerBase<TRcInventoryDetail, TRcInventoryDetailReadModel, TRcInventoryDetailCreateModel, TRcInventoryDetailUpdateModel>
    {
        public TRcInventoryDetailController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcInventoryDetailCreateModel> createValidator, IValidator<TRcInventoryDetailUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// ���ɨ����Ϣ
        /// </summary>
        /// <returns></returns>
        [TokenActionFilter]
        [HttpPost("")]
        public async Task<ActionResult<AddScanDetailResult>>
            AddScanDetailEx(string bayId, string planNo, string materialNo, CancellationToken cancellationToken)
        {
            var l = User.GetUserName();
            var rc = DataContext.Set<TRcInventory>();
            var rcDetail = DataContext.Set<TRcInventoryDetail>();
            var tr = DataContext.Set<TTrLocationMaterial>();
            var rcTemp = DataContext.Set<TRcInventoryTemp>();
            var plmaterial = DataContext.Set<TPlMaterial>();
            var logs = DataContext.Set<TRcLog>();
            if (materialNo.IsValidValue())
            {
                if (planNo.IsValidValue())
                {
                    var trmodel = await rcTemp.Where(t => t.PlanNo == planNo && t.MaterialNo == materialNo).FirstOrDefaultAsync();
                    var inventoryPlan = await rc.Where(t => t.PlanNo == planNo && t.IsFinished == 0).FirstOrDefaultAsync();
                    var trlm = tr.Where(t => t.Type == 2 && t.MaterialNo == materialNo).ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).FirstOrDefault();
                    var plMaterial = await plmaterial.Where(t => t.No == materialNo).FirstOrDefaultAsync();
                    if (inventoryPlan != null)
                    {
                        var rcMaterial = await rcDetail.Where(t => t.PlanId == inventoryPlan.Id && t.MaterialNo == materialNo).FirstOrDefaultAsync();
                        if (rcMaterial != null)
                        {
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = false,
                                Message = $"��ɨ����˾�� {rcMaterial.SystemComment}"
                            };
                            if (trlm == null)
                            {
                                return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, item));
                            }
                            return Ok(new AddScanDetailResult(trlm, item));
                        }
                        if (trmodel != null && trmodel.BayId == bayId && trlm != null) //���ɨ���ڿ�
                        {
                            if (trlm.LockReason != null)
                            {
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = inventoryPlan.Id,
                                    MaterialNo = materialNo,
                                    IsScan = 1,
                                    IsWms = 1,
                                    WmsLocationName = trmodel.LocationName,
                                    SystemComment = trlm.LockReason,
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(detail);
                            }
                            else
                            {
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = inventoryPlan.Id,
                                    MaterialNo = materialNo,
                                    IsScan = 1,
                                    IsWms = 1,
                                    WmsLocationName = trmodel.LocationName,
                                    //SystemComment = ,
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(detail);
                            }
                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ�"
                            };

                            return Ok(new AddScanDetailResult(trlm, item));
                        }
                        else if (trlm != null && trlm.BayId != bayId)
                        {
                            //���ɨ�費�ڿ� 
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 1,
                                WmsLocationName = trlm.LocationName,
                                SystemComment = "���ڴ˿�",
                                IsEnable = 1,

                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API"
                            };
                            rcDetail.Add(detail);
                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ���ϵͳ���ڴ˿�"
                            };

                            return Ok(new AddScanDetailResult(trlm, item));
                        }
                        else if (plMaterial != null && trlm == null)
                        {
                            //���ɨ���ڿ��޸���
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "��ɨ���޿�λ",
                                IsEnable = 1,
                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API"
                            };

                            rcDetail.Add(detail);

                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ�,��λ������"
                            };

                            return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, item));
                        }
                        else if (trmodel == null && plMaterial != null && trlm != null)//��ʱ�������ҵ�ǰ���ڿ�
                        {
                            if (plMaterial.MaterialBussinessOwner == null || plMaterial.MaterialBussinessOwner == "" || plMaterial.MaterialBussinessOwner.Contains("L"))//����û�������
                            {
                                //δ�����
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = inventoryPlan.Id,
                                    MaterialNo = materialNo,
                                    IsScan = 1,
                                    IsWms = 0,
                                    WmsLocationName = trlm.LocationName,
                                    SystemComment = "�����",
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(detail);
                                await DataContext.SaveChangesAsync(cancellationToken);

                                var item = new ItemResult<TRcInventoryReadModel>
                                {
                                    Success = true,
                                    Message = "ɨ��ɹ�"
                                };
                                return Ok(new AddScanDetailResult(trlm, item));
                            }
                            else if (plMaterial.MaterialBussinessOwner == "P4")
                            {
                                //P4
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = inventoryPlan.Id,
                                    MaterialNo = materialNo,
                                    IsScan = 1,
                                    IsWms = 0,
                                    WmsLocationName = trlm.LocationName,
                                    SystemComment = "����⣨����P4��λ��",
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(detail);
                                await DataContext.SaveChangesAsync(cancellationToken);

                                var item = new ItemResult<TRcInventoryReadModel>
                                {
                                    Success = true,
                                    Message = "ɨ��ɹ�,��ǰ��λ����P4��λ"
                                };
                                return Ok(new AddScanDetailResult(trlm, item));
                            }
                            else //�����Ϊ����
                            {
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = inventoryPlan.Id,
                                    MaterialNo = materialNo,
                                    IsScan = 1,
                                    IsWms = 1,
                                    WmsLocationName = trlm.LocationName,
                                    SystemComment = "",
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(detail);
                                await DataContext.SaveChangesAsync(cancellationToken);

                                var item = new ItemResult<TRcInventoryReadModel>
                                {
                                    Success = true,
                                    Message = "ɨ��ɹ�"
                                };
                                return Ok(new AddScanDetailResult(trlm, item));
                            }
                        }
                        else if (plMaterial == null)
                        {
                            //���ɨ�費�ڿ�
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "ϵͳ��Ų�����",
                                IsEnable = 1,
                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API"
                            };
                            rcDetail.Add(detail);

                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ���ϵͳ������"
                            };

                            return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, item));
                        }
                    }
                }
                var items = new ItemResult<TRcInventoryReadModel>
                {
                    Success = false,
                    Message = "���κ��쳣"
                };
                return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, items));
            }
            var log = new TRcLog
            {
                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                Dt = DateTime.Now,
                EventNo = "1000",
                WarningLevel = "INFO",
                Message = $"�ֳֻ�ɨ��{materialNo}�쳣���̿�����{planNo}��id{bayId}",
                Source = "API"
            };
            logs.Add(log);
            await DataContext.SaveChangesAsync(cancellationToken);
            var result = new ItemResult<TRcInventoryReadModel>
            {
                Success = false,
                Message = $"ɨ��ʧ��"
            };
            return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, result)); ;
        }


        /// <summary>
        /// ���ɨ����Ϣ
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<ItemResult<TRcInventoryReadModel>>> AddScanDetail(string bayId, string planNo, string materialNo, CancellationToken cancellationToken)
        {
            var rc = DataContext.Set<TRcInventory>();
            var rcDetail = DataContext.Set<TRcInventoryDetail>();
            var tr = DataContext.Set<TTrLocationMaterial>();
            var rcTemp = DataContext.Set<TRcInventoryTemp>();
            var pl = DataContext.Set<TPlMaterial>();
            var logs = DataContext.Set<TRcLog>();
            if (materialNo.IsValidValue())
            {
                if (planNo.IsValidValue())
                {
                    var rcmodel = await rcTemp.Where(t => t.PlanNo == planNo && t.MaterialNo == materialNo).FirstOrDefaultAsync();
                    var inventoryPlan = await rc.Where(t => t.PlanNo == planNo && t.IsFinished == 0).FirstOrDefaultAsync();
                    var trlm = tr.Where(t => t.MaterialNo == materialNo).FirstOrDefault();
                    var plMaterial = await pl.Where(t => t.No == materialNo).FirstOrDefaultAsync();
                    if (inventoryPlan != null)
                    {
                        var rcMaterial = await rcDetail.Where(t => t.PlanId == inventoryPlan.Id && t.MaterialNo == materialNo).FirstOrDefaultAsync();
                        if (rcMaterial != null)
                        {
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ�"
                            };
                            return item;
                        }
                        if (rcmodel != null && rcmodel.BayId == bayId) //���ɨ���ڿ�
                        {
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 1,
                                WmsLocationName = rcmodel.LocationName,
                                //SystemComment="",
                                IsEnable = 1,
                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API"
                            };
                            rcDetail.Add(detail);
                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ�"
                            };

                            return item;
                        }
                        else if (trlm != null && trlm.BayId != bayId)
                        {
                            //���ɨ�費�ڿ�
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = rcmodel.LocationName,
                                SystemComment = "���ڵ�ǰ��",
                                IsEnable = 1,

                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API"
                            };
                            rcDetail.Add(detail);
                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ���ϵͳ���ڴ˿�"
                            };

                            return item;
                        }
                        else if (rcmodel == null && plMaterial != null && trlm == null)
                        {
                            //ɨ�費�ڿ��޸���  //�����
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "��ɨ���޿�λ",
                                IsEnable = 1,
                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API"
                            };

                            rcDetail.Add(detail);

                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ�,��λ�貹��"
                            };

                            return item;
                        }
                        else if (rcmodel == null && plMaterial != null && trlm != null)
                        {
                            //ɨ�費�ڿ�
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "�����",
                                IsEnable = 1,
                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API"
                            };

                            rcDetail.Add(detail);

                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ�"
                            };

                            return item;
                        }
                        else if (rcmodel == null && plMaterial == null)
                        {
                            //���ɨ�費�ڿ�
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "ϵͳ��Ų�����",
                                IsEnable = 1,
                                CreateTime = DateTime.Now,
                                CreateUser = "API",
                                UpdateTime = DateTime.Now,
                                UpdateUser = "API"
                            };
                            rcDetail.Add(detail);

                            await DataContext.SaveChangesAsync(cancellationToken);
                            var item = new ItemResult<TRcInventoryReadModel>
                            {
                                Success = true,
                                Message = "ɨ��ɹ���ϵͳ������"
                            };

                            return item;
                        }
                    }
                }
                var items = new ItemResult<TRcInventoryReadModel>
                {
                    Success = false,
                    Message = "���κ��쳣"
                };
                return items;
            }
            var log = new TRcLog
            {
                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                Dt = DateTime.Now,
                EventNo = "1000",
                WarningLevel = "INFO",
                Message = $"�ֳֻ�ɨ��{materialNo}�쳣���̿�����{planNo}��id{bayId}",
                Source = "API"
            };
            logs.Add(log);
            await DataContext.SaveChangesAsync(cancellationToken);
            var result = new ItemResult<TRcInventoryReadModel>
            {
                Success = false,
                Message = $"ɨ��ʧ�ܣ�����쳣"
            };
            return result;
        }


        /// <summary>
        /// ����̿�
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<List<TRcInventoryDetailReadModel>>> AddNotScanDetail(string bayId, string planNo, CancellationToken cancellationToken)
        {
            var rc = DataContext.Set<TRcInventory>();
            var rcDetail = DataContext.Set<TRcInventoryDetail>();
            var rctemp = DataContext.Set<TRcInventoryTemp>();
            var tr = DataContext.Set<TTrLocationMaterial>();
            var repoBay = DataContext.Set<TWhBay>();
            var plBack = DataContext.Set<TPlBackReturn>();
            if (planNo.IsValidValue())
            {
                var plan = rc.Where(t => t.PlanNo == planNo && t.IsFinished == 0).FirstOrDefault();
                if (plan != null)
                {
                    var planDetailList = rcDetail.Where(t => t.PlanId == plan.Id).ToList();
                    //ȥ�ش���
                    List<TRcInventoryDetail> detailList = planDetailList.GroupBy(x => x.MaterialNo).Select(x => x.First()).ToList();

                    var rcList = rctemp.Where(t => t.PlanNo == planNo).ToList(); //ϵͳ�ڿ�
                    //ɨ�����
                    List<string> scanCoilList = detailList.Where(t => t.IsScan == 1).Select(t => t.MaterialNo).ToList();

                    List<string> rcTempList = rcList.Select(t => t.MaterialNo).ToList();//ϵͳ�ڿ���
                    var a = rcTempList.Intersect(scanCoilList).ToList();
                    var scanBay = detailList.Where(t => t.IsScan == 1 && t.IsWms == 1).Count();//ɨ���ڿ�
                    var b = scanCoilList.Except(rcTempList).ToList();
                    int scanNotBay = detailList.Where(t => t.IsScan == 1 && t.IsWms == 0).Count();//ɨ�費�ڿ����
                    var bayNotScanData = rcTempList.Except(scanCoilList).ToList();  //�ڿ�δɨ��
                    //�����ڿ�δɨ�����ѷ���
                    foreach (var item in bayNotScanData)
                    {
                        var temp = rcList.Where(t => t.MaterialNo == item).FirstOrDefault();
                        var trIsWms = tr.Where(t => t.Type == 2 && t.MaterialNo == item && t.AreaCode != "88A" && t.AreaCode != "88B" && t.AreaCode != "88C").FirstOrDefault();
                        if (trIsWms != null)
                        {
                            //�ڵ���
                            if (temp != null && trIsWms.AreaCode == "0L")
                            {
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = plan.Id,
                                    MaterialNo = item,
                                    IsScan = 0,
                                    IsWms = 1,
                                    WmsLocationName = trIsWms.LocationName,
                                    SystemComment = "�������",
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(detail);
                            }
                            else if (temp != null && (trIsWms.AreaCode == "P1" || trIsWms.AreaCode == "P2"))
                            {
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = plan.Id,
                                    MaterialNo = item,
                                    IsScan = 0,
                                    IsWms = 1,
                                    WmsLocationName = trIsWms.LocationName,
                                    SystemComment = "�ѷ���",
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(detail);
                            }
                            else// if (temp != null && (trIsWms.AreaCode != "P1" || trIsWms.AreaCode != "P2"))
                            {
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = plan.Id,
                                    MaterialNo = item,
                                    IsScan = 0,
                                    IsWms = 1,
                                    WmsLocationName = trIsWms.LocationName,
                                    SystemComment = $"�ڿ�δɨ��{trIsWms.LocationName}",
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(detail);
                            }
                        }
                        else
                        {
                            var backInfo = plBack.Where(t => t.MaterialNo == item).FirstOrDefault();
                            if (backInfo != null && backInfo.Mode == 1)
                            {
                                var d = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = plan.Id,
                                    MaterialNo = item,
                                    IsScan = 0,
                                    IsWms = 1,
                                    WmsLocationName = "",
                                    SystemComment = "���˿�",
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(d);
                            }
                            else
                            {
                                var d = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = plan.Id,
                                    MaterialNo = item,
                                    IsScan = 0,
                                    IsWms = 1,
                                    WmsLocationName = "",
                                    SystemComment = "�ѷ���",
                                    IsEnable = 1,
                                    CreateTime = DateTime.Now,
                                    CreateUser = "API",
                                    UpdateTime = DateTime.Now,
                                    UpdateUser = "API"
                                };
                                rcDetail.Add(d);
                            }
                        }
                    }

                    //��������ͳ��
                    var pl = rc.Where(t => t.PlanNo == planNo).FirstOrDefault();
                    if (pl != null)
                    {
                        pl.ScanCount = scanCoilList.Count;
                        pl.WmsCount = rcTempList.Count;
                        pl.ScanNotInWmsCount = scanNotBay;
                        pl.ScanInWmsCount = scanBay;
                        pl.WmsNotInScanCount = bayNotScanData.Count;
                        pl.IsFinished = 1;
                        pl.UpdateTime = DateTime.Now;
                        pl.UpdateUser = "API";
                    }

                    //�����������ʱ������
                    foreach (var item in rcList)
                    {
                        rctemp.Remove(item);
                    }

                    await DataContext.SaveChangesAsync();
                    var IsWmsNotScan = rcDetail.Where(t => t.PlanId == plan.Id && t.SystemComment.Contains("�ڿ�δɨ��")).ProjectTo<TRcInventoryDetailReadModel>(Mapper.ConfigurationProvider).ToList();
                    return IsWmsNotScan;
                }
            }
            return NotFound();
        }

        /// <summary>
        /// �����̿ⱨ��
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> DownReportExcel(string bayCode, string planNo)
        {
            MemoryStream memoryStream = await CreateReportExcelStream(planNo);
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = "�̿�ͳ��.xlsx"
            };
        }

        /// <summary>
        /// �����̿�Pdf����
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> CreateReportPdf(string bayCode, string planNo)
        {
            MemoryStream excelStream = await CreateReportExcelStream(planNo);
            var workbook = new Aspose.Cells.Workbook(excelStream);

            var pdfStream = new MemoryStream();
            workbook.Save(pdfStream, Aspose.Cells.SaveFormat.Pdf);

            return new FileStreamResult(pdfStream, "application/pdf")
            {
                FileDownloadName = "Inventory.pdf"
            };

        }

        ///// <summary>
        ///// ���ɱ���Pdf�ַ���
        ///// </summary>
        ///// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<string>> CreateReportPdfString(string bayCode, string planNo)
        {
            MemoryStream excelStream = await CreateReportExcelStream(planNo);
            var workbook = new Aspose.Cells.Workbook(excelStream);

            var pdfStream = new MemoryStream();
            workbook.Save(pdfStream, Aspose.Cells.SaveFormat.Pdf);

            return Convert.ToBase64String(pdfStream.ToArray());
        }

        /// <summary>
        /// ��������Excel�ļ�
        /// </summary>
        /// <returns></returns>
        private async Task<MemoryStream> CreateReportExcelStream(string planNo)
        {
            var rc = DataContext.Set<TRcInventory>();
            var rcDetail = DataContext.Set<TRcInventoryDetail>();
            var trLM = DataContext.Set<TTrLocationMaterial>();
            var model = await rc.Where(t => t.PlanNo == planNo).FirstOrDefaultAsync();
            var trmodel = trLM.Where(t => t.BayCode == model.BayCode).FirstOrDefault();
            var detailList = rcDetail.Where(t => t.PlanId == model.Id).ToList();
            var rModel = new ReportInventory
            {
                Id = DateTime.Now.ToFileTime().ToString(),
                OwnerBussinessName = trmodel.OwnerBussinessName,
                BayCode = trmodel.BayCode,
                PlanNo = planNo,
                ScanCount = model.ScanCount,
                WmsCount = model.WmsCount,
                ScanInWmsCount = model.ScanInWmsCount,
                ScanNotInWmsCount = model.ScanNotInWmsCount,
                WmsNotInScanCount = model.WmsNotInScanCount
            };
            foreach (var d in detailList)
            {
                var i = new ReportInventoryDetail
                {
                    MaterialNo = d.MaterialNo,
                    BundleNo = d.BundleNo,
                    IsScan = d.IsScan,
                    IsWms = d.IsWms,
                    SystemComment = d.SystemComment
                };
                rModel.Details.Add(i);
            }

            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate(@"excel/InventoryReport.xlsx", rModel);

            memoryStream.Seek(0, SeekOrigin.Begin);
            return memoryStream;
        }

    }
}
