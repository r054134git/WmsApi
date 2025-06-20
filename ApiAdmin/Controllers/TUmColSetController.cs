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
	public class TUmColSetController : EntityControllerBase<TUmColSet, TUmColSetReadModel, TUmColSetCreateModel, TUmColSetUpdateModel>
	{
		public TUmColSetController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TUmColSetCreateModel> createValidator, IValidator<TUmColSetUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
