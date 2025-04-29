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
    public class TPlProductionDetailController : EntityControllerBase<TPlProductionDetail, TPlProductionDetailReadModel, TPlProductionDetailCreateModel, TPlProductionDetailUpdateModel>
    {
        public TPlProductionDetailController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlProductionDetailCreateModel> createValidator, IValidator<TPlProductionDetailUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
