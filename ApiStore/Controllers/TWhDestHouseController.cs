using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Linq;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("store/[controller]/[action]")]
	public class TWhDestHouseController : EntityControllerBase<TWhDestHouse, TWhDestHouseReadModel, TWhDestHouseCreateModel, TWhDestHouseUpdateModel>
	{
		public TWhDestHouseController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TWhDestHouseCreateModel> createValidator, IValidator<TWhDestHouseUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
    }
}
