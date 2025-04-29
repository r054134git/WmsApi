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
    public class TWhLocationController : EntityControllerBase<TWhLocation, TWhLocationReadModel, TWhLocationCreateModel, TWhLocationUpdateModel>
    {
        public TWhLocationController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhLocationCreateModel> createValidator, IValidator<TWhLocationUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
