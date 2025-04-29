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
    public class TWhPlanTypeController : EntityControllerBase<TWhPlanType, TWhPlanTypeReadModel, TWhPlanTypeCreateModel, TWhPlanTypeUpdateModel>
    {
        public TWhPlanTypeController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhPlanTypeCreateModel> createValidator, IValidator<TWhPlanTypeUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
