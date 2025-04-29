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
    public class TUmShiftController : EntityControllerBase<TUmShift, TUmShiftReadModel, TUmShiftCreateModel, TUmShiftUpdateModel>
    {
        public TUmShiftController(WmspcrContext dataContext, IMapper mapper, IValidator<TUmShiftCreateModel> createValidator, IValidator<TUmShiftUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
