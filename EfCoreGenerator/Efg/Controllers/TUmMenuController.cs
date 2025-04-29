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
    public class TUmMenuController : EntityControllerBase<TUmMenu, TUmMenuReadModel, TUmMenuCreateModel, TUmMenuUpdateModel>
    {
        public TUmMenuController(WmspcrContext dataContext, IMapper mapper, IValidator<TUmMenuCreateModel> createValidator, IValidator<TUmMenuUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
