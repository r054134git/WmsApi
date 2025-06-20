using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("auth/[controller]/[action]")]
	public class LoginController : EntityControllerBase<TUmUser, TUmUserReadModel, TUmUserCreateModel, TUmUserUpdateModel>
	{
		public LoginController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TUmUserCreateModel> createValidator, IValidator<TUmUserUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}

		[HttpPost()]
		public async Task<ActionResult<LoginResultModel>> Login(string userName, string password)
		{
			if (!password.IsValidValue())
			{
				return new LoginResultModel { IsSucceed = false, Message = "密码不能为空" };
			}

			var predicate = ExpressionBuilder.True<TUmUser>();
			predicate = predicate.And(x => x.Account == userName && x.Password == password);
			var query = GetQueryOrderByIdDesc(predicate);
			var user = await ReadModel(query);
			if (user == null)
			{
				return new LoginResultModel { IsSucceed = false, Message = "用户名密码不匹配" };
			}
			else
			{
				var jwt = Jwt.GetToken("admin", user.Account, true);
				//var userFunctions = await _permissionGetUserPermission(user.Id);
				var role = DataContext.Set<TUmRole>().FirstOrDefault(t => t.Id == user.RoleId);
				var defaultBay = DataContext.Set<TWhBay>().FirstOrDefault(t => t.Name.Contains("16"));
				if (role == null)
				{
					return new LoginResultModel
					{
						IsSucceed = false,
					};
				}
				var rps = DataContext.Set<TUmRolePermission>()
					.Where(t => t.RoleId == user.RoleId).Select(t => t.PermissionId).ToList();
				var menus = DataContext.Set<TUmMenu>()
					.Where(t => rps.Contains(t.Id)).Select(t => t.Path).ToList();

				return new LoginResultModel
				{
					IsSucceed = true,
					Message = "登录成功",
					userId = user.Id,
					Name = user.Name,
					Account=user.Account,
					IsAdmin = user.Name.Equals("admin"),
					Role = role.Name,
					Department = user.Department,
					DefaultBayId = defaultBay.Id,
					DefaultBayName = defaultBay.Code,
					Token = jwt,
					CurrentAuthority = menus.ToArray(),
				};
			}
		}
	}
}
