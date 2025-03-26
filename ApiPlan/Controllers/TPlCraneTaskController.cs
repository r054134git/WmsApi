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
        /// ��ȡ�г����������б�
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
        /// �ֳֶ����������
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
        /// �ͻ��˶����������
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> UpdateTaskFrozon(string id, bool frozon, CancellationToken cancellationToken)
        {
            if (id.IsValidValue())
            {
                var predicate = DataContext.Set<TPlCraneTask>();
                var result = predicate.Where(x => x.Id == id).FirstOrDefault();
                var taskName = frozon ? "��������" : "ȡ����������";
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
                        return new OperationResult(true, $"{taskName}�ɹ���");
                    }
                }
                return new OperationResult(false, $"{taskName}ʧ�ܡ�");
            }
            return new OperationResult(false, $"idΪ�ա�");
        }

        /// <summary>
        /// ���������г�
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
                        return new OperationResult(true, $"���������г��ɹ���");
                    }
                }
                return new OperationResult(false, $"û�в�ѯ��������");
            }
            return new OperationResult(false, $"idΪ�ա�");
        }


    }
}
