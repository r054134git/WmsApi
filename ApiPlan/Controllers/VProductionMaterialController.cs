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
    public class VProductionMaterialController : EntityControllerBase<VProductionMaterial, VProductionMaterialReadModel, VProductionMaterialCreateModel, VProductionMaterialUpdateModel>
    {
        public VProductionMaterialController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<VProductionMaterialCreateModel> createValidator, IValidator<VProductionMaterialUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

    }
}
