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
    public class TEqGateParkingController : EntityControllerBase<TEqGateParking, TEqGateParkingReadModel, TEqGateParkingCreateModel, TEqGateParkingUpdateModel>
    {
        public TEqGateParkingController(WmspcrContext dataContext, IMapper mapper, IValidator<TEqGateParkingCreateModel> createValidator, IValidator<TEqGateParkingUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
