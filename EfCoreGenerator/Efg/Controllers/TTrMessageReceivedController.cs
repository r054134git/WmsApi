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
    public class TTrMessageReceivedController : EntityControllerBase<TTrMessageReceived, TTrMessageReceivedReadModel, TTrMessageReceivedCreateModel, TTrMessageReceivedUpdateModel>
    {
        public TTrMessageReceivedController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrMessageReceivedCreateModel> createValidator, IValidator<TTrMessageReceivedUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
