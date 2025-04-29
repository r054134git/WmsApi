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
    public class TScClientController : EntityControllerBase<TScClient, TScClientReadModel, TScClientCreateModel, TScClientUpdateModel>
    {
        public TScClientController(WmspcrContext dataContext, IMapper mapper, IValidator<TScClientCreateModel> createValidator, IValidator<TScClientUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
