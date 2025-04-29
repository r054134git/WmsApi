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
    public class VCraneUnloadlocationController : EntityControllerBase<VCraneUnloadlocation, VCraneUnloadlocationReadModel, VCraneUnloadlocationCreateModel, VCraneUnloadlocationUpdateModel>
    {
        public VCraneUnloadlocationController(WmspcrContext dataContext, IMapper mapper, IValidator<VCraneUnloadlocationCreateModel> createValidator, IValidator<VCraneUnloadlocationUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
