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
	[Route("tracker/[controller]/[action]")]
	public class TTrTruckQueueController : EntityControllerBase<TTrTruckQueue, TTrTruckQueueReadModel, TTrTruckQueueCreateModel, TTrTruckQueueUpdateModel>
	{
		public TTrTruckQueueController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrTruckQueueCreateModel> createValidator, IValidator<TTrTruckQueueUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
