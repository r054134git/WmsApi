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
	public class TTrTodoListController : EntityControllerBase<TTrTodoList, TTrTodoListReadModel, TTrTodoListCreateModel, TTrTodoListUpdateModel>
	{
		public TTrTodoListController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrTodoListCreateModel> createValidator, IValidator<TTrTodoListUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
