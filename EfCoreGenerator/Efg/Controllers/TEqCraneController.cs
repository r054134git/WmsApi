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
    public class TEqCraneController : EntityControllerBase<TEqCrane, TEqCraneReadModel, TEqCraneCreateModel, TEqCraneUpdateModel>
    {
        public TEqCraneController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqCraneCreateModel> createValidator, IValidator<TEqCraneUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
