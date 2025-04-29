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
    public class TRcCraneTaskController : EntityControllerBase<TRcCraneTask, TRcCraneTaskReadModel, TRcCraneTaskCreateModel, TRcCraneTaskUpdateModel>
    {
        public TRcCraneTaskController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcCraneTaskCreateModel> createValidator, IValidator<TRcCraneTaskUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
