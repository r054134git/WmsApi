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
    public class TUmUserController : EntityControllerBase<TUmUser, TUmUserReadModel, TUmUserCreateModel, TUmUserUpdateModel>
    {
        public TUmUserController(WmspcrContext dataContext, IMapper mapper, IValidator<TUmUserCreateModel> createValidator, IValidator<TUmUserUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
