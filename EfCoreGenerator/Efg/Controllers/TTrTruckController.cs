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
    public class TTrTruckController : EntityControllerBase<TTrTruck, TTrTruckReadModel, TTrTruckCreateModel, TTrTruckUpdateModel>
    {
        public TTrTruckController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrTruckCreateModel> createValidator, IValidator<TTrTruckUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
