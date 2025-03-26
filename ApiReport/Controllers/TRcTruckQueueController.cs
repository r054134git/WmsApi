using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Linq;
using WmsApi.Controllers;
using WmsApi;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

//public class TruckBayQueueWithCountDto : TRcTruckBayQueueReadModel
//{
//    public int Count { get; set; }
//}

namespace ApiReport.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcTruckQueueController : EntityControllerBase<TRcTruckBayQueue, TRcTruckBayQueueReadModel, TRcTruckBayQueueCreateModel, TRcTruckBayQueueUpdateModel>
    {
        public TRcTruckQueueController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcTruckBayQueueCreateModel> createValidator, IValidator<TRcTruckBayQueueUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {

        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcTruckBayQueueWithCountDto>>>
            GetPageByStringH([FromQuery] PageParam pageParam, string where, [FromQuery] string[] time,
                     string orders, CancellationToken cancellationToken)
        {
            // 1. 构建主表查询（TRcTruckBayQueue）
            var baseQuery = GetQueryByString(where, orders)
                .Where(t => t.CreateTime >= Convert.ToDateTime(time[0])
                           && t.CreateTime <= Convert.ToDateTime(time[1]));
            //.OrderBy(t => t.SortNo); // 保留原有排序

            // 2. 分页查询（优先执行分页减少数据量）
            var pagedResult = await QueryPageModel(baseQuery, pageParam, cancellationToken);

            // 3. 提取当前分页数据中的主编号列表
            var mainNos = pagedResult.Data
                .Select(x => x.MainLoadingNo)
                .Distinct()
                .ToList();

            // 4. 查询原始数据（加载到内存）
            var dataList = await DataContext.Set<TPlTruckLoadList>()
                .Where(x => mainNos.Contains(x.MainTruckLoadingNo)
                           && x.OperationMark == "N"
                           //&& x.IsEnable == 1
                           )
                .ToListAsync(cancellationToken);

            // 5. 在内存中执行分组和求和
            var sumDict = dataList
                .GroupBy(x => x.MainTruckLoadingNo)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(item =>
                        int.TryParse(item.Count, out int count) ? count : 0)
                );

            // 6. 映射到 DTO
            var dtoList = pagedResult.Data.Select(item =>
            {
                // 复制主表属性
                // 需要先配置 AutoMapper
                var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<TRcTruckBayQueueReadModel, TRcTruckBayQueueWithCountDto>());
                var mapper = config.CreateMapper();

                // 使用映射器
                var dto = mapper.Map<TRcTruckBayQueueWithCountDto>(item);
                dto.Count = sumDict.GetValueOrDefault(item.MainLoadingNo);
                return dto;
            }).ToList();

            // 7. 返回分页结果
            return Ok(new PageResult<TRcTruckBayQueueWithCountDto>
            {
                Data = dtoList,
                Success = true,
                Total = pagedResult.Total,
                //PageIndex = pageParam.PageIndex,
                //PageSize = pageParam.PageSize
            });
        }
    }
}
