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
    public class TRcInventoryTempController : EntityControllerBase<TRcInventoryTemp, TRcInventoryTempReadModel, TRcInventoryTempCreateModel, TRcInventoryTempUpdateModel>
    {
        public TRcInventoryTempController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcInventoryTempCreateModel> createValidator, IValidator<TRcInventoryTempUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
