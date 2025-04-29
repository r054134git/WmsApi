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
    public class TScTransferSpecController : EntityControllerBase<TScTransferSpec, TScTransferSpecReadModel, TScTransferSpecCreateModel, TScTransferSpecUpdateModel>
    {
        public TScTransferSpecController(WmspcrContext dataContext, IMapper mapper, IValidator<TScTransferSpecCreateModel> createValidator, IValidator<TScTransferSpecUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
