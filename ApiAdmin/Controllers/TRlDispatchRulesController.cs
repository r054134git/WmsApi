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
	public class TRlDispatchRulesController : EntityControllerBase<TRlDispatchRules, TRlDispatchRulesReadModel, TRlDispatchRulesCreateModel, TRlDispatchRulesUpdateModel>
	{
		public TRlDispatchRulesController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRlDispatchRulesCreateModel> createValidator, IValidator<TRlDispatchRulesUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
