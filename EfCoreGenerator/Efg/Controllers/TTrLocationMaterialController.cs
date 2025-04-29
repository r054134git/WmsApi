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
    public class TTrLocationMaterialController : EntityControllerBase<TTrLocationMaterial, TTrLocationMaterialReadModel, TTrLocationMaterialCreateModel, TTrLocationMaterialUpdateModel>
    {
        public TTrLocationMaterialController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrLocationMaterialCreateModel> createValidator, IValidator<TTrLocationMaterialUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
