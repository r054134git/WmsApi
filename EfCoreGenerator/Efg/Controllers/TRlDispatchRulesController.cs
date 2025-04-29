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
    public class TRlDispatchRulesController : EntityControllerBase<TRlDispatchRules, TRlDispatchRulesReadModel, TRlDispatchRulesCreateModel, TRlDispatchRulesUpdateModel>
    {
        public TRlDispatchRulesController(WmspcrContext dataContext, IMapper mapper, IValidator<TRlDispatchRulesCreateModel> createValidator, IValidator<TRlDispatchRulesUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
