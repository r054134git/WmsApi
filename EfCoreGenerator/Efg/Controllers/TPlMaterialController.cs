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
    public class TPlMaterialController : EntityControllerBase<TPlMaterial, TPlMaterialReadModel, TPlMaterialCreateModel, TPlMaterialUpdateModel>
    {
        public TPlMaterialController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlMaterialCreateModel> createValidator, IValidator<TPlMaterialUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
