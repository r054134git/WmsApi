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
    public class TRcInventoryController : EntityControllerBase<TRcInventory, TRcInventoryReadModel, TRcInventoryCreateModel, TRcInventoryUpdateModel>
    {
        public TRcInventoryController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcInventoryCreateModel> createValidator, IValidator<TRcInventoryUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
