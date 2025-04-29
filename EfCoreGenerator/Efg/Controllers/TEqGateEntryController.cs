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
    public class TEqGateEntryController : EntityControllerBase<TEqGateEntry, TEqGateEntryReadModel, TEqGateEntryCreateModel, TEqGateEntryUpdateModel>
    {
        public TEqGateEntryController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqGateEntryCreateModel> createValidator, IValidator<TEqGateEntryUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
