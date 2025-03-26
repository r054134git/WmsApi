using AutoMapper;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("store/[controller]/[action]")]
    public class TWhStackController : EntityControllerBase<TWhStack, TWhStackReadModel, TWhStackCreateModel, TWhStackUpdateModel>
    {
        public TWhStackController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhStackCreateModel> createValidator, IValidator<TWhStackUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhStackReadModel>>> GetListOfArea(string areaId, StackTypes stackType, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhStack>();
            if (areaId.IsValidValue())
            {
                predicate = predicate.And(t => t.OwnerId == areaId);
            }
            if (stackType != StackTypes.All)
            {
                var type = (decimal)stackType;
                predicate = predicate.And(t => t.Type == type);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhStackReadModel>>> GetListOfAreaList([FromQuery] string[] areaIds, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhStack>();
            if (areaIds != null && areaIds.Length > 1)
            {
                predicate = predicate.And(t => areaIds.Contains(t.OwnerId));
                var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.BayId).ThenBy(t => t.AreaNo);
                var listResult = await QueryListModel(query, cancellationToken);
                return Ok(listResult);
            }

            var singleBayId = areaIds?.FirstOrDefault();
            if (!singleBayId.IsValidValue())
            {
                var query = GetQueryOrderByIdAsc(predicate).OrderBy(t => t.BayId).ThenBy(t=>t.AreaNo);

                var listResult = await QueryListModel(query, cancellationToken);
                return Ok(listResult);
            }

            predicate = predicate.And(t => t.OwnerId == singleBayId);
            {
                var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.BayId).ThenBy(t => t.AreaNo);
                var listResult = await QueryListModel(query, cancellationToken);
                return Ok(listResult);
            }
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhStackReadModel>>> GetListOfBay(string bayId, StackTypes stackType, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhStack>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(t => t.OwnerTWhArea.OwnerId == bayId);
            }
            if (stackType != StackTypes.All)
            {
                var type = (decimal)stackType;
                predicate = predicate.And(t => t.Type == type);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// ∂‚Œª…∏—°
        /// </summary>
        /// <param name="pageParam"></param>
        /// <param name="bayId"></param>
        /// <param name="ownerId"></param>
        /// <param name="orientation"></param>
        /// <param name="type"></param>
        /// <param name="isLockable"></param>
        /// <param name="loadOrder"></param>
        /// <param name="isEnable"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhStackReadModel>>> GetPageQuery([FromQuery] PageParam pageParam, [FromQuery] string[] bayId, [FromQuery] string[] ownerId, [FromQuery] int[] orientation, [FromQuery] int[] type, [FromQuery] int?[] isLockable, [FromQuery] int[] loadOrder, [FromQuery] int?[] isEnable, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhStack>();
            if (bayId.Length > 0 && bayId != null)
            {
                predicate = predicate.And(t => bayId.Contains(t.BayId));
            }
            if (ownerId.Length > 0 && ownerId != null)
            {
                predicate = predicate.And(t => ownerId.Contains(t.OwnerId));
            }
            if (orientation.Length > 0 && orientation != null)
            {
                predicate = predicate.And(t => orientation.Contains(t.Orientation));
            }
            if (type.Length > 0 && type != null)
            {
                predicate = predicate.And(t => type.Contains(t.Type));
            }
            if (isLockable.Length > 0 && isLockable != null)
            {
                predicate = predicate.And(t => isLockable.Contains(t.IsLockable));
            }
            if (loadOrder.Length > 0 && loadOrder != null)
            {
                predicate = predicate.And(t => loadOrder.Contains(t.LoadOrder));
            }
            if (isEnable.Length > 0 && isEnable != null)
            {
                predicate = predicate.And(t => isEnable.Contains(t.IsEnable));
            }
            var query = GetQueryOrderByIdAsc(predicate);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }
    }
}
