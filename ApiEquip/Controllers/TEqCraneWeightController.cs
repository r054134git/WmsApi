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
	[Route("equip/[controller]/[action]")]
	public class TEqCraneWeightController : EntityControllerBase<TEqCraneWeight, TEqCraneWeightReadModel, TEqCraneWeightCreateModel, TEqCraneWeightUpdateModel>
	{
		public TEqCraneWeightController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqCraneWeightCreateModel> createValidator, IValidator<TEqCraneWeightUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
