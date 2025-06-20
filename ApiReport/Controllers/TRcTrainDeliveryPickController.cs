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
	[Route("report/[controller]/[action]")]
	public class TRcTrainDeliveryPickController : EntityControllerBase<TRcTrainDeliveryPick, TRcTrainDeliveryPickReadModel, TRcTrainDeliveryPickCreateModel, TRcTrainDeliveryPickUpdateModel>
	{
		public TRcTrainDeliveryPickController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcTrainDeliveryPickCreateModel> createValidator, IValidator<TRcTrainDeliveryPickUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
