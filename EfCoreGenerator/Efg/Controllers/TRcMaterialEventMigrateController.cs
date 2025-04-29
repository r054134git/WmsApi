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
    public class TRcMaterialEventMigrateController : EntityControllerBase<TRcMaterialEventMigrate, TRcMaterialEventMigrateReadModel, TRcMaterialEventMigrateCreateModel, TRcMaterialEventMigrateUpdateModel>
    {
        public TRcMaterialEventMigrateController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcMaterialEventMigrateCreateModel> createValidator, IValidator<TRcMaterialEventMigrateUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
