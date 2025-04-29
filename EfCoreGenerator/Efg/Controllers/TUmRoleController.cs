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
    public class TUmRoleController : EntityControllerBase<TUmRole, TUmRoleReadModel, TUmRoleCreateModel, TUmRoleUpdateModel>
    {
        public TUmRoleController(WmspcrContext dataContext, IMapper mapper, IValidator<TUmRoleCreateModel> createValidator, IValidator<TUmRoleUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
