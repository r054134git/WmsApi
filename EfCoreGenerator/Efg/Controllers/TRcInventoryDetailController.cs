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
    public class TRcInventoryDetailController : EntityControllerBase<TRcInventoryDetail, TRcInventoryDetailReadModel, TRcInventoryDetailCreateModel, TRcInventoryDetailUpdateModel>
    {
        public TRcInventoryDetailController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcInventoryDetailCreateModel> createValidator, IValidator<TRcInventoryDetailUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
