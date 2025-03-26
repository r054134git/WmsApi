using AutoMapper;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("tracker/[controller]/[action]")]
	public class TTrConveyingChainController : EntityControllerBase<TTrConveyingChain, TTrConveyingChainReadModel, TTrConveyingChainCreateModel, TTrConveyingChainUpdateModel>
	{
		public TTrConveyingChainController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrConveyingChainCreateModel> createValidator, IValidator<TTrConveyingChainUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
