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
    public class TScTransferTerminalController : EntityControllerBase<TScTransferTerminal, TScTransferTerminalReadModel, TScTransferTerminalCreateModel, TScTransferTerminalUpdateModel>
    {
        public TScTransferTerminalController(WmspcrContext dataContext, IMapper mapper, IValidator<TScTransferTerminalCreateModel> createValidator, IValidator<TScTransferTerminalUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
