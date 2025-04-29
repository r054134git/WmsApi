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
    public class TUmColsetController : EntityControllerBase<TUmColset, TUmColsetReadModel, TUmColsetCreateModel, TUmColsetUpdateModel>
    {
        public TUmColsetController(WmspcrContext dataContext, IMapper mapper, IValidator<TUmColsetCreateModel> createValidator, IValidator<TUmColsetUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
