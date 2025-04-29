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
    public class TEqCrossVehicleController : EntityControllerBase<TEqCrossVehicle, TEqCrossVehicleReadModel, TEqCrossVehicleCreateModel, TEqCrossVehicleUpdateModel>
    {
        public TEqCrossVehicleController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqCrossVehicleCreateModel> createValidator, IValidator<TEqCrossVehicleUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
