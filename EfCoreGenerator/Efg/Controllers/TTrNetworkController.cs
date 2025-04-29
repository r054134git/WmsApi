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
    public class TTrNetworkController : EntityControllerBase<TTrNetwork, TTrNetworkReadModel, TTrNetworkCreateModel, TTrNetworkUpdateModel>
    {
        public TTrNetworkController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrNetworkCreateModel> createValidator, IValidator<TTrNetworkUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
