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
    public class TWhDestHouseController : EntityControllerBase<TWhDestHouse, TWhDestHouseReadModel, TWhDestHouseCreateModel, TWhDestHouseUpdateModel>
    {
        public TWhDestHouseController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhDestHouseCreateModel> createValidator, IValidator<TWhDestHouseUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
