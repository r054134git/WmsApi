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
    public class TTrTodoListController : EntityControllerBase<TTrTodoList, TTrTodoListReadModel, TTrTodoListCreateModel, TTrTodoListUpdateModel>
    {
        public TTrTodoListController(WmspcrContext dataContext, IMapper mapper, IValidator<TTrTodoListCreateModel> createValidator, IValidator<TTrTodoListUpdateModel> updateValidator)
            : base(dataContext, mapper, createValidator, updateValidator)
        {
        }
    }
}
