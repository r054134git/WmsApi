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
    public class TRcTrainNodeController : EntityControllerBase<TRcTrainNode, TRcTrainNodeReadModel, TRcTrainNodeCreateModel, TRcTrainNodeUpdateModel>
    {
        public TRcTrainNodeController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcTrainNodeCreateModel> createValidator, IValidator<TRcTrainNodeUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
