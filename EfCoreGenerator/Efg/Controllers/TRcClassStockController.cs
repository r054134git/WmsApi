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
    public class TRcClassStockController : EntityControllerBase<TRcClassStock, TRcClassStockReadModel, TRcClassStockCreateModel, TRcClassStockUpdateModel>
    {
        public TRcClassStockController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcClassStockCreateModel> createValidator, IValidator<TRcClassStockUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
