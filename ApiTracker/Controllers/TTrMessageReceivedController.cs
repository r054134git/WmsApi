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
	public class TTrMessageReceivedController : EntityControllerBase<TTrMessageReceived, TTrMessageReceivedReadModel, TTrMessageReceivedCreateModel, TTrMessageReceivedUpdateModel>
	{
		public TTrMessageReceivedController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrMessageReceivedCreateModel> createValidator, IValidator<TTrMessageReceivedUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
