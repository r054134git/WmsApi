using AutoMapper;
using Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;
using Wms.Telegram;
using WmsApi;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlBayTransferController : EntityControllerBase<TPlBayTransfer, TPlBayTransferReadModel, TPlBayTransferCreateModel, TPlBayTransferUpdateModel>
    {
        public TPlBayTransferController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlBayTransferCreateModel> createValidator, IValidator<TPlBayTransferUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 客户端创建库间倒运计划
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> CreateTransferPlan(TPlBayTransferCreateModel createModel, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBayTransfer>();
            var repoTr = DataContext.Set<TTrTruck>();
            var repoEq = DataContext.Set<TEqCrossVehicle>();
            var trCT = DataContext.Set<TTrCrossTrain>();
            var repoTrLM = DataContext.Set<TTrLocationMaterial>();
            var eqType = repoEq.Where(t => t.Id == createModel.VehicleTypeId).FirstOrDefault();
            //var plBayTransfer = repoPl.Where(t => t.VehicleTypeName == eqType.Name).FirstOrDefault();
            //if (plBayTransfer != null)
            //{
            //    return new OperationResult(true, $"{eqType.Name}已存在计划，不可重复添加");
            //}
            List<string> materialNoList = new List<string>(createModel.MaterialNo.Split(','));
            List<string> locationList = new List<string>();
            foreach (var no in materialNoList)
            {
                var lm = repoTrLM.Where(t => t.MaterialNo == no && t.Type == 2).FirstOrDefault();
                if (lm != null)
                {
                    locationList.Add(lm.LocationName);
                }
            }
            if (eqType.Type == 1)
            {
                //SetCreateModelBasic(createModel);
                createModel.Id = DateTime.Now.ToFileTime().ToString();
                createModel.CreateTime = DateTime.Now;
                createModel.UpdateTime = DateTime.Now;
                createModel.Remark = string.Join(",", locationList);
                await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);
                var pl = Mapper.Map<TPlBayTransfer>(createModel);
                await repoPl.AddAsync(pl);
                var tr = new TTrTruck
                {
                    Id = DateTime.Now.ToFileTime().ToString(),
                    TruckNo = createModel.VehicleTypeName,
                    TransferNo = createModel.No,
                    IsEnable = createModel.IsEnable,
                    CreateTime = DateTime.Now,
                    CreateUser = "API",
                    UpdateTime = DateTime.Now,
                    UpdateUser = "API",
                };
                repoTr.Add(tr);
                await DataContext.SaveChangesAsync(cancellationToken);
                return new OperationResult(true, $"{createModel.CreateUser}用户创建成功");
            }
            else if (eqType.Type == 2)
            {
                var count = materialNoList.Count;
                for (int i = 0; i < count;)
                {
                    if (i + 3 <= count)
                    {
                        var list = $"{materialNoList[i]},{materialNoList[i + 1]},{materialNoList[i + 2]}";
                        if (list != null)
                        {
                            createModel.MaterialNo = list;
                            SetCreateModelBasic(createModel);
                            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);
                            var pl = Mapper.Map<TPlBayTransfer>(createModel);
                            await repoPl.AddAsync(pl);
                            await DataContext.SaveChangesAsync(cancellationToken);
                        }
                        i = i + 3;
                    }
                    else if (i + 2 == count)
                    {
                        var list = $"{materialNoList[i]},{materialNoList[i + 1]}";
                        if (list != null)
                        {
                            createModel.MaterialNo = list;
                            SetCreateModelBasic(createModel);
                            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);
                            var pl = Mapper.Map<TPlBayTransfer>(createModel);
                            await repoPl.AddAsync(pl);
                            await DataContext.SaveChangesAsync(cancellationToken);
                        }
                        break;
                    }
                    else if (i + 1 == count)
                    {
                        var list = $"{materialNoList[i]}";
                        if (list != null)
                        {
                            createModel.MaterialNo = list;
                            SetCreateModelBasic(createModel);
                            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);
                            var pl = Mapper.Map<TPlBayTransfer>(createModel);
                            await repoPl.AddAsync(pl);
                            await DataContext.SaveChangesAsync(cancellationToken);
                        }
                        break;
                    }
                }
                //var trct = new TTrCrossTrain
                //{
                //    Id = DateTime.Now.ToFileTime().ToString(),
                //    VehicleId = createModel.VehicleTypeId,
                //    VehicleType = eqType.Type,
                //    VehicleName = createModel.VehicleTypeName,
                //    IsEnable = createModel.IsEnable,
                //    CreateTime = DateTime.Now,
                //    CreateUser = "API",
                //    UpdateTime = DateTime.Now,
                //    UpdateUser = "API"
                //};
                //trCT.Add(trct);
                //var save = await DataContext.SaveChangesAsync(cancellationToken);
                return new OperationResult(true, "计划新建成功");
            }
            else if (eqType.Type == 3)
            {
                SetCreateModelBasic(createModel);
                await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);
                var pl = Mapper.Map<TPlBayTransfer>(createModel);
                await repoPl.AddAsync(pl);
                await DataContext.SaveChangesAsync(cancellationToken);
                return new OperationResult(true, "计划新建成功");
            }
            return new OperationResult(false, "新建计划失败");
        }


        /// <summary>
        /// 发送倒运信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<ItemResult<TPlBayTransferReadModel>>>
            SendTransferInfo(string materialNo, string location, CancellationToken cancellationToken)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();
            var repoPl = DataContext.Set<TPlBayTransfer>();
            var item = new ItemResult<TPlBayTransferReadModel>();
            var plBayTransfer = repoPl.Where(t => t.MaterialNo.Contains(materialNo)).FirstOrDefault();

            if (materialNo.IsValidValue() && plBayTransfer != null)
            {
                if (location == null)
                {
                    var wmbm19 = new TeleWMBM19
                    {
                        Payload = new TruckInTransfer
                        {
                            RecOperator = plBayTransfer.CreateUser,//---------------------------
                            RecTime = plBayTransfer.CreateTime.ToString("yyyyMMddHHmmss"),
                            CoilNo = materialNo,
                            FromHouse = GetBayHouse(plBayTransfer.FromBayName[..2]),
                            FromLocationNo = location,
                            ToHouse = GetBayHouse(plBayTransfer.DestBayName[..2]),
                            ToLocationNo = $"{plBayTransfer.DestBayName[..2]}0L01011",
                            TruckNo = plBayTransfer.VehicleTypeName
                        }
                    };
                    await mbs.Publish(wmbm19);
                }
                else
                {
                    var wmbm19 = new TeleWMBM19
                    {
                        Payload = new TruckInTransfer
                        {
                            RecOperator = plBayTransfer.CreateUser,//---------------------------
                            RecTime = plBayTransfer.CreateTime.ToString("yyyyMMddHHmmss"),
                            CoilNo = materialNo,
                            FromHouse = GetBayHouse(plBayTransfer.FromBayName[..2]),
                            FromLocationNo = $"{plBayTransfer.FromBayName[..2]}01A01011",
                            ToHouse = GetBayHouse(plBayTransfer.DestBayName[..2]),
                            ToLocationNo = $"{plBayTransfer.DestBayName[..2]}0L01011",
                            TruckNo = plBayTransfer.VehicleTypeName
                        }
                    };
                    await mbs.Publish(wmbm19);
                }
                item.Success = true;
                item.Message = "倒运信息已发出";
                return item;
            }
            item.Success = false;
            item.Message = "钢卷信息异常";
            return item;
        }

        private string GetBayHouse(string bayCode)
        {
            if (bayCode == "16" || bayCode == "17" || bayCode == "18")
            {
                return "P5";
            }
            if (bayCode == "21" || bayCode == "22" || bayCode == "23" || bayCode == "24")
            {
                return "P6";
            }
            if (bayCode == "25" || bayCode == "26" || bayCode == "27")
            {
                return "P8";
            }
            return "";
        }

        /// <summary>
        /// 导入倒运钢卷信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<List<string>>>> ImportBayTransferData(IFormFile file, CancellationToken cancellationToken)
        {
            var plTransfer = DataContext.Set<TPlBayTransfer>();
            var trLoc = DataContext.Set<TTrLocationMaterial>();
            try
            {
                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream).ConfigureAwait(false);
                    var rows = stream.Query(useHeaderRow: true).ToList();
                    List<string> pickMatNos = new();
                    if (rows != null && rows.Count > 0)
                    {
                        int[] states = { 1, 2, 3 };
                        for (int i = 0; i < rows.Count; i++)
                        {
                            string matNo = rows[i].MaterialNo;
                            if (string.IsNullOrEmpty(matNo))
                                continue;
                            var trLocM = await trLoc.FirstOrDefaultAsync(t => t.Type == 2 && t.MaterialNo == matNo.Trim());
                            if (trLocM == null)
                            {
                                return new OperationResult<List<string>>(false, $"卷号{matNo}不在库，导入失败", null);
                            }
                            pickMatNos.Add(matNo.Trim());
                        }
                        await DataContext.SaveChangesAsync(cancellationToken);
                    }
                    return new OperationResult<List<string>>(true, $"导入成功", pickMatNos);
                }
            }
            catch (Exception ex)
            {
                return new OperationResult<List<string>>(false, $"导入失败{ex.Message}", null);
            }
        }

        /// <summary>
        /// 手持创建电瓶车库间倒运计划
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<AddScanDetailResult>> HoldCreateTransferPlan(string vehicleId, string material, string fromBayName, string destBayName, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBayTransfer>();
            var repoTr = DataContext.Set<TTrTruck>();
            var repoEq = DataContext.Set<TEqCrossVehicle>();
            var trCT = DataContext.Set<TTrCrossTrain>();
            var repoPlanType = DataContext.Set<TWhPlanType>();
            var repoWhBay = DataContext.Set<TWhBay>();
            var eqType = repoEq.Where(t => t.Id == vehicleId).FirstOrDefault();
            var plBayTransfer = repoPl.Where(t => t.VehicleTypeId == vehicleId).FirstOrDefault();
            var planType = repoPlanType.Where(t => t.Name.Contains("库间倒运")).FirstOrDefault();
            var fromBay = repoWhBay.Where(t => t.Code == fromBayName).FirstOrDefault();
            var destBay = repoWhBay.Where(t => t.Name == destBayName).FirstOrDefault();
            if (eqType == null || planType == null || fromBay == null || destBay == null)
            {
                var item = new ItemResult<TRcInventoryReadModel>
                {
                    Success = false,
                    Message = $"添加失败"
                };
                return Ok(new AddScanDetailResult(null, item));
            }
            if (plBayTransfer != null && (plBayTransfer.FromBayName != fromBay.Name || plBayTransfer.DestBayName != destBay.Name))
            {
                var item = new ItemResult<TRcInventoryReadModel>
                {
                    Success = false,
                    Message = $"与其他计划起点或终点不一致"
                };
                return Ok(new AddScanDetailResult(null, item));
            }
            if (plBayTransfer != null && plBayTransfer.MaterialNo.Contains(material))
            {
                var item = new ItemResult<TRcInventoryReadModel>
                {
                    Success = false,
                    Message = $" {material}此卷号已在计划中"
                };
                DataContext.SaveChanges();
                return Ok(new AddScanDetailResult(null, item));
            }
            else if (plBayTransfer != null && !plBayTransfer.MaterialNo.Contains(material))
            {
                plBayTransfer.MaterialNo += $",{material}";
                var item = new ItemResult<TRcInventoryReadModel>
                {
                    Success = true,
                    Message = $" {material}计划添加成功"
                };
                DataContext.SaveChanges();
                return Ok(new AddScanDetailResult(null, item));
            }
            else
            {
                plBayTransfer = new TPlBayTransfer()
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    No = CreatePlanId(),
                    MaterialNo = material,
                    PlanTypeId = planType.Id,
                    PlanTypeName = planType.Name,
                    FromBayId = fromBay.Id,
                    FromBayName = fromBay.Name,
                    DestBayId = destBay.Id,
                    DestBayName = destBay.Name,
                    VehicleTypeId = eqType.Id,
                    VehicleTypeName = eqType.Name,
                    PlanState = 0,
                    ResolveState = 0,
                    ExecState = 0,
                    IsEnable = 1,
                    CreateTime = DateTime.Now,
                    CreateUser = "API",
                    UpdateTime = DateTime.Now,
                    UpdateUser = "API"
                };
                repoPl.Add(plBayTransfer);
                var item = new ItemResult<TRcInventoryReadModel>
                {
                    Success = true,
                    Message = $" {material}计划添加成功"
                };
                DataContext.SaveChanges();
                return Ok(new AddScanDetailResult(null, item));
            }
        }
        /// <summary>
        /// 创建计划编号
        /// </summary>
        /// <returns></returns>
        private string CreatePlanId()
        {
            var repo = DataContext.Set<TWhStack>();
            var sql = "SELECT F_PL_AUTO_CODE('PLAN','WMS') FROM DUAL";
            var number = SqlQuery(sql, (t) => (string)t[0]).First();
            return number;
        }

        /// <summary>
        /// 查询电瓶车计划
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<List<TransferPlanModel>>> GetTransferPlan(string vehicleId, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBayTransfer>();
            //var repoClass = DataContext.Set<TRcClassStock>();
            //var classStockList = repoClass.Where(t => t.CurrentClasses == "甲班" && t.HouseNo == "P6" && t.HandStockWeight == null && t.CreateTime > DateTime.Now.AddHours(-13)).ToList(;

            var plBayTransfer = repoPl.Where(t => t.VehicleTypeId == vehicleId).FirstOrDefault();
            if (plBayTransfer != null && plBayTransfer.MaterialNo != null && plBayTransfer.MaterialNo != "")
            {
                var materialList = plBayTransfer.MaterialNo.Split(",").ToList();
                var i = 1;
                var transferPlans = new List<TransferPlanModel>();
                foreach (var material in materialList)
                {
                    var plan = new TransferPlanModel()
                    {
                        Count = i,
                        MaterialNo = material,
                        FromBay = plBayTransfer.FromBayName,
                        DestBay = plBayTransfer.DestBayName
                    };
                    transferPlans.Add(plan);
                    i++;
                }
                return transferPlans;
            }
            return null;
        }

        /// <summary>
        /// 手持删除电瓶车倒运计划
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> HoldDeleteTransferPlan(string vehicleId, string material, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBayTransfer>();
            var plBayTransfer = repoPl.Where(t => t.VehicleTypeId == vehicleId).FirstOrDefault();
            if (plBayTransfer != null && plBayTransfer.MaterialNo != null && plBayTransfer.MaterialNo != "")
            {
                var materialList = plBayTransfer.MaterialNo.Split(",").ToList();
                var materialNoToRemove = new List<string>();
                foreach (var no in materialList)
                {
                    if (no == material)
                    {
                        materialNoToRemove.Add(no);
                        break;
                    }
                }
                foreach (var materialNo in materialNoToRemove)
                {
                    materialList.Remove(materialNo);
                }
                plBayTransfer.MaterialNo = string.Join(",", materialList);
                if (plBayTransfer.MaterialNo == "" || plBayTransfer.MaterialNo == null)
                {
                    repoPl.Remove(plBayTransfer);
                }
                var count = DataContext.SaveChanges();
                if (count > 0)
                {
                    return new OperationResult(true, $"{material}计划删除成功");
                }
            }
            return new OperationResult(true, $"{material}计划删除失败");
        }


        /// <summary>
        /// 判断计划不唯一
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<OperationResult>> CreatePlanCondition([FromQuery] string vehicleTypeId, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBayTransfer>();
            var repoEq = DataContext.Set<TEqCrossVehicle>();
            var eqType = repoEq.Where(t => t.Id == vehicleTypeId).FirstOrDefault();
            var plBayTransfer = repoPl.Where(t => t.IsEnable == 1 && t.VehicleTypeName == eqType.Name).FirstOrDefault();
            if (plBayTransfer != null)
            {
                return new OperationResult(false, $"{eqType.Name}已存在计划，不可重复添加");
            }
            return new OperationResult(true, "");
        }
        /// <summary>
        /// 更新库间倒运计划
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> UpdateTransferPlan(TPlBayTransferUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBayTransfer>();
            var repoTr = DataContext.Set<TTrTruck>();
            var repoEq = DataContext.Set<TEqCrossVehicle>();
            var eqType = repoEq.Where(t => t.Id == updateModel.VehicleTypeId).FirstOrDefault();
            var operationResult = await Update(updateModel.Id, updateModel, cancellationToken);
            if (!operationResult.Value.Success)
            {
                return operationResult;
            }
            SetUpdateModelBasic(updateModel);
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken);
            if (eqType.Type == 1)
            {
                var trModel = repoTr.Where(t => t.TransferNo == updateModel.No).FirstOrDefault();
                if (trModel != null)
                {
                    trModel.TruckNo = updateModel.VehicleTypeName;
                    trModel.UpdateTime = DateTime.Now;
                    trModel.UpdateUser = "API";
                }
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            return operationResult;
        }

        /// <summary>
        /// 删除库间倒运计划
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpDelete("")]
        public async Task<ActionResult<OperationResult>> DeleteTransferPlan([FromQuery] string[] ids, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBayTransfer>();
            var repoTr = DataContext.Set<TTrTruck>();
            var repoEq = DataContext.Set<TEqCrossVehicle>();
            var trCrossTrains = DataContext.Set<TTrCrossTrain>();
            var repoPlCBTask = DataContext.Set<TPlCrossBayTask>();
            foreach (var id in ids)
            {
                var plBayTransfer = repoPl.Where(t => t.Id == id).FirstOrDefault();
                if (plBayTransfer != null)
                {
                    var eqType = repoEq.Where(t => t.Id == plBayTransfer.VehicleTypeId).FirstOrDefault();
                    if (eqType.Type == 1)
                    {
                        var trTruck = repoTr.Where(t => t.TransferNo == plBayTransfer.No).FirstOrDefault();
                        if (trTruck != null)
                        {
                            repoTr.Remove(trTruck);
                        }
                    }
                    if (eqType.Type == 2)
                    {
                        //删除分解任务
                        var plCrossBayTask = repoPlCBTask.Where(t => t.MaterialNoPlan == plBayTransfer.MaterialNo).FirstOrDefault();
                        if (plCrossBayTask != null)
                        {
                            repoPlCBTask.Remove(plCrossBayTask);
                        }

                        //初始化任务跟踪
                        var tr = trCrossTrains.Where(t => t.VehicleName == plBayTransfer.VehicleTypeName).FirstOrDefault();
                        tr.ParkedState = 0;
                        tr.TaskNoWms = null;
                        tr.TaskNoPlc = null;
                        tr.UpdateTime = DateTime.Now;
                        tr.UpdateUser = "API";
                    }
                    repoPl.Remove(plBayTransfer);
                    await DataContext.SaveChangesAsync();
                }
            }
            return new OperationResult(true, "计划已删除");
        }
    }
}
