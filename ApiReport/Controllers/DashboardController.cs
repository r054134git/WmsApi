using Aspose.Cells.Drawing;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using MiniExcelLibs;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using static MassTransit.ValidationResultExtensions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class DashboardController : QueryControllerBase<TRcLog, TRcLogReadModel, TRcLogCreateModel, TRcLogUpdateModel>
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public DashboardController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcLogCreateModel> createValidator, IValidator<TRcLogUpdateModel> updateValidator, IHubContext<ChatHub> hubContext)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
            _hubContext = hubContext;
        }

        /// <summary>
        /// 月（30天）入库曲线
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<int>>> GetCraneInbound(string bayId)
        {
            var whBays = DataContext.Set<TWhBay>();
            var bay = await whBays.Where(t => t.Id == bayId).FirstOrDefaultAsync();
            var result = new PageResult<int>();
            var listMon = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                var Nowtime = Convert.ToDateTime(DateTime.Now.AddDays(i - 29).ToString("yyyy-MM-dd"));
                var houTime = Convert.ToDateTime(DateTime.Now.AddDays(i + 1 - 29).ToString("yyyy-MM-dd"));
                var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();

                //入库
                var inputW = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                     && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                     && t.Dt > Nowtime
                     && t.Dt <= houTime
                      && t.Result == "成功"
                    ).Count();
                listMon.Add(inputW);
            }
            result.Success = true;
            result.Data = listMon;
            result.Message = "";
            return result;
        }

        /// <summary>
        /// 月（30天）出库曲线
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<int>>> GetCraneOutbound(string bayId)
        {
            var whBays = DataContext.Set<TWhBay>();
            var bay = await whBays.Where(t => t.Id == bayId).FirstOrDefaultAsync();
            var result = new PageResult<int>();
            var listMon = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                var Nowtime = Convert.ToDateTime(DateTime.Now.AddDays(i - 29).ToString("yyyy-MM-dd"));
                var houTime = Convert.ToDateTime(DateTime.Now.AddDays(i + 1 - 29).ToString("yyyy-MM-dd"));
                var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
                //出库
                var outW = rcMaterialEvents.
                        Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                        && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > Nowtime
                         && t.Dt <= houTime
                          && t.Result == "成功"
                        ).Count();
                listMon.Add(outW);
            }
            result.Success = true;
            result.Data = listMon;
            result.Message = "";
            return result;
        }

        /// <summary>
        /// 一层，二层垛位钢卷数量
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<StackNumModel>>> GetStackNum(string bayId, int floor)
        {
            var ds = DataContext.Set<TTrLocationMaterial>();
            var stackFind = ds.Where(t => t.BayId == bayId && t.Type == 2 && t.IsEnable == 1 && t.FloorNo == floor).Count();
            var stackNoFind = ds.Where(t => t.BayId == bayId && t.Type == 0 && t.IsEnable == 1 && t.FloorNo == floor).Count();
            var result = new PageResult<StackNumModel>();
            List<StackNumModel> stack = new()
            {
                new StackNumModel() { value = stackNoFind, name = "空垛" },
                new StackNumModel() { value = stackFind, name = "满垛" }
            };
            result.Success = true;
            result.Data = stack;
            result.Message = "查询垛位钢卷数量成功";
            return result;
        }

        /// <summary>
        /// 班组实时信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<List<int>>>> GetGroup(string bayId)
        {
            var result = new PageResult<List<int>>();
            if (bayId == "1510090392011018240")
            {
                List<List<int>> list = new List<List<int>>();
                List<int> day = new List<int>() { 1, 4, 2, 4, 7 };
                List<int> month = new List<int>() { 2, 6, 3, 7, 8 };
                list.Add(day);
                list.Add(month);
                result.Success = true;
                result.Data = list;
                result.Message = "";
            }
            else if (bayId == "1510090554074730496")
            {
                List<List<int>> list = new List<List<int>>();
                List<int> day = new List<int>() { 6, 9, 2, 5, 2 };
                List<int> month = new List<int>() { 8, 2, 6, 3, 1 };
                list.Add(day);
                list.Add(month);
                result.Success = true;
                result.Data = list;
                result.Message = "";
            }
            return result;
        }

        /// <summary>
        /// 待调运任务统计
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlBayReadModel>>> GetCraneTask(string bayId, CancellationToken cancellationToken)
        {
            var plBays = DataContext.Set<TPlBay>();
            var plbayList = plBays.Where(t => t.BayId == bayId).OrderByDescending(t => t.PlanNo).Take(20);
            var results = await plbayList
                .ProjectTo<TPlBayReadModel>(Mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var result = new PageResult<TPlBayReadModel>
            {
                Success = true,
                Data = results,
                Message = ""
            };
            return result;
        }

        /// <summary>
        /// 任务实时统计
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<Double>>> GetDayTask(string bayId)
        {
            var whBays = DataContext.Set<TWhBay>();
            var bay = await whBays.Where(t => t.Id == bayId).FirstOrDefaultAsync();
            var result = new PageResult<Double>();
            var Nowtime = Convert.ToDateTime(DateTime.Now.AddDays(0).ToString("yyyy-MM-dd"));
            var houTime = Convert.ToDateTime(DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
            var hour = DateTime.Now.Hour;
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();

            //入库
            var inputW = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                 && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                 && t.Dt > Nowtime
                 && t.Dt <= houTime
                  && t.Result == "成功"
                ).Count();

            //出库
            var outW = rcMaterialEvents.
                    Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                     && t.Dt > Nowtime
                     && t.Dt <= houTime
                      && t.Result == "成功"
                    ).Count();

            //倒垛
            var fromLocatinTo1 = rcMaterialEvents.
                  Where(t => t.OperationType == "自动" && t.ContentType == "倒垛"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                     && t.Dt > Nowtime
                     && t.Dt <= houTime
                      && t.Result == "成功"
                   ).Count();


            var fromLocatinTo = rcMaterialEvents.Where(t => t.OperationType == "自动"
                        && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")
                        && !t.FromLocationName.Contains("" + bay.Code + "0M")
                        && !t.FromLocationName.Contains("" + bay.Code + "0N")
                        && !t.ToLocationName.Contains("" + bay.Code + "P")
                        && t.Dt > Nowtime
                        && t.Dt <= houTime
                        && t.Result == "成功"
                   ).Count();


            Double outxl = Math.Round((Double)outW / (Double)hour, 2);
            Double inputxl = Math.Round((Double)inputW / (Double)hour, 2);
            result.Success = true;
            result.Data = new List<Double>() { inputW + outW + fromLocatinTo, inputW, outW, fromLocatinTo, outxl, inputxl };
            result.Message = "查询成功！";
            return result;
        }


        /// <summary>
        /// 库存钢卷宽度
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<StackNumModel>>> GetMaterialWidth(string bayId)
        {
            var result = new PageResult<StackNumModel>();
            var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
            var list = await trLocationMaterials.Where(t => t.BayId == bayId && t.IsEnable == 1 && t.Type == 2).Select(t => t.Width).Distinct().ToListAsync();
            List<StackNumModel> stack = new();
            foreach (var item in list)
            {
                stack.Add(new StackNumModel() { value = await GetWidthNumAsync(bayId, item), name = item.ToString() });
            }
            result.Success = true;
            result.Data = stack;
            result.Message = "";
            return result;
        }

        [HttpGet("")]
        protected async Task<int> GetWidthNumAsync(string bayId, int? witdh)
        {
            var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
            var count = await trLocationMaterials.Where(t => t.BayId == bayId && t.IsEnable == 1 && t.Type == 2 && t.Width == witdh).CountAsync();
            return count;
        }

        /// <summary>
        /// 在库时间
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<StackNumModel>>> GetMaterialInTime(string bayId)
        {
            var result = new PageResult<StackNumModel>();
            var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
            var dateNow5 = DateTime.Now.AddDays(-5);
            var dateNow10 = DateTime.Now.AddDays(-10);
            var list5 = await trLocationMaterials.Where(t => t.BayId == bayId && t.IsEnable == 1 && t.Type == 2 && t.UpdateTime > dateNow5).CountAsync();
            var list10 = await trLocationMaterials.Where(t => t.BayId == bayId && t.IsEnable == 1 && t.Type == 2 && t.UpdateTime < dateNow5 && t.UpdateTime > dateNow10).CountAsync();
            var listElse = await trLocationMaterials.Where(t => t.BayId == bayId && t.IsEnable == 1 && t.Type == 2 && t.UpdateTime <= dateNow10).CountAsync();
            List<StackNumModel> list = new List<StackNumModel>
            {
                new StackNumModel() { value = list5, name = "<=5天" },
                new StackNumModel() { value = list10, name = "5-10天" },
                new StackNumModel() { value = listElse, name = ">=10天" }
            };
            result.Success = true;
            result.Data = list;
            return result;
        }

        /// <summary>
        /// 中间行车大屏
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>> GetSlabModel(string bayId, CancellationToken cancellationToken)
        {

            var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
            var query = trLocationMaterials.Where(t => t.BayId == bayId && t.IsEnable == 1 && t.Type == 2);

            var results = await query
               .ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider)
               .ToListAsync(cancellationToken);

            var result = new PageResult<TTrLocationMaterialReadModel>
            {
                Success = true,
                Data = results,
                Message = ""
            };
            return result;

        }

        /// <summary>
        /// 中间行车大屏鞍座
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>> GetSlabModelAz(string bayId, CancellationToken cancellationToken)
        {

            var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
            var query = trLocationMaterials.Where(t => t.BayId == bayId && t.IsEnable == 1 && t.FloorNo == 1);

            var results = await query
               .ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider)
               .ToListAsync(cancellationToken);

            var result = new PageResult<TTrLocationMaterialReadModel>
            {
                Success = true,
                Data = results,
                Message = ""
            };
            return result;

        }


        /// <summary>
        /// 大小车移动速度
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<CraneSpeed>>> GetCraneSpeed(string bayId)
        {
            var result = new PageResult<CraneSpeed>();
            if (bayId == "1510090392011018240")
            {
                result.Success = true;
                List<CraneSpeed> list = new List<CraneSpeed>();
                list.Add(new CraneSpeed() { id = "1", speed1 = 135, speed2 = 8 });
                list.Add(new CraneSpeed() { id = "2", speed1 = 201, speed2 = 13 });
                list.Add(new CraneSpeed() { id = "3", speed1 = 160, speed2 = 8 });
                result.Data = list;
                result.Message = "";
            }
            else if (bayId == "1510090554074730496")
            {
                result.Success = true;
                List<CraneSpeed> list = new List<CraneSpeed>();
                list.Add(new CraneSpeed() { id = "4", speed1 = 185, speed2 = 8 });
                list.Add(new CraneSpeed() { id = "5", speed1 = 199, speed2 = 13 });
                list.Add(new CraneSpeed() { id = "6", speed1 = 172, speed2 = 8 });
                result.Data = list;
                result.Message = "";
            }
            return result;
        }

        /// <summary>
        /// 自动作业比例查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<BLModel>>> GetBIList([FromQuery] PageParam pageParam, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var rcCraneTasks = DataContext.Set<TRcCraneTask>();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var whBays = DataContext.Set<TWhBay>();
            var query = whBays.Where(t => t.IsEnable == 1);
            var baycount = query.Count();
            var baylist = await query.ToListAsync(cancellationToken);
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 09:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");
            if (time.Length > 0 && time != null)
            {
                startime = Convert.ToDateTime(time[0]);
                endtime = Convert.ToDateTime(time[1]);
            }

            var result = new PageResult<BLModel>();
            var listmodel = new List<BLModel>();
            foreach (var bay in baylist)
            {
                if (bay.Code != "18" && bay.Code != "19" && bay.Code != "20")
                {
                    //自动入库
                    var inputZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                         && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                            || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > startime
                         && t.Dt <= endtime
                         && t.Result == "成功"
                        ).Count();

                    //手动入库
                    //var inputR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "入库"
                    //    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    //       || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    //    && t.Dt > startime
                    //    && t.Dt <= endtime
                    //     && t.Result == "成功"
                    //   ).Count();
                    //手动入库
                    var inputR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "入库"
                        && !string.IsNullOrEmpty(t.CraneName)
                        && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0M%")
                        || EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0N%"))
                        && t.Dt > startime
                        && t.Dt <= endtime
                         && t.Result == "成功"
                       ).Count();


                    //自动出库
                    var outZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                        && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                        && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                        && t.Dt > startime
                        && t.Dt <= endtime
                         && t.Result == "成功"
                   ).Count();

                    //人工出库
                    var outR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                       && !string.IsNullOrEmpty(t.CraneName)
                       && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                       && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                       && t.Dt > startime
                       && t.Dt <= endtime
                        && t.Result == "成功"
                  ).Count();

                    //人工出库(系统判定)
                    var outRsys = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                       && !string.IsNullOrEmpty(t.CraneName)
                       && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                       //&& (EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%") ||
                       //    t.Description.Contains("装车或是地面"))
                       && t.Description.Contains("装车或是地面")
                       && t.Dt > startime
                       && t.Dt <= endtime
                        && t.Result == "成功"
                     ).Count();

                    //自动倒垛
                    //  var ddZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "倒垛"
                    //     && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    //        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    //     && t.Dt > startime
                    //     && t.Dt <= endtime
                    //      && t.Result == "成功"
                    //).Count();
                    var ddZ = rcMaterialEvents.Where(t => t.OperationType == "自动"
                        && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")

                        && !t.FromLocationName.Contains("" + bay.Code + "0M")
                        && !t.FromLocationName.Contains("" + bay.Code + "0N")
                        && !t.ToLocationName.Contains("" + bay.Code + "P")
                        && t.Dt > startime
                        && t.Dt <= endtime
                         && t.Result == "成功"
                   ).Count();

                    //人工倒垛
                    //  var ddR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "倒垛"
                    //     && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    //        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    //     && t.Dt > startime
                    //     && t.Dt <= endtime
                    //      && t.Result == "成功"
                    //).Count();
                    var ddR = rcMaterialEvents.Where(t => t.OperationType == "人工"
                        && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")

                        && !t.FromLocationName.Contains("" + bay.Code + "0M")
                        && !t.FromLocationName.Contains("" + bay.Code + "0N")
                        && !t.ToLocationName.Contains("" + bay.Code + "P")
                        && t.Dt > startime
                        && t.Dt <= endtime
                         && t.Result == "成功"
                   ).Count();


                    //过跨倒运
                    var ddGK = rcCraneTasks.Where(t => t.PlanTypeName == "过跨倒运"
                         && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                         && t.StartTime > startime
                         && t.EndTime <= endtime
                        ).Count();

                    //库间倒运
                    var ddKJ = rcCraneTasks.Where(t => t.PlanTypeName == "库间倒运"
                         && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                         && t.StartTime > startime
                         && t.EndTime <= endtime
                        ).Count();

                    double inputBl = 0;
                    if ((inputR + inputZ) != 0)
                    {
                        inputBl = Math.Round((double)inputZ / (inputR + inputZ), 4) * 100;
                    }
                    double outBl = 0;
                    if ((outZ + outR + outRsys) != 0)
                    {
                        outBl = Math.Round((double)outZ / (outZ + outR + outRsys), 4) * 100;
                    }

                    var model = new BLModel()
                    {
                        id = bay.Id,
                        name = bay.Name,
                        inputZ = inputZ,
                        inputR = inputR,
                        outZ = outZ,
                        outR = outR,
                        outRsys = outRsys,
                        ddZ = ddZ,
                        ddR = ddR,
                        ddGK = ddGK,
                        ddKJ = ddKJ,
                        inputBl = inputBl,
                        outBl = outBl,
                    };
                    listmodel.Add(model);
                }
            }

            result.Success = true;
            result.Data = listmodel;
            result.Total = baycount;
            result.Message = "查询统计成功！";
            return result;
        }

        /// <summary>
        /// 自动作业比例详情查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcMaterialEventReadModel>>> GetBIListDetail([FromQuery] PageParam pageParam, [FromQuery] string bayId, [FromQuery] string type, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            if (bayId.IsValidValue())
            {
                var rcCraneTasks = DataContext.Set<TRcCraneTask>();
                var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
                var whBays = DataContext.Set<TWhBay>();
                var query = whBays.Where(t => t.IsEnable == 1 && t.Id == bayId);
                var bay = await query.FirstOrDefaultAsync(cancellationToken);
                var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 09:00:00");
                var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");
                if (time.Length > 0 && time != null)
                {
                    startime = Convert.ToDateTime(time[0]);
                    endtime = Convert.ToDateTime(time[1]);
                }
                var result = new PageResult<TRcMaterialEventReadModel>();
                var listmodel = new List<TRcMaterialEventReadModel>();
                var count = 0;
                if (type == "自动入库")
                {
                    //自动入库
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                         && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                            || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > startime
                         && t.Dt <= endtime
                         && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                }
                if (type == "人工入库")
                {
                    //人工入库
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "入库"
                         && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0M%")
                         || EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0N%"))
                         && t.Dt > startime
                         && t.Dt <= endtime
                         && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                }
                if (type == "自动出库")
                {
                    //自动出库
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                    && t.Dt > startime
                    && t.Dt <= endtime
                    && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                }
                if (type == "人工出库")
                {
                    //人工出库
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                   && t.Dt > startime
                   && t.Dt <= endtime
                   && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                }
                if (type == "系统判定")
                {
                    //人工出库(系统判定)
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && t.Description.Contains("装车或是地面")
                   && t.Dt > startime
                   && t.Dt <= endtime
                   && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                }
                if (type == "自动倒垛")
                {
                    //自动倒垛
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")
                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime
                    && t.Dt <= endtime
                    && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                }
                if (type == "人工倒垛")
                {
                    //人工倒垛
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")
                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime
                    && t.Dt <= endtime
                    && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                }
                if (type == "过跨倒运")
                {
                    //过跨倒运
                    var listQuery = rcCraneTasks.Where(t => t.PlanTypeName == "过跨倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime
                     && t.EndTime <= endtime);
                    count = listQuery.Count();
                    var ddGK = listQuery.Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                    foreach (var item in ddGK)
                    {
                        var rcmodel = new TRcMaterialEventReadModel()
                        {
                            Id = item.Id,
                            MaterialNo = item.MaterialNo,
                            FromLocationName = item.LoadLocationName,
                            ToLocationName = item.UnloadLocationName,
                            Remark = item.Remark,
                        };
                        listmodel.Add(rcmodel);
                    }
                }
                if (type == "库间倒运")
                {
                    //库间倒运
                    var listQuery = rcCraneTasks.Where(t => t.PlanTypeName == "库间倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime
                     && t.EndTime <= endtime);
                    count = listQuery.Count();
                    var ddKJ = listQuery.Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList();
                    foreach (var item in ddKJ)
                    {
                        var rcmodel = new TRcMaterialEventReadModel()
                        {
                            Id = item.Id,
                            MaterialNo = item.MaterialNo,
                            FromLocationName = item.LoadLocationName,
                            ToLocationName = item.UnloadLocationName,
                            Remark = item.Remark,
                        };
                        listmodel.Add(rcmodel);
                    }
                }
                result.Success = true;
                result.Data = listmodel;
                result.Total = count;
                result.Message = "查询统计详情成功！";
                return result;
            }
            else
            {
                var result = new PageResult<TRcMaterialEventReadModel>();
                result.Success = true;
                result.Data = null;
                result.Total = 0;
                result.Message = "查询统计详情成功！";
                return result;
            }
        }

        [HttpGet("")]
        public async Task<PageResult<TRcMaterialEventReadModel>> GetBIListDetailCommon([FromQuery] string bayId, [FromQuery] string type, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            if (bayId.IsValidValue())
            {
                var rcCraneTasks = DataContext.Set<TRcCraneTask>();
                var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
                var whBays = DataContext.Set<TWhBay>();
                var query = whBays.Where(t => t.IsEnable == 1 && t.Id == bayId);
                var bay = await query.FirstOrDefaultAsync(cancellationToken);
                var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 09:00:00");
                var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");
                if (time.Length > 0 && time != null)
                {
                    startime = Convert.ToDateTime(time[0]);
                    endtime = Convert.ToDateTime(time[1]);
                }
                var result = new PageResult<TRcMaterialEventReadModel>();
                var listmodel = new List<TRcMaterialEventReadModel>();
                var count = 0;
                if (type == "自动入库")
                {
                    //自动入库
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                         && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                            || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > startime
                         && t.Dt <= endtime
                         && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).ToList();
                }
                if (type == "人工入库")
                {
                    //人工入库
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "入库"
                         && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0M%")
                         || EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0N%"))
                         && t.Dt > startime
                         && t.Dt <= endtime
                         && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).ToList();
                }
                if (type == "自动出库")
                {
                    //自动出库
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                    && t.Dt > startime
                    && t.Dt <= endtime
                    && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).ToList();
                }
                if (type == "人工出库")
                {
                    //人工出库
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                   && t.Dt > startime
                   && t.Dt <= endtime
                   && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).ToList();
                }
                if (type == "系统判定")
                {
                    //人工出库(系统判定)
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && t.Description.Contains("装车或是地面")
                   && t.Dt > startime
                   && t.Dt <= endtime
                   && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).ToList();
                }
                if (type == "自动倒垛")
                {
                    //自动倒垛
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")
                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime
                    && t.Dt <= endtime
                    && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).ToList();
                }
                if (type == "人工倒垛")
                {
                    //人工倒垛
                    var listQuery = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")
                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime
                    && t.Dt <= endtime
                    && t.Result == "成功");
                    count = listQuery.Count();
                    listmodel = listQuery.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).ToList();
                }
                if (type == "过跨倒运")
                {
                    //过跨倒运
                    var listQuery = rcCraneTasks.Where(t => t.PlanTypeName == "过跨倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime
                     && t.EndTime <= endtime);
                    count = listQuery.Count();
                    var ddGK = listQuery.ToList();
                    foreach (var item in ddGK)
                    {
                        var rcmodel = new TRcMaterialEventReadModel()
                        {
                            Id = item.Id,
                            MaterialNo = item.MaterialNo,
                            FromLocationName = item.LoadLocationName,
                            ToLocationName = item.UnloadLocationName,
                            Remark = item.Remark,
                        };
                        listmodel.Add(rcmodel);
                    }
                }
                if (type == "库间倒运")
                {
                    //库间倒运
                    var listQuery = rcCraneTasks.Where(t => t.PlanTypeName == "库间倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime
                     && t.EndTime <= endtime);
                    count = listQuery.Count();
                    var ddKJ = listQuery.ToList();
                    foreach (var item in ddKJ)
                    {
                        var rcmodel = new TRcMaterialEventReadModel()
                        {
                            Id = item.Id,
                            MaterialNo = item.MaterialNo,
                            FromLocationName = item.LoadLocationName,
                            ToLocationName = item.UnloadLocationName,
                            Remark = item.Remark,
                        };
                        listmodel.Add(rcmodel);
                    }
                }
                result.Success = true;
                result.Data = listmodel;
                result.Total = count;
                result.Message = "查询统计详情成功！";
                return result;
            }
            else
            {
                var result = new PageResult<TRcMaterialEventReadModel>();
                result.Success = true;
                result.Data = null;
                result.Total = 0;
                result.Message = "查询统计详情成功！";
                return result;
            }
        }

        /// <summary>
        /// 生成交接班报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> GetClassListExcel([FromQuery] string house, [FromQuery] string bayCode, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var rcClassStock = DataContext.Set<TRcClassStock>();
            var classStock = rcClassStock.Where(t => t.CreateTime > DateTime.Now.AddDays(-1) && t.HandStockWeight != null);
            var listResult = classStock.ProjectTo<TRcClassStockReadModel>(Mapper.ConfigurationProvider).ToList();
            var classStocks = new List<ClassStockModel>();
            var model = new ClassStockModel();

            foreach (var result in listResult)
            {
                if (result.BayCode == "16")
                {
                    model.Bay16BayCplCount = result.BayCplCount;
                    model.Bay16BayPickedCount = result.BayPickedCount;
                    model.Bay16BayProduceCount = result.BayProduceCount;
                    model.Bay16BayStackCount = result.BayStackCount;
                    model.Bay16CurrentClasses = result.CurrentClasses;
                    model.Bay16DeliveryWeight = result.DeliveryWeight;
                    model.Bay16HandStockWeight = result.HandStockWeight;
                    model.Bay16HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay16LockStockWeight = result.LockStockWeight;
                    model.Bay16MakeStockWeight = result.MakeStockWeight;
                    model.Bay16PickStockWeight = result.PickStockWeight;
                    model.Bay16TakeStockWeight = result.TakeStockWeight;
                    model.House1TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House1HandStockWeight += (decimal)result.HandStockWeight;
                    model.House1DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House1HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House1MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House1LockStockWeight += (decimal)result.LockStockWeight;
                    model.House1PickStockWeight += (decimal)result.PickStockWeight;
                    model.House1CplCount += (int)result.BayCplCount;
                    model.House1PickedCount += (int)result.BayPickedCount;
                    model.House1StackCount += (int)result.BayStackCount;
                    model.House1LbWeight += (decimal)result.BayLbWeight;
                    model.House1LsWeight += (decimal)result.BayLsWeight;
                    model.House1LqWeight += (decimal)result.BayLqWeight;
                    model.House1LyWeight += (decimal)result.BayLyWeight;
                    model.House1RzWeight += (decimal)result.BayRzWeight;
                    model.House1TrainWeight += (decimal)result.BayTrainWeight;
                    model.House1NoneWeight += (decimal)result.BayNoneWeight;
                    model.House1TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer1Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "17")
                {
                    model.Bay17BayCplCount = result.BayCplCount;
                    model.Bay17BayPickedCount = result.BayPickedCount;
                    model.Bay17BayProduceCount = result.BayProduceCount;
                    model.Bay17BayStackCount = result.BayStackCount;
                    model.Bay17CurrentClasses = result.CurrentClasses;
                    model.Bay17DeliveryWeight = result.DeliveryWeight;
                    model.Bay17HandStockWeight = result.HandStockWeight;
                    model.Bay17HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay17LockStockWeight = result.LockStockWeight;
                    model.Bay17MakeStockWeight = result.MakeStockWeight;
                    model.Bay17PickStockWeight = result.PickStockWeight;
                    model.Bay17TakeStockWeight = result.TakeStockWeight;
                    model.House1TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House1HandStockWeight += (decimal)result.HandStockWeight;
                    model.House1DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House1HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House1MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House1LockStockWeight += (decimal)result.LockStockWeight;
                    model.House1PickStockWeight += (decimal)result.PickStockWeight;
                    model.House1CplCount += (int)result.BayCplCount;
                    model.House1PickedCount += (int)result.BayPickedCount;
                    model.House1StackCount += (int)result.BayStackCount;
                    model.House1LbWeight += (decimal)result.BayLbWeight;
                    model.House1LsWeight += (decimal)result.BayLsWeight;
                    model.House1LqWeight += (decimal)result.BayLqWeight;
                    model.House1LyWeight += (decimal)result.BayLyWeight;
                    model.House1RzWeight += (decimal)result.BayRzWeight;
                    model.House1TrainWeight += (decimal)result.BayTrainWeight;
                    model.House1NoneWeight += (decimal)result.BayNoneWeight;
                    model.House1TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer1Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "18")
                {
                    model.Bay18BayCplCount = result.BayCplCount;
                    model.Bay18BayPickedCount = result.BayPickedCount;
                    model.Bay18BayProduceCount = result.BayProduceCount;
                    model.Bay18BayStackCount = result.BayStackCount;
                    model.Bay18CurrentClasses = result.CurrentClasses;
                    model.Bay18DeliveryWeight = result.DeliveryWeight;
                    model.Bay18HandStockWeight = result.HandStockWeight;
                    model.Bay18HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay18LockStockWeight = result.LockStockWeight;
                    model.Bay18MakeStockWeight = result.MakeStockWeight;
                    model.Bay18PickStockWeight = result.PickStockWeight;
                    model.Bay18TakeStockWeight = result.TakeStockWeight;
                    model.House1TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House1HandStockWeight += (decimal)result.HandStockWeight;
                    model.House1DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House1HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House1MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House1LockStockWeight += (decimal)result.LockStockWeight;
                    model.House1PickStockWeight += (decimal)result.PickStockWeight;
                    model.House1CplCount += (int)result.BayCplCount;
                    model.House1PickedCount += (int)result.BayPickedCount;
                    model.House1StackCount += (int)result.BayStackCount;
                    model.House1LbWeight += (decimal)result.BayLbWeight;
                    model.House1LsWeight += (decimal)result.BayLsWeight;
                    model.House1LqWeight += (decimal)result.BayLqWeight;
                    model.House1LyWeight += (decimal)result.BayLyWeight;
                    model.House1RzWeight += (decimal)result.BayRzWeight;
                    model.House1TrainWeight += (decimal)result.BayTrainWeight;
                    model.House1NoneWeight += (decimal)result.BayNoneWeight;
                    model.House1TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer1Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "19")
                {
                    model.Bay19BayProduceCount = result.BayProduceCount;
                    model.Bay19CurrentClasses = result.CurrentClasses;
                    model.Bay19TakeStockWeight = result.TakeStockWeight;
                    model.Bay19HandStockWeight = result.HandStockWeight;
                    model.Bay19DeliveryWeight = result.DeliveryWeight;
                    model.Bay19HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay19MakeStockWeight = result.MakeStockWeight;
                    model.Bay19LockStockWeight = result.LockStockWeight;
                    model.Bay19PickStockWeight = result.PickStockWeight;
                    model.Bay19BayCplCount = result.BayCplCount;
                    model.Bay19BayPickedCount = result.BayPickedCount;
                    model.Bay19BayStackCount = result.BayStackCount;
                    model.House1TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House1HandStockWeight += (decimal)result.HandStockWeight;
                    model.House1DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House1HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House1MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House1LockStockWeight += (decimal)result.LockStockWeight;
                    model.House1PickStockWeight += (decimal)result.PickStockWeight;
                    model.House1CplCount += (int)result.BayCplCount;
                    model.House1PickedCount += (int)result.BayPickedCount;
                    model.House1StackCount += (int)result.BayStackCount;
                    model.House1LbWeight += (decimal)result.BayLbWeight;
                    model.House1LsWeight += (decimal)result.BayLsWeight;
                    model.House1LqWeight += (decimal)result.BayLqWeight;
                    model.House1LyWeight += (decimal)result.BayLyWeight;
                    model.House1RzWeight += (decimal)result.BayRzWeight;
                    model.House1TrainWeight += (decimal)result.BayTrainWeight;
                    model.House1NoneWeight += (decimal)result.BayNoneWeight;
                    model.House1TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer1Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "21")
                {
                    model.Bay21BayCplCount = result.BayCplCount;
                    model.Bay21BayPickedCount = result.BayPickedCount;
                    model.Bay21BayProduceCount = result.BayProduceCount;
                    model.Bay21BayStackCount = result.BayStackCount;
                    model.Bay21CurrentClasses = result.CurrentClasses;
                    model.Bay21DeliveryWeight = result.DeliveryWeight;
                    model.Bay21HandStockWeight = result.HandStockWeight;
                    model.Bay21HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay21LockStockWeight = result.LockStockWeight;
                    model.Bay21MakeStockWeight = result.MakeStockWeight;
                    model.Bay21PickStockWeight = result.PickStockWeight;
                    model.Bay21TakeStockWeight = result.TakeStockWeight;
                    model.House2TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House2HandStockWeight += (decimal)result.HandStockWeight;
                    model.House2DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House2HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House2MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House2LockStockWeight += (decimal)result.LockStockWeight;
                    model.House2PickStockWeight += (decimal)result.PickStockWeight;
                    model.House2CplCount += (int)result.BayCplCount;
                    model.House2PickedCount += (int)result.BayPickedCount;
                    model.House2StackCount += (int)result.BayStackCount;
                    model.House2LbWeight += (decimal)result.BayLbWeight;
                    model.House2LsWeight += (decimal)result.BayLsWeight;
                    model.House2LqWeight += (decimal)result.BayLqWeight;
                    model.House2LyWeight += (decimal)result.BayLyWeight;
                    model.House2RzWeight += (decimal)result.BayRzWeight;
                    model.House2TrainWeight += (decimal)result.BayTrainWeight;
                    model.House2NoneWeight += (decimal)result.BayNoneWeight;
                    model.House2TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer2Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "22")
                {
                    model.Bay22BayCplCount = result.BayCplCount;
                    model.Bay22BayPickedCount = result.BayPickedCount;
                    model.Bay22BayProduceCount = result.BayProduceCount;
                    model.Bay22BayStackCount = result.BayStackCount;
                    model.Bay22CurrentClasses = result.CurrentClasses;
                    model.Bay22DeliveryWeight = result.DeliveryWeight;
                    model.Bay22HandStockWeight = result.HandStockWeight;
                    model.Bay22HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay22LockStockWeight = result.LockStockWeight;
                    model.Bay22MakeStockWeight = result.MakeStockWeight;
                    model.Bay22PickStockWeight = result.PickStockWeight;
                    model.Bay22TakeStockWeight = result.TakeStockWeight;
                    model.House2TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House2HandStockWeight += (decimal)result.HandStockWeight;
                    model.House2DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House2HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House2MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House2LockStockWeight += (decimal)result.LockStockWeight;
                    model.House2PickStockWeight += (decimal)result.PickStockWeight;
                    model.House2CplCount += (int)result.BayCplCount;
                    model.House2PickedCount += (int)result.BayPickedCount;
                    model.House2StackCount += (int)result.BayStackCount;
                    model.House2LbWeight += (decimal)result.BayLbWeight;
                    model.House2LsWeight += (decimal)result.BayLsWeight;
                    model.House2LqWeight += (decimal)result.BayLqWeight;
                    model.House2LyWeight += (decimal)result.BayLyWeight;
                    model.House2RzWeight += (decimal)result.BayRzWeight;
                    model.House2TrainWeight += (decimal)result.BayTrainWeight;
                    model.House2NoneWeight += (decimal)result.BayNoneWeight;
                    model.House2TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer2Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "23")
                {
                    model.Bay23BayCplCount = result.BayCplCount;
                    model.Bay23BayPickedCount = result.BayPickedCount;
                    model.Bay23BayProduceCount = result.BayProduceCount;
                    model.Bay23BayStackCount = result.BayStackCount;
                    model.Bay23CurrentClasses = result.CurrentClasses;
                    model.Bay23DeliveryWeight = result.DeliveryWeight;
                    model.Bay23HandStockWeight = result.HandStockWeight;
                    model.Bay23HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay23LockStockWeight = result.LockStockWeight;
                    model.Bay23MakeStockWeight = result.MakeStockWeight;
                    model.Bay23PickStockWeight = result.PickStockWeight;
                    model.Bay23TakeStockWeight = result.TakeStockWeight;
                    model.House2TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House2HandStockWeight += (decimal)result.HandStockWeight;
                    model.House2DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House2HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House2MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House2LockStockWeight += (decimal)result.LockStockWeight;
                    model.House2PickStockWeight += (decimal)result.PickStockWeight;
                    model.House2CplCount += (int)result.BayCplCount;
                    model.House2PickedCount += (int)result.BayPickedCount;
                    model.House2StackCount += (int)result.BayStackCount;
                    model.House2LbWeight += (decimal)result.BayLbWeight;
                    model.House2LsWeight += (decimal)result.BayLsWeight;
                    model.House2LqWeight += (decimal)result.BayLqWeight;
                    model.House2LyWeight += (decimal)result.BayLyWeight;
                    model.House2RzWeight += (decimal)result.BayRzWeight;
                    model.House2TrainWeight += (decimal)result.BayTrainWeight;
                    model.House2NoneWeight += (decimal)result.BayNoneWeight;
                    model.House2TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer2Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "24")
                {
                    model.Bay24BayCplCount = result.BayCplCount;
                    model.Bay24BayPickedCount = result.BayPickedCount;
                    model.Bay24BayProduceCount = result.BayProduceCount;
                    model.Bay24BayStackCount = result.BayStackCount;
                    model.Bay24CurrentClasses = result.CurrentClasses;
                    model.Bay24DeliveryWeight = result.DeliveryWeight;
                    model.Bay24HandStockWeight = result.HandStockWeight;
                    model.Bay24HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay24LockStockWeight = result.LockStockWeight;
                    model.Bay24MakeStockWeight = result.MakeStockWeight;
                    model.Bay24PickStockWeight = result.PickStockWeight;
                    model.Bay24TakeStockWeight = result.TakeStockWeight;
                    model.House2TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House2HandStockWeight += (decimal)result.HandStockWeight;
                    model.House2DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House2HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House2MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House2LockStockWeight += (decimal)result.LockStockWeight;
                    model.House2PickStockWeight += (decimal)result.PickStockWeight;
                    model.House2CplCount += (int)result.BayCplCount;
                    model.House2PickedCount += (int)result.BayPickedCount;
                    model.House2StackCount += (int)result.BayStackCount;
                    model.House2LbWeight += (decimal)result.BayLbWeight;
                    model.House2LsWeight += (decimal)result.BayLsWeight;
                    model.House2LqWeight += (decimal)result.BayLqWeight;
                    model.House2LyWeight += (decimal)result.BayLyWeight;
                    model.House2RzWeight += (decimal)result.BayRzWeight;
                    model.House2TrainWeight += (decimal)result.BayTrainWeight;
                    model.House2NoneWeight += (decimal)result.BayNoneWeight;
                    model.House2TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer2Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "25")
                {
                    model.Bay25BayCplCount = result.BayCplCount;
                    model.Bay25BayPickedCount = result.BayPickedCount;
                    model.Bay25BayProduceCount = result.BayProduceCount;
                    model.Bay25BayStackCount = result.BayStackCount;
                    model.Bay25CurrentClasses = result.CurrentClasses;
                    model.Bay25DeliveryWeight = result.DeliveryWeight;
                    model.Bay25HandStockWeight = result.HandStockWeight;
                    model.Bay25HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay25LockStockWeight = result.LockStockWeight;
                    model.Bay25MakeStockWeight = result.MakeStockWeight;
                    model.Bay25PickStockWeight = result.PickStockWeight;
                    model.Bay25TakeStockWeight = result.TakeStockWeight;
                    model.House3TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House3HandStockWeight += (decimal)result.HandStockWeight;
                    model.House3DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House3HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House3MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House3LockStockWeight += (decimal)result.LockStockWeight;
                    model.House3PickStockWeight += (decimal)result.PickStockWeight;
                    model.House3CplCount += (int)result.BayCplCount;
                    model.House3PickedCount += (int)result.BayPickedCount;
                    model.House3StackCount += (int)result.BayStackCount;
                    model.House3LbWeight += (decimal)result.BayLbWeight;
                    model.House3LsWeight += (decimal)result.BayLsWeight;
                    model.House3LqWeight += (decimal)result.BayLqWeight;
                    model.House3LyWeight += (decimal)result.BayLyWeight;
                    model.House3RzWeight += (decimal)result.BayRzWeight;
                    model.House3TrainWeight += (decimal)result.BayTrainWeight;
                    model.House3NoneWeight += (decimal)result.BayNoneWeight;
                    model.House3TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer3Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "26")
                {
                    model.Bay26BayCplCount = result.BayCplCount;
                    model.Bay26BayPickedCount = result.BayPickedCount;
                    model.Bay26BayProduceCount = result.BayProduceCount;
                    model.Bay26BayStackCount = result.BayStackCount;
                    model.Bay26CurrentClasses = result.CurrentClasses;
                    model.Bay26DeliveryWeight = result.DeliveryWeight;
                    model.Bay26HandStockWeight = result.HandStockWeight;
                    model.Bay26HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay26LockStockWeight = result.LockStockWeight;
                    model.Bay26MakeStockWeight = result.MakeStockWeight;
                    model.Bay26PickStockWeight = result.PickStockWeight;
                    model.Bay26TakeStockWeight = result.TakeStockWeight;
                    model.House3TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House3HandStockWeight += (decimal)result.HandStockWeight;
                    model.House3DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House3HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House3MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House3LockStockWeight += (decimal)result.LockStockWeight;
                    model.House3PickStockWeight += (decimal)result.PickStockWeight;
                    model.House3CplCount += (int)result.BayCplCount;
                    model.House3PickedCount += (int)result.BayPickedCount;
                    model.House3StackCount += (int)result.BayStackCount;
                    model.House3LbWeight += (decimal)result.BayLbWeight;
                    model.House3LsWeight += (decimal)result.BayLsWeight;
                    model.House3LqWeight += (decimal)result.BayLqWeight;
                    model.House3LyWeight += (decimal)result.BayLyWeight;
                    model.House3RzWeight += (decimal)result.BayRzWeight;
                    model.House3TrainWeight += (decimal)result.BayTrainWeight;
                    model.House3NoneWeight += (decimal)result.BayNoneWeight;
                    model.House3TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer3Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
                if (result.BayCode == "27")
                {
                    model.Bay27BayCplCount = result.BayCplCount;
                    model.Bay27BayPickedCount = result.BayPickedCount;
                    model.Bay27BayProduceCount = result.BayProduceCount;
                    model.Bay27BayStackCount = result.BayStackCount;
                    model.Bay27CurrentClasses = result.CurrentClasses;
                    model.Bay27DeliveryWeight = result.DeliveryWeight;
                    model.Bay27HandStockWeight = result.HandStockWeight;
                    model.Bay27HandTakeDiffweight = result.HandTakeDiffweight;
                    model.Bay27LockStockWeight = result.LockStockWeight;
                    model.Bay27MakeStockWeight = result.MakeStockWeight;
                    model.Bay27PickStockWeight = result.PickStockWeight;
                    model.Bay27TakeStockWeight = result.TakeStockWeight;
                    model.House3TakeStockWeight += (decimal)result.TakeStockWeight;
                    model.House3HandStockWeight += (decimal)result.HandStockWeight;
                    model.House3DeliveryWeight += (decimal)result.DeliveryWeight;
                    model.House3HandTakeDiffweight += (decimal)result.HandTakeDiffweight;
                    model.House3MakeStockWeight += (decimal)result.MakeStockWeight;
                    model.House3LockStockWeight += (decimal)result.LockStockWeight;
                    model.House3PickStockWeight += (decimal)result.PickStockWeight;
                    model.House3CplCount += (int)result.BayCplCount;
                    model.House3PickedCount += (int)result.BayPickedCount;
                    model.House3StackCount += (int)result.BayStackCount;
                    model.House3LbWeight += (decimal)result.BayLbWeight;
                    model.House3LsWeight += (decimal)result.BayLsWeight;
                    model.House3LqWeight += (decimal)result.BayLqWeight;
                    model.House3LyWeight += (decimal)result.BayLyWeight;
                    model.House3RzWeight += (decimal)result.BayRzWeight;
                    model.House3TrainWeight += (decimal)result.BayTrainWeight;
                    model.House3NoneWeight += (decimal)result.BayNoneWeight;
                    model.House3TruckWeight += (decimal)result.BayTruckWeight;
                    model.Houer3Residue += (decimal)result.BayLbWeight + (decimal)result.BayLsWeight + (decimal)result.BayLqWeight + (decimal)result.BayLyWeight + (decimal)result.BayRzWeight + (decimal)result.BayTrainWeight + (decimal)result.BayNoneWeight + (decimal)result.BayTruckWeight;
                }
            }
            classStocks.Add(model);
            var results = new PageResult<ClassStockModel>();
            results.Success = true;
            results.Data = classStocks;
            results.Message = "查询统计成功！";
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/交接班报表.xlsx", results);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"交接班报表.xlsx"
            };
        }
        /// <summary>
        /// 生成生产报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> GetProduceExcel(CancellationToken cancellationToken)
        {
            var vMaterials = DataContext.Set<VMaterialEvent>();
            var repotrLM = DataContext.Set<TTrLocationMaterial>();
            var bayCodes = new List<string> { "16", "17", "21", "22", "23", "24", "25", "26", "27" };
            var lms = repotrLM.Where(t => t.OwnerBussinessName != "P4" && !t.LocationName.Contains("P")).ToList();
            var deliverList = vMaterials.Where(t => t.Dt > DateTime.Now.Date).ToList();
            //var listResult = classStock.ProjectTo<TRcClassStockReadModel>(Mapper.ConfigurationProvider).ToList();
            var produceList = new List<ProduceModel>();
            var model = new ProduceModel();
            foreach (var bayCode in bayCodes)
            {
                if (bayCode == "16")
                {
                    var bay16 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay16Weight = (int)bay16.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay16Count = bay16.Where(t => t.Type == 2).Count();
                    model.Bay16AverageWeight = Math.Round(model.Bay16Weight / model.Bay16Count, 2);
                    model.Bay16Utilization = Math.Round((decimal)bay16.Where(t => t.Type == 2).Count() / (decimal)bay16.Count(), 2);
                    model.Bay16LBTransferWeight = (int)bay16.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay16LYTransferWeight = (int)bay16.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
                if (bayCode == "17")
                {
                    var bay17 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay17Weight = (int)bay17.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay17Count = bay17.Where(t => t.Type == 2).Count();
                    model.Bay17AverageWeight = Math.Round(model.Bay17Weight / model.Bay17Count, 2);
                    model.Bay17Utilization = Math.Round((decimal)bay17.Where(t => t.Type == 2).Count() / (decimal)bay17.Count(), 2);
                    model.Bay17LBTransferWeight = (int)bay17.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay17LYTransferWeight = (int)bay17.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
                if (bayCode == "21")
                {
                    var bay21 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay21Weight = (int)bay21.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay21Count = bay21.Where(t => t.Type == 2).Count();
                    model.Bay21AverageWeight = Math.Round(model.Bay21Weight / model.Bay21Count, 2);
                    model.Bay21Utilization = Math.Round((decimal)bay21.Where(t => t.Type == 2).Count() / (decimal)bay21.Count(), 2);
                    model.Bay21LBTransferWeight = (int)bay21.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay21LYTransferWeight = (int)bay21.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
                if (bayCode == "22")
                {
                    var bay22 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay22Weight = (int)bay22.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay22Count = bay22.Where(t => t.Type == 2).Count();
                    model.Bay22AverageWeight = Math.Round(model.Bay22Weight / model.Bay22Count, 2);
                    model.Bay22Utilization = Math.Round((decimal)bay22.Where(t => t.Type == 2).Count() / (decimal)bay22.Count(), 2);
                    model.Bay22LBTransferWeight = (int)bay22.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay22LYTransferWeight = (int)bay22.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
                if (bayCode == "23")
                {
                    var bay23 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay23Weight = (int)bay23.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay23Count = bay23.Where(t => t.Type == 2).Count();
                    model.Bay23AverageWeight = Math.Round(model.Bay23Weight / model.Bay23Count, 2);
                    model.Bay23Utilization = Math.Round((decimal)bay23.Where(t => t.Type == 2).Count() / (decimal)bay23.Count(), 2);
                    model.Bay23LBTransferWeight = (int)bay23.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay23LYTransferWeight = (int)bay23.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
                if (bayCode == "24")
                {
                    var bay24 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay24Weight = (int)bay24.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay24Count = bay24.Where(t => t.Type == 2).Count();
                    model.Bay24AverageWeight = Math.Round(model.Bay24Weight / model.Bay24Count, 2);
                    model.Bay24Utilization = Math.Round((decimal)bay24.Where(t => t.Type == 2).Count() / (decimal)bay24.Count(), 2);
                    model.Bay24LBTransferWeight = (int)bay24.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay24LYTransferWeight = (int)bay24.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
                if (bayCode == "25")
                {
                    var bay25 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay25Weight = (int)bay25.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay25Count = bay25.Where(t => t.Type == 2).Count();
                    model.Bay25AverageWeight = Math.Round(model.Bay25Weight / model.Bay25Count, 2);
                    model.Bay25Utilization = Math.Round((decimal)bay25.Where(t => t.Type == 2).Count() / (decimal)bay25.Count(), 2);
                    model.Bay25LBTransferWeight = (int)bay25.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay25LYTransferWeight = (int)bay25.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
                if (bayCode == "26")
                {
                    var bay26 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay26Weight = (int)bay26.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay26Count = bay26.Where(t => t.Type == 2).Count();
                    model.Bay26AverageWeight = Math.Round(model.Bay26Weight / model.Bay26Count, 2);
                    model.Bay26Utilization = Math.Round((decimal)bay26.Where(t => t.Type == 2).Count() / (decimal)bay26.Count(), 2);
                    model.Bay26LBTransferWeight = (int)bay26.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay26LYTransferWeight = (int)bay26.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
                if (bayCode == "27")
                {
                    var bay27 = lms.Where(t => t.BayCode == bayCode).ToList();
                    model.Bay27Weight = (int)bay27.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
                    model.Bay27Count = bay27.Where(t => t.Type == 2).Count();
                    model.Bay27AverageWeight = Math.Round(model.Bay27Weight / model.Bay27Count, 2);
                    model.Bay27Utilization = Math.Round((decimal)bay27.Where(t => t.Type == 2).Count() / (decimal)bay27.Count(), 2);
                    model.Bay27LBTransferWeight = (int)bay27.Where(t => t.MatDirection == "U127").Sum(t => t.Weight) / 1000;
                    model.Bay27LYTransferWeight = (int)bay27.Where(t => t.MatDirection == "U123").Sum(t => t.Weight) / 1000;
                }
            }
            model.TruckDeliverCount = deliverList.Where(t => t.MatDirection == "").Count();
            model.TruckDeliverWeight = deliverList.Where(t => t.MatDirection == "").Sum(t => t.Weight) / 1000;
            model.TrainDeliverCount = deliverList.Where(t => t.MatDirection == "C1").Count();
            model.TrainDeliverWeight = deliverList.Where(t => t.MatDirection == "C1").Sum(t => t.Weight) / 1000;
            model.DeliverWeight = (double)lms.Where(t => t.Type == 2).Sum(t => t.Weight) / 1000;
            model.DateTime = DateTime.Now.ToString("d");
            produceList.Add(model);
            var results = new PageResult<ProduceModel>();
            results.Success = true;
            results.Data = produceList;
            results.Message = "查询统计成功！";
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/生产报表.xlsx", results);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"生产报表.xlsx"
            };
        }

        /// <summary>
        /// 生成行车统计报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> GetCraneListExcel([FromQuery] string bayCode, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var repoRcMatEv = DataContext.Set<VMaterialEvent>();
            var eqCrane = DataContext.Set<TEqCrane>();
            var cranes = eqCrane.Where(t => t.Id != null).ToList();
            var startime = Convert.ToDateTime(time[0]);
            var endtime = Convert.ToDateTime(time[1]);
            var craneTasks = repoRcMatEv.Where(t => t.Dt > startime && t.Dt < endtime).ToList();
            var models = new List<CraneInfoModel>();
            var model = new CraneInfoModel();
            foreach (var crane in cranes)
            {
                if (crane.Name == "4-2行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C402Count = tasks.Count();
                    model.C402Weight = taskWeight;
                }
                if (crane.Name == "4-1行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C401Count = tasks.Count();
                    model.C401Weight = taskWeight;
                }
                if (crane.Name == "4-13行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C4013Count = tasks.Count();
                    model.C4013Weight = taskWeight;
                }
                if (crane.Name == "7-4行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C704Count = tasks.Count();
                    model.C704Weight = taskWeight;
                }
                if (crane.Name == "7-5行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C705Count = tasks.Count();
                    model.C705Weight = taskWeight;
                }
                if (crane.Name == "7-13行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C7013Count = tasks.Count();
                    model.C7013Weight = taskWeight;
                }
                if (crane.Name == "7-8行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C708Count = tasks.Count();
                    model.C708Weight = taskWeight;
                }
                if (crane.Name == "7-14行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C7014Count = tasks.Count();
                    model.C7014Weight = taskWeight;
                }
                if (crane.Name == "7-11行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C7011Count = tasks.Count();
                    model.C7011Weight = taskWeight;
                }
                if (crane.Name == "7-12行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C7012Count = tasks.Count();
                    model.C7012Weight = taskWeight;
                }
                if (crane.Name == "11-3行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1103Count = tasks.Count();
                    model.C1103Weight = taskWeight;
                }
                if (crane.Name == "11-2行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1102Count = tasks.Count();
                    model.C1102Weight = taskWeight;
                }
                if (crane.Name == "11-1行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1101Count = tasks.Count();
                    model.C1101Weight = taskWeight;
                }
                if (crane.Name == "11-6行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1106Count = tasks.Count();
                    model.C1106Weight = taskWeight;
                }
                if (crane.Name == "11-5行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1105Count = tasks.Count();
                    model.C1105Weight = taskWeight;
                }
                if (crane.Name == "11-4行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1104Count = tasks.Count();
                    model.C1104Weight = taskWeight;
                }
                if (crane.Name == "14-1行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1401Count = tasks.Count();
                    model.C1401Weight = taskWeight;
                }
                if (crane.Name == "14-2行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1402Count = tasks.Count();
                    model.C1402Weight = taskWeight;
                }
                if (crane.Name == "14-3行车")
                {
                    var tasks = craneTasks.Where(t => t.CraneName == crane.Name).ToList();
                    var taskWeight = tasks.Sum(t => t.Weight) / 1000M;
                    model.C1403Count = tasks.Count();
                    model.C1403Weight = taskWeight;
                }
            }
            models.Add(model);
            var results = new PageResult<CraneInfoModel>();
            results.Success = true;
            results.Data = models;
            results.Message = "查询统计成功！";
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/行车信息统计.xlsx", results);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"行车信息统计.xlsx"
            };
        }

        /// <summary>
        /// 生成报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public virtual async Task<ActionResult> GetBIListDetailExcel([FromQuery] string bayId, [FromQuery] string type, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var listResult = await GetBIListDetailCommon(bayId, type, time, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/自动作业详情.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"自动作业详情.xlsx"
            };
        }

        /// <summary>
        /// 自动作业比例下载
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<BLModel>> GetBIListCommon([FromQuery] string baycode, [FromQuery] string[] time, CancellationToken cancellationToken)
        {

            var rcCraneTasks = DataContext.Set<TRcCraneTask>();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var whBays = DataContext.Set<TWhBay>();
            var bay = whBays.Where(t => t.IsEnable == 1 && t.Code == baycode).FirstOrDefault();
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 09:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");
            if (time.Length > 0 && time != null)
            {
                startime = Convert.ToDateTime(time[0]);
                endtime = Convert.ToDateTime(time[1]);
            }
            var dayCha = (endtime - startime).Days;
            var hourCha = (endtime - startime).Hours;
            var result = new PageResult<BLModel>();
            var listmodel = new List<BLModel>();
            var chaSum = dayCha * 24 + hourCha;
            for (int i = 0; i < chaSum; i++)
            {
                var startime_addHour = startime.AddHours(i);
                var endtime_addHour = startime_addHour.AddHours(1);
                #region MyRegion
                //自动入库
                var inputZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                         && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                            || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > startime_addHour
                         && t.Dt <= endtime_addHour
                         && t.Result == "成功"
                        ).Count();

                //手动入库
                var inputR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "入库"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0M%")
                    || EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0N%"))
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
                   ).Count();


                //自动出库
                var outZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                //人工出库
                var outR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                   && t.Dt > startime_addHour
                   && t.Dt <= endtime_addHour
                    && t.Result == "成功"
              ).Count();

                //人工出库(系统判定)
                var outRsys = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && t.Description.Contains("装车或是地面")
                   && t.Dt > startime_addHour
                   && t.Dt <= endtime_addHour
                    && t.Result == "成功"
                 ).Count();

                var ddZ = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")

                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                var ddR = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")

                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                //过跨倒运
                var ddGK = rcCraneTasks.Where(t => t.PlanTypeName == "过跨倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime_addHour
                     && t.EndTime <= endtime_addHour
                    ).Count();

                //库间倒运
                var ddKJ = rcCraneTasks.Where(t => t.PlanTypeName == "库间倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime_addHour
                     && t.EndTime <= endtime_addHour
                    ).Count();

                double inputBl = 0;
                if ((inputR + inputZ) != 0)
                {
                    inputBl = Math.Round((double)inputZ / (inputR + inputZ), 4) * 100;
                }
                double outBl = 0;
                if ((outZ + outR + outRsys) != 0)
                {
                    outBl = Math.Round((double)outZ / (outZ + outR + outRsys), 4) * 100;
                }
                var model = new BLModel()
                {
                    id = bay.Id,
                    name = bay.Name,

                    strTime = startime_addHour,
                    endTime = endtime_addHour,

                    inputZ = inputZ,
                    inputR = inputR,
                    outZ = outZ,
                    outR = outR,
                    outRsys = outRsys,
                    ddZ = ddZ,
                    ddR = ddR,
                    ddGK = ddGK,
                    ddKJ = ddKJ,
                    inputBl = inputBl,
                    outBl = outBl,
                };
                listmodel.Add(model);
                #endregion
            }
            result.Success = true;
            result.Data = listmodel;
            result.Total = chaSum;
            result.Message = "查询统计成功！";
            return result;
        }

        /// <summary>
        /// 生成报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public virtual async Task<ActionResult> CreateReportExcelHour([FromQuery] string baycode, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var listResult = await GetBIListCommon(baycode, time, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/一小时工作表.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"一小时工作表.xlsx"
            };
        }
        /// <summary>
        /// 自动作业比例下载  间隔24小时
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<BLModel>> GetBIListCommonDay2([FromQuery] string baycode, [FromQuery] string[] time, CancellationToken cancellationToken)
        {

            var rcCraneTasks = DataContext.Set<TRcCraneTask>();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var whBays = DataContext.Set<TWhBay>();
            var bay = whBays.Where(t => t.IsEnable == 1 && t.Code == baycode).FirstOrDefault();
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 00:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 00:00:00");
            if (time.Length > 0 && time != null)
            {
                startime = Convert.ToDateTime(time[0]);
                endtime = Convert.ToDateTime(time[1]);
            }
            var dayCha = (endtime - startime).Days;
            var hourCha = (endtime - startime).Hours;
            var result = new PageResult<BLModel>();
            var listmodel = new List<BLModel>();
            var chaSum = dayCha + hourCha / 12;
            for (int i = 0; i < chaSum; i++)
            {
                var startime_addHour = startime.AddHours(i * 24);
                var endtime_addHour = startime_addHour.AddDays(1);
                #region MyRegion
                //自动入库
                var inputZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                         && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                            || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > startime_addHour
                         && t.Dt <= endtime_addHour
                         && t.Result == "成功"
                        ).Count();

                //手动入库
                var inputR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "入库"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0M%")
                    || EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0N%"))
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
                   ).Count();


                //自动出库
                var outZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                //人工出库
                var outR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                   && t.Dt > startime_addHour
                   && t.Dt <= endtime_addHour
                    && t.Result == "成功"
              ).Count();

                //人工出库(系统判定)
                var outRsys = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && t.Description.Contains("装车或是地面")
                   && t.Dt > startime_addHour
                   && t.Dt <= endtime_addHour
                    && t.Result == "成功"
                 ).Count();

                var ddZ = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")

                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                var ddR = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")

                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                //过跨倒运
                var ddGK = rcCraneTasks.Where(t => t.PlanTypeName == "过跨倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime_addHour
                     && t.EndTime <= endtime_addHour
                    ).Count();

                //库间倒运
                var ddKJ = rcCraneTasks.Where(t => t.PlanTypeName == "库间倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime_addHour
                     && t.EndTime <= endtime_addHour
                    ).Count();

                double inputBl = 0;
                if ((inputR + inputZ) != 0)
                {
                    inputBl = Math.Round((double)inputZ / (inputR + inputZ), 4) * 100;
                }
                double outBl = 0;
                if ((outZ + outR + outRsys) != 0)
                {
                    outBl = Math.Round((double)outZ / (outZ + outR + outRsys), 4) * 100;
                }
                var model = new BLModel()
                {
                    id = bay.Id,
                    name = bay.Name,

                    strTime = startime_addHour,
                    endTime = endtime_addHour,

                    inputZ = inputZ,
                    inputR = inputR,
                    outZ = outZ,
                    outR = outR,
                    outRsys = outRsys,
                    ddZ = ddZ,
                    ddR = ddR,
                    ddGK = ddGK,
                    ddKJ = ddKJ,
                    inputBl = inputBl,
                    outBl = outBl,
                };
                listmodel.Add(model);
                #endregion
            }
            result.Success = true;
            result.Data = listmodel;
            result.Total = chaSum;
            result.Message = "查询统计成功！";
            return result;
        }

        /// <summary>
        /// 自动作业比例下载 间隔12小时
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<BLModel>> GetBIListCommonDay([FromQuery] string baycode, [FromQuery] string[] time, CancellationToken cancellationToken)
        {

            var rcCraneTasks = DataContext.Set<TRcCraneTask>();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var whBays = DataContext.Set<TWhBay>();
            var bay = whBays.Where(t => t.IsEnable == 1 && t.Code == baycode).FirstOrDefault();
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 08:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 20:00:00");
            if (time.Length > 0 && time != null)
            {
                startime = Convert.ToDateTime(time[0]);
                endtime = Convert.ToDateTime(time[1]);
            }
            var dayCha = (endtime - startime).Days;
            var hourCha = (endtime - startime).Hours;
            var result = new PageResult<BLModel>();
            var listmodel = new List<BLModel>();
            var chaSum = dayCha * 2 + hourCha / 12;
            for (int i = 0; i < chaSum; i++)
            {
                var startime_addHour = startime.AddHours(i * 12);
                var endtime_addHour = startime_addHour.AddHours(12);
                #region MyRegion
                //自动入库
                var inputZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                         && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                            || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > startime_addHour
                         && t.Dt <= endtime_addHour
                         && t.Result == "成功"
                        ).Count();

                //手动入库
                var inputR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "入库"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0M%")
                    || EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0N%"))
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
                   ).Count();


                //自动出库
                var outZ = rcMaterialEvents.Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                //人工出库
                var outR = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "P%")
                   && t.Dt > startime_addHour
                   && t.Dt <= endtime_addHour
                    && t.Result == "成功"
              ).Count();

                //人工出库(系统判定)
                var outRsys = rcMaterialEvents.Where(t => t.OperationType == "人工" && t.ContentType == "出库"
                   && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "0%")
                   && t.Description.Contains("装车或是地面")
                   && t.Dt > startime_addHour
                   && t.Dt <= endtime_addHour
                    && t.Result == "成功"
                 ).Count();

                var ddZ = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")

                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                var ddR = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                    && EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%")

                    && !t.FromLocationName.Contains("" + bay.Code + "0M")
                    && !t.FromLocationName.Contains("" + bay.Code + "0N")
                    && !t.ToLocationName.Contains("" + bay.Code + "P")
                    && t.Dt > startime_addHour
                    && t.Dt <= endtime_addHour
                     && t.Result == "成功"
               ).Count();

                //过跨倒运
                var ddGK = rcCraneTasks.Where(t => t.PlanTypeName == "过跨倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime_addHour
                     && t.EndTime <= endtime_addHour
                    ).Count();

                //库间倒运
                var ddKJ = rcCraneTasks.Where(t => t.PlanTypeName == "库间倒运"
                     && EF.Functions.Like(t.BayName, "" + bay.Code + "%")
                     && t.StartTime > startime_addHour
                     && t.EndTime <= endtime_addHour
                    ).Count();

                double inputBl = 0;
                if ((inputR + inputZ) != 0)
                {
                    inputBl = Math.Round((double)inputZ / (inputR + inputZ), 4) * 100;
                }
                double outBl = 0;
                if ((outZ + outR + outRsys) != 0)
                {
                    outBl = Math.Round((double)outZ / (outZ + outR + outRsys), 4) * 100;
                }
                var model = new BLModel()
                {
                    id = bay.Id,
                    name = bay.Name,

                    strTime = startime_addHour,
                    endTime = endtime_addHour,

                    inputZ = inputZ,
                    inputR = inputR,
                    outZ = outZ,
                    outR = outR,
                    outRsys = outRsys,
                    ddZ = ddZ,
                    ddR = ddR,
                    ddGK = ddGK,
                    ddKJ = ddKJ,
                    inputBl = inputBl,
                    outBl = outBl,
                };
                listmodel.Add(model);
                #endregion
            }
            result.Success = true;
            result.Data = listmodel;
            result.Total = chaSum;
            result.Message = "查询统计成功！";
            return result;
        }

        /// <summary>
        /// 生成报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public virtual async Task<ActionResult> CreateReportExcelDay([FromQuery] string baycode, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var listResult = await GetBIListCommonDay(baycode, time, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/一天工作表.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"一天工作表.xlsx"
            };
        }

        /// <summary>
        /// 虚拟卷查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<MaterialVirtualModel>>> GetMaterialVirtual([FromQuery] PageParam pageParam, CancellationToken cancellationToken)
        {
            var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
            var whBays = DataContext.Set<TWhBay>();
            string[] noBayCode = { "18", "19", "20" };
            var bayquery = whBays.Where(t => t.IsEnable == 1 && noBayCode.Contains(t.Code) == false);
            var baycount = bayquery.Count();
            var baylist = await bayquery.ToListAsync(cancellationToken);
            var result = new PageResult<MaterialVirtualModel>();
            var listmodel = new List<MaterialVirtualModel>();
            foreach (var bay in baylist)
            {
                var query = trLocationMaterials.Where(t => t.BayCode == bay.Code && t.Type == 2 && t.OwnerBussinessName != "P4" && t.IsVirtual == 0);

                //虚拟卷
                var virtual_count = query.Where(t => t.MaterialNo.StartsWith("Q")).Count();
                var model = new MaterialVirtualModel()
                {
                    Id = bay.Id,
                    Name = bay.Name,
                    Code = bay.Code,
                    VirtualCount = virtual_count
                };
                listmodel.Add(model);
            }
            result.Success = true;
            result.Data = listmodel;
            result.Total = baycount;
            result.Message = "查询虚拟卷成功！";
            return result;
        }

        /// <summary>
        /// 虚拟卷详情查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TTrLocationMaterialReadModel>>> GetMaterialVirtualDetail([FromQuery] string bayId, CancellationToken cancellationToken)
        {
            if (bayId.IsValidValue())
            {
                var trLocationMaterials = DataContext.Set<TTrLocationMaterial>();
                var whBays = DataContext.Set<TWhBay>();
                var bayquery = whBays.Where(t => t.IsEnable == 1 && t.Id == bayId);
                var baylist = await bayquery.FirstOrDefaultAsync(cancellationToken);
                var result = new PageResult<TTrLocationMaterialReadModel>();
                var query = trLocationMaterials.Where(t => t.BayCode == baylist.Code && t.Type == 2 && t.OwnerBussinessName != "P4" && t.IsVirtual == 0 && t.MaterialNo.StartsWith("Q"));
                var results = await query.ProjectTo<TTrLocationMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
                result.Success = true;
                result.Data = results;
                result.Total = results.Count;
                result.Message = "查询虚拟卷详情成功！";
                return result;
            }
            else
            {
                var result = new PageResult<TTrLocationMaterialReadModel>();
                result.Success = true;
                result.Data = null;
                result.Total = 0;
                result.Message = "查询虚拟卷详情成功！";
                return result;
            }
        }

        /// <summary>
        /// 手包完成查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<VPlMaterialReadModel>>> GetMaterialHandBag([FromQuery] PageParam pageParam, [FromQuery] string[] bayCode, CancellationToken cancellationToken)
        {
            var vPlMaterials = DataContext.Set<VPlMaterial>();
            var query = vPlMaterials.Where(t => t.DefectType == 2 && t.LocationName != null && t.LocationName != "" && t.OwnerBussinessName == "P4");
            if (bayCode.Length > 0 && bayCode != null)
            {
                query = query.Where(t => bayCode.Contains(t.BayCode));
            }
            var results = await query.ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToListAsync(cancellationToken);
            var result = new PageResult<VPlMaterialReadModel>();
            result.Success = true;
            result.Data = results;
            result.Total = query.Count();
            result.Message = "查询手包卷成功！";
            return result;
        }

        /// <summary>
        /// 手包完成下载
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<VPlMaterialReadModel>> GetMaterialHandBagCommon([FromQuery] string[] bayCode, CancellationToken cancellationToken)
        {
            var vPlMaterials = DataContext.Set<VPlMaterial>();
            var query = vPlMaterials.Where(t => t.DefectType == 2 && t.LocationName != null && t.LocationName != "" && t.OwnerBussinessName == "P4");
            if (bayCode.Length > 0 && bayCode != null)
            {
                query = query.Where(t => bayCode.Contains(t.BayCode));
            }
            var results = await query.ProjectTo<VPlMaterialReadModel>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            var result = new PageResult<VPlMaterialReadModel>();
            result.Success = true;
            result.Data = results;
            result.Total = query.Count();
            result.Message = "查询手包卷成功！";
            return result;
        }

        /// <summary>
        /// 手包完成下载
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public virtual async Task<ActionResult> GetMaterialHandBagExcel([FromQuery] string[] bayCode, CancellationToken cancellationToken)
        {
            var listResult = await GetMaterialHandBagCommon(bayCode, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/手包完成.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"手包完成.xlsx"
            };
        }

        /// <summary>
        /// 推送消息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<BLModel>>> GetWebsocket([FromQuery] string message, CancellationToken cancellationToken)
        {
            var bi = new BLModel()
            {
                id = "111",
                name = message
            };
            await _hubContext.Clients.All.SendAsync("GetWebsocket", bi);
            return Ok();
        }

        /// <summary>
        /// 推送消息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<AutoPrePickConfirm>>> PrePickConfirm([FromQuery] string message, CancellationToken cancellationToken)
        {
            AutoPrePickConfirm confirmInfo = new()
            {
                Id = "111",
                TruckNo = message,
                TruckLoadingNo = message,
                DetailNo = message,
                IsPrePickSuc = true,
                CreateTime = DateTime.Now,
            };
            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Title = $"自动预挑库完成，车号{message}",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = false,
                Data = confirmInfo,
            };
            await _hubContext.Clients.All.SendAsync("PrePickConfirm", noticeIconItem);
            return Ok();
        }

        /// <summary>
        /// 推送消息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<AutoPrePickConfirm>>> PrePickConfirm2([FromQuery] string message, CancellationToken cancellationToken)
        {
            //NoticeIconItem noticeIconItem = new()
            //{
            //    Id = IdWorkerGenerator.Instance.NextId().ToString(),
            //    Avatar = "",
            //    Code = message,
            //    Title = $"{message}库虚拟卷报警",
            //    Description = "虚拟卷为：111111111111",
            //    Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            //    Read = false,
            //};
            //await _hubContext.Clients.All.SendAsync("GetMaterialVirtual", noticeIconItem);

            //NoticeIconItem noticeIconItem = new()
            //{
            //    Id = IdWorkerGenerator.Instance.NextId().ToString(),
            //    Avatar = "",
            //    Title = "行车通讯异常报警",
            //    Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            //    Read = false,
            //    Type = "CommErrorToG2",
            //    Description = $"{message}库，二代行车终端通讯异常,异常时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}",
            //};
            //await _hubContext.Clients.All.SendAsync("ToClientPushCommErrorToG2", noticeIconItem);
            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Title = "16南北通道的设备异常报警",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = false,
                Type = "equipRoad16",
                Description = "111"
            };
            await _hubContext.Clients.All.SendAsync("ToClientPushEquipRoad16", noticeIconItem);
            return Ok();
        }


        /// <summary>
        /// 推送消息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<AutoPrePickConfirm>>> PrePickConfirm3([FromQuery] string messageInfo, CancellationToken cancellationToken)
        {

            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Code = "16-1",
                No = messageInfo,
                Title = await GetChainPage("16-1") + "报警提示！",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = false,
                Description = "ggggggggggggg"
            };
            await _hubContext.Clients.All.SendAsync("ToClientPush", noticeIconItem);
            return Ok();
        }

        private async Task<string> GetChainPage(string key)
        {
            var predicate = ExpressionBuilder.True<TScDictionary>();
            predicate = predicate.And(t => t.Key == key);
            var dataContext = ServiceProvider.GetService<WmspcrContext>();
            var plLoadList = await dataContext.Set<TScDictionary>().AsNoTracking().Where(predicate).FirstOrDefaultAsync();
            return plLoadList?.Value;
        }


        //数据统计一览图
        /// <summary>
        /// 当日吊运任务
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<PlanTaskModel>>> GetDbTj(string bayId, CancellationToken cancellationToken)
        {

            var whBays = DataContext.Set<TWhBay>();
            var bay = await whBays.Where(t => t.Id == bayId).FirstOrDefaultAsync();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();

            var Nowtime = DateTime.Now;
            var bc = RiGangShitDomain.GetAccountNoByBc(bay.Code, Nowtime);   //丙

            var Nowtimeday = DateTime.Now.ToString("yyyy-MM-dd");

            //白班
            var Bstartime = Convert.ToDateTime($"{Nowtimeday} 08:00:00");
            var Bendtime = Convert.ToDateTime($"{Nowtimeday} 20:00:00");

            //夜班
            var Ystartime1 = Convert.ToDateTime($"{Nowtimeday} 00:00:00");
            var Yendtime1 = Convert.ToDateTime($"{Nowtimeday} 08:00:00");

            var Ystartime2 = Convert.ToDateTime($"{Nowtimeday} 20:00:00");
            var Yendtime2 = Convert.ToDateTime($"{Nowtimeday} 24:00:00");

            var result = new PageResult<PlanTaskModel>();
            var listmodel = new List<PlanTaskModel>();


            //当班吊运任务数  白班
            var B_ZD = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Bstartime
                    && t.Dt <= Bendtime
                     && t.Result == "成功"
                   ).Count();

            //人工
            var B_RG = rcMaterialEvents.Where(t => t.OperationType == "人工"
                     && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                     && t.Dt > Bstartime
                     && t.Dt <= Bendtime
                      && t.Result == "成功"
                    ).Count();

            //当班吊运任务数  夜班1
            var Y_ZD = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Ystartime1
                    && t.Dt <= Yendtime1
                     && t.Result == "成功"
                   ).Count();

            //人工
            var Y_RG = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Ystartime1
                    && t.Dt <= Yendtime1
                     && t.Result == "成功"
                    ).Count();


            //当班吊运任务数  夜班2
            var Y_ZD2 = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Ystartime2
                    && t.Dt <= Yendtime2
                     && t.Result == "成功"
                   ).Count();

            //人工
            var Y_RG2 = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Ystartime2
                    && t.Dt <= Yendtime2
                     && t.Result == "成功"
                    ).Count();


            var model = new PlanTaskModel()
            {
                B_ZD = B_ZD,
                B_RG = B_RG,
                Y_ZD = Y_ZD + Y_ZD2,
                Y_RG = Y_RG + Y_RG2
            };
            listmodel.Add(model);

            result.Success = true;
            result.Data = listmodel;
            result.Message = "当班吊运任务统计！";
            return result;

        }


        ///<summary>
        /// 当日吊运任务
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<List<int>>>> GetDbTjBC(string bayId, CancellationToken cancellationToken)
        {
            var whBays = DataContext.Set<TWhBay>();
            var bay = await whBays.Where(t => t.Id == bayId).FirstOrDefaultAsync();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();

            var Nowtime = DateTime.Now;
            var Nowtimeday = DateTime.Now.ToString("yyyy-MM-dd");

            //早夜班
            var Ystartime1 = Convert.ToDateTime($"{Nowtimeday} 00:00:01");
            var YZtime = Convert.ToDateTime($"{Nowtimeday} 06:00:00");
            var Yendtime1 = Convert.ToDateTime($"{Nowtimeday} 08:00:00");
            var bc1 = RiGangShitDomain.GetAccountNoByBc(bay.Code, YZtime);

            //白班
            var Bstartime = Convert.ToDateTime($"{Nowtimeday} 08:00:01");
            var BZtime = Convert.ToDateTime($"{Nowtimeday} 16:00:00");
            var Bendtime = Convert.ToDateTime($"{Nowtimeday} 20:00:00");
            var bc2 = RiGangShitDomain.GetAccountNoByBc(bay.Code, BZtime);

            //晚夜班
            var Ystartime2 = Convert.ToDateTime($"{Nowtimeday} 20:00:01");
            var YZtime2 = Convert.ToDateTime($"{Nowtimeday} 22:00:00");
            var Yendtime2 = Convert.ToDateTime($"{Nowtimeday} 23:59:59");
            var bc3 = RiGangShitDomain.GetAccountNoByBc(bay.Code, YZtime2);


            //当班吊运任务数  夜班1
            var Y_ZD = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Ystartime1
                    && t.Dt <= Yendtime1
                     && t.Result == "成功"
                   ).Count();

            //人工
            var Y_RG = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Ystartime1
                    && t.Dt <= Yendtime1
                     && t.Result == "成功"
                    ).Count();

            //当班吊运任务数  白班
            var B_ZD = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Bstartime
                    && t.Dt <= Bendtime
                     && t.Result == "成功"
                   ).Count();

            //人工
            var B_RG = rcMaterialEvents.Where(t => t.OperationType == "人工"
                     && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                     && t.Dt > Bstartime
                     && t.Dt <= Bendtime
                      && t.Result == "成功"
                    ).Count();



            //当班吊运任务数  夜班2
            var Y_ZD2 = rcMaterialEvents.Where(t => t.OperationType == "自动"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Ystartime2
                    && t.Dt <= Yendtime2
                     && t.Result == "成功"
                   ).Count();

            //人工
            var Y_RG2 = rcMaterialEvents.Where(t => t.OperationType == "人工"
                    && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                    && t.Dt > Ystartime2
                    && t.Dt <= Yendtime2
                     && t.Result == "成功"
                    ).Count();

            var result = new PageResult<List<int>>();
            List<List<int>> list = new();
            List<int> sbc = new() { GetBcCode(bc1), GetBcCode(bc2), GetBcCode(bc3) };
            List<int> zd = new() { Y_ZD, B_ZD, Y_ZD2 };
            List<int> rg = new() { Y_RG, B_RG, Y_RG2 };
            list.Add(sbc);
            list.Add(zd);
            list.Add(rg);
            result.Success = true;
            result.Data = list;
            result.Message = "当班吊运任务统计";
            return result;
        }

        private static int GetBcCode(string bc)
        {
            if (bc == "甲")
            {
                return 1;
            }
            if (bc == "乙")
            {
                return 2;
            }
            if (bc == "丙")
            {
                return 3;
            }
            return 0;

        }


        [HttpGet("")]
        public bool Is2andBy1FloorAvaliable(string LocationName)
        {
            var repo = DataContext.Set<TTrLocationMaterial>();
            var plBays = DataContext.Set<TPlBay>();

            var location = repo.Where(t => t.LocationName == LocationName).FirstOrDefault();

            var leftColNo = location.ColNo;
            var rightColNo = location.ColNo + 1;
            var list = repo.Where(t => t.BayId == location.BayId && t.AreaCode == location.AreaCode &&
                                                        t.RowNo == location.RowNo &&
                                                        (t.ColNo == leftColNo || t.ColNo == rightColNo) &&
                                                        t.FloorNo == 1 && t.Type == 2).ToList();
            //一二层，要没有装车计划才行，
            if (list.Count == 2)
            {
                var plcount = 0;
                foreach (var item in list)
                {
                    var pl = plBays.AsNoTracking().Where(t => t.BayId == location.BayId && t.PlanTypeName == "装车出库" && t.LoadLocationName == item.LocationName);
                    if (pl.Count() > 0)
                    {
                        plcount++;
                    }
                }
                return plcount == 0;
            }
            return false;
        }


        [HttpGet("")]
        public bool Is2andBy1FloorAvaliable111()
        {
            var repo = DataContext.Set<TTrLocationMaterial>();

            var left = repo.Where(t => t.LocationName == "2604A01071").FirstOrDefault();

            //2604A01071
            if (!(left.SteelGrade != null && left.SteelGrade.Contains("卷板")))
            {

                return false;
            }

            return false;
        }


        /// <summary>
        /// （日）自动曲线
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<int>> GetAuto1list(string bayCode, string time)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var result = new PageResult<int>();
            var selecttime = Convert.ToDateTime(time);
            var listAuto1 = new List<int>();
            for (int i = 0; i < 24; i++)
            {
                var Nowtime = Convert.ToDateTime(selecttime).AddHours(i);
                var houTime = Convert.ToDateTime(selecttime).AddHours(i + 1);
                //出库
                var automationd1 = rcMaterialEvents.
                        Where(t => t.OperationType == "自动"
                        && (EF.Functions.Like(t.FromLocationName, "" + bayCode + "%")
                               || EF.Functions.Like(t.ToLocationName, "" + bayCode + "%"))
                         && t.Dt > Nowtime
                         && t.Dt <= houTime
                        ).Count();
                listAuto1.Add(automationd1);
            }
            result.Success = true;
            result.Data = listAuto1;
            result.Message = "";
            return result;
        }
        /// <summary>
        /// （日）入库自动曲线
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<int>> GetAuto2list(string bayCode, string time)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var result = new PageResult<int>();
            var selecttime = Convert.ToDateTime(time);
            var listAuto2 = new List<int>();
            for (int i = 0; i < 24; i++)
            {
                var Nowtime = Convert.ToDateTime(selecttime).AddHours(i);
                var houTime = Convert.ToDateTime(selecttime).AddHours(i + 1);
                //出库
                var automationd2 = rcMaterialEvents.
                        Where(t => t.OperationType == "自动" && t.ContentType == "入库"
                        && (EF.Functions.Like(t.FromLocationName, "" + bayCode + "%")
                               || EF.Functions.Like(t.ToLocationName, "" + bayCode + "%"))
                         && t.Dt > Nowtime
                         && t.Dt <= houTime
                        ).Count();
                listAuto2.Add(automationd2);
            }
            result.Success = true;
            result.Data = listAuto2;
            result.Message = "";
            return result;
        }
        /// <summary>
        /// （日）出库自动曲线
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<int>> GetAuto3list(string bayCode, string time)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var result = new PageResult<int>();
            var selecttime = Convert.ToDateTime(time);
            var listAuto3 = new List<int>();
            for (int i = 0; i < 24; i++)
            {
                var Nowtime = Convert.ToDateTime(selecttime).AddHours(i);
                var houTime = Convert.ToDateTime(selecttime).AddHours(i + 1);
                //出库
                var automationd3 = rcMaterialEvents.
                        Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                        && (EF.Functions.Like(t.FromLocationName, "" + bayCode + "%")
                               || EF.Functions.Like(t.ToLocationName, "" + bayCode + "%"))
                         && t.Dt > Nowtime
                         && t.Dt <= houTime
                        ).Count();
                listAuto3.Add(automationd3);
            }
            result.Success = true;
            result.Data = listAuto3;
            result.Message = "";
            return result;
        }


        ///<summary>
        /// 当日吊运任务
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<int>> GetCraneTaskTime(string bayName, CancellationToken cancellationToken)
        {
            var rcTasks = DataContext.Set<TRcCraneTask>();
            var result = new PageResult<int>();
            var list = new List<int>();
            var taskLists = rcTasks.Where(t => t.BayName == bayName).OrderByDescending(t => t.StartTime).Take(20).ToList();
            foreach (var item in taskLists)
            {
                var time = (int)(item.EndTime - item.StartTime).Value.TotalSeconds;
                list.Add(time);
            }
            result.Success = true;
            result.Data = list;
            result.Message = "";
            return result;
        }

        ///<summary>
        /// 当日吊运计划时间
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<PageResult<int>> GetCranePlanTime(string bayName, string type, CancellationToken cancellationToken)
        {
            var rcTasks = DataContext.Set<TRcBay>();
            var result = new PageResult<int>();
            var list = new List<int>();
            var taskLists = rcTasks.Where(t => t.BayName == bayName && t.PlanTypeName == type).OrderByDescending(t => t.StartTime).Take(20).ToList();
            foreach (var item in taskLists)
            {
                var time = (int)(item.EndTime - item.StartTime).Value.TotalSeconds;
                list.Add(time);
            }
            result.Success = true;
            result.Data = list;
            result.Message = "";
            return result;
        }
    }
}
