using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlAutoCodeController : EntityControllerBase<TPlAutoCode, TPlAutoCodeReadModel, TPlAutoCodeCreateModel, TPlAutoCodeUpdateModel>
    {
        public TPlAutoCodeController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlAutoCodeCreateModel> createValidator, IValidator<TPlAutoCodeUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 创建计划编号
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<string>> CreatePlanId()
        {
            var repo = DataContext.Set<TWhStack>();
            var sql = "SELECT F_PL_AUTO_CODE('PLAN','WMS') FROM DUAL";
            var number = SqlQuery(sql, (t) => (string)t[0]).First();
            var id = GetPrimaryId();
            return Ok(number);
        }

        /// <summary>
        /// 创建计划编号
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<string>> CreateTransferNo()
        {
            var repo = DataContext.Set<TWhStack>();
            var sql = "SELECT F_PL_AUTO_CODE('TRANSFER_NO','WMS') FROM DUAL";
            var number = SqlQuery(sql, (t) => (string)t[0]).First();
            var id = GetPrimaryId();
            return Ok(number);
        }
    }
}
