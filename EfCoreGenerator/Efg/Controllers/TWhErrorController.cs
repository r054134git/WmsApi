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
    public class TWhErrorController : EntityControllerBase<TWhError, TWhErrorReadModel, TWhErrorCreateModel, TWhErrorUpdateModel>
    {
        public TWhErrorController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhErrorCreateModel> createValidator, IValidator<TWhErrorUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
