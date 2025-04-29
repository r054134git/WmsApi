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
    public class TTestPreController : EntityControllerBase<TTestPre, TTestPreReadModel, TTestPreCreateModel, TTestPreUpdateModel>
    {
        public TTestPreController(WmspcrContext dataContext, IMapper mapper, IValidator<TTestPreCreateModel> createValidator, IValidator<TTestPreUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
