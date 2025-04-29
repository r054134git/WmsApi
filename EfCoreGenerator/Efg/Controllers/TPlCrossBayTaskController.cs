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
    public class TPlCrossBayTaskController : EntityControllerBase<TPlCrossBayTask, TPlCrossBayTaskReadModel, TPlCrossBayTaskCreateModel, TPlCrossBayTaskUpdateModel>
    {
        public TPlCrossBayTaskController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlCrossBayTaskCreateModel> createValidator, IValidator<TPlCrossBayTaskUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
