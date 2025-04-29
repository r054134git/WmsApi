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
    public class TTrMessageSendController : EntityControllerBase<TTrMessageSend, TTrMessageSendReadModel, TTrMessageSendCreateModel, TTrMessageSendUpdateModel>
    {
        public TTrMessageSendController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrMessageSendCreateModel> createValidator, IValidator<TTrMessageSendUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
