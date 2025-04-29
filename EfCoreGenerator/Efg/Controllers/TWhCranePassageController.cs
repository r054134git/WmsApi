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
    public class TWhCranePassageController : EntityControllerBase<TWhCranePassage, TWhCranePassageReadModel, TWhCranePassageCreateModel, TWhCranePassageUpdateModel>
    {
        public TWhCranePassageController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhCranePassageCreateModel> createValidator, IValidator<TWhCranePassageUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
