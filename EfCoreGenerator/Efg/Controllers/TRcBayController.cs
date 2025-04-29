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
    public class TRcBayController : EntityControllerBase<TRcBay, TRcBayReadModel, TRcBayCreateModel, TRcBayUpdateModel>
    {
        public TRcBayController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcBayCreateModel> createValidator, IValidator<TRcBayUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
