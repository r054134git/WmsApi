using AutoMapper;
using Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("tracker/[controller]/[action]")]
    public class TTrCplController : EntityControllerBase<TTrCpl, TTrCplReadModel, TTrCplCreateModel, TTrCplUpdateModel>
    {
        private readonly IHubContext<ChatHub> _hubContext;
        public TTrCplController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrCplCreateModel> createValidator, IValidator<TTrCplUpdateModel> updateValidator, IHubContext<ChatHub> hubContext)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {

        }
    }
}
