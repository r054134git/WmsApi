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
    public class TEqFenceDoorController : EntityControllerBase<TEqFenceDoor, TEqFenceDoorReadModel, TEqFenceDoorCreateModel, TEqFenceDoorUpdateModel>
    {
        public TEqFenceDoorController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqFenceDoorCreateModel> createValidator, IValidator<TEqFenceDoorUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
