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
    public class TTrUserController : EntityControllerBase<TTrUser, TTrUserReadModel, TTrUserCreateModel, TTrUserUpdateModel>
    {
        public TTrUserController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrUserCreateModel> createValidator, IValidator<TTrUserUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
