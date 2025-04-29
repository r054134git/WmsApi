using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;
using WmsApi.Domain;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("admin/[controller]/[action]")]
    public class TRlTransferPrewiredController : EntityControllerBase<TRlTransferPrewired, TRlTransferPrewiredReadModel, TRlTransferPrewiredCreateModel, TRlTransferPrewiredUpdateModel>
    {
        public TRlTransferPrewiredController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRlTransferPrewiredCreateModel> createValidator, IValidator<TRlTransferPrewiredUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {

        }
    }
}
