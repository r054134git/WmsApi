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
    public class TRcMaterialController : EntityControllerBase<TRcMaterial, TRcMaterialReadModel, TRcMaterialCreateModel, TRcMaterialUpdateModel>
    {
        public TRcMaterialController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcMaterialCreateModel> createValidator, IValidator<TRcMaterialUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
