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
    public class TPlTruckLoadListDetailController : EntityControllerBase<TPlTruckLoadListDetail, TPlTruckLoadListDetailReadModel, TPlTruckLoadListDetailCreateModel, TPlTruckLoadListDetailUpdateModel>
    {
        public TPlTruckLoadListDetailController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckLoadListDetailCreateModel> createValidator, IValidator<TPlTruckLoadListDetailUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
