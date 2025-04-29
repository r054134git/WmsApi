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
    public class TTrCraneController : EntityControllerBase<TTrCrane, TTrCraneReadModel, TTrCraneCreateModel, TTrCraneUpdateModel>
    {
        public TTrCraneController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrCraneCreateModel> createValidator, IValidator<TTrCraneUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
