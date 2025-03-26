using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("admin/[controller]/[action]")]
    public class TScTransferTerminalController : EntityControllerBase<TScTransferTerminal, TScTransferTerminalReadModel, TScTransferTerminalCreateModel, TScTransferTerminalUpdateModel>
    {
        public TScTransferTerminalController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TScTransferTerminalCreateModel> createValidator, IValidator<TScTransferTerminalUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {

        }

        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> UpdateList([FromQuery] string[] ids, string cityName, int operateType, CancellationToken cancellationToken)
        {
            var entity = DataContext.Set<TScTransferTerminal>();
            var list = entity.Where(t => ids.Contains(t.Id)).ToList();
            if (list.Count > 0)
            {
                list.ForEach(t =>
                {
                    if (operateType == 0)
                    {
                        t.BelongCityName = "";
                    }
                    else
                    {
                        t.BelongCityName = cityName;
                    }
                    entity.Update(t);
                });
            }

            // copy updates from model to entity
            //Mapper.Map(updateModel, entity);

            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return new OperationResult(true, "数据更新成功。");
        }

        public override async Task<ActionResult<OperationResult>> Delete([FromQuery] string[] ids, CancellationToken cancellationToken)
        {
            var dbSet = DataContext
                .Set<TScTransferTerminal>();

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
                    var list = dbSet.Where(t => t.BelongCityName == entity.CityName);
                    if (list.Any())
                    {
                        foreach (var update in list)
                        {
                            update.BelongCityName = "";
                            dbSet.Update(update);
                        }
                    }
                }
                // save
                await DataContext
                    .SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                return new OperationResult(false, ex.Message);
            }

            return new OperationResult(true, $"id {idsString} 的数据删除成功！");
        }

        /// <summary>
        /// 码头/左侧
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<TScTransferTerminalReadModel>>>
        GetAllTransferSpecLeft([FromQuery] PageParam pageParam, string cityName, int? isEnable, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TScTransferTerminal>();
            //按照码头名称查询
            if (!string.IsNullOrEmpty(cityName))
            {
                predicate = predicate.And(t => t.CityName.Contains(cityName));
            }
            if (isEnable != null)
            {
                predicate = predicate.And(t => t.IsEnable == isEnable);
            }
            predicate = predicate.And(t => string.IsNullOrEmpty(t.BelongCityName));
            var query = GetQueryOrderByIdDesc(predicate).Distinct().OrderByDescending(t => t.CityName);
            var listResult = await QueryPageModel(query, pageParam);
            return Ok(listResult);
        }

        /// <summary>
        /// 码头/右侧
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult<List<TScTransferTerminalReadModel>>>>
            GetAllTransferSpecRight(string belongCityName, CancellationToken cancellationToken)
        {
            var query = DataContext.Set<TScTransferTerminal>().AsNoTracking().Where(t => t.BelongCityName.Equals(belongCityName) && !string.IsNullOrEmpty(t.Code) && t.IsEnable == 1);
            var trs = await query.ProjectTo<TScTransferTerminalReadModel>(Mapper.ConfigurationProvider)
                                                   .ToListAsync(cancellationToken);
            return new OperationResult<List<TScTransferTerminalReadModel>>(true, "", trs);
        }

        /// <summary>
        /// 查询码头名称
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<TScTransferTerminalReadModel>> GetCodeName(string code, CancellationToken cancellationToken)
        {
            var repoTf = DataContext.Set<TScTransferTerminal>();
            var terminal = repoTf.AsNoTracking().Where(t => t.Code == code);
            var listResult = await ReadModel(terminal, cancellationToken);
            return Ok(terminal);
        }



        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> UpdateListIsEnable([FromQuery] string[] ids, int isEnable, CancellationToken cancellationToken)
        {
            var entity = DataContext.Set<TScTransferTerminal>();
            var list = entity.Where(t => ids.Contains(t.Id)).ToList();
            if (list.Count > 0)
            {
                list.ForEach(t =>
                {
                    t.IsEnable = isEnable;
                    entity.Update(t);
                });
            }
            await DataContext
                .SaveChangesAsync(cancellationToken);
            return new OperationResult(true, "数据更新成功。");
        }

    }
}
