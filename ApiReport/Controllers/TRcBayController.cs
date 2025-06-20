using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Linq;
using WmsApi.Controllers;

namespace ApiReport.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcBayController : EntityControllerBase<TRcBay,TRcBayReadModel,TRcBayCreateModel,TRcBayUpdateModel>
    {
        public TRcBayController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcBayCreateModel>createValidator, IValidator<TRcBayUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {

        }
    }
}
