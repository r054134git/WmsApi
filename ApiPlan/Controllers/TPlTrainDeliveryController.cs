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
    public class TPlTrainDeliveryController : EntityControllerBase<TPlTrainDelivery, TPlTrainDeliveryReadModel, TPlTrainDeliveryCreateModel, TPlTrainDeliveryUpdateModel>
    {
        public TPlTrainDeliveryController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlTrainDeliveryCreateModel> createValidator, IValidator<TPlTrainDeliveryUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
