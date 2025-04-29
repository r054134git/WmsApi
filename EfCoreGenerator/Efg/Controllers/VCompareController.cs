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
    public class VCompareController : EntityControllerBase<VCompare, VCompareReadModel, VCompareCreateModel, VCompareUpdateModel>
    {
        public VCompareController(WmspcrContext dataContext, IMapper mapper, IValidator<VCompareCreateModel> createValidator, IValidator<VCompareUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
