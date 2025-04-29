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
    public class TEqTrainCarController : EntityControllerBase<TEqTrainCar, TEqTrainCarReadModel, TEqTrainCarCreateModel, TEqTrainCarUpdateModel>
    {
        public TEqTrainCarController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqTrainCarCreateModel> createValidator, IValidator<TEqTrainCarUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
