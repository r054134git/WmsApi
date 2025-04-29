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
    public class TUmRolePermissionController : EntityControllerBase<TUmRolePermission, TUmRolePermissionReadModel, TUmRolePermissionCreateModel, TUmRolePermissionUpdateModel>
    {
        public TUmRolePermissionController(WmspcrContext dataContext, IMapper mapper, IValidator<TUmRolePermissionCreateModel> createValidator, IValidator<TUmRolePermissionUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
