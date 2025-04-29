using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using System.Linq;
using WmsApi.Domain.Entities;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using WmsApi;
using WmsApi.Controllers;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlProductionController : EntityControllerBase<TPlProduction, TPlProductionReadModel, TPlProductionCreateModel, TPlProductionUpdateModel>
    {
        public TPlProductionController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlProductionCreateModel> createValidator, IValidator<TPlProductionUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 查询计划上料的物料信息
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<TPlProductionDetailReadModel>>> GetPlanDetails(string planNo)
        {
            List<TPlProductionDetailReadModel> result = new List<TPlProductionDetailReadModel>();

            var planDetails = await DataContext.Set<TPlProductionDetail>()
                                            .Where(t => t.ProductionNo == planNo)
                                            .ProjectTo<TPlProductionDetailReadModel>(Mapper.ConfigurationProvider)
                                            .ToListAsync();
            if (planDetails == null || planDetails.Count == 0)
            {
                return new PageResult<TPlProductionDetailReadModel>();
            }
            result.AddRange(planDetails);
            return new PageResult<TPlProductionDetailReadModel>
            {
                Data = result
            };
        }
    }
}
