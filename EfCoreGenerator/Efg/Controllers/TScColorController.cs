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
    public class TScColorController : EntityControllerBase<TScColor, TScColorReadModel, TScColorCreateModel, TScColorUpdateModel>
    {
        public TScColorController(WmspcrContext dataContext, IMapper mapper, IValidator<TScColorCreateModel> createValidator, IValidator<TScColorUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
