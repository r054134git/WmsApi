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
    public class TTrLocationMaterialCopy1Controller : EntityControllerBase<TTrLocationMaterialCopy1, TTrLocationMaterialCopy1ReadModel, TTrLocationMaterialCopy1CreateModel, TTrLocationMaterialCopy1UpdateModel>
    {
        public TTrLocationMaterialCopy1Controller(WmspcrContext dataContext, IMapper mapper, IValidator<TTrLocationMaterialCopy1CreateModel> createValidator, IValidator<TTrLocationMaterialCopy1UpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
