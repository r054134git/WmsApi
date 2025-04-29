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
    public class TTrEntryController : EntityControllerBase<TTrEntry, TTrEntryReadModel, TTrEntryCreateModel, TTrEntryUpdateModel>
    {
        public TTrEntryController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrEntryCreateModel> createValidator, IValidator<TTrEntryUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
