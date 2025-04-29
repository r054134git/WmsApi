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
    public class TWhTrainLocationController : EntityControllerBase<TWhTrainLocation, TWhTrainLocationReadModel, TWhTrainLocationCreateModel, TWhTrainLocationUpdateModel>
    {
        public TWhTrainLocationController(WmspcrContext dataContext, IMapper mapper, IValidator<TWhTrainLocationCreateModel> createValidator, IValidator<TWhTrainLocationUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
