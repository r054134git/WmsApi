using AutoMapper;
using AutoMapper.QueryableExtensions;
using Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Wms.Telegram;
using WmsApi;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlTruckLoadListHistoryController : EntityControllerBase<TPlTruckLoadList, TPlTruckLoadListReadModel, TPlTruckLoadListCreateModel, TPlTruckLoadListUpdateModel>
    {
        public TPlTruckLoadListHistoryController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlTruckLoadListCreateModel> createValidator, IValidator<TPlTruckLoadListUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }


        /// <summary>
        /// 移库/发货单列表
        /// </summary>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlTruckLoadListReadModel>>> GetAllLoadingNos([FromQuery] PageParam pageParam, string where, string orders)
        {
            var repoPlLoadList = DataContext.Set<TPlTruckLoadList>();
            var predicate = ExpressionBuilder.True<TPlTruckLoadList>();
            predicate = predicate.And(t => t.IsFinished == 1 && t.IsEnable == 1);
            var query = repoPlLoadList.AsNoTracking();
            query = query.Where(predicate);
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }
            var listResult = await QueryPageModel(query, pageParam);
            return Ok(listResult);
        }

        /// <summary>
        /// 移库/发货 已挑库
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<PageResult<TPlMaterialReadModel>>> GetAllPicked(string vehicleNo, string truckLoadingNo, string detailNo,
            string where, string orders, CancellationToken cancellationToken)
        {
            List<TPlMaterialReadModel> result = new List<TPlMaterialReadModel>();
            var plLoadList = await DataContext.Set<TPlTruckLoadList>().
                FirstOrDefaultAsync(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.TruckLoadingNo == truckLoadingNo && t.DetailNo == detailNo);
            if (plLoadList == null)
            {
                return new PageResult<TPlMaterialReadModel>();
            }
            var plMaterials = DataContext.Set<TPlMaterial>();
            var query = plMaterials.AsNoTracking();
            query = query.Where(t => t.TruckLoadListId == plLoadList.Id);
            if (!string.IsNullOrWhiteSpace(where))
            {
                query = query.Where(where);
            }
            if (orders != null && orders.Any())
            {
                query = query.OrderBy(orders);
            }
            var tpl = await query.ProjectTo<TPlMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            result.AddRange(tpl);
            return new PageResult<TPlMaterialReadModel>
            {
                Data = result
            };
        }

        /// <summary>
        /// 移库/发货出库撤销
        /// </summary>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Cancel(string vehicleNo, string mainTruckLoadingNo, string sourceHouse, CancellationToken cancellationToken)
        {
            var identityName = MesUser.GetUserName(sourceHouse);
            //确认装车清单状态
            var plLoadLists = DataContext.Set<TPlTruckLoadList>()
                .Where(t => t.IsEnable == 1 && t.VehicleNo == vehicleNo && t.MainTruckLoadingNo == mainTruckLoadingNo && t.SourceHouse == sourceHouse).ToList();
            if (plLoadLists == null || plLoadLists.Count == 0)
            {
                return new OperationResult(false, $"车号{vehicleNo}不存在");
            }
            foreach (var plLoadList in plLoadLists)
            {
                plLoadList.IsFinished = 0;
            }

            var confirmLoad = plLoadLists.FirstOrDefault();
            var truckTran = await DataContext.Set<TPlTruckTransfer>().FirstOrDefaultAsync(t => confirmLoad.DeliveryOrderNo.Contains(t.TransferNo));
            if (truckTran != null)
            {
                truckTran.PickState = 2;
            }
            await DataContext.SaveChangesAsync(cancellationToken);

            var mbs = ServiceProvider.GetService<MbsProxy>();
            var teleWMBM12 = new TeleWMBM12
            {
                Payload = new TruckOutBound
                {
                    OperationMark = "R",
                    Card = confirmLoad.CardNo,
                    MainTruckLoadingNo = confirmLoad.MainTruckLoadingNo,
                    TruckLoadingNo = confirmLoad.TruckLoadingNo,
                    OrderInformNo = confirmLoad.DeliveryOrderNo,
                    OrderNo = confirmLoad.OrderNo,
                    DetailNo = confirmLoad.DetailNo,
                    TruckNo = confirmLoad.VehicleNo,
                    SourceHouse = confirmLoad.SourceHouse,
                    Operator = identityName
                }
            };
            await mbs.Publish(teleWMBM12);

            //撤销发货实绩成功，
            return new OperationResult(true, $"车牌号{vehicleNo}撤销出库完成");
        }
    }
}
