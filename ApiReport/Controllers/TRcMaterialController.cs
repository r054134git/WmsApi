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
	public class TRcMaterialController : EntityControllerBase<TRcMaterial, TRcMaterialReadModel, TRcMaterialCreateModel, TRcMaterialUpdateModel>
	{
		public TRcMaterialController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcMaterialCreateModel> createValidator, IValidator<TRcMaterialUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
