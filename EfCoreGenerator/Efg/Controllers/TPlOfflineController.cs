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
    public class TPlOfflineController : EntityControllerBase<TPlOffline, TPlOfflineReadModel, TPlOfflineCreateModel, TPlOfflineUpdateModel>
    {
        public TPlOfflineController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlOfflineCreateModel> createValidator, IValidator<TPlOfflineUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
