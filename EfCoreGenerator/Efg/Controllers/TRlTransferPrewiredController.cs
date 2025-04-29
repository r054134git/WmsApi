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
    public class TRlTransferPrewiredController : EntityControllerBase<TRlTransferPrewired, TRlTransferPrewiredReadModel, TRlTransferPrewiredCreateModel, TRlTransferPrewiredUpdateModel>
    {
        public TRlTransferPrewiredController(WmspcrContext dataContext, IMapper mapper, IValidator<TRlTransferPrewiredCreateModel> createValidator, IValidator<TRlTransferPrewiredUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
