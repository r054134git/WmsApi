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
    public class VCompareNameNoController : EntityControllerBase<VCompareNameNo, VCompareNameNoReadModel, VCompareNameNoCreateModel, VCompareNameNoUpdateModel>
    {
        public VCompareNameNoController(WmspcrContext dataContext, IMapper mapper, IValidator<VCompareNameNoCreateModel> createValidator, IValidator<VCompareNameNoUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
