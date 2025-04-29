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
    public class TPlBayTransferController : EntityControllerBase<TPlBayTransfer, TPlBayTransferReadModel, TPlBayTransferCreateModel, TPlBayTransferUpdateModel>
    {
        public TPlBayTransferController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlBayTransferCreateModel> createValidator, IValidator<TPlBayTransferUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
