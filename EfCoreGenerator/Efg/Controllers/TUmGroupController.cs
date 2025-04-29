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
    public class TUmGroupController : EntityControllerBase<TUmGroup, TUmGroupReadModel, TUmGroupCreateModel, TUmGroupUpdateModel>
    {
        public TUmGroupController(WmspcrContext dataContext, IMapper mapper, IValidator<TUmGroupCreateModel> createValidator, IValidator<TUmGroupUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
