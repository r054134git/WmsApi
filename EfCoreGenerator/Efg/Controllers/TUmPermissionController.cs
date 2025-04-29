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
    public class TUmPermissionController : EntityControllerBase<TUmPermission, TUmPermissionReadModel, TUmPermissionCreateModel, TUmPermissionUpdateModel>
    {
        public TUmPermissionController(WmspcrContext dataContext, IMapper mapper, IValidator<TUmPermissionCreateModel> createValidator, IValidator<TUmPermissionUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
