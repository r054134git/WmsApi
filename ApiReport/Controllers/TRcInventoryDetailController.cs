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
        /// 添加扫描信息
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
                                Message = $"已扫描过此卷号 {rcMaterial.SystemComment}"
                            };
                            if (trlm == null)
                            {
                                return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, item));
                            }
                            return Ok(new AddScanDetailResult(trlm, item));
                        }
                        if (trmodel != null && trmodel.BayId == bayId && trlm != null) //添加扫描在库
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
                                Message = "扫描成功"
                            };

                            return Ok(new AddScanDetailResult(trlm, item));
                        }
                        else if (trlm != null && trlm.BayId != bayId)
                        {
                            //添加扫描不在跨 
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 1,
                                WmsLocationName = trlm.LocationName,
                                SystemComment = "不在此库",
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
                                Message = "扫描成功，系统不在此跨"
                            };

                            return Ok(new AddScanDetailResult(trlm, item));
                        }
                        else if (plMaterial != null && trlm == null)
                        {
                            //添加扫描在库无跟踪
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "已扫描无库位",
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
                                Message = "扫描成功,库位待补充"
                            };

                            return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, item));
                        }
                        else if (trmodel == null && plMaterial != null && trlm != null)//临时表不存在且当前不在库
                        {
                            if (plMaterial.MaterialBussinessOwner == null || plMaterial.MaterialBussinessOwner == "" || plMaterial.MaterialBussinessOwner.Contains("L"))//物料没有入过库
                            {
                                //未入过库
                                var detail = new TRcInventoryDetail
                                {
                                    Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                    PlanId = inventoryPlan.Id,
                                    MaterialNo = materialNo,
                                    IsScan = 1,
                                    IsWms = 0,
                                    WmsLocationName = trlm.LocationName,
                                    SystemComment = "新入库",
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
                                    Message = "扫描成功"
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
                                    SystemComment = "新入库（所属P4库位）",
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
                                    Message = "扫描成功,当前库位所属P4库位"
                                };
                                return Ok(new AddScanDetailResult(trlm, item));
                            }
                            else //入过库为倒垛
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
                                    Message = "扫描成功"
                                };
                                return Ok(new AddScanDetailResult(trlm, item));
                            }
                        }
                        else if (plMaterial == null)
                        {
                            //添加扫描不在库
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "系统卷号不存在",
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
                                Message = "扫描成功，系统不存在"
                            };

                            return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, item));
                        }
                    }
                }
                var items = new ItemResult<TRcInventoryReadModel>
                {
                    Success = false,
                    Message = "批次号异常"
                };
                return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, items));
            }
            var log = new TRcLog
            {
                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                Dt = DateTime.Now,
                EventNo = "1000",
                WarningLevel = "INFO",
                Message = $"手持机扫描{materialNo}异常，盘库批次{planNo}库id{bayId}",
                Source = "API"
            };
            logs.Add(log);
            await DataContext.SaveChangesAsync(cancellationToken);
            var result = new ItemResult<TRcInventoryReadModel>
            {
                Success = false,
                Message = $"扫描失败"
            };
            return Ok(new AddScanDetailResult(new TTrLocationMaterialReadModel() { MaterialNo = materialNo }, result)); ;
        }


        /// <summary>
        /// 添加扫描信息
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
                                Message = "扫描成功"
                            };
                            return item;
                        }
                        if (rcmodel != null && rcmodel.BayId == bayId) //添加扫描在库
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
                                Message = "扫描成功"
                            };

                            return item;
                        }
                        else if (trlm != null && trlm.BayId != bayId)
                        {
                            //添加扫描不在跨
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = rcmodel.LocationName,
                                SystemComment = "不在当前跨",
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
                                Message = "扫描成功，系统不在此跨"
                            };

                            return item;
                        }
                        else if (rcmodel == null && plMaterial != null && trlm == null)
                        {
                            //扫描不在库无跟踪  //虚拟卷
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "已扫描无库位",
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
                                Message = "扫描成功,库位需补充"
                            };

                            return item;
                        }
                        else if (rcmodel == null && plMaterial != null && trlm != null)
                        {
                            //扫描不在库
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "新入库",
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
                                Message = "扫描成功"
                            };

                            return item;
                        }
                        else if (rcmodel == null && plMaterial == null)
                        {
                            //添加扫描不在库
                            var detail = new TRcInventoryDetail
                            {
                                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                                PlanId = inventoryPlan.Id,
                                MaterialNo = materialNo,
                                IsScan = 1,
                                IsWms = 0,
                                WmsLocationName = null,
                                SystemComment = "系统卷号不存在",
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
                                Message = "扫描成功，系统不存在"
                            };

                            return item;
                        }
                    }
                }
                var items = new ItemResult<TRcInventoryReadModel>
                {
                    Success = false,
                    Message = "批次号异常"
                };
                return items;
            }
            var log = new TRcLog
            {
                Id = DateTime.Now.ToFileTime().ToString() /*repo.GetPrimaryId()*/,
                Dt = DateTime.Now,
                EventNo = "1000",
                WarningLevel = "INFO",
                Message = $"手持机扫描{materialNo}异常，盘库批次{planNo}库id{bayId}",
                Source = "API"
            };
            logs.Add(log);
            await DataContext.SaveChangesAsync(cancellationToken);
            var result = new ItemResult<TRcInventoryReadModel>
            {
                Success = false,
                Message = $"扫描失败，卷号异常"
            };
            return result;
        }


        /// <summary>
        /// 完成盘库
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
                    //去重处理
                    List<TRcInventoryDetail> detailList = planDetailList.GroupBy(x => x.MaterialNo).Select(x => x.First()).ToList();

                    var rcList = rctemp.Where(t => t.PlanNo == planNo).ToList(); //系统在库
                    //扫描个数
                    List<string> scanCoilList = detailList.Where(t => t.IsScan == 1).Select(t => t.MaterialNo).ToList();

                    List<string> rcTempList = rcList.Select(t => t.MaterialNo).ToList();//系统在库卷号
                    var a = rcTempList.Intersect(scanCoilList).ToList();
                    var scanBay = detailList.Where(t => t.IsScan == 1 && t.IsWms == 1).Count();//扫描在库
                    var b = scanCoilList.Except(rcTempList).ToList();
                    int scanNotBay = detailList.Where(t => t.IsScan == 1 && t.IsWms == 0).Count();//扫描不在库个数
                    var bayNotScanData = rcTempList.Except(scanCoilList).ToList();  //在库未扫描
                    //结算在库未扫描与已发货
                    foreach (var item in bayNotScanData)
                    {
                        var temp = rcList.Where(t => t.MaterialNo == item).FirstOrDefault();
                        var trIsWms = tr.Where(t => t.Type == 2 && t.MaterialNo == item && t.AreaCode != "88A" && t.AreaCode != "88B" && t.AreaCode != "88C").FirstOrDefault();
                        if (trIsWms != null)
                        {
                            //内倒中
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
                                    SystemComment = "倒库出库",
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
                                    SystemComment = "已发货",
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
                                    SystemComment = $"在库未扫描{trIsWms.LocationName}",
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
                                    SystemComment = "已退库",
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
                                    SystemComment = "已发货",
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

                    //结算批次统计
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

                    //清除该批次临时表数据
                    foreach (var item in rcList)
                    {
                        rctemp.Remove(item);
                    }

                    await DataContext.SaveChangesAsync();
                    var IsWmsNotScan = rcDetail.Where(t => t.PlanId == plan.Id && t.SystemComment.Contains("在库未扫描")).ProjectTo<TRcInventoryDetailReadModel>(Mapper.ConfigurationProvider).ToList();
                    return IsWmsNotScan;
                }
            }
            return NotFound();
        }

        /// <summary>
        /// 生成盘库报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> DownReportExcel(string bayCode, string planNo)
        {
            MemoryStream memoryStream = await CreateReportExcelStream(planNo);
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = "盘库统计.xlsx"
            };
        }

        /// <summary>
        /// 生成盘库Pdf报表
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
        ///// 生成报表Pdf字符串
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
        /// 创建报表Excel文件
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
