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
    public class TPlTruckTransferController : EntityControllerBase<TPlTruckTransfer, TPlTruckTransferReadModel, TPlTruckTransferCreateModel, TPlTruckTransferUpdateModel>
    {
        public TPlTruckTransferController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckTransferCreateModel> createValidator, IValidator<TPlTruckTransferUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
