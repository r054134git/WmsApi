using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("admin/[controller]/[action]")]
	public class TUmPermissionController : EntityControllerBase<TUmPermission, TUmPermissionReadModel, TUmPermissionCreateModel, TUmPermissionUpdateModel>
	{
		public TUmPermissionController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TUmPermissionCreateModel> createValidator, IValidator<TUmPermissionUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
