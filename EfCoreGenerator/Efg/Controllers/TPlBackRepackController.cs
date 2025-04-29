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
    public class TPlBackRepackController : EntityControllerBase<TPlBackRepack, TPlBackRepackReadModel, TPlBackRepackCreateModel, TPlBackRepackUpdateModel>
    {
        public TPlBackRepackController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlBackRepackCreateModel> createValidator, IValidator<TPlBackRepackUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
