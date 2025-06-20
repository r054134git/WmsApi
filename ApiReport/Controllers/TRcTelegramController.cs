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
	public class TRcTelegramController : EntityControllerBase<TRcTelegram, TRcTelegramReadModel, TRcTelegramCreateModel, TRcTelegramUpdateModel>
	{
		public TRcTelegramController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcTelegramCreateModel> createValidator, IValidator<TRcTelegramUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
