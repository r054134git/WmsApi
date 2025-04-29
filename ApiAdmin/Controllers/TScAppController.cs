using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;


namespace WmsApi.Controllers
{
    [ApiController]
    [Route("admin/[controller]/[action]")]
    public class TScAppController : EntityControllerBase<TScApp,TScAppReadModel,TScAppCreateModel,TScAppUpdateModel>
    {
        public TScAppController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TScAppCreateModel> createValidator, IValidator<TScAppUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
		/// <summary>
		/// 手持终端版本号
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<TScAppReadModel>> GetHoldApp(CancellationToken cancellationToken)
		{
			var predicate = ExpressionBuilder.True<TScApp>();
			predicate = predicate.And(x => x.AppType == "hold");
			var query = GetQueryOrderByIdDesc(predicate);
			var result = await ReadModel(query, cancellationToken);
			return Ok(result);
		}

		/// <summary>
		/// 车载终端版本号
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<TScAppReadModel>> GetCraneApp(CancellationToken cancellationToken)
		{
			var predicate = ExpressionBuilder.True<TScApp>();
			predicate = predicate.And(x => x.AppType == "crane");
			var query = GetQueryOrderByIdDesc(predicate);
			var result = await ReadModel(query, cancellationToken);
			return Ok(result);
		}
	}
}
