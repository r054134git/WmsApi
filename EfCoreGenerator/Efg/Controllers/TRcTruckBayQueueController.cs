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
    public class TRcTruckBayQueueController : EntityControllerBase<TRcTruckBayQueue, TRcTruckBayQueueReadModel, TRcTruckBayQueueCreateModel, TRcTruckBayQueueUpdateModel>
    {
        public TRcTruckBayQueueController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcTruckBayQueueCreateModel> createValidator, IValidator<TRcTruckBayQueueUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
