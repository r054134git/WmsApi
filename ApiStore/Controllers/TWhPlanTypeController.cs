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
	public class TWhPlanTypeController : EntityControllerBase<TWhPlanType, TWhPlanTypeReadModel, TWhPlanTypeCreateModel, TWhPlanTypeUpdateModel>
	{
		public TWhPlanTypeController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhPlanTypeCreateModel> createValidator, IValidator<TWhPlanTypeUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
