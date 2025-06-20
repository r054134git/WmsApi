using AutoMapper;
using AutoMapper.QueryableExtensions;

using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("equip/[controller]/[action]")]
	public class TEqGateEntryController : EntityControllerBase<TEqGateEntry, TEqGateEntryReadModel, TEqGateEntryCreateModel, TEqGateEntryUpdateModel>
	{
		public TEqGateEntryController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqGateEntryCreateModel> createValidator, IValidator<TEqGateEntryUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
    }
}
