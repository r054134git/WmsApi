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
    public class TRcMaterialEventController : EntityControllerBase<TRcMaterialEvent, TRcMaterialEventReadModel, TRcMaterialEventCreateModel, TRcMaterialEventUpdateModel>
    {
        public TRcMaterialEventController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcMaterialEventCreateModel> createValidator, IValidator<TRcMaterialEventUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
