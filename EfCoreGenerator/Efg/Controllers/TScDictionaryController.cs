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
    public class TScDictionaryController : EntityControllerBase<TScDictionary, TScDictionaryReadModel, TScDictionaryCreateModel, TScDictionaryUpdateModel>
    {
        public TScDictionaryController(WmspcrContext dataContext, IMapper mapper, IValidator<TScDictionaryCreateModel> createValidator, IValidator<TScDictionaryUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
