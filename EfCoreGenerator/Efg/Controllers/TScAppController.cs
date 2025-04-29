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
    public class TScAppController : EntityControllerBase<TScApp, TScAppReadModel, TScAppCreateModel, TScAppUpdateModel>
    {
        public TScAppController(WmspcrContext dataContext, IMapper mapper, IValidator<TScAppCreateModel> createValidator, IValidator<TScAppUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
