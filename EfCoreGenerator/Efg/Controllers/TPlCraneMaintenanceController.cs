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
    public class TPlCraneMaintenanceController : EntityControllerBase<TPlCraneMaintenance, TPlCraneMaintenanceReadModel, TPlCraneMaintenanceCreateModel, TPlCraneMaintenanceUpdateModel>
    {
        public TPlCraneMaintenanceController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlCraneMaintenanceCreateModel> createValidator, IValidator<TPlCraneMaintenanceUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
