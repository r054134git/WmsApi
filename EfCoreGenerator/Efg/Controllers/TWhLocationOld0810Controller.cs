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
    public class TWhLocationOld0810Controller : EntityControllerBase<TWhLocationOld0810, TWhLocationOld0810ReadModel, TWhLocationOld0810CreateModel, TWhLocationOld0810UpdateModel>
    {
        public TWhLocationOld0810Controller(WmspcrContext dataContext, IMapper mapper, IValidator<TWhLocationOld0810CreateModel> createValidator, IValidator<TWhLocationOld0810UpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
