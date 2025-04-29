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
    public class TPlTruckDeliveryDetailController : EntityControllerBase<TPlTruckDeliveryDetail, TPlTruckDeliveryDetailReadModel, TPlTruckDeliveryDetailCreateModel, TPlTruckDeliveryDetailUpdateModel>
    {
        public TPlTruckDeliveryDetailController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckDeliveryDetailCreateModel> createValidator, IValidator<TPlTruckDeliveryDetailUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
