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
    public class TPlFinishLineController : EntityControllerBase<TPlFinishLine, TPlFinishLineReadModel, TPlFinishLineCreateModel, TPlFinishLineUpdateModel>
    {
        public TPlFinishLineController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlFinishLineCreateModel> createValidator, IValidator<TPlFinishLineUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
