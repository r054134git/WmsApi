using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain.Entities;
using WmsApi.Domain;
using System.Threading.Tasks;
using System.Threading;
using WmsApi;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MassTransit;
using WmsApi.Utils;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlStackTranferController : EntityControllerBase<TPlStackTranfer, TPlStackTranferReadModel, TPlStackTranferCreateModel, TPlStackTranferUpdateModel>
    {
        public TPlStackTranferController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlStackTranferCreateModel> createValidator, IValidator<TPlStackTranferUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [TokenActionFilter]
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> CreateStack(TPlStackTranferCreateModel createModel, CancellationToken cancellationToken)
        {
            var operationResult = await CanCreate(createModel, cancellationToken);
            if (!operationResult.Success)
            {
                return operationResult;
            }
            SetCreateModelBasic(createModel);

            // validate model
            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);


            var (minX, minY) = await GetStackXY(createModel.AreaId, createModel.StartStackId, createModel.StartColId);
            var (maxX, maxY) = await GetStackXY(createModel.AreaId, createModel.EndStackId, createModel.EndColId);

            createModel.FromPointX = minX;
            createModel.FromPointY = minY;

            createModel.DestPointX = maxX;
            createModel.DestPointY = maxY;
            if (createModel.Type == 1)
            {
                createModel.MaterialNoList = "";
            }
            

            // create new entity from model
            var entity = Mapper.Map<TPlStackTranfer>(createModel);

            // add to data set, id should be generated
            await DataContext
                .Set<TPlStackTranfer>()
                .AddAsync(entity, cancellationToken);

            // save to database
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return operationResult;
        }


        [TokenActionFilter]
        [HttpPut("{id}")]
        public async Task<ActionResult<OperationResult>> UpdateStack(string id, TPlStackTranferUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);

            // validate model
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

            // primary key
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TPlStackTranfer>()
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
            {
                return new OperationResult(false, "数据已经存在，更新失败。");
            }

            var (minX, minY) = await GetStackXY(updateModel.AreaId, updateModel.StartStackId, updateModel.StartColId);
            var (maxX, maxY) = await GetStackXY(updateModel.AreaId, updateModel.EndStackId, updateModel.EndColId);

            updateModel.FromPointX = minX;
            updateModel.FromPointY = minY;

            updateModel.DestPointX = maxX;
            updateModel.DestPointY = maxY;
            if (updateModel.Type == 1)
            {
                updateModel.MaterialNoList = "";
            }
            // copy updates from model to entity
            Mapper.Map(updateModel, entity);

            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return new OperationResult(true, "数据更新成功。");
        }


        /// <summary>
        /// 查询坐标范围
        /// </summary>
        /// <returns></returns>
        private async Task<(decimal, decimal)> GetStackXY(string AreaId, string stackId, string colId)
        {
            var stackNo = await GetStackNo(stackId);
            var locationcolNo = await GetLocationColNo(colId);

            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var predicate = ExpressionBuilder.True<TTrLocationMaterial>();
            if (AreaId.IsValidValue())
            {
                predicate = predicate.And(t => t.AreaId == AreaId);
            }
            predicate = predicate.And(t => t.IsEnable == 1 && t.FloorNo == 1);
            predicate = predicate.And(t => t.RowNo == stackNo);
            predicate = predicate.And(t => t.ColNo == locationcolNo);
            var query = dbSet.AsNoTracking();
            var listResult = await query.Where(predicate).FirstOrDefaultAsync();
            return (listResult.PointX, listResult.PointY);
        }


        /// <summary>
        /// 查询行号
        /// </summary>
        /// <returns></returns>
        private async Task<int> GetStackNo(string stackId)
        {
            var dbSet = DataContext.Set<TWhStack>();
            var firstStack = await dbSet.AsNoTracking().Where(t => t.Id == stackId).FirstOrDefaultAsync();
            if (firstStack != null)
            {
                return firstStack.StackNo;
            }
            return 0;
        }

        /// <summary>
        /// 查询列号
        /// </summary>
        /// <returns></returns>
        private async Task<int> GetLocationColNo(string locationId)
        {
            var dbSet = DataContext.Set<TWhLocation>();
            var firstStack = await dbSet.AsNoTracking().Where(t => t.Id == locationId).FirstOrDefaultAsync();
            if (firstStack != null)
            {
                return firstStack.ColNo;
            }
            return 0;
        }


        [TokenActionFilter]
        [HttpDelete]
        public async Task<ActionResult<OperationResult>> DeleteStack([FromQuery] string[] ids, CancellationToken cancellationToken)
        {
            var dbSet = DataContext.Set<TPlStackTranfer>();
            var repoLog = DataContext.Set<TRcLog>();
            var idsString = string.Join(",", ids);
            try
            {
                foreach (var id in ids)
                {
                    var entity = await dbSet
                        .FindAsync(new[] { id }, cancellationToken);
                    if (entity == null)
                    {
                        return new OperationResult(false, $"id {idsString} 的数据不存在！");
                    }
                    dbSet.Remove(entity);

                    var mess = $"批量倒垛/备料操作：删除，id：{entity.Id}，计划类型:{entity.Type}，起点垛位{entity.StartStackId}，终点垛位{entity.EndStackId}";
                    var log = RevLogMessage.RevLog(mess);
                    repoLog.Add(log);
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
        /// 批量启用/禁用
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        [TokenActionFilter]
        public async Task<ActionResult<OperationResult>>
            UpdateIsabled([FromQuery] string[] ids, int isEnable, CancellationToken cancellationToken)
        {
            var locations = DataContext.Set<TPlStackTranfer>();
            var repoLog = DataContext.Set<TRcLog>();
            var identityName = User.GetUserName();
            var isE = isEnable == 1 ? "启用" : "禁用";
            foreach (var item in ids)
            {
                var model = locations.Where(t => t.Id == item).FirstOrDefault();
                model.IsEnable = isEnable;
                model.UpdateTime = DateTime.Now;
                model.UpdateUser = identityName;

                var mess = $"批量倒垛/备料操作：{isE}，id：{model.Id}，计划类型:{model.Type}，起点垛位{model.StartStackId}，终点垛位{model.EndStackId}";
                var log = RevLogMessage.RevLog(mess);
                repoLog.Add(log);
            }
            var count = await DataContext.SaveChangesAsync(cancellationToken);
            return count > 0 ? new OperationResult(true, $"数据{isE}成功。") : new OperationResult(false, $"数据{isE}失败。");
        }

        /// <summary>
        /// 批量重置
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        [TokenActionFilter]
        public async Task<ActionResult<OperationResult>>
            UpdateReset([FromQuery] string[] ids, CancellationToken cancellationToken)
        {
            var locations = DataContext.Set<TPlStackTranfer>();
            var repoLog = DataContext.Set<TRcLog>();
            var identityName = User.GetUserName();
            foreach (var item in ids)
            {
                var model = locations.Where(t => t.Id == item).FirstOrDefault();
                model.TodoCount = model.PlanCount;
                model.UpdateTime = DateTime.Now;
                model.UpdateUser = identityName;

                var mess = $"批量倒垛/备料操作：重置，id：{model.Id}，计划类型:{model.Type}，起点垛位{model.StartStackId}，终点垛位{model.EndStackId}";
                var log = RevLogMessage.RevLog(mess);
                repoLog.Add(log);
            }
            var count = await DataContext.SaveChangesAsync(cancellationToken);
            return count > 0 ? new OperationResult(true, $"数据重置成功。") : new OperationResult(false, $"数据重置失败。");
        }
    }
}
