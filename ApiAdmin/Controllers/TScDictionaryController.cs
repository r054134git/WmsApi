using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("admin/[controller]/[action]")]
	public class TScDictionaryController : EntityControllerBase<TScDictionary, TScDictionaryReadModel, TScDictionaryCreateModel, TScDictionaryUpdateModel>
	{
		public TScDictionaryController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TScDictionaryCreateModel> createValidator, IValidator<TScDictionaryUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{

		}

		/// <summary>
		/// 获取所有owner为空（即字典分类）的数据列表
		/// </summary>
		/// <param name="ownerValue"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public async Task<ActionResult<PageResult<TScDictionaryReadModel>>> GetAllClassList(CancellationToken cancellationToken)
		{
			var query = GetQueryOrderByIdDesc(t => t.Owner == "" || t.Owner == null);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}

		[HttpGet("")]
		public async Task<ActionResult<PageResult<TScDictionaryReadModel>>> GetListQuery([FromQuery] string[] ownerValue, CancellationToken cancellationToken)
		{
			var predicate = ExpressionBuilder.True<TScDictionary>();
			if (ownerValue != null && ownerValue.Length > 1)
			{
				predicate = predicate.And(t => ownerValue.Contains(t.Value));
				var query = GetQueryOrderByIdDesc(predicate).Include(t => t.OwnerTScDictionary).OrderBy(t => t.Seq);
				var listResult = await QueryListModel(query, cancellationToken);
				return Ok(listResult);
			}

			var singleOwnerValue = ownerValue?.FirstOrDefault();
			if (!singleOwnerValue.IsValidValue())
			{
				var query = GetQueryOrderByIdDesc(predicate).Include(t => t.OwnerTScDictionary).OrderBy(t => t.Seq);

				var listResult = await QueryListModel(query, cancellationToken);
				return Ok(listResult);
			}

			predicate = predicate.And(t => t.Value == singleOwnerValue);
			var ownerItem = await ReadModel(predicate, cancellationToken);
			if (ownerItem != null)
			{
				var query = GetQueryOrderByIdDesc(t => t.Owner == ownerItem.Id)
					.Include(t => t.OwnerTScDictionary).OrderBy(t => t.Seq);

				var listResult = await QueryListModel(query, cancellationToken);

				return Ok(listResult);
			}
			return NotFound();
		}

		/// <summary>
		/// 各库产线列表
		/// </summary>
		[HttpGet("")]
		public async Task<ActionResult<PageResult<TScDictionaryReadModel>>> GetChainPage(string bayName, CancellationToken cancellationToken)
        {
			var predicate = ExpressionBuilder.True<TScDictionary>();
			if (bayName.IsValidValue())
			{
				var bayCode = bayName.Substring(0, 2);
				predicate = predicate.And(t => t.Key.Contains(bayCode) && t.Owner == "3");
			}
			var query = GetQueryOrderByIdAsc(predicate);
			var listResult = await QueryListModel(query, cancellationToken);
			return Ok(listResult);
		}
	}
}
