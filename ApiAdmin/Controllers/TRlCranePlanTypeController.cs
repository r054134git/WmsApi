using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("admin/[controller]/[action]")]
    public class TRlCranePlanTypeController : EntityControllerBase<TRlCranePlanType, TRlCranePlanTypeReadModel, TRlCranePlanTypeCreateModel, TRlCranePlanTypeUpdateModel>
    {
        public TRlCranePlanTypeController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRlCranePlanTypeCreateModel> createValidator, IValidator<TRlCranePlanTypeUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [TokenActionFilter]
        [HttpPut("{id}")]
        public override async Task<ActionResult<OperationResult>> Update(string id, TRlCranePlanTypeUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);

            // validate model
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

            // primary key
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TRlCranePlanType>()
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
            {
                return new OperationResult(false, "数据不存在，更新失败。");
            }

            SetRcLog(updateModel, entity);
            // copy updates from model to entity
            Mapper.Map(updateModel, entity);

            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return new OperationResult(true, "数据更新成功。");
        }

        protected void SetRcLog(TRlCranePlanTypeUpdateModel updateModel, TRlCranePlanType entity)
        {
            List<string> preEdit = new()
            {
                entity.PlanTypeName1,
                entity.PlanTypeName2,
                entity.PlanTypeName3,
                entity.PlanTypeName4,
                entity.PlanTypeName5,
                entity.PlanTypeName6,
                entity.PlanTypeName7,
                entity.PlanTypeName8,
                entity.PlanTypeName9,
                entity.PlanTypeName10,
                entity.PlanTypeName11,
                entity.PlanTypeName12,
            };
            var preEditStr = string.Join(",", preEdit.Where(x => !string.IsNullOrEmpty(x)).ToArray());

            List<string> afterEdit = new()
            {
                updateModel.PlanTypeName1,
                updateModel.PlanTypeName2,
                updateModel.PlanTypeName3,
                updateModel.PlanTypeName4,
                updateModel.PlanTypeName5,
                updateModel.PlanTypeName6,
                updateModel.PlanTypeName7,
                updateModel.PlanTypeName8,
                updateModel.PlanTypeName9,
                updateModel.PlanTypeName10,
                updateModel.PlanTypeName11,
                updateModel.PlanTypeName12,
            };
            var afterEditStr = string.Join(",", afterEdit.Where(x => !string.IsNullOrEmpty(x)).ToArray());

            var repoLog = DataContext.Set<TRcLog>();
            var log = new TRcLog
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Dt = DateTime.Now,
                EventNo = "1000",
                Source = "API",
                WarningLevel = "INFO",
                Message = $"{entity.CraneName}分配吊运类型变更前为{preEditStr}，变更后为{afterEditStr}"
            };
            repoLog.Add(log);
        }

    }
}
