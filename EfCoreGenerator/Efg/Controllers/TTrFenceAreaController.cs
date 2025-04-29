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
    public class TTrFenceAreaController : EntityControllerBase<TTrFenceArea, TTrFenceAreaReadModel, TTrFenceAreaCreateModel, TTrFenceAreaUpdateModel>
    {
        public TTrFenceAreaController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrFenceAreaCreateModel> createValidator, IValidator<TTrFenceAreaUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
