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
	public class TWhTruckParkingPlaceController : EntityControllerBase<TWhTruckParkingPlace, TWhTruckParkingPlaceReadModel, TWhTruckParkingPlaceCreateModel, TWhTruckParkingPlaceUpdateModel>
	{
		public TWhTruckParkingPlaceController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhTruckParkingPlaceCreateModel> createValidator, IValidator<TWhTruckParkingPlaceUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
