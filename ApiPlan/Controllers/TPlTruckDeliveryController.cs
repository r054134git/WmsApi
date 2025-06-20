using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlTruckDeliveryController : EntityControllerBase<TPlTruckDelivery, TPlTruckDeliveryReadModel, TPlTruckDeliveryCreateModel, TPlTruckDeliveryUpdateModel>
    {
        public TPlTruckDeliveryController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckDeliveryCreateModel> createValidator, IValidator<TPlTruckDeliveryUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
