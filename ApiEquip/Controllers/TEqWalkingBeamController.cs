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
	public class TEqWalkingBeamController : EntityControllerBase<TEqWalkingBeam, TEqWalkingBeamReadModel, TEqWalkingBeamCreateModel, TEqWalkingBeamUpdateModel>
	{
		public TEqWalkingBeamController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqWalkingBeamCreateModel> createValidator, IValidator<TEqWalkingBeamUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
