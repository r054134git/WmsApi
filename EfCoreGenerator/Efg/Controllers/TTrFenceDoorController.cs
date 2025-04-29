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
    public class TTrFenceDoorController : EntityControllerBase<TTrFenceDoor, TTrFenceDoorReadModel, TTrFenceDoorCreateModel, TTrFenceDoorUpdateModel>
    {
        public TTrFenceDoorController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrFenceDoorCreateModel> createValidator, IValidator<TTrFenceDoorUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
