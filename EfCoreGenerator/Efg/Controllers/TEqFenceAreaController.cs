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
    public class TEqFenceAreaController : EntityControllerBase<TEqFenceArea, TEqFenceAreaReadModel, TEqFenceAreaCreateModel, TEqFenceAreaUpdateModel>
    {
        public TEqFenceAreaController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqFenceAreaCreateModel> createValidator, IValidator<TEqFenceAreaUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
