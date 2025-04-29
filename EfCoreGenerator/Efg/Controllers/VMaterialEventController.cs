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
    public class VMaterialEventController : EntityControllerBase<VMaterialEvent, VMaterialEventReadModel, VMaterialEventCreateModel, VMaterialEventUpdateModel>
    {
        public VMaterialEventController(WmspcrContext dataContext, IMapper mapper, IValidator<VMaterialEventCreateModel> createValidator, IValidator<VMaterialEventUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
