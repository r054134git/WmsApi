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
	[Route("store/[controller]/[action]")]
	public class TWhTruckPassageController : EntityControllerBase<TWhTruckPassage, TWhTruckPassageReadModel, TWhTruckPassageCreateModel, TWhTruckPassageUpdateModel>
	{
		public TWhTruckPassageController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhTruckPassageCreateModel> createValidator, IValidator<TWhTruckPassageUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
