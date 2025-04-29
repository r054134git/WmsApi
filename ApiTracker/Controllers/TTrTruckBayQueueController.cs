using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("tracker/[controller]/[action]")]
    public class TTrTruckBayQueueController : EntityControllerBase<TTrTruckBayQueue, TTrTruckBayQueueReadModel, TTrTruckBayQueueCreateModel, TTrTruckBayQueueUpdateModel>
    {
        public TTrTruckBayQueueController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrTruckBayQueueCreateModel> createValidator, IValidator<TTrTruckBayQueueUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [HttpGet("")]
        public override async Task<ActionResult<PageResult<TTrTruckBayQueueReadModel>>>
            GetPageByString([FromQuery] PageParam pageParam, string where,
                            string orders, CancellationToken cancellationToken)
        {
            //if (!string.IsNullOrEmpty(where))
            //{
            //    where = where + " and NO like \"H%\"";
            //}
            var query = GetQueryByString(where, orders);
            query = query.Where(t => t.DispatchStepState != 4 && t.CreateTime > DateTime.Now.AddHours(-8)).OrderBy(t => t.SortNo);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 根据主要装车单查询排队车辆装车的卷信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<List<VPlMaterialReadModel>>>
            GetLoadTruckList(string truckNo, string mainLoadingNo, string bayCode, CancellationToken cancellationToken)
        {

            var loadList = await DataContext.Set<TPlTruckLoadList>().Where(t => t.IsEnable == 1 && t.MainTruckLoadingNo == mainLoadingNo && t.VehicleNo == truckNo).ToListAsync();
            if (loadList.Count > 0)
            {
                var loadListIdList = loadList.Select(t => t.Id).ToList();
                var listResult = await DataContext.Set<VPlMaterial>().Where(t => !string.IsNullOrEmpty(t.TruckLoadListId) && loadListIdList.Contains(t.TruckLoadListId) && t.BayCode == bayCode).ToListAsync();
                return Ok(listResult);
            }
            return Ok();
        }

    }
}
