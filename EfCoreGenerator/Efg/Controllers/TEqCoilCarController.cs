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
    public class TEqCoilCarController : EntityControllerBase<TEqCoilCar, TEqCoilCarReadModel, TEqCoilCarCreateModel, TEqCoilCarUpdateModel>
    {
        public TEqCoilCarController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqCoilCarCreateModel> createValidator, IValidator<TEqCoilCarUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
