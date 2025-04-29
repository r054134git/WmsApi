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
    public class TPlAutoCodeController : EntityControllerBase<TPlAutoCode, TPlAutoCodeReadModel, TPlAutoCodeCreateModel, TPlAutoCodeUpdateModel>
    {
        public TPlAutoCodeController(WmspcrContext dataContext, IMapper mapper, IValidator<TPlAutoCodeCreateModel> createValidator, IValidator<TPlAutoCodeUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
