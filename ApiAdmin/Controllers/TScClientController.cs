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
	public class TScClientController : EntityControllerBase<TScClient, TScClientReadModel, TScClientCreateModel, TScClientUpdateModel>
	{
		public TScClientController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TScClientCreateModel> createValidator, IValidator<TScClientUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
