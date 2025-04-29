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
    public class TPlBayController : EntityControllerBase<TPlBay, TPlBayReadModel, TPlBayCreateModel, TPlBayUpdateModel>
    {
        public TPlBayController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlBayCreateModel> createValidator, IValidator<TPlBayUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
