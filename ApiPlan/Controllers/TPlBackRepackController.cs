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
    public class TPlBackRepackController : EntityControllerBase<TPlBackRepack, TPlBackRepackReadModel, TPlBackRepackCreateModel, TPlBackRepackUpdateModel>
    {
        public TPlBackRepackController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlBackRepackCreateModel> createValidator, IValidator<TPlBackRepackUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
