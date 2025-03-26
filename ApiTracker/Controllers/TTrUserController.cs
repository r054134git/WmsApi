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
	[Route("tracker/[controller]/[action]")]
	public class TTrUserController : EntityControllerBase<TTrUser, TTrUserReadModel, TTrUserCreateModel, TTrUserUpdateModel>
	{
		public TTrUserController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrUserCreateModel> createValidator, IValidator<TTrUserUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
