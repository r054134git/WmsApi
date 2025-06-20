using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading;
using Cds.Contracts;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using Newtonsoft.Json;
using WmsApi.Contracts;
using System.Collections.Generic;
using Ucp.Contracts;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("equip/[controller]/[action]")]
    public class TEqCrossVehicleController : EntityControllerBase<TEqCrossVehicle, TEqCrossVehicleReadModel, TEqCrossVehicleCreateModel, TEqCrossVehicleUpdateModel>
    {
        public TEqCrossVehicleController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqCrossVehicleCreateModel> createValidator, IValidator<TEqCrossVehicleUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// ���ι��糵
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<TEqCrossVehicleReadModel>> GetCrossCar(string bayCode, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TEqCrossVehicle>();

            if (bayCode.IsValidValue())
            {
                var Bay3 = bayCode.Contains("25") || bayCode.Contains("26") || bayCode.Contains("27");
                var Bay2 = bayCode.Contains("21") || bayCode.Contains("22") || bayCode.Contains("23") || bayCode.Contains("24");
                if (Bay3)
                {
                    predicate = predicate.And(t => t.Name == "���ι��糵");

                }
                else
                {
                    predicate = predicate.And(t => t.Name == "���ι��糵");
                }
                var query = GetQueryOrderByIdDesc(predicate);
                var result = await ReadModel(query, cancellationToken);
                return Ok(result);
            }
            return Ok(false);
        }

        /// <summary>
        /// ���糵ȥ����
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> SendCrossTrainMove(string name, string bayName, int opCmd)
        {
            var eqCrossVehicle = DataContext.Set<TEqCrossVehicle>();
            var whBay = DataContext.Set<TWhBay>();
            var rcLog = DataContext.Set<TRcLog>();
            var repoTr = DataContext.Set<TTrCrossTrain>();
            var trCrossTrains = DataContext.Set<TTrCrossTrain>();
            var trCrossTrain = repoTr.Where(t => t.VehicleName == name).FirstOrDefault();
            var mbs = ServiceProvider.GetService<MbsProxy>();
            if (trCrossTrain.OperationMode == 1)
            {
                if (name.IsValidValue() || bayName.IsValidValue())
                {
                    var trModel = trCrossTrains.Where(t => t.VehicleName == name).FirstOrDefault();
                    var eqModel = eqCrossVehicle.Where(t => t.Name == name).FirstOrDefault();
                    var bayModel = whBay.Where(t => t.Name.Contains(bayName)).FirstOrDefault();
                    //var trLaser = trCrossTrain.Where(t => t.VehicleName == name).FirstOrDefault();
                    var laser = JsonConvert.DeserializeObject<CrossVehicleConfigs>(eqModel.BayDistanceConfig);
                    var crossTrainKey = new Key(trModel.VehiclePlcName, trModel.VehiclePlcName, 0);
                    foreach (var item in laser.Data)
                    {
                        if (item.BayName.Contains(bayName) && bayModel != null)
                        {
                            var cmd = new CrossTrainTaskCommand()
                            {
                                CrossTrainKey = crossTrainKey,
                                BayId = bayModel.Id,
                                Laser = item.LaserDistance,
                                OpCmd = opCmd,
                                TaskNo = "",
                            };
                            await mbs.Publish(cmd);
                            if (opCmd == 1)
                            {
                                var log = new TRcLog
                                {
                                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                                    Dt = DateTime.Now,
                                    EventNo = "1000",
                                    Source = "API",
                                    WarningLevel = "INFO",
                                    Message = $"API����{name}��{item.LaserDistance}��������"
                                };                                 /*��{trLaser.LaserDistance}*/
                                rcLog.Add(log);
                                await DataContext.SaveChangesAsync();
                                return new OperationResult(true, "���糵������");
                            }
                            if (opCmd == 0)
                            {
                                var log = new TRcLog
                                {
                                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                                    Dt = DateTime.Now,
                                    EventNo = "1000",
                                    Source = "API",
                                    WarningLevel = "INFO",
                                    Message = $"API����{name}��ͣ������"
                                };                                 /*��{trLaser.LaserDistance}*/
                                rcLog.Add(log);
                                await DataContext.SaveChangesAsync();
                                return new OperationResult(true, "���糵����ͣ");
                            }
                            if (opCmd == 10)
                            {
                                var log = new TRcLog
                                {
                                    Id = IdWorkerGenerator.Instance.NextId().ToString(),
                                    Dt = DateTime.Now,
                                    EventNo = "1000",
                                    Source = "API",
                                    WarningLevel = "INFO",
                                    Message = $"API����{name}��λ������"
                                };                                 /*��{trLaser.LaserDistance}*/
                                rcLog.Add(log);
                                await DataContext.SaveChangesAsync();
                                return new OperationResult(true, "���糵������λ��");
                            }
                        }
                    }
                }
                return new OperationResult(false, "����Ϊ�գ�����ʧ��");
            }
            return new OperationResult(false, "���糵���Զ�ģʽ���޷�����");
        }

        /// <summary>
        /// ��ȡ��ƿ��
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TEqCrossVehicleReadModel>>> GetElectronicVehicle(CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TEqCrossVehicle>();
            predicate = predicate.And(t => t.Type == 3);
            var query = GetQueryOrderByIdAsc(predicate);
            var result = await QueryListModel(query, cancellationToken);
            return result;
        }
    }
}
