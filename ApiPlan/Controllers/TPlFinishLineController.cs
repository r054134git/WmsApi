using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
    public class TPlFinishLineController : EntityControllerBase<TPlFinishLine, TPlFinishLineReadModel, TPlFinishLineCreateModel, TPlFinishLineUpdateModel>
    {
        public TPlFinishLineController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlFinishLineCreateModel> createValidator, IValidator<TPlFinishLineUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
        private static DateTime _dbTime = DateTime.Now;

        /// <summary>
        /// 获取上料机组
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlFinishLineReadModel>>> GetLine(CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlFinishLine>();
            predicate = predicate.And(t => t.CreateTime > DateTime.Now.AddDays(-1));
            var query = GetQueryOrderByIdAsc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 获取生产计划号
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlFinishLineReadModel>>> GetStockPlan(string lineNo, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlFinishLine>();
            if (lineNo.IsValidValue())
            {
                predicate = predicate.And(t => t.LineNo == lineNo && t.CreateTime > DateTime.Now.AddDays(-1));
            }
            var query = GetQueryOrderByIdAsc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 上料计划钢卷列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<List<TTrLocationMaterialReadModel>>>
            GetAllStockList(string planNo, CancellationToken cancellationToken)
        {
            var repoPl = DataContext.Set<TPlFinishLine>();
            var repoTr = DataContext.Set<TTrLocationMaterial>();
            List<TTrLocationMaterial> trLMList = new List<TTrLocationMaterial>();
            if (planNo.IsValidValue())
            {
                var plLine = repoPl.Where(x => x.PlanNo == planNo).ToList();
                for (int i = 0; i < plLine.Count; i++)
                {
                    var trLM = await repoTr.Where(x => x.MaterialNo == plLine[i].MaterialNo).FirstOrDefaultAsync();
                    if (trLM != null)
                    {
                        trLMList.Add(trLM);
                        return Ok(trLMList);
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 精整上料
        /// </summary>
        /// <param name="materialNo"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> LoadMaterial(string materialNo, CancellationToken cancellationToken)
        {
            var repoLine = DataContext.Set<TPlFinishLine>();
            var repoLocMat = DataContext.Set<TTrLocationMaterial>();
            var repoBay = DataContext.Set<TPlBay>();
            var repoMat = DataContext.Set<TPlMaterial>();
            var finishLine = await repoLine.FirstOrDefaultAsync(t => t.MaterialNo == materialNo && t.PlanState == "N");
            if (finishLine == null)
            {
                return new OperationResult(true, $"计划卷号{materialNo}不存在，上料失败");
            }
            var locMat = await repoLocMat.FirstOrDefaultAsync(t => t.MaterialNo == materialNo && t.Type == 2);
            if (locMat == null)
            {
                return new OperationResult(true, $"卷号{materialNo}不在库，上料失败");
            }
            var repoType = DataContext.Set<TWhPlanType>();
            var planType = repoType.Where(t => t.Name.Contains("精整上料")).FirstOrDefault();
            var sql = "SELECT F_PL_AUTO_CODE('PLAN','WMS') FROM DUAL";
            var taskNo = SqlQuery(sql, (t) => (string)t[0]).First();

            if (locMat.BayCode == "25" || locMat.BayCode == "21")
            {
                var unLocation = await repoLocMat.FirstOrDefaultAsync(t => t.LocationName == $"{locMat.BayCode}01J01011");
                if (unLocation == null)
                {
                    return new OperationResult(true, $"上料库位不存在");
                }
                var d = new TPlBay
                {
                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                    PlanNo = taskNo,
                    MaterialId = locMat.MaterialId,
                    MaterialNo = locMat.MaterialNo,
                    PlanTypeId = planType.Id,
                    PlanTypeName = planType.Name,
                    BayId = locMat.BayId,
                    BayName = locMat.BayCode + "库",
                    SortIndex = 0,
                    TransferStep = 0,
                    PlanState = 0,
                    ExecState = 0,
                    ResolveState = 0,
                    PriorityOperator = 0,//优先级
                    LoadLocationId = locMat.LocationId,
                    LoadLocationName = locMat.LocationName,
                    UnloadLocationId = unLocation.Id,
                    UnloadLocationName = unLocation.LocationName,
                    IsEnable = 1,
                    CreateTime = DateTime.Now,
                    CreateUser = "API",
                    UpdateTime = DateTime.Now,
                    UpdateUser = "API",
                };
                repoBay.Add(d);
                var count = DataContext.SaveChanges();
                if (count == 0)
                {
                    return new OperationResult(false, $"卷号{materialNo}上料失败");
                }
                var mat = await repoMat.FirstOrDefaultAsync(t => t.Id == locMat.MaterialId);
                var trlocMat = await repoLocMat.FirstOrDefaultAsync(t => t.LocationId == locMat.Id);
                if (mat != null && trlocMat != null)
                {
                    CommUpdateMatToLoc(trlocMat, mat);
                    trlocMat.Type = (int)LocationMaterialTypes.PlanIn;
                }

                await DataContext.SaveChangesAsync(cancellationToken);
                return new OperationResult(true, $"卷号{materialNo}上料成功，等待行车执行");
            }
            else
            {
                return new OperationResult(true, $"卷号{materialNo}暂不支持上料");
            }
        }

        private static void CommUpdateMatToLoc(TTrLocationMaterial trLocMat, TPlMaterial material)
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
    }
}
