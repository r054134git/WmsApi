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
    public class TTrConveyingChainController : EntityControllerBase<TTrConveyingChain, TTrConveyingChainReadModel, TTrConveyingChainCreateModel, TTrConveyingChainUpdateModel>
    {
        public TTrConveyingChainController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrConveyingChainCreateModel> createValidator, IValidator<TTrConveyingChainUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
