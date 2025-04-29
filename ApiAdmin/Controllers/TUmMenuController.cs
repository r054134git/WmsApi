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
	public class TUmMenuController : EntityControllerBase<TUmMenu, TUmMenuReadModel, TUmMenuCreateModel, TUmMenuUpdateModel>
	{
		public TUmMenuController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TUmMenuCreateModel> createValidator, IValidator<TUmMenuUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}

		/// <summary>
		/// 获取所有ownerid为空（即菜单文件夹）的数据列表
		/// </summary>
		[HttpGet("")]
		public async Task<ActionResult<PageResult<TUmMenuReadModel>>> GetAllFolderList(CancellationToken cancellationToken)
		{
			var query = GetQueryOrderByIdDesc(t => t.IsRouter == 0);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}

		/// <summary>
		/// 获取所有的菜单列表
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public virtual async Task<ActionResult<PageResult<TUmMenuReadModel>>> GetAllList(CancellationToken cancellationToken)
		{
			var query = GetQueryOrderByIdDesc(null);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}
	}
}
