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
	public class TUmRolePermissionController : EntityControllerBase<TUmRolePermission, TUmRolePermissionReadModel, TUmRolePermissionCreateModel, TUmRolePermissionUpdateModel>
	{
		public TUmRolePermissionController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TUmRolePermissionCreateModel> createValidator, IValidator<TUmRolePermissionUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}

		/// <summary>
		/// 获取所有的菜单列表
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
		public virtual async Task<ActionResult<PageResult<TUmMenuReadModel>>> GetAllListQuery(string roleId, CancellationToken cancellationToken)
		{
			var query = GetQueryOrderByIdDesc(t => t.RoleId == roleId);
			var listResult = await QueryListModel(query, cancellationToken);

			return Ok(listResult);
		}

		/// <summary>
		/// 获取所有的菜单列表
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpPost("")]
		public virtual async Task<ActionResult<PageResult<TUmMenuReadModel>>> AddRolePermissonList(string roleId, string[] permissions, CancellationToken cancellationToken)
		{
			var dbSet = DataContext.Set<TUmRolePermission>();
			var prevItems = dbSet.AsNoTracking().Where(t => t.RoleId == roleId);
			dbSet.RemoveRange(prevItems);
			foreach (var p in permissions)
			{
				dbSet.Add(new TUmRolePermission
				{
					Id = IdWorkerGenerator.Instance.NextId().ToString(),
					RoleId = roleId,
					PermissionId = p,
					CreateTime = DateTime.Now,
					CreateUser = "API",
					UpdateTime = DateTime.Now,
					UpdateUser = "API"
				});
			}
			// save updates
			await DataContext
				.SaveChangesAsync(cancellationToken);

			return Ok(default);
		}
	}
}
