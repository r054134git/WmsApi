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
    public class TRlLocationAssignController : EntityControllerBase<TRlLocationAssign, TRlLocationAssignReadModel, TRlLocationAssignCreateModel, TRlLocationAssignUpdateModel>
    {
        public TRlLocationAssignController(WmspcrContext dataContext, IMapper mapper, IValidator<TRlLocationAssignCreateModel> createValidator, IValidator<TRlLocationAssignUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
