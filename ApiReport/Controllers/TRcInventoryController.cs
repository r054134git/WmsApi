using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;


namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcInventoryController : EntityControllerBase<TRcInventory, TRcInventoryReadModel, TRcInventoryCreateModel, TRcInventoryUpdateModel>
    {
        public TRcInventoryController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcInventoryCreateModel> createValidator, IValidator<TRcInventoryUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 手持获取批次号
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcInventoryReadModel>>> GetAllPlanNo(string bayId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TRcInventory>();
            var repoBay = DataContext.Set<TWhBay>();
            if (bayId.IsValidValue())
            {
                var bay = repoBay.Where(t => t.Id == bayId).First();
                predicate = predicate.And(x => x.BayCode.Contains(bay.Code) && x.IsFinished == 0);
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 客户端获取批次号
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcInventoryReadModel>>> GetPlanNo(DateTime startTime, DateTime endTime, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TRcInventory>();
            predicate = predicate.And(t => t.CreateTime >= startTime && t.CreateTime <= endTime);
            var query = GetQueryOrderByIdAsc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 创建盘库批次号
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<ItemResult<TRcInventoryReadModel>>> AddAllPlanNo(string bayId, CancellationToken cancellationToken)
        {
            var tRcInventory = DataContext.Set<TRcInventory>();
            var tRcDetail = DataContext.Set<TRcInventoryDetail>();
            var trLM = DataContext.Set<TTrLocationMaterial>();
            var rcTemp = DataContext.Set<TRcInventoryTemp>();
            var repo = DataContext.Set<TWhStack>();
            if (bayId.IsValidValue())
            {
                var trBay = trLM.Where(t => t.BayId == bayId).FirstOrDefault();
                var rcIsFinished = tRcInventory.Where(t => t.BayCode == trBay.BayCode && t.IsFinished == 0).FirstOrDefault();
                if (rcIsFinished != null)
                {
                    var item = new ItemResult<TRcInventoryReadModel>
                    {
                        Success = false,
                        Message = "当前库有未完成的批次号，创建失败"
                    };
                    return item;
                }

                var sql = "SELECT F_PL_AUTO_CODE('INVENTORY_NO','WMS') FROM DUAL";
                var number = SqlQuery(sql, (t) => (string)t[0]).First();
                var rc = new TRcInventory
                {
                    Id = DateTime.Now.ToFileTime().ToString(),
                    PlanNo = number,
                    UserAccount = "user",
                    UserName = "user",
                    BayCode = trBay.BayCode,
                    ScanCount = 0,
                    WmsCount = 0,
                    ScanNotInWmsCount = 0,
                    ScanInWmsCount = 0,
                    WmsNotInScanCount = 0,
                    IsFinished = 0,
                    IsEnable = 1,
                    CreateTime = DateTime.Now,
                    CreateUser = "API",
                    UpdateTime = DateTime.Now,
                    UpdateUser = "API"
                };
                tRcInventory.Add(rc);

                var trTempLM = trLM.Where(t => t.Type == 2 && t.BayId == bayId && 
                                         (t.OwnerBussinessName == "P5" || t.OwnerBussinessName == "P6" || t.OwnerBussinessName == "P8") &&
                                         t.AreaCode != "0L" && !t.MaterialNo.Contains("Q") && t.IsEnable == 1).ToList();
                foreach (var item in trTempLM)
                {
                    var temp = new TRcInventoryTemp
                    {
                        Id = DateTime.Now.ToFileTime().ToString(),
                        PlanNo = number,
                        BayId = bayId,
                        BayCode = item.BayCode,
                        LocationName = item.LocationName,
                        MaterialNo = item.MaterialNo,
                        IsEnable = item.IsEnable,
                        CreateTime = DateTime.Now,
                        CreateUser = "API",
                        UpdateTime = DateTime.Now,
                        UpdateUser = "API"
                    };
                    rcTemp.Add(temp);
                }
                int count = await DataContext.SaveChangesAsync(cancellationToken);
                if (count > 0)
                {
                    var item = new ItemResult<TRcInventoryReadModel>
                    {
                        Success = true,
                        Message = $"{number}批次号创建完成！"
                    };
                    return item;
                }
            }
            return NotFound();
        }
    }
}
