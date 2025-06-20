using AutoMapper;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
	public class TTrTruckController : EntityControllerBase<TTrTruck, TTrTruckReadModel, TTrTruckCreateModel, TTrTruckUpdateModel>
	{
		public TTrTruckController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrTruckCreateModel> createValidator, IValidator<TTrTruckUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}

        [HttpGet("")]
        public async Task<ActionResult<List<TTrTruckReadModel>>> GetAllTrucks(string bayId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrTruck>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(t => t.Id == bayId);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
            
        }

        /// <summary>
        /// 获取当前进库汽车排队信息
        /// </summary>
        /// <param name="bayName">装卷仓库名称列表</param>
        /// <param name="dispatchState">发送状态</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<List<TTrTruckReadModel>>> GetAllTruckLines(string bayName, int dispatchState, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrTruck>();
            if (bayName.IsValidValue())
            {
                predicate = predicate.And(x => x.LoadBayCodeList.Contains(bayName)
                                               && (x.IsDriverCheckIn == 1 || x.TruckLoadType == 2)
                                               //&& (x.CurrentHouseId == "" || x.CurrentHouseId == null)
                                               );
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);

        }

        [HttpGet("")]
        public async Task<(bool, string)> TruckLoadConfirm(string houseId, string truckName, CancellationToken cancellationToken)
        {
            return (false, "库内暂时没有该汽车");
        }

        [HttpGet("")]
        public async Task<(bool, string)> TruckPickConfirm(string houseId, string truckName, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrTruck>();
            if (houseId.IsValidValue())
            {
                //predicate = predicate.And(t => t.CurrentHouseId == houseId && t.TruckNo == truckName);
            }
            return (false, "库内暂时没有该汽车");
            //var query = GetQueryable(predicate);
            //var listResult = await QueryListModel(query, cancellationToken);
            
        }

        [HttpGet("")]
        public async Task<(bool, string)> TruckLeaveConfirm(string houseId, string houseName, string truckName, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrTruck>();
            if (houseId.IsValidValue())
            {
                //predicate = predicate.And(t => t.CurrentHouseId == houseId && t.Name == truckName);
            }
            return (false, "库内暂时没有该汽车");
        }

        [HttpGet("")]
        public async Task<string> TruckArriveStation(string houseId, string truckName, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrTruck>();
            if (houseId.IsValidValue())
            {
                //predicate = predicate.And(t => t.CurrentHouseId == houseId && t.Name == truckName);
            }
            return "库内暂时没有该汽车";
        }
        [HttpGet("")]
        public async Task<string> TruckEntryStation(string houseId, string truckId, int stationNo, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrTruck>();
            if (houseId.IsValidValue())
            {
                var truck = predicate.And(t => t.Id == truckId);
                var query = GetQueryOrderByIdDesc(truck);
                var listResult = await ReadModel(query, cancellationToken);
                if (listResult != null)
                {
                    //listResult.CurrentHouseId = houseId;
                    //listResult.CurrentStationNo = stationNo;
                    listResult.DispatchState = 2;
                    //await predicate.CommitChangesAsync();
                    return "提交成功";
                }
                return "库内暂时没有该汽车";
            }
            return "仓库编号为空";
        }
    }
}
