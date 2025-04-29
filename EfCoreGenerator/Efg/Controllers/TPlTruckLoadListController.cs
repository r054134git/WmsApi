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
    public class TPlTruckLoadListController : EntityControllerBase<TPlTruckLoadList, TPlTruckLoadListReadModel, TPlTruckLoadListCreateModel, TPlTruckLoadListUpdateModel>
    {
        public TPlTruckLoadListController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckLoadListCreateModel> createValidator, IValidator<TPlTruckLoadListUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
