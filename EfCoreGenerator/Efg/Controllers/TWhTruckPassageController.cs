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
    public class TWhTruckPassageController : EntityControllerBase<TWhTruckPassage, TWhTruckPassageReadModel, TWhTruckPassageCreateModel, TWhTruckPassageUpdateModel>
    {
        public TWhTruckPassageController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhTruckPassageCreateModel> createValidator, IValidator<TWhTruckPassageUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
