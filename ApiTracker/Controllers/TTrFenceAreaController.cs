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
	public class TTrFenceAreaController : EntityControllerBase<TTrFenceArea, TTrFenceAreaReadModel, TTrFenceAreaCreateModel, TTrFenceAreaUpdateModel>
	{
		public TTrFenceAreaController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrFenceAreaCreateModel> createValidator, IValidator<TTrFenceAreaUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
