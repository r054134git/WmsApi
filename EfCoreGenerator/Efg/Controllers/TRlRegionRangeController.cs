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
    public class TRlRegionRangeController : EntityControllerBase<TRlRegionRange, TRlRegionRangeReadModel, TRlRegionRangeCreateModel, TRlRegionRangeUpdateModel>
    {
        public TRlRegionRangeController(WmspcrContext dataContext, IMapper mapper, IValidator<TRlRegionRangeCreateModel> createValidator, IValidator<TRlRegionRangeUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
