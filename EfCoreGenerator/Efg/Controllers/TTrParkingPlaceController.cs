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
    public class TTrParkingPlaceController : EntityControllerBase<TTrParkingPlace, TTrParkingPlaceReadModel, TTrParkingPlaceCreateModel, TTrParkingPlaceUpdateModel>
    {
        public TTrParkingPlaceController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrParkingPlaceCreateModel> createValidator, IValidator<TTrParkingPlaceUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
