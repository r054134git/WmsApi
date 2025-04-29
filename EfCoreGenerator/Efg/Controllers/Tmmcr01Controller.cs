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
    public class Tmmcr01Controller : EntityControllerBase<Tmmcr01, Tmmcr01ReadModel, Tmmcr01CreateModel, Tmmcr01UpdateModel>
    {
        public Tmmcr01Controller(WmspcrContext dataContext, IMapper mapper, IValidator<Tmmcr01CreateModel> createValidator, IValidator<Tmmcr01UpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
