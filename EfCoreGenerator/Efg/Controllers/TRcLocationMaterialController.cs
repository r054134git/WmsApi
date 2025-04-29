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
    public class TRcLocationMaterialController : EntityControllerBase<TRcLocationMaterial, TRcLocationMaterialReadModel, TRcLocationMaterialCreateModel, TRcLocationMaterialUpdateModel>
    {
        public TRcLocationMaterialController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcLocationMaterialCreateModel> createValidator, IValidator<TRcLocationMaterialUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
