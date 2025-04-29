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
    public class TRcCameraIdsController : EntityControllerBase<TRcCameraIds, TRcCameraIdsReadModel, TRcCameraIdsCreateModel, TRcCameraIdsUpdateModel>
    {
        public TRcCameraIdsController(WmspcrContext dataContext, IMapper mapper, IValidator<TRcCameraIdsCreateModel> createValidator, IValidator<TRcCameraIdsUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
