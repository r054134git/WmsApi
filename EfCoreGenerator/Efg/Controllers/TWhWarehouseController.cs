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
    public class TWhWarehouseController : EntityControllerBase<TWhWarehouse, TWhWarehouseReadModel, TWhWarehouseCreateModel, TWhWarehouseUpdateModel>
    {
        public TWhWarehouseController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhWarehouseCreateModel> createValidator, IValidator<TWhWarehouseUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
