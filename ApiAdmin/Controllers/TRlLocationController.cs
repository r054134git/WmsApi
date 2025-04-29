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
	public class TRlLocationController : EntityControllerBase<TRlLocation, TRlLocationReadModel, TRlLocationCreateModel, TRlLocationUpdateModel>
	{
		public TRlLocationController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRlLocationCreateModel> createValidator, IValidator<TRlLocationUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
