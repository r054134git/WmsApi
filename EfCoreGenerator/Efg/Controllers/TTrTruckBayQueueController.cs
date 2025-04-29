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
    public class TTrTruckBayQueueController : EntityControllerBase<TTrTruckBayQueue, TTrTruckBayQueueReadModel, TTrTruckBayQueueCreateModel, TTrTruckBayQueueUpdateModel>
    {
        public TTrTruckBayQueueController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrTruckBayQueueCreateModel> createValidator, IValidator<TTrTruckBayQueueUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
