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
	public class TEqCoilCarController : EntityControllerBase<TEqCoilCar, TEqCoilCarReadModel, TEqCoilCarCreateModel, TEqCoilCarUpdateModel>
	{
		public TEqCoilCarController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqCoilCarCreateModel> createValidator, IValidator<TEqCoilCarUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
