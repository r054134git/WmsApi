using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("equip/[controller]/[action]")]
	public class TEqGateParkingController : EntityControllerBase<TEqGateParking, TEqGateParkingReadModel, TEqGateParkingCreateModel, TEqGateParkingUpdateModel>
	{
		public TEqGateParkingController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqGateParkingCreateModel> createValidator, IValidator<TEqGateParkingUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}

    }
}
