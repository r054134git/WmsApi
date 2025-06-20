using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static MassTransit.ValidationResultExtensions;
using Cds.Contracts;
using System.Linq.Dynamic.Core;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcWorkModeController : EntityControllerBase<TRcWorkMode, TRcWorkModeReadModel, TRcWorkModeCreateModel, TRcWorkModeUpdateModel>
    {
        public TRcWorkModeController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcWorkModeCreateModel> createValidator, IValidator<TRcWorkModeUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
        /// <summary>
        /// 自动手动作业时长
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<WorkModel>>> GetWorkModeList([FromQuery] DateTime[] time, CancellationToken cancellationToken)
        {
            //3 自动，1 手动
            var eqs = DataContext.Set<TEqCrane>();
            var query = eqs.Where(t => t.IsEnable == 1);
            var eqsList = await query.ToListAsync(cancellationToken);

            List<WorkModel> workModelsList = new();
            var rcs = DataContext.Set<TRcWorkMode>();
            foreach (var item in eqsList)
            {             
                double second = 0;
                var rcsList = rcs.Where(t => t.CraneName == item.Name && t.CreateTime >= time[0] && t.CreateTime <= time[1]).OrderBy(t => t.CreateTime).ToList();
                for (int i = 0; i < rcsList.Count; i++)
                {
                    if (i == 0 && rcsList[i].ToMode == 1)
                    {
                        continue;
                    }
                    if (i + 1 < rcsList.Count)
                    {
                        if (rcsList[i].ToMode == 3 && rcsList[i + 1].ToMode == 1)
                        {
                            var timeSpan = rcsList[i + 1].CreateTime - rcsList[i].CreateTime;
                            second += timeSpan.TotalMinutes;
                            i++;
                        }
                    }
                }

                if (rcsList.Count > 0)
                {
                    //开始时间在自动时间范围内，，再下一次时间节点时，加上差值，与第一次时间进行比较
                    var rcsMin = rcsList[0];
                    if (rcsMin.CreateTime > time[0] && rcsMin.FromMode == 3)
                    {
                        var minTime = rcsMin.CreateTime - time[0];
                        second += minTime.TotalMinutes;
                    }

                    //结束时间在自动时间范围内，，再下一次时间节点时，加上差值
                    var rcsMax = rcsList[rcsList.Count - 1];
                    if (time[1] > rcsMax.CreateTime && rcsMax.ToMode == 3)
                    {
                        var rcsfirst = rcs.Where(t => t.CraneName == item.Name && t.CreateTime >= rcsMax.CreateTime).FirstOrDefault();
                        if (rcsfirst != null)
                        {
                            var maxTime = rcsfirst.CreateTime - rcsMax.CreateTime;
                            second += maxTime.TotalMinutes;
                        }
                        else
                        {
                            if (time[1] > DateTime.Now)
                            {
                                var maxTime = DateTime.Now - rcsMax.CreateTime;
                                second += maxTime.TotalMinutes;
                            }
                            else
                            {
                                var maxTime = time[1] - rcsMax.CreateTime;
                                second += maxTime.TotalMinutes;
                            }
                        }
                    }
                }
                //如果中间是很长一段自动或者手动，没有日志写入时，需要去查找最近的一条数据
                if (rcsList.Count==0) 
                {
                    var rcsList2 =await rcs.Where(t => t.CraneName == item.Name && t.CreateTime < time[0]).OrderByDescending(t => t.CreateTime).FirstOrDefaultAsync();
                    if (rcsList2!=null && rcsList2.ToMode == 3)
                    {
                        var minTime = time[1]- time[0];
                        second += minTime.TotalMinutes;
                    }
                }

                WorkModel work = new()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Mode3Time = Convert.ToInt64(second),
                    Mode1Time = 0,
                    Mode1TimePercent = (Convert.ToInt64(second) / (time[1] - time[0]).TotalMinutes) * 100
                };
                workModelsList.Add(work);
            }
            var result = new PageResult<WorkModel>();
            result.Success = true;
            result.Data = workModelsList;
            result.Message = "查询手动自动时长成功！";
            return result;

        }
    }
}












