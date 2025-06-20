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
            // 根据查询字符串参数获取数据页
            // 该方法通过解析查询字符串来筛选和排序结果，并返回分页的数据集
            // 参数:
            //   pageParam: 包含分页信息的参数，如页码和每页大小
            //   where: 用于筛选结果的查询条件字符串
            //   orders: 用于排序结果的字段和顺序字符串
            //   cancellationToken: 用于取消异步操作的令牌

            //if (!string.IsNullOrEmpty(where))
            //{
            //    where = where + " and NO like \"H%\"";
            //}

            // 根据提供的查询条件和排序字符串构建查询对象
            var query = GetQueryByString(where, orders);

            // 进一步筛选查询对象，排除DispatchStepState为4的项，并且只包含最近8小时内的记录，按SortNo排序
            query = query.Where(t => t.DispatchStepState != 4 && t.CreateTime > DateTime.Now.AddHours(-8)).OrderBy(t => t.SortNo);

            // 执行分页查询并获取结果
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);

            // 返回分页查询结果
            return Ok(listResult);
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrTruckBayQueueWithCountDto>>>
            GetPageByStringH([FromQuery] PageParam pageParam, string where, [FromQuery] string[] time,
                     string orders, CancellationToken cancellationToken)
        {
            // 1. 构建主表查询（TTrTruckBayQueue）
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
                    cfg.CreateMap<TTrTruckBayQueueReadModel, TTrTruckBayQueueWithCountDto>());
                var mapper = config.CreateMapper();

                // 使用映射器
                var dto = mapper.Map<TTrTruckBayQueueWithCountDto>(item);
                dto.Count = sumDict.GetValueOrDefault(item.MainLoadingNo);
                return dto;
            }).ToList();

            // 7. 返回分页结果
            return Ok(new PageResult<TTrTruckBayQueueWithCountDto>
            {
                Data = dtoList,
                Success = true,
                Total = pagedResult.Total,
                //PageIndex = pageParam.PageIndex,
                //PageSize = pageParam.PageSize
            });
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
