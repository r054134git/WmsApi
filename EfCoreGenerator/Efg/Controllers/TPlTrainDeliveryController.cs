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
    public class TPlTrainDeliveryController : EntityControllerBase<TPlTrainDelivery, TPlTrainDeliveryReadModel, TPlTrainDeliveryCreateModel, TPlTrainDeliveryUpdateModel>
    {
        public TPlTrainDeliveryController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlTrainDeliveryCreateModel> createValidator, IValidator<TPlTrainDeliveryUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
