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
	public class TRlRegionRangeController : EntityControllerBase<TRlRegionRange, TRlRegionRangeReadModel, TRlRegionRangeCreateModel, TRlRegionRangeUpdateModel>
	{
		public TRlRegionRangeController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRlRegionRangeCreateModel> createValidator, IValidator<TRlRegionRangeUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
		
	}
}
