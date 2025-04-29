using AutoMapper;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
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
	public class TTrTrainController : EntityControllerBase<TTrTrain, TTrTrainReadModel, TTrTrainCreateModel, TTrTrainUpdateModel>
	{
		public TTrTrainController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrTrainCreateModel> createValidator, IValidator<TTrTrainUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
	}
}
