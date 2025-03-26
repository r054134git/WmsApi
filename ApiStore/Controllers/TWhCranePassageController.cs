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
	public class TWhCranePassageController : EntityControllerBase<TWhCranePassage, TWhCranePassageReadModel, TWhCranePassageCreateModel, TWhCranePassageUpdateModel>
	{
		public TWhCranePassageController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhCranePassageCreateModel> createValidator, IValidator<TWhCranePassageUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
