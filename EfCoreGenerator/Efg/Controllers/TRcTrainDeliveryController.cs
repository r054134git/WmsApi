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
    public class TRcTrainDeliveryController : EntityControllerBase<TRcTrainDelivery, TRcTrainDeliveryReadModel, TRcTrainDeliveryCreateModel, TRcTrainDeliveryUpdateModel>
    {
        public TRcTrainDeliveryController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcTrainDeliveryCreateModel> createValidator, IValidator<TRcTrainDeliveryUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
