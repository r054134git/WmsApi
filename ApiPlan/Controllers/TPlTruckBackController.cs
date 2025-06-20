using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain.Entities;
using WmsApi.Domain;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlTruckBackController : EntityControllerBase<TPlTruckBack, TPlTruckBackReadModel, TPlTruckBackCreateModel, TPlTruckBackUpdateModel>
    {
        public TPlTruckBackController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckBackCreateModel> createValidator, IValidator<TPlTruckBackUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
