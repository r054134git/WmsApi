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
    public class TRlLocationController : EntityControllerBase<TRlLocation, TRlLocationReadModel, TRlLocationCreateModel, TRlLocationUpdateModel>
    {
        public TRlLocationController(WmspcrContext dataContext, IMapper mapper, IValidator<TRlLocationCreateModel> createValidator, IValidator<TRlLocationUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
