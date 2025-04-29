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
    public class TRcWorkModeController : EntityControllerBase<TRcWorkMode, TRcWorkModeReadModel, TRcWorkModeCreateModel, TRcWorkModeUpdateModel>
    {
        public TRcWorkModeController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcWorkModeCreateModel> createValidator, IValidator<TRcWorkModeUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
