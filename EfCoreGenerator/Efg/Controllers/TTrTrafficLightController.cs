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
    public class TTrTrafficLightController : EntityControllerBase<TTrTrafficLight, TTrTrafficLightReadModel, TTrTrafficLightCreateModel, TTrTrafficLightUpdateModel>
    {
        public TTrTrafficLightController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrTrafficLightCreateModel> createValidator, IValidator<TTrTrafficLightUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
