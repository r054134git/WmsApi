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
    public class TPlTruckDeliveryController : EntityControllerBase<TPlTruckDelivery, TPlTruckDeliveryReadModel, TPlTruckDeliveryCreateModel, TPlTruckDeliveryUpdateModel>
    {
        public TPlTruckDeliveryController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckDeliveryCreateModel> createValidator, IValidator<TPlTruckDeliveryUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
