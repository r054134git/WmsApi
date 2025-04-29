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
    public class TRcLocationsRateController : EntityControllerBase<TRcLocationsRate, TRcLocationsRateReadModel, TRcLocationsRateCreateModel, TRcLocationsRateUpdateModel>
    {
        public TRcLocationsRateController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcLocationsRateCreateModel> createValidator, IValidator<TRcLocationsRateUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
