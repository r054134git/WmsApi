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
    public class TWhCraneTravelSpaceController : EntityControllerBase<TWhCraneTravelSpace, TWhCraneTravelSpaceReadModel, TWhCraneTravelSpaceCreateModel, TWhCraneTravelSpaceUpdateModel>
    {
        public TWhCraneTravelSpaceController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhCraneTravelSpaceCreateModel> createValidator, IValidator<TWhCraneTravelSpaceUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
