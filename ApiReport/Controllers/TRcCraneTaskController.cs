using Aspose.Cells;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcCraneTaskController : EntityControllerBase<TRcCraneTask, TRcCraneTaskReadModel, TRcCraneTaskCreateModel, TRcCraneTaskUpdateModel>
    {
        public TRcCraneTaskController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcCraneTaskCreateModel> createValidator, IValidator<TRcCraneTaskUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
        /// <summary>
        /// 行车作业比例
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<CraneModel>>> GetCranePercent([FromQuery] PageParam pageParam, [FromQuery] string[] bayId, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var eqCranes = DataContext.Set<TEqCrane>();
            var predicateCrane = ExpressionBuilder.True<TEqCrane>();
            predicateCrane = predicateCrane.And(t => t.IsEnable == 1);
            if (bayId.Length > 0 && bayId != null)
            {
                predicateCrane = predicateCrane.And(x => bayId.Contains(x.OwnerId));
            }
            var queryCrane = eqCranes.AsNoTracking().Where(predicateCrane);
            var queryCraneCount = queryCrane.Count();
            if (pageParam != null)
            {
                queryCrane = queryCrane.Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize);
            }
            else
            {
                queryCrane = queryCrane.Take(1000);
            }
            var craneList = await queryCrane.ToListAsync();

            var rcCraneTasks = DataContext.Set<TRcCraneTask>();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var query = rcCraneTasks.AsNoTracking();
            var evQuery = rcMaterialEvents.AsNoTracking();
            if (time.Length > 0 && time != null)
            {
                var Bstartime = Convert.ToDateTime(time[0]);
                var Bendtime = Convert.ToDateTime(time[1]);
                query = query.Where(t => t.StartTime > Bstartime && t.EndTime < Bendtime);
                evQuery = evQuery.Where(t => t.Dt > Bstartime && t.Dt <= Bendtime);
            }
            else
            {
                var startime = DateTime.Now.ToString("yyyy-MM-dd");
                var endtime = DateTime.Now.ToString("yyyy-MM-dd");
                var Bstartime = Convert.ToDateTime($"{startime} 09:00:00");
                var Bendtime = Convert.ToDateTime($"{endtime} 18:00:00");
                query = query.Where(t => t.StartTime > Bstartime && t.EndTime < Bendtime);
                evQuery = evQuery.Where(t => t.Dt > Bstartime && t.Dt <= Bendtime);
            }
            var result = new PageResult<CraneModel>();
            var listmodel = new List<CraneModel>();

            foreach (var crane in craneList)
            {
                var bayCode = DataContext.Set<TWhBay>().FirstOrDefault(t => t.Id == crane.OwnerId).Code;
                var plan = query.Where(t => t.CraneName == crane.Name);
                //evQuery = evQuery.Where(t => t.CraneName == crane.Name);
                var count1 = plan.Where(t => t.PlanTypeName == "倒垛").Count();
                var count2 = plan.Where(t => t.PlanTypeName == "装车出库").Count();
                var count3 = plan.Where(t => t.PlanTypeName == "库间倒运").Count();
                var count4 = plan.Where(t => t.PlanTypeName == "精整上料").Count();
                var count5 = plan.Where(t => t.PlanTypeName == "直取出库").Count();

                var count6 = plan.Where(t => t.PlanTypeName == "发货备料").Count();
                var count7 = plan.Where(t => t.PlanTypeName == "配载备料").Count();
                var count8 = plan.Where(t => t.PlanTypeName == "过跨倒运").Count();

                var count9 = plan.Where(t => t.PlanTypeName == "钢卷下线").Count();

                if (crane == craneList.FirstOrDefault())
                {
                    var ddR = evQuery.Where(t => t.OperationType == "人工"
                        && EF.Functions.Like(t.FromLocationName, "" + bayCode + "%")
                        && EF.Functions.Like(t.ToLocationName, "" + bayCode + "%")
                        && !t.FromLocationName.Contains("" + bayCode + "0M")
                        && !t.FromLocationName.Contains("" + bayCode + "0N")
                        && !t.ToLocationName.Contains("" + bayCode + "P")
                        && t.Result == "成功"
                   ).Count();

                    var inputR = evQuery.Where(t => t.OperationType == "人工" && t.ContentType == "入库"
                      && !string.IsNullOrEmpty(t.CraneName)
                      && (EF.Functions.Like(t.FromLocationName, "" + bayCode + "0M%")
                      || EF.Functions.Like(t.FromLocationName, "" + bayCode + "0N%"))
                       && t.Result == "成功"
                     ).Count();

                    var outR = evQuery.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                       && !string.IsNullOrEmpty(t.CraneName)
                       && EF.Functions.Like(t.FromLocationName, "" + bayCode + "0%")
                       && (EF.Functions.Like(t.ToLocationName, "" + bayCode + "P%") || t.Description.Contains("装车或是地面"))
                        && t.Result == "成功"
                  ).Count();
                    count2 += outR;
                    count1 += ddR;
                    count9 += inputR;
                }

                var count10 = plan.Where(t => t.PlanTypeName == "退库到包装库").Count();

                var craneModel = new CraneModel()
                {
                    Id = crane.Id,
                    BayId = crane.OwnerId,
                    Name = crane.Name,
                    Count1 = count1,
                    Count2 = count2,
                    Count3 = count3,
                    Count4 = count4,
                    Count5 = count5,
                    Count6 = count6,
                    Count7 = count7,
                    Count8 = count8,
                    Count9 = count9,
                    Count10 = count10
                };
                listmodel.Add(craneModel);
            }
            result.Success = true;
            result.Data = listmodel;
            result.Total = queryCraneCount;
            result.Message = "查询统计成功！";
            return result;
        }


    }
}
