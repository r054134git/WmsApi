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
    public class TTrCplController : EntityControllerBase<TTrCpl, TTrCplReadModel, TTrCplCreateModel, TTrCplUpdateModel>
    {
        public TTrCplController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrCplCreateModel> createValidator, IValidator<TTrCplUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
