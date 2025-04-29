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
	public class TEqTrainCarController : EntityControllerBase<TEqTrainCar, TEqTrainCarReadModel, TEqTrainCarCreateModel, TEqTrainCarUpdateModel>
	{
		public TEqTrainCarController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqTrainCarCreateModel> createValidator, IValidator<TEqTrainCarUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
