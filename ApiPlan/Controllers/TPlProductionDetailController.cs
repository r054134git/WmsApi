using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using System.Linq;
using WmsApi.Domain.Entities;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using WmsApi.Controllers;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlProductionDetailController : EntityControllerBase<TPlProductionDetail, TPlProductionDetailReadModel, TPlProductionDetailCreateModel, TPlProductionDetailUpdateModel>
    {
        public TPlProductionDetailController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlProductionDetailCreateModel> createValidator, IValidator<TPlProductionDetailUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

    }
}
