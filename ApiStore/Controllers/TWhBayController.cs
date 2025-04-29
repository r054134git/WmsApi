using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("store/[controller]/[action]")]
	public class TWhBayController : EntityControllerBase<TWhBay, TWhBayReadModel, TWhBayCreateModel, TWhBayUpdateModel>
	{
		public TWhBayController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhBayCreateModel> createValidator, IValidator<TWhBayUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}

		/// <summary>
		/// 获取所有的跨列表
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<PageResult<TWhBayReadModel>>> GetAllList(CancellationToken cancellationToken)
		{
			var query = GetQueryOrderByIdDesc(null);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}


		[HttpGet("")]
		public async Task<ActionResult<PageResult<TWhBayReadModel>>> GetAllBays(CancellationToken cancellationToken)
		{
			var predicate = ExpressionBuilder.True<TWhBay>();
			var query = GetQueryOrderByIdDesc(predicate);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}

		[HttpGet("")]
		public async Task<ActionResult<PageResult<TWhBayReadModel>>>
			GetBayInfo(List<int> bayNoList, CancellationToken cancellationToken)
		{
			var predicate = ExpressionBuilder.True<TWhBay>();
			predicate = predicate.And(t => bayNoList.Contains(t.No));
			var query = GetQueryOrderByIdAsc(predicate);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}
	}
}
