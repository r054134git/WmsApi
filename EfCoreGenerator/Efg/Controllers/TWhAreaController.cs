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
    public class TWhAreaController : EntityControllerBase<TWhArea, TWhAreaReadModel, TWhAreaCreateModel, TWhAreaUpdateModel>
    {
        public TWhAreaController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhAreaCreateModel> createValidator, IValidator<TWhAreaUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
