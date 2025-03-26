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
	public class TTrLocationMaterialEventController : EntityControllerBase<TTrLocationMaterialEvent, TTrLocationMaterialEventReadModel, TTrLocationMaterialEventCreateModel, TTrLocationMaterialEventUpdateModel>
	{
		public TTrLocationMaterialEventController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrLocationMaterialEventCreateModel> createValidator, IValidator<TTrLocationMaterialEventUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
