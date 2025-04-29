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
    public class TPlStackTranferController : EntityControllerBase<TPlStackTranfer, TPlStackTranferReadModel, TPlStackTranferCreateModel, TPlStackTranferUpdateModel>
    {
        public TPlStackTranferController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlStackTranferCreateModel> createValidator, IValidator<TPlStackTranferUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
