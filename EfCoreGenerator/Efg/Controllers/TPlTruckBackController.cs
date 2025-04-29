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
    public class TPlTruckBackController : EntityControllerBase<TPlTruckBack, TPlTruckBackReadModel, TPlTruckBackCreateModel, TPlTruckBackUpdateModel>
    {
        public TPlTruckBackController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckBackCreateModel> createValidator, IValidator<TPlTruckBackUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
