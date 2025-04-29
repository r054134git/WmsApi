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
    public class VPlMaterialController : EntityControllerBase<VPlMaterial, VPlMaterialReadModel, VPlMaterialCreateModel, VPlMaterialUpdateModel>
    {
        public VPlMaterialController(WmspcrContext dataContext, IMapper mapper, IValidator<VPlMaterialCreateModel> createValidator, IValidator<VPlMaterialUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
