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
    public class VProductionMaterialController : EntityControllerBase<VProductionMaterial, VProductionMaterialReadModel, VProductionMaterialCreateModel, VProductionMaterialUpdateModel>
    {
        public VProductionMaterialController(WmspcrContext dataContext, IMapper mapper, IValidator<VProductionMaterialCreateModel> createValidator, IValidator<VProductionMaterialUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
