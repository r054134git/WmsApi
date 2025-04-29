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
    public class TTrTrainController : EntityControllerBase<TTrTrain, TTrTrainReadModel, TTrTrainCreateModel, TTrTrainUpdateModel>
    {
        public TTrTrainController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrTrainCreateModel> createValidator, IValidator<TTrTrainUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
