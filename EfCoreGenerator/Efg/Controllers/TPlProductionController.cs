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
    public class TPlProductionController : EntityControllerBase<TPlProduction, TPlProductionReadModel, TPlProductionCreateModel, TPlProductionUpdateModel>
    {
        public TPlProductionController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlProductionCreateModel> createValidator, IValidator<TPlProductionUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
