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
	public class TUmShiftController : EntityControllerBase<TUmShift, TUmShiftReadModel, TUmShiftCreateModel, TUmShiftUpdateModel>
	{
		public TUmShiftController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TUmShiftCreateModel> createValidator, IValidator<TUmShiftUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
