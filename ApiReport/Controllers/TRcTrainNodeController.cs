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
	public class TRcTrainNodeController : EntityControllerBase<TRcTrainNode, TRcTrainNodeReadModel, TRcTrainNodeCreateModel, TRcTrainNodeUpdateModel>
	{
		public TRcTrainNodeController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcTrainNodeCreateModel> createValidator, IValidator<TRcTrainNodeUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
