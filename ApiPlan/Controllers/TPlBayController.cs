using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Ucp.Contracts;
using WmsApi;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;


namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlBayController : EntityControllerBase<TPlBay, TPlBayReadModel, TPlBayCreateModel, TPlBayUpdateModel>
    {
        public TPlBayController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlBayCreateModel> createValidator, IValidator<TPlBayUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
        //反射
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

        private List<TPlCraneTaskReadModel> GetPlCraneTask(string id)
        {
            var dbSet = DataContext.Set<TPlCraneTask>();
            var query = dbSet.AsNoTracking().Where(t => t.OwnerId == id);
            var results = query.ProjectTo<TPlCraneTaskReadModel>(Mapper.ConfigurationProvider).ToList();
            return results;
        }

        [HttpGet("")]

        public async Task<ActionResult<PageResult<TPlBayReadCraneTaskModel>>> GetPagePlayAndTaskByString([FromQuery] PageParam pageParam, string where, string orders, CancellationToken cancellationToken)
        {
            var query = GetQueryByString(where, orders);
            var total = query.Count();
            if (pageParam != null)
            {
                query = query.Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize);
            }
            else
            {
                query = query.Take(1000);
            }
            var results = await query.ToListAsync();
            List<TPlBayReadCraneTaskModel> plBayList = new();
            foreach (var item in results)
            {
                TPlBayReadCraneTaskModel plbay = TransReflection<TPlBay, TPlBayReadCraneTaskModel>(item);
                plbay.plCraneTaskList = GetPlCraneTask(item.Id);
                plBayList.Add(plbay);
            }
            return new PageResult<TPlBayReadCraneTaskModel>
            {
                Data = plBayList,
                Success = true,
                Total = total
            };
        }

        /// <summary>
        /// 创建库内倒垛计划
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> CreateBayPlan(TPlBayCreateModel createModel, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBay>();
            var repoTr = DataContext.Set<TTrLocationMaterial>().AsNoTracking();
            var repoMat = DataContext.Set<TPlMaterial>().AsNoTracking();
            var location = await DataContext.Set<TWhLocation>().FirstOrDefaultAsync(t => t.Name == createModel.UnloadLocationName);
            if (location == null)
            {
                return new OperationResult(false, "选择的目标库位不存在！");
            }
            if (createModel.BayId != location.BayId)
            {
                return new OperationResult(false, "选择的目标库位与起始库位不在同一库区！");
            }
            var operationResult = await CanCreate(createModel, cancellationToken);
            if (!operationResult.Success)
            {
                return operationResult;
            }
            createModel.UnloadLocationId = location.Id;
            SetCreateModelBasic(createModel);
            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);
            var plBay = Mapper.Map<TPlBay>(createModel);
            await repoPl.AddAsync(plBay);

            var mat = await repoMat.FirstOrDefaultAsync(t => t.Id == createModel.MaterialId);
            var tr = await repoTr.FirstOrDefaultAsync(t => t.LocationId == createModel.UnloadLocationId);
            if (mat != null && tr != null)
            {
                CommUpdateMatToLoc(tr, mat);
                tr.Type = (int)LocationMaterialTypes.PlanIn;
            }

            await DataContext.SaveChangesAsync(cancellationToken);
            return operationResult;
        }

        /// <summary>
        /// 批量创建库内倒垛计划
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> CreateBayPlanBatch(TPlBayBatchCreateModel createModel, CancellationToken cancellationToken)
        {
            var (trLocationMaterialsList, count) = await GetLibLocation(createModel, cancellationToken);
            var (trLocationMaterialsList2, count2) = await GetKongLocation(createModel, cancellationToken);
            var countCom = count > count2 ? count2 : count;     // 4    2

            for (int i = 0; i < countCom; i++)
            {
                var plBay = new TPlBayCreateModel()
                {
                    BayId = trLocationMaterialsList[i].BayId,
                    BayName = trLocationMaterialsList[i].BayCode + "库",
                    LoadLocationId = trLocationMaterialsList[i].LocationId,
                    LoadLocationName = trLocationMaterialsList[i].LocationName,
                    UnloadLocationName = trLocationMaterialsList2[i].LocationName,
                    MaterialId = trLocationMaterialsList[i].MaterialId,
                    MaterialNo = trLocationMaterialsList[i].MaterialNo,
                    PlanNo = CreatePlanId(),

                    ExecState = 0,
                    IsEnable = 1,
                    PlanState = 0,
                    PlanTypeId = "1",
                    PlanTypeName = "倒垛",
                    PriorityOperator = 0,
                    ResolveState = 0,
                    SortIndex = 0,
                    TransferStep = 0,
                };
                await CreateBayPlan(plBay, cancellationToken);
            }
            return Ok();
        }

        /// <summary>
        /// 获取在库鞍座
        /// </summary>
        [HttpGet("")]
        public async Task<(List<TTrLocationMaterialReadModel> list, int count)> GetLibLocation(TPlBayBatchCreateModel createModel, CancellationToken cancellationToken)
        {
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var query = repoTr.AsNoTracking();
            var query2 = repoTr.AsNoTracking();
            //在库鞍座
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.BayId == createModel.BayId && t.AreaId == createModel.AreaId && t.StackId == createModel.StackId);
            predicate = predicate.And(t => t.ColNo >= createModel.FromColNo && t.ColNo <= createModel.ToColNo && t.IsEnable == 1 && t.Type == 2);
            if (createModel.FloorNo != 12)
            {
                predicate = predicate.And(t => t.FloorNo == createModel.FloorNo);
            }
            var trLocationMaterialsList = await query.Where(predicate).ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            var count = trLocationMaterialsList.Count;
            return (trLocationMaterialsList, count);
        }

        /// <summary>
        /// 获取空鞍座
        /// </summary>
        [HttpGet("")]
        public async Task<(List<TTrLocationMaterialReadModel> list, int count)> GetKongLocation(TPlBayBatchCreateModel createModel, CancellationToken cancellationToken)
        {
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var query = repoTr.AsNoTracking();
            //空鞍座
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            predicate = predicate.And(t => t.BayId == createModel.BayId && t.AreaId == createModel.AreaId2 && t.StackId == createModel.StackId2);
            predicate = predicate.And(t => t.ColNo >= createModel.FromColNo2 && t.ColNo <= createModel.ToColNo2 && t.IsEnable == 1 && t.Type == 0);
            if (createModel.FloorNo != 12)
            {
                predicate = predicate.And(t => t.FloorNo == createModel.FloorNo2);
            }
            var trLocationMaterialsList = await query.Where(predicate).ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            var count = trLocationMaterialsList.Count;
            return (trLocationMaterialsList, count);
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
        /// 创建精整上料倒垛计划
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> AddFinishLinePlan(string materialNo, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBay>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoMat = DataContext.Set<TPlMaterial>();
            var repoType = DataContext.Set<TWhPlanType>();
            var planType = repoType.Where(t => t.Name.Contains("精整上料")).FirstOrDefault();
            var locationTr = repoTr.Where(t => t.MaterialNo == materialNo).FirstOrDefault();
            var unLocation = await DataContext.Set<TWhLocation>().FirstOrDefaultAsync(t => t.Name == "2501J01011");
            var sql = "SELECT F_PL_AUTO_CODE('PLAN','WMS') FROM DUAL";
            var taskNo = SqlQuery(sql, (t) => (string)t[0]).First();
            if (unLocation == null)
            {
                return new OperationResult(false, "选择的目标库位不存在！");
            }
            if (locationTr == null)
            {
                return new OperationResult(false, "找不到该物料的库存信息");
            }
            if (locationTr.BayId != unLocation.BayId)
            {
                return new OperationResult(false, "物料与备料区不在同一库区！");
            }
            var d = new TPlBay
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                PlanNo = taskNo,
                MaterialId = locationTr.MaterialId,
                MaterialNo = locationTr.MaterialNo,
                PlanTypeId = planType.Id,
                PlanTypeName = planType.Name,
                BayId = locationTr.BayId,
                BayName = locationTr.BayCode + "库",
                SortIndex = 0,
                TransferStep = 0,
                PlanState = 0,
                ExecState = 0,
                ResolveState = 0,
                PriorityOperator = 0,//优先级
                LoadLocationId = locationTr.LocationId,
                LoadLocationName = locationTr.LocationName,
                UnloadLocationId = unLocation.Id,
                UnloadLocationName = unLocation.Name,
                IsEnable = 1,
                CreateTime = DateTime.Now,
                CreateUser = "API",
                UpdateTime = DateTime.Now,
                UpdateUser = "API",
            };
            repoPl.Add(d);
            var count = DataContext.SaveChanges();
            if (count == 0)
            {
                return new OperationResult(false, "精整上料计划添加失败");
            }
            var mat = await repoMat.FirstOrDefaultAsync(t => t.Id == locationTr.MaterialId);
            var tr = await repoTr.FirstOrDefaultAsync(t => t.LocationId == locationTr.LocationId);
            if (mat != null && tr != null)
            {
                CommUpdateMatToLoc(tr, mat);
                tr.Type = (int)LocationMaterialTypes.PlanIn;
            }

            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, "精整上料计划添加成功！");
        }

        public static void CommUpdateMatToLoc(TTrLocationMaterial trLocMat, TPlMaterial material)
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
            trLocMat.Weight = material.Weight;
            trLocMat.Width = material.Width;
            trLocMat.CustomerCode = material.CustomerCode;
            trLocMat.CustomerName = material.CustomerName;
            trLocMat.LockMark = material.LockMark;
            trLocMat.LockReason = material.LockReason;
            trLocMat.IsDistributionShip = material.IsDistributionShip;

            //trLocMat.MaxZ = CalcMaxZ(trLocMat.BayId, trLocMat.LocationName, trLocMat.Diameter ?? 2000);
            trLocMat.TrimFlag = material.TrimFlag;
            trLocMat.ProductPackTime = material.ProductPackTime;
            trLocMat.DecideThick = material.DecideThick;
            trLocMat.DecideWidth = material.DecideWidth;
            trLocMat.BundlePackageNo = material.BundlePackageNo;
            trLocMat.Terminal = material.Terminal;
            trLocMat.PackingTypeCode = material.PackingTypeCode;
            trLocMat.PortLotNumber = material.PortLotNumber;
            trLocMat.TrnpModeCode = material.TrnpModeCode;

            trLocMat.UpdateTime = DateTime.Now;
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlBayReadModel>>> GetCranePlan(string bayId, string type, string craneName, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlBay>();
            if (type.IsValidValue())
            {
                predicate = predicate.And(x => x.BayId == bayId && x.PlanTypeName == type);
            }
            else
            {
                predicate = predicate.And(x => x.BayId == bayId);
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 手持创建计划
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> HoldCreatePlan(string material, string destLocation, string type, CancellationToken cancellationToken)
        {
            var repoPlanType = DataContext.Set<TWhPlanType>();
            var repoPlBay = DataContext.Set<TPlBay>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var planType = repoPlanType.Where(t => t.Name.Contains(type)).FirstOrDefault();
            var locationTr = repoTr.Where(t => t.MaterialNo == material).FirstOrDefault();
            var unLocation = repoTr.Where(t => t.LocationName == destLocation).FirstOrDefault();
            var plan = repoPlBay.Where(t => t.MaterialNo == material).FirstOrDefault();
            if (unLocation == null)
            {
                return new OperationResult(false, "添加失败，目标库位不存在！");
            }
            if (unLocation.Type == 2)
            {
                return new OperationResult(false, "添加失败，目标库位有卷！");
            }
            if (plan != null)
            {
                return new OperationResult(false, "添加失败，此卷号已存在计划！");

            }
            if (locationTr.BayCode != unLocation.BayCode)
            {
                return new OperationResult(false, "添加失败，起点终点库不统一！");
            }
            if (planType == null)
            {
                return new OperationResult(false, "计划类型不存在");
            }
            var pl = new TPlBay()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                PlanNo = CreatePlanId(),
                MaterialId = locationTr.MaterialId,
                MaterialNo = material,
                PlanTypeId = planType.Id,
                PlanTypeName = planType.Name,
                BayId = locationTr.BayId,
                BayName = locationTr.BayCode,
                SortIndex = 0,
                BayTransferPlanId = null,
                TransferStep = 0,
                PlanState = 0,
                ResolveState = 0,
                ExecState = 0,
                PriorityOperator = 0,
                LoadLocationId = locationTr.LocationId,
                LoadLocationName = locationTr.LocationName,
                UnloadLocationId = unLocation.LocationId,
                UnloadLocationName = unLocation.LocationName,
                IsEnable = 1,
                CreateTime = DateTime.Now,
                CreateUser = "API",
                UpdateTime = DateTime.Now,
                UpdateUser = "API"
            };
            repoPlBay.Add(pl);
            DataContext.SaveChanges();
            return new OperationResult(true, "添加成功");
        }

        /// <summary>
        /// 修改计划优先级
        /// </summary>
        /// <param name="bayId"></param>
        /// <param name="materialNo"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<int>> UpdatePlanPriority(string bayId, string materialNo, CancellationToken cancellationToken)
        {
            var plTask = DataContext.Set<TPlCraneTask>();
            var plPlan = DataContext.Set<TPlBay>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            if (materialNo.IsValidValue())
            {
                var task = plTask.Where(x => x.BayId == bayId && x.MaterialNo == materialNo).FirstOrDefault();
                var trLM = repoTr.Where(t => t.LocationName == task.UnloadLocationName).FirstOrDefault();
                if (task != null && trLM != null)
                {
                    var plan = plPlan.Where(t => t.Id == task.OwnerId).FirstOrDefault();
                    if (trLM.BayCode == "16" && (trLM.AreaCode == "P2" || trLM.AreaCode == "P3") || trLM.BayCode == "22" && trLM.AreaCode == "P3" ||
                        trLM.BayCode == "23" && trLM.AreaCode == "P1" || trLM.BayCode == "24" && trLM.AreaCode == "P1")
                    {
                        if (trLM.Angle == 90)
                        {
                            plan.SortIndex = -65;
                        }
                        else
                        {
                            plan.SortIndex = -70;
                        }
                    }
                    else
                    {
                        if (trLM.Angle == 90)
                        {
                            plan.SortIndex = -70;
                        }
                        else
                        {
                            plan.SortIndex = -65;
                        }
                    }
                }
                var count = await DataContext.SaveChangesAsync();
                if (count > 0)
                {
                    return Ok(count);
                }
            }
            return 0;
        }

        /// <summary>
        /// 编辑库内倒垛计划
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> UpdateBayPlan(TPlBayUpdateModel updateModel, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlBay>();
            var location = await DataContext.Set<TWhLocation>().FirstOrDefaultAsync(t => t.Name == updateModel.UnloadLocationName);
            if (location == null)
            {
                return new OperationResult(false, "选择的目标库位不存在！");
            }
            if (updateModel.BayId != location.BayId)
            {
                return new OperationResult(false, "选择的目标库位与起始库位不在同一库区！");
            }

            updateModel.UnloadLocationId = location.Id;
            var operationResult = await Update(updateModel.Id, updateModel, cancellationToken);
            if (!operationResult.Value.Success)
            {
                return operationResult;
            }
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken);
            return operationResult;
        }

        /// <summary>
        /// 客户端行车计划重置
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> ResettingTask(string id, CancellationToken cancellationToken)
        {
            var plBay = await DataContext.Set<TPlBay>().FirstOrDefaultAsync(t => t.Id == id);
            var plCraneTask = DataContext.Set<TPlCraneTask>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoLog = DataContext.Set<TRcLog>();
            var taskList = plCraneTask.Where(t => t.OwnerId == id).ToList();
            var truckLocation = new TTrLocationMaterial();
            if (taskList.Any(t => t.AssignState == 2))
            {
                return new OperationResult(false, $"卷号 {plBay?.MaterialNo} 计划正在执行，不允许重置！");
            }

            if (plBay != null)
            {
                plBay.ResolveState = 0;

                if (plBay.IsTruckLoadFixed == 0 && plBay.UnloadLocationName.Contains("P1"))
                {
                    var bayCode = plBay.UnloadLocationName[..2];
                    plBay.UnloadLocationId = repoTr.FirstOrDefault(t => t.LocationName == $"{bayCode}88A01011").LocationId;
                    plBay.UnloadLocationName = $"{bayCode}88A01011";
                }
                if (plBay.IsTruckLoadFixed == 0 && plBay.UnloadLocationName.Contains("P2"))
                {
                    var bayCode = plBay.UnloadLocationName[..2];
                    plBay.UnloadLocationId = repoTr.FirstOrDefault(t => t.LocationName == $"{bayCode}88B01011").LocationId;
                    plBay.UnloadLocationName = $"{bayCode}88B01011";
                }
                if (plBay.IsTruckLoadFixed == 0 && plBay.UnloadLocationName.Contains("P3"))
                {
                    var bayCode = plBay.UnloadLocationName[..2];
                    plBay.UnloadLocationId = repoTr.FirstOrDefault(t => t.LocationName == $"{bayCode}88C01011").LocationId;
                    plBay.UnloadLocationName = $"{bayCode}88C01011";
                }
                if (plBay.LoadLocationName.Contains("0M") || plBay.LoadLocationName.Contains("0N"))
                {
                    var bayCode = plBay.UnloadLocationName[..2];
                    plBay.UnloadLocationId = repoTr.FirstOrDefault(t => t.LocationName == $"{bayCode}99A01011").LocationId;
                    plBay.UnloadLocationName = $"{bayCode}99A01011";
                }

                //if (plBay.IsTruckLoadFixed == 1 && plBay.Remark.Contains("库位有其它钢卷"))
                //{
                //    truckLocation = repoTr.Where(t => t.LocationName.Contains($"{plBay.UnloadLocationName.Substring(0, 4)}") && t.Type == 0).FirstOrDefault();
                //    plBay.UnloadLocationName = truckLocation.LocationName;
                //}
            }

            foreach (var task in taskList)
            {
                var tr = repoTr.FirstOrDefault(t => t.LocationId == task.UnloadLocationId && t.Type == 1);
                if (tr != null)
                {
                    CommClearLocMat(tr);
                    var log = new TRcLog
                    {
                        Id = IdWorkerGenerator.Instance.NextId().ToString(),
                        Dt = DateTime.Now,
                        EventNo = "1000",
                        Source = "API",
                        WarningLevel = "INFO",
                        Message = $"重置计划{plBay?.PlanNo},任务{task.TaskNo},卷号{plBay?.MaterialNo},关联库位信息{tr.LocationName}"
                    };
                    repoLog.Add(log);
                }
                plCraneTask.Remove(task);
            }

            var proxy = ServiceProvider.GetService<IBus>();
            if (proxy != null)
            {
                var command = new MttPlanReset();
                command.PlanKey = new Key(plBay.Id, plBay.PlanNo, 0);
                await proxy.Publish(command);
            }

            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, "计划重置成功");
        }

        /// <summary>
        /// 客户端批量重置计划
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> BatchResettingPlan([FromQuery] string[] ids, CancellationToken cancellationToken)
        {
            var plCraneTask = DataContext.Set<TPlCraneTask>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            var repoLog = DataContext.Set<TRcLog>();

            foreach (var planId in ids)
            {
                var plBay = await DataContext.Set<TPlBay>().FirstOrDefaultAsync(t => t.Id == planId);
                var taskList = plCraneTask.Where(t => t.OwnerId == planId).ToList();
                var loaction = repoTr.Where(t => t.LocationId == plBay.UnloadLocationId).ToList();

                if (taskList.Any(t => t.AssignState == 2))
                {
                    return new OperationResult(false, $"卷号 {plBay?.MaterialNo} 计划正在执行，不允许重置！");
                }

                if (plBay != null)
                {
                    plBay.ResolveState = 0;
                    if (plBay.IsTruckLoadFixed == 0 && plBay.UnloadLocationName.Contains("P1"))
                    {
                        var bayCode = plBay.UnloadLocationName[..2];
                        plBay.UnloadLocationId = repoTr.FirstOrDefault(t => t.LocationName == $"{bayCode}88A01011").LocationId;
                        plBay.UnloadLocationName = $"{bayCode}88A01011";
                    }
                    if (plBay.IsTruckLoadFixed == 0 && plBay.UnloadLocationName.Contains("P2"))
                    {
                        var bayCode = plBay.UnloadLocationName[..2];
                        plBay.UnloadLocationId = repoTr.FirstOrDefault(t => t.LocationName == $"{bayCode}88B01011").LocationId;
                        plBay.UnloadLocationName = $"{bayCode}88B01011";
                    }
                    if (plBay.IsTruckLoadFixed == 0 && plBay.UnloadLocationName.Contains("P3"))
                    {
                        var bayCode = plBay.UnloadLocationName[..2];
                        plBay.UnloadLocationId = repoTr.FirstOrDefault(t => t.LocationName == $"{bayCode}88C01011").LocationId;
                        plBay.UnloadLocationName = $"{bayCode}88C01011";
                    }
                }

                foreach (var task in taskList)
                {
                    var tr = repoTr.FirstOrDefault(t => t.LocationId == task.UnloadLocationId && t.Type == 1);
                    if (tr != null)
                    {
                        CommClearLocMat(tr);
                        var log = new TRcLog
                        {
                            Id = IdWorkerGenerator.Instance.NextId().ToString(),
                            Dt = DateTime.Now,
                            EventNo = "1000",
                            Source = "API",
                            WarningLevel = "INFO",
                            Message = $"重置计划{plBay?.PlanNo},任务{task.TaskNo},卷号{plBay?.MaterialNo},关联库位信息{tr.LocationName}"
                        };
                        repoLog.Add(log);
                    }
                    plCraneTask.Remove(task);
                }
                var proxy = ServiceProvider.GetService<IBus>();
                if (proxy != null)
                {
                    var command = new MttPlanReset();
                    command.PlanKey = new Key(plBay.Id, plBay.PlanNo, 0);
                    await proxy.Publish(command);
                }
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, "计划重置成功");
        }

        /// <summary>
        /// 计划删除
        /// </summary>
        /// <returns></returns>
        [TokenActionFilter]
        [HttpDelete]
        public override async Task<ActionResult<OperationResult>> Delete([FromQuery] string[] ids, CancellationToken cancellationToken)
        {
            var plBay = DataContext.Set<TPlBay>();
            var plCraneTask = DataContext.Set<TPlCraneTask>();
            var trLM = DataContext.Set<TTrLocationMaterial>();
            var repoLog = DataContext.Set<TRcLog>();

            var idsString = string.Join(",", ids);

            try
            {
                foreach (var planId in ids)
                {
                    var plan = await plBay.FirstOrDefaultAsync(t => t.Id == planId);
                    if (plan == null)
                    {
                        return new OperationResult(false, $"卷号 {plan.MaterialNo} 的数据不存在！");
                    }

                    //var trPlans = trLM.Where(t => t.LocationId == plan.UnloadLocationId && t.Type == 1);
                    //foreach (var trPlan in trPlans)
                    //{
                    //    if (trPlan != null)
                    //    {
                    //        CommClearLocMat(trPlan);
                    //        trPlan.UpdateUser = "API";

                    //        var log = new TRcLog
                    //        {
                    //            Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    //            Dt = DateTime.Now,
                    //            EventNo = "1000",
                    //            Source = "API",
                    //            WarningLevel = "INFO",
                    //            Message = $"删除计划关联库位信息{trPlan.LocationName}"
                    //        };
                    //        repoLog.Add(log);
                    //    }
                    //}

                    //删除计划对应的任务
                    var taskList = plCraneTask.Where(t => t.OwnerId == planId).ToList();
                    //if (taskList.Any(t => t.AssignState == 2) || taskList.Any(t => t.ExecState == 1))
                    if (taskList.Any(t => t.AssignState == 2))
                    {
                        return new OperationResult(false, $"卷号 {plan.MaterialNo} 正在执行，不允许删除！");
                    }

                    foreach (var task in taskList)
                    {
                        var trs = trLM.Where(t => t.LocationId == task.UnloadLocationId && t.Type == 1);
                        foreach (var tr in trs)
                        {
                            if (tr != null)
                            {
                                CommClearLocMat(tr);
                                tr.UpdateUser = "API";
                                var log = new TRcLog
                                {
                                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                                    Dt = DateTime.Now,
                                    EventNo = "1000",
                                    Source = "API",
                                    WarningLevel = "INFO",
                                    Message = $"删除计划{plan.PlanNo}任务{task.TaskNo}关联卷号{tr.MaterialNo}/库位信息{tr.LocationName}"
                                };
                                repoLog.Add(log);
                            }
                        }
                        plCraneTask.Remove(task);
                    }

                    //删除计划
                    plBay.Remove(plan);

                    //跟踪表数据状态清除                  
                    var proxy = ServiceProvider.GetService<IBus>();
                    if (proxy != null)
                    {
                        var command = new MttPlanDeleted();
                        command.PlanKey = new Key(plan.Id, plan.PlanNo, 0);
                        await proxy.Publish(command);
                    }
                }
                await DataContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                return new OperationResult(false, ex.Message);
            }

            return new OperationResult(true, $"id {idsString} 的数据删除成功！");
        }



        /// <summary>
        /// 计划是否存在
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<TPlBayReadModel>> PlanIsNotExist(string materialNo)
        {
            var repoPl = DataContext.Set<TPlBay>();
            if (materialNo.IsValidValue())
            {
                var pl = await repoPl.Where(t => t.MaterialNo == materialNo).FirstOrDefaultAsync();
                if (pl != null)
                {
                    return Ok(pl);
                }
            }
            return null;
        }

        /// <summary>
        /// 清除库存信息
        /// </summary>
        /// <param name="trLocMat"></param>
        public static void CommClearLocMat(TTrLocationMaterial trLocMat)
        {
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
        }
    }
}
