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
    public class TTrLocationMaterialEventController : EntityControllerBase<TTrLocationMaterialEvent, TTrLocationMaterialEventReadModel, TTrLocationMaterialEventCreateModel, TTrLocationMaterialEventUpdateModel>
    {
        public TTrLocationMaterialEventController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrLocationMaterialEventCreateModel> createValidator, IValidator<TTrLocationMaterialEventUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
