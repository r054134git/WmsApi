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
    public class TEqTrainController : EntityControllerBase<TEqTrain, TEqTrainReadModel, TEqTrainCreateModel, TEqTrainUpdateModel>
    {
        public TEqTrainController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqTrainCreateModel> createValidator, IValidator<TEqTrainUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
