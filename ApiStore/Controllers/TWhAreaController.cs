using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Wms.Telegram;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("store/[controller]/[action]")]
    public class TWhAreaController : EntityControllerBase<TWhArea, TWhAreaReadModel, TWhAreaCreateModel, TWhAreaUpdateModel>
    {
        public TWhAreaController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhAreaCreateModel> createValidator, IValidator<TWhAreaUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [TokenActionFilter]
        [HttpPost("")]
        public override async Task<ActionResult<OperationResult>> Create(TWhAreaCreateModel createModel, CancellationToken cancellationToken)
        {
            var userAccount = User.GetUserName();
            var operationResult = await CanCreate(createModel, cancellationToken);
            if (!operationResult.Success)
            {
                return operationResult;
            }
            SetCreateModelBasic(createModel);

            // validate model
            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);

            // create new entity from model
            var entity = Mapper.Map<TWhArea>(createModel);

            // add to data set, id should be generated
            await DataContext
                .Set<TWhArea>()
                .AddAsync(entity, cancellationToken);

            // save to database
            var count = await DataContext
                .SaveChangesAsync(cancellationToken);
            if (count > 0)
            {
                var mbs = ServiceProvider.GetService<MbsProxy>();
                TeleWMBM20 tele20 = new TeleWMBM20
                {
                    Payload = new LocationAreaInfo
                    {
                        OperationMark = "E",
                        House = createModel.OwnerBussinessName,
                        BayAreaNo = createModel.Name.Replace("-", "").Replace("区", ""),
                        Operator = userAccount,
                        CreateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
                    }
                };
                await mbs.Publish(tele20);
            }
            return operationResult;
        }


        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhAreaReadModel>>>
            GetListOfBay(string bayId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhArea>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(t => t.OwnerId == bayId);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }
        /// <summary>
        /// 创建库区域
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> SendMesInfo(string ownerBussinessName, string bayArea, string user, CancellationToken cancellationToken)
        {
            var mbs = ServiceProvider.GetService<MbsProxy>();
            TeleWMBM20 tele20 = new TeleWMBM20
            {
                Payload = new LocationAreaInfo
                {
                    OperationMark = "E",
                    House = ownerBussinessName,
                    BayAreaNo = bayArea,
                    Operator = user,
                    CreateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
                }
            };
            await mbs.Publish(tele20);
            return new OperationResult(true, "");
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhAreaReadModel>>>
            GetListOfBayList([FromQuery] string[] bayIds, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TWhArea>();
            if (bayIds != null && bayIds.Length > 1)
            {
                predicate = predicate.And(t => bayIds.Contains(t.OwnerId));
                var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.OwnerId).ThenBy(t => t.Code);
                var listResult = await QueryListModel(query, cancellationToken);
                return Ok(listResult);
            }

            var singleBayId = bayIds?.FirstOrDefault();
            if (!singleBayId.IsValidValue())
            {
                var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.OwnerId).ThenBy(t => t.Code);

                var listResult = await QueryListModel(query, cancellationToken);
                return Ok(listResult);
            }

            predicate = predicate.And(t => t.OwnerId == singleBayId);
            {
                var query = GetQueryOrderByIdDesc(predicate).OrderBy(t => t.OwnerId).ThenBy(t => t.Code);
                var listResult = await QueryListModel(query, cancellationToken);
                return Ok(listResult);
            }
        }

        /// <summary>
        /// 区域筛选
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TWhAreaReadModel>>> GetPageQuery([FromQuery] PageParam pageParam, [FromQuery] string[] ownerId, [FromQuery] int[] isVirtual, [FromQuery] int[] isEnable, CancellationToken cancellationToken)
        {
            try
            {
                var predicate = ExpressionBuilder.True<TWhArea>();
                if (ownerId.Length > 0 && ownerId != null)
                {
                    predicate = predicate.And(t => ownerId.Contains(t.OwnerId));
                }
                if (isVirtual.Length > 0 && isVirtual != null)
                {
                    predicate = predicate.And(t => isVirtual.Contains(t.IsVirtual));
                }
                if (isEnable.Length > 0 && isEnable != null)
                {
                    predicate = predicate.And(t => isEnable.Contains(t.IsEnable));
                }
                var query = GetQueryOrderByIdAsc(predicate).OrderBy(t => t.OwnerId).ThenBy(t => t.Code);
                //.OrderByDescending(t => t.Id).Include(t => t.TeamTScDictionary).Include(T => T.RoleTUmRole);
                var listResult = await QueryPageModel(query, pageParam, cancellationToken);

                return Ok(listResult);
            }
            catch (Exception ex)
            {
                return NoContent();
            }

        }
    }
}
