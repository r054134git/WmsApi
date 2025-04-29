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
    public class TEqWalkingBeamController : EntityControllerBase<TEqWalkingBeam, TEqWalkingBeamReadModel, TEqWalkingBeamCreateModel, TEqWalkingBeamUpdateModel>
    {
        public TEqWalkingBeamController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqWalkingBeamCreateModel> createValidator, IValidator<TEqWalkingBeamUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
