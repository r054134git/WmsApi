using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ucp.Contracts;
using Wms.Telegram;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;


namespace WmsApi.Controllers
{
    [ApiController]
    [Route("tracker/[controller]/[action]")]
    public class TTrCrossTrainController : EntityControllerBase<TTrCrossTrain, TTrCrossTrainReadModel, TTrCrossTrainCreateModel, TTrCrossTrainUpdateModel>
    {
        public TTrCrossTrainController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrCrossTrainCreateModel> createValidator, IValidator<TTrCrossTrainUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 各课过跨车
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<TTrCrossTrainReadModel>> GetCrossCar(string bayCode, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrCrossTrain>();

            if (bayCode.IsValidValue())
            {
                var Bay3 = bayCode.Contains("25") || bayCode.Contains("26") || bayCode.Contains("27");
                var Bay2 = bayCode.Contains("21") || bayCode.Contains("22") || bayCode.Contains("23") || bayCode.Contains("24");
                if (Bay3)
                {
                    predicate = predicate.And(t => t.VehicleName == "三课过跨车");
                }
                else if (Bay2)
                {
                    predicate = predicate.And(t => t.VehicleName == "二课过跨车");
                }
                var query = GetQueryOrderByIdDesc(predicate);
                var result = await ReadModel(query, cancellationToken);
                return Ok(result);
            }
            return Ok(false);
        }

        /// <summary>
        /// 电瓶车信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<TTrCrossTrainReadModel>> GetElectronicVehicle(string name, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TTrCrossTrain>();

            if (name.IsValidValue())
            {
                predicate = predicate.And(t => t.VehicleName == name);
                var query = GetQueryOrderByIdDesc(predicate);
                var result = await ReadModel(query, cancellationToken);
                return Ok(result);
            }
            return Ok(false);
        }

        /// <summary>
        /// 更改过跨车锁定状态
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> UpdateIsLock([FromQuery] string id, [FromQuery] int islock, CancellationToken cancellationToken)
        {
            var trCrossTrains = DataContext.Set<TTrCrossTrain>();
            var mbs = ServiceProvider.GetService<MbsProxy>();
            if (id != null && id != "")
            {
                var trModel = trCrossTrains.Where(t => t.Id == id).FirstOrDefault();
                var crossTrainKey = new Key(trModel.VehiclePlcName, trModel.VehiclePlcName, 0);
                var payLoad = new ConveyorUnLockCommand()
                {
                    ConveyorId = crossTrainKey,
                    SaddleNo = 0,
                    Lock = islock == 1 ? true : false
                };
                await mbs.Publish(payLoad);
                var trCross = trCrossTrains.FirstOrDefault(t => t.Id == id);
                trCross.IsLock = islock;
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            var islockname = islock == 1 ? "锁定" : islock == 2 ? "解锁" : "";
            return new OperationResult(true, $"{islockname}状态更新成功！");
        }

        /// <summary>
        /// 过跨车作业类型更改
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> UpdateCrossTrainTaskType(string name, int type, string fromBay, string destBay, CancellationToken cancellationToken)
        {
            var trCrossTrains = DataContext.Set<TTrCrossTrain>();
            var trModel = trCrossTrains.Where(t => t.VehicleName == name).FirstOrDefault();
            if (type == 1)
            {
                trModel.TaskType = type;
                trModel.ParkedState = 0;
                trModel.FromBayName = null;
                trModel.DestBayName = null;
                await DataContext.SaveChangesAsync(cancellationToken);
                return new OperationResult(true, $"{name}已更改为库间倒运");
            }
            if (type == 2 && fromBay != null && destBay != null)
            {
                trModel.TaskType = type;
                trModel.ParkedState = 0;
                trModel.FromBayName = fromBay;
                trModel.DestBayName = destBay;
                await DataContext.SaveChangesAsync(cancellationToken);
                return new OperationResult(true, $"{name}已更改为下线倒运");
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(false, $"{name}类型更改失败");
        }
    }
}
