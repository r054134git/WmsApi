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
	public class TWhTrainLocationController : EntityControllerBase<TWhTrainLocation, TWhTrainLocationReadModel, TWhTrainLocationCreateModel, TWhTrainLocationUpdateModel>
	{
		public TWhTrainLocationController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhTrainLocationCreateModel> createValidator, IValidator<TWhTrainLocationUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
