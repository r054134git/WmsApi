using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TRcTruckLoadingLogController : EntityControllerBase<TRcTruckLoadingLog, TRcTruckLoadingLogReadModel, TRcTruckLoadingLogCreateModel, TRcTruckLoadingLogUpdateModel>
    {
        public TRcTruckLoadingLogController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcTruckLoadingLogCreateModel> createValidator, IValidator<TRcTruckLoadingLogUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
