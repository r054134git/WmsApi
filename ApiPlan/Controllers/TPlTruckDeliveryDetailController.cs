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
    public class TPlTruckDeliveryDetailController : EntityControllerBase<TPlTruckDeliveryDetail, TPlTruckDeliveryDetailReadModel, TPlTruckDeliveryDetailCreateModel, TPlTruckDeliveryDetailUpdateModel>
    {
        public TPlTruckDeliveryDetailController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckDeliveryDetailCreateModel> createValidator, IValidator<TPlTruckDeliveryDetailUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
