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
    public class TTrTruckQueueController : EntityControllerBase<TTrTruckQueue, TTrTruckQueueReadModel, TTrTruckQueueCreateModel, TTrTruckQueueUpdateModel>
    {
        public TTrTruckQueueController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrTruckQueueCreateModel> createValidator, IValidator<TTrTruckQueueUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
