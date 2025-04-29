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
    public class TRlCranePlanTypeController : EntityControllerBase<TRlCranePlanType, TRlCranePlanTypeReadModel, TRlCranePlanTypeCreateModel, TRlCranePlanTypeUpdateModel>
    {
        public TRlCranePlanTypeController(WmspcrContext dataContext, IMapper mapper, IValidator<TRlCranePlanTypeCreateModel> createValidator, IValidator<TRlCranePlanTypeUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
