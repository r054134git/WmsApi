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
	public class TWhWarehouseController : EntityControllerBase<TWhWarehouse, TWhWarehouseReadModel, TWhWarehouseCreateModel, TWhWarehouseUpdateModel>
	{
		public TWhWarehouseController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhWarehouseCreateModel> createValidator, IValidator<TWhWarehouseUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
