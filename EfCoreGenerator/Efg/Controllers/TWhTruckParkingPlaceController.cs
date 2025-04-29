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
    public class TWhTruckParkingPlaceController : EntityControllerBase<TWhTruckParkingPlace, TWhTruckParkingPlaceReadModel, TWhTruckParkingPlaceCreateModel, TWhTruckParkingPlaceUpdateModel>
    {
        public TWhTruckParkingPlaceController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhTruckParkingPlaceCreateModel> createValidator, IValidator<TWhTruckParkingPlaceUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
