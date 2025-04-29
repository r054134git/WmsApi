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
    public class TWhStackController : EntityControllerBase<TWhStack, TWhStackReadModel, TWhStackCreateModel, TWhStackUpdateModel>
    {
        public TWhStackController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhStackCreateModel> createValidator, IValidator<TWhStackUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
