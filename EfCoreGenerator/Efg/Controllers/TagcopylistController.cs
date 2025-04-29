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
    public class TagcopylistController : EntityControllerBase<Tagcopylist, TagcopylistReadModel, TagcopylistCreateModel, TagcopylistUpdateModel>
    {
        public TagcopylistController(WmspcrContext dataContext, IMapper mapper, IValidator<TagcopylistCreateModel> createValidator, IValidator<TagcopylistUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
