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
	public class TEqTrainController : EntityControllerBase<TEqTrain, TEqTrainReadModel, TEqTrainCreateModel, TEqTrainUpdateModel>
	{
		public TEqTrainController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqTrainCreateModel> createValidator, IValidator<TEqTrainUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
