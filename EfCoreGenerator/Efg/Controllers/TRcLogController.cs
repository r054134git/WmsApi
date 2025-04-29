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
    public class TRcLogController : EntityControllerBase<TRcLog, TRcLogReadModel, TRcLogCreateModel, TRcLogUpdateModel>
    {
        public TRcLogController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcLogCreateModel> createValidator, IValidator<TRcLogUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
