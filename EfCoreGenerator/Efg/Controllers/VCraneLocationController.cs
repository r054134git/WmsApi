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
    public class VCraneLocationController : EntityControllerBase<VCraneLocation, VCraneLocationReadModel, VCraneLocationCreateModel, VCraneLocationUpdateModel>
    {
        public VCraneLocationController(WmspcrContext dataContext, IMapper mapper, IValidator<VCraneLocationCreateModel> createValidator, IValidator<VCraneLocationUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
