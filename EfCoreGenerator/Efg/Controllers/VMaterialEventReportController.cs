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
    public class VMaterialEventReportController : EntityControllerBase<VMaterialEventReport, VMaterialEventReportReadModel, VMaterialEventReportCreateModel, VMaterialEventReportUpdateModel>
    {
        public VMaterialEventReportController(WmspcrContext dataContext, IMapper mapper, IValidator<VMaterialEventReportCreateModel> createValidator, IValidator<VMaterialEventReportUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
