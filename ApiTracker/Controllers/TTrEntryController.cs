using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("tracker/[controller]/[action]")]
    public class TTrEntryController : EntityControllerBase<TTrEntry,TTrEntryReadModel,TTrEntryCreateModel,TTrEntryUpdateModel>
    {
        public TTrEntryController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrEntryCreateModel> createValidator, IValidator<TTrEntryUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
		/// 获取库门道闸
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]
        public async Task<ActionResult<PageResult<TTrEntryReadModel>>> GetGateEntry(CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrEntry>();
            predicate = predicate.And(t => t.IsEnable == 1);
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }
    }
}
