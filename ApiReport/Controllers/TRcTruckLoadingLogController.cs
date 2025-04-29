using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;
using WmsApi.Domain;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcTruckLoadingLogController : EntityControllerBase<TRcTruckLoadingLog, TRcTruckLoadingLogReadModel, TRcTruckLoadingLogCreateModel, TRcTruckLoadingLogUpdateModel>
    {
        public TRcTruckLoadingLogController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcTruckLoadingLogCreateModel> createValidator, IValidator<TRcTruckLoadingLogUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {

        }
    }
}
