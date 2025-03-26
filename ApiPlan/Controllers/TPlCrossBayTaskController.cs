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
    public class TPlCrossBayTaskController : EntityControllerBase<TPlCrossBayTask, TPlCrossBayTaskReadModel, TPlCrossBayTaskCreateModel, TPlCrossBayTaskUpdateModel>
    {
        public TPlCrossBayTaskController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlCrossBayTaskCreateModel> createValidator, IValidator<TPlCrossBayTaskUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
