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
    public class TTrCrossTrainController : EntityControllerBase<TTrCrossTrain, TTrCrossTrainReadModel, TTrCrossTrainCreateModel, TTrCrossTrainUpdateModel>
    {
        public TTrCrossTrainController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrCrossTrainCreateModel> createValidator, IValidator<TTrCrossTrainUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
