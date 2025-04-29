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
    public class TRcTrainDeliveryPickController : EntityControllerBase<TRcTrainDeliveryPick, TRcTrainDeliveryPickReadModel, TRcTrainDeliveryPickCreateModel, TRcTrainDeliveryPickUpdateModel>
    {
        public TRcTrainDeliveryPickController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcTrainDeliveryPickCreateModel> createValidator, IValidator<TRcTrainDeliveryPickUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
