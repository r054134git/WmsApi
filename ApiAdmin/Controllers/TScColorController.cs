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
	[Route("admin/[controller]/[action]")]
	public class TScColorController : EntityControllerBase<TScColor, TScColorReadModel, TScColorCreateModel, TScColorUpdateModel>
	{
		public TScColorController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TScColorCreateModel> createValidator, IValidator<TScColorUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
