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
    public class TEqCraneWeightController : EntityControllerBase<TEqCraneWeight, TEqCraneWeightReadModel, TEqCraneWeightCreateModel, TEqCraneWeightUpdateModel>
    {
        public TEqCraneWeightController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqCraneWeightCreateModel> createValidator, IValidator<TEqCraneWeightUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
