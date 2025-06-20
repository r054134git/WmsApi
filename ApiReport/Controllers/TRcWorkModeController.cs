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
        /// �Զ��ֶ���ҵʱ��
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<WorkModel>>> GetWorkModeList([FromQuery] DateTime[] time, CancellationToken cancellationToken)
        {
            //3 �Զ���1 �ֶ�
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
                    //��ʼʱ�����Զ�ʱ�䷶Χ�ڣ�������һ��ʱ��ڵ�ʱ�����ϲ�ֵ�����һ��ʱ����бȽ�
                    var rcsMin = rcsList[0];
                    if (rcsMin.CreateTime > time[0] && rcsMin.FromMode == 3)
                    {
                        var minTime = rcsMin.CreateTime - time[0];
                        second += minTime.TotalMinutes;
                    }

                    //����ʱ�����Զ�ʱ�䷶Χ�ڣ�������һ��ʱ��ڵ�ʱ�����ϲ�ֵ
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
                //����м��Ǻܳ�һ���Զ������ֶ���û����־д��ʱ����Ҫȥ���������һ������
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
            result.Message = "��ѯ�ֶ��Զ�ʱ���ɹ���";
            return result;

        }
    }
}












