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
            // ���ݲ�ѯ�ַ���������ȡ����ҳ
            // �÷���ͨ��������ѯ�ַ�����ɸѡ���������������ط�ҳ�����ݼ�
            // ����:
            //   pageParam: ������ҳ��Ϣ�Ĳ�������ҳ���ÿҳ��С
            //   where: ����ɸѡ����Ĳ�ѯ�����ַ���
            //   orders: �������������ֶκ�˳���ַ���
            //   cancellationToken: ����ȡ���첽����������

            //if (!string.IsNullOrEmpty(where))
            //{
            //    where = where + " and NO like \"H%\"";
            //}

            // �����ṩ�Ĳ�ѯ�����������ַ���������ѯ����
            var query = GetQueryByString(where, orders);

            // ��һ��ɸѡ��ѯ�����ų�DispatchStepStateΪ4�������ֻ�������8Сʱ�ڵļ�¼����SortNo����
            query = query.Where(t => t.DispatchStepState != 4 && t.CreateTime > DateTime.Now.AddHours(-8)).OrderBy(t => t.SortNo);

            // ִ�з�ҳ��ѯ����ȡ���
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);

            // ���ط�ҳ��ѯ���
            return Ok(listResult);
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrTruckBayQueueWithCountDto>>>
            GetPageByStringH([FromQuery] PageParam pageParam, string where, [FromQuery] string[] time,
                     string orders, CancellationToken cancellationToken)
        {
            // 1. ���������ѯ��TTrTruckBayQueue��
            var baseQuery = GetQueryByString(where, orders)
                .Where(t => t.CreateTime >= Convert.ToDateTime(time[0])
                           && t.CreateTime <= Convert.ToDateTime(time[1]));
                //.OrderBy(t => t.SortNo); // ����ԭ������

            // 2. ��ҳ��ѯ������ִ�з�ҳ������������
            var pagedResult = await QueryPageModel(baseQuery, pageParam, cancellationToken);

            // 3. ��ȡ��ǰ��ҳ�����е�������б�
            var mainNos = pagedResult.Data
                .Select(x => x.MainLoadingNo)
                .Distinct()
                .ToList();

            // 4. ��ѯԭʼ���ݣ����ص��ڴ棩
            var dataList = await DataContext.Set<TPlTruckLoadList>()
                .Where(x => mainNos.Contains(x.MainTruckLoadingNo)
                           && x.OperationMark == "N"
                           //&& x.IsEnable == 1
                           )
                .ToListAsync(cancellationToken);

            // 5. ���ڴ���ִ�з�������
            var sumDict = dataList
                .GroupBy(x => x.MainTruckLoadingNo)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(item =>
                        int.TryParse(item.Count, out int count) ? count : 0)
                );

            // 6. ӳ�䵽 DTO
            var dtoList = pagedResult.Data.Select(item =>
            {
                // ������������
                // ��Ҫ������ AutoMapper
                var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<TTrTruckBayQueueReadModel, TTrTruckBayQueueWithCountDto>());
                var mapper = config.CreateMapper();

                // ʹ��ӳ����
                var dto = mapper.Map<TTrTruckBayQueueWithCountDto>(item);
                dto.Count = sumDict.GetValueOrDefault(item.MainLoadingNo);
                return dto;
            }).ToList();

            // 7. ���ط�ҳ���
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
        /// ������Ҫװ������ѯ�Ŷӳ���װ���ľ���Ϣ
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
