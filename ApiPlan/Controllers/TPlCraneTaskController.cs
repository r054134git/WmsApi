using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ucp.Contracts;
using WmsApi;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using Z.EntityFramework.Plus;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlCraneTaskController : EntityControllerBase<TPlCraneTask, TPlCraneTaskReadModel, TPlCraneTaskCreateModel, TPlCraneTaskUpdateModel>
    {
        public TPlCraneTaskController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlCraneTaskCreateModel> createValidator, IValidator<TPlCraneTaskUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 获取行车吊运任务列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlCraneTaskReadModel>>> GetAllTaskList(string bayId, string craneId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlCraneTask>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(x => x.BayId == bayId);
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 手持冻结吊运任务
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<int>> UpdateTaskState(string bayId, string materialNo, CancellationToken cancellationToken)
        {
            var predicate = DataContext.Set<TPlCraneTask>();
            if (materialNo.IsValidValue())
            {
                var result = predicate.Where(x => x.BayId == bayId && x.MaterialNo == materialNo).FirstOrDefault();
                if (result != null)
                {
                    if (result.IsEnable == 1)
                    {
                        result.IsEnable = 0;
                    }
                    else
                    {
                        result.IsEnable = 1;
                    }
                }
                var count = await DataContext.SaveChangesAsync();
                if (count > 0)
                {
                    var mbs = ServiceProvider.GetService<MbsProxy>();
                    var taskFrozon = new TaskFrozon()
                    {
                        TaskNo = result.TaskNo,
                        MaterialNo = result.MaterialNo,
                        FrozonType = true
                    };
                    await mbs.Publish(taskFrozon);
                    return Ok(1);
                }
            }
            return null;
        }


        /// <summary>
        /// 客户端冻结吊运任务
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> UpdateTaskFrozon(string id, bool frozon, CancellationToken cancellationToken)
        {
            if (id.IsValidValue())
            {
                var predicate = DataContext.Set<TPlCraneTask>();
                var result = predicate.Where(x => x.Id == id).FirstOrDefault();
                var taskName = frozon ? "冻结任务" : "取消冻结任务";
                if (result != null)
                {
                    result.IsFrozon = frozon ? 1 : 0;
                    var count = await DataContext.SaveChangesAsync(cancellationToken);
                    if (count > 0)
                    {
                        var mbs = ServiceProvider.GetService<MbsProxy>();
                        var taskFrozon = new TaskFrozon()
                        {
                            TaskNo = result.TaskNo,
                            MaterialNo = result.MaterialNo,
                            FrozonType = frozon
                        };
                        await mbs.Publish(taskFrozon);
                        return new OperationResult(true, $"{taskName}成功。");
                    }
                }
                return new OperationResult(false, $"{taskName}失败。");
            }
            return new OperationResult(false, $"id为空。");
        }

        /// <summary>
        /// 发送其它行车
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> UpdateUserCraneId(string id, string craneId, CancellationToken cancellationToken)
        {
            if (id.IsValidValue())
            {
                var predicate = DataContext.Set<TPlCraneTask>();
                var result = predicate.Where(x => x.Id == id).FirstOrDefault();
                if (result != null)
                {
                    result.UserCraneId = craneId;
                    var count = await DataContext.SaveChangesAsync(cancellationToken);
                    if (count > 0)
                    {
                        var mbs = ServiceProvider.GetService<MbsProxy>();
                        var taskKey = new Key(result.Id, result.TaskNo, 0);
                        var payLoad = new MttTaskUpdated()
                        {
                            TaskKey = taskKey
                        };
                        await mbs.Publish(payLoad);
                        return new OperationResult(true, $"发送其它行车成功。");
                    }
                }
                return new OperationResult(false, $"没有查询到该任务。");
            }
            return new OperationResult(false, $"id为空。");
        }


    }
}
