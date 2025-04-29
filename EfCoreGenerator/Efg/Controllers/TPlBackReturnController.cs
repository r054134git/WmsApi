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
    public class TPlBackReturnController : EntityControllerBase<TPlBackReturn, TPlBackReturnReadModel, TPlBackReturnCreateModel, TPlBackReturnUpdateModel>
    {
        public TPlBackReturnController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlBackReturnCreateModel> createValidator, IValidator<TPlBackReturnUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
