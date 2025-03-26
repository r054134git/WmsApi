using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("admin/[controller]/[action]")]
	public class TUmRoleController : EntityControllerBase<TUmRole, TUmRoleReadModel, TUmRoleCreateModel, TUmRoleUpdateModel>
	{
		public TUmRoleController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TUmRoleCreateModel> createValidator, IValidator<TUmRoleUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}

		/// <summary>
		/// 获取所有的角色列表
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public virtual async Task<ActionResult<PageResult<TUmRoleReadModel>>> GetAllList(string order, CancellationToken cancellationToken)
		{
			var query = GetQueryOrderByIdDesc(null);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}
	}
}
