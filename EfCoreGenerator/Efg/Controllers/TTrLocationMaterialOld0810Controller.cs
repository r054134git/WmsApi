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
    public class TTrLocationMaterialOld0810Controller : EntityControllerBase<TTrLocationMaterialOld0810, TTrLocationMaterialOld0810ReadModel, TTrLocationMaterialOld0810CreateModel, TTrLocationMaterialOld0810UpdateModel>
    {
        public TTrLocationMaterialOld0810Controller(WmspcrContext dataContext, IMapper mapper, IValidator<TTrLocationMaterialOld0810CreateModel> createValidator, IValidator<TTrLocationMaterialOld0810UpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
