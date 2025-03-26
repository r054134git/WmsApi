using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Net;
using MiniExcelLibs;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcLocationMaterialController : EntityControllerBase<TRcLocationMaterial, TRcLocationMaterialReadModel, TRcLocationMaterialCreateModel, TRcLocationMaterialUpdateModel>
    {
        public TRcLocationMaterialController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcLocationMaterialCreateModel> createValidator, IValidator<TRcLocationMaterialUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {


        }

        /// <summary>
        /// 交接班统计
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<ShiftModel>>> GetShiftList([FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var whBays = DataContext.Set<TWhBay>();
            var rcLocationMaterials = DataContext.Set<TRcLocationMaterial>();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var query = whBays.Where(t => t.IsEnable == 1);
            var baylist = await query
               .ProjectTo<TWhBayReadModel>(Mapper.ConfigurationProvider)
               .ToListAsync(cancellationToken);

            var startime = Convert.ToDateTime(time[0]);
            var endtime = Convert.ToDateTime(time[1]);

            var result = new PageResult<ShiftModel>();
            var listmodel = new List<ShiftModel>();
        
            foreach (var bay in baylist) 
            {
                var predicate = ExpressionBuilder.True<TRcLocationMaterial>();
                predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2
                     && t.BayId == bay.Id
                     && t.ShiftStratTime > startime
                     && t.ShiftEndTime <= endtime);

                //物料总量
                var matSum = rcLocationMaterials.Where(predicate).Count();
                //被锁定物料
                var lockMatSum = rcLocationMaterials.Where(predicate).Where(t=>t.MaterialLockedFlag=="1").Count();
                //排入运输指令的物料
                var cmdMatSum = rcLocationMaterials.Where(predicate).Where(t=>t.PlanCmdC3 == "1").Count();

                //发运的物料
                var outMat = rcMaterialEvents.
                        Where(t => t.OperationType == "自动" && t.ContentType == "出库"
                        && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > startime
                         && t.Dt <= endtime
                        ).Count();
                //轧制的物料
                var zMat = 0;

                var model = new ShiftModel()
                {
                    id = bay.Id,
                    name = bay.Name,
                    matSum= matSum,
                    lockMatSum= lockMatSum,
                    cmdMatSum= cmdMatSum,
                    outMat= outMat,
                    ZMat= zMat
                };
                listmodel.Add(model);
            }
            result.Success = true;
            result.Data = listmodel;
            result.Message = "查询统计成功！";
            return result;
        }

        /// <summary>
        /// 物料总量展示
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcLocationMaterialReadModel>>> GetMatSumList([FromQuery] PageParam pageParam, [FromQuery] string bayid,[FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var dbSet = DataContext.Set<TRcLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TRcLocationMaterial>();
            var startime = Convert.ToDateTime(time[0]);
            var endtime = Convert.ToDateTime(time[1]);
            predicate= predicate.And(t => t.IsEnable == 1 && t.Type == 2
                     && t.BayId==bayid
                     && t.ShiftStratTime > startime
                     && t.ShiftEndTime <= endtime);

            query = query.Where(predicate).OrderBy(t=>t.BayCode).ThenBy(t=>t.AreaCode).ThenBy(t => t.RowNo).ThenBy(t => t.FloorNo).ThenBy(t => t.ColNo);
            var listResult = await QueryPageModel(query, pageParam,cancellationToken);
            return Ok(listResult);
        }


        /// <summary>
        /// 锁定物料展示
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcLocationMaterialReadModel>>> GetLockMatSumList([FromQuery] PageParam pageParam, [FromQuery] string bayid, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var dbSet = DataContext.Set<TRcLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TRcLocationMaterial>();
            var startime = Convert.ToDateTime(time[0]);
            var endtime = Convert.ToDateTime(time[1]);
            predicate= predicate.And(t => t.IsEnable == 1 && t.Type == 2
                     && t.BayId == bayid
                     && t.ShiftStratTime > startime
                     && t.ShiftEndTime <= endtime
                     &&t.MaterialLockedFlag=="1");
            query = query.Where(predicate).OrderBy(t => t.BayCode).ThenBy(t => t.AreaCode).ThenBy(t => t.RowNo).ThenBy(t => t.FloorNo).ThenBy(t => t.ColNo);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 排入运输指令的物料展示
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcLocationMaterialReadModel>>> GetCmdMatSumList([FromQuery] PageParam pageParam, [FromQuery] string bayid, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var dbSet = DataContext.Set<TRcLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TRcLocationMaterial>();
            var startime = Convert.ToDateTime(time[0]);
            var endtime = Convert.ToDateTime(time[1]);
            predicate= predicate.And(t => t.IsEnable == 1 && t.Type == 2
                     && t.BayId == bayid
                     && t.ShiftStratTime > startime
                     && t.ShiftEndTime <= endtime
                     && t.PlanCmdC3 == "1");
            query = query.Where(predicate).OrderBy(t => t.BayCode).ThenBy(t => t.AreaCode).ThenBy(t => t.RowNo).ThenBy(t => t.FloorNo).ThenBy(t => t.ColNo);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }


        /// <summary>
        /// 生成物料相关报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> CreateMatReportExcel([FromQuery] string time, [FromQuery] string end, [FromQuery] string type, [FromQuery] string reportName, CancellationToken cancellationToken)
        {
            reportName = WebUtility.UrlDecode(reportName);
            var dbSet = DataContext.Set<TRcLocationMaterial>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TRcLocationMaterial>();
            var startime = Convert.ToDateTime(time);
            var endtime = Convert.ToDateTime(end);

            predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2
                         && t.ShiftStratTime > startime
                         && t.ShiftEndTime <= endtime);
            if (type == "lockmat")
            {
                predicate = predicate.And(t=> t.MaterialLockedFlag == "1");
            }
            else if (type == "cmdmat")
            {
                predicate = predicate.And(t => t.PlanCmdC3 == "1");
            }
            query = query.Where(predicate).OrderBy(t => t.BayCode).ThenBy(t => t.AreaCode).ThenBy(t => t.RowNo).ThenBy(t => t.FloorNo).ThenBy(t => t.ColNo);
            var listResult = await QueryListModel(query, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/{reportName}.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"{reportName}.xlsx"
            };
        }



        /// <summary>
        /// 交接班库存差异统计
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<ShiftModel>>> GetDiverList([FromQuery] string[] time, CancellationToken cancellationToken)
        {
            var whBays = DataContext.Set<TWhBay>();
            var rcLocationMaterials = DataContext.Set<TRcLocationMaterial>();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var query = whBays.Where(t => t.IsEnable == 1).OrderBy(t=>t.Code);
            var baylist = await query
               .ProjectTo<TWhBayReadModel>(Mapper.ConfigurationProvider)
               .ToListAsync(cancellationToken);

            var startime = Convert.ToDateTime(time[0]);
            var endtime = Convert.ToDateTime(time[1]);

            var result = new PageResult<ShiftModel>();
            var listmodel = new List<ShiftModel>();

            foreach (var bay in baylist)
            {
                for (int i = 0; i < 3; i++)
                {
                    var predicate = ExpressionBuilder.True<TRcLocationMaterial>();
                    var divertime = "";
                    if (i == 0) {
                        //2022-10-19 20:00:00    2022-10-20 08:00:00
                        var startime_new = endtime.AddDays(-1);
                        var endtime_new = startime; 
                        divertime = startime_new.ToString();
                        predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2
                             && t.BayId == bay.Id
                             && t.ShiftStratTime > startime_new
                             && t.ShiftEndTime <= endtime_new);
                    }
                    if (i == 1) {
                        //2022-10-20 08:00:00    2022-10-20 20:00:00
                        divertime = startime.ToString();
                        predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2
                         && t.BayId == bay.Id
                         && t.ShiftStratTime > startime
                         && t.ShiftEndTime <= endtime);
                    }
                    if (i == 2)
                    {
                        //2022-10-20 20:00:00    2022-10-21 08:00:00
                        var startime_new = endtime;
                        var endtime_new = startime.AddDays(1);
                        divertime = startime_new.ToString();
                        predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2
                         && t.BayId == bay.Id
                         && t.ShiftStratTime > startime_new
                         && t.ShiftEndTime <= endtime_new);
                    }

                    //物料总量
                    var matSum = rcLocationMaterials.Where(predicate).Count();
                   
                    var model = new ShiftModel()
                    {
                        id = bay.Id+i,
                        name = bay.Name,
                        matSum = matSum,
                        time= divertime
                    };
                    listmodel.Add(model);
                }
            }
            result.Success = true;
            result.Data = listmodel;
            result.Message = "查询统计成功！";
            return result;
        }


        /// <summary>
        /// 生成库存差异报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> CreateDiverReportExcel([FromQuery] string time, [FromQuery] string end, [FromQuery] string reportName, CancellationToken cancellationToken)
        {
            reportName = WebUtility.UrlDecode(reportName);
            var whBays = DataContext.Set<TWhBay>();
            var rcLocationMaterials = DataContext.Set<TRcLocationMaterial>();
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var query = whBays.Where(t => t.IsEnable == 1).OrderBy(t => t.Code);
            var baylist = await query
               .ProjectTo<TWhBayReadModel>(Mapper.ConfigurationProvider)
               .ToListAsync(cancellationToken);

            var startime = Convert.ToDateTime(time);
            var endtime = Convert.ToDateTime(end);

            var result = new PageResult<ShiftModel>();
            var listmodel = new List<ShiftModel>();

            foreach (var bay in baylist)
            {
                for (int i = 0; i < 3; i++)
                {
                    var predicate = ExpressionBuilder.True<TRcLocationMaterial>();
                    var divertime = "";
                    if (i == 0)
                    {
                        //2022-10-19 20:00:00    2022-10-20 08:00:00
                        var startime_new = endtime.AddDays(-1);
                        var endtime_new = startime;
                        divertime = startime_new.ToString();
                        predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2
                             && t.BayId == bay.Id
                             && t.ShiftStratTime > startime_new
                             && t.ShiftEndTime <= endtime_new);
                    }
                    if (i == 1)
                    {
                        //2022-10-20 08:00:00    2022-10-20 20:00:00
                        divertime = startime.ToString();
                        predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2
                         && t.BayId == bay.Id
                         && t.ShiftStratTime > startime
                         && t.ShiftEndTime <= endtime);
                    }
                    if (i == 2)
                    {
                        //2022-10-20 20:00:00    2022-10-21 08:00:00
                        var startime_new = endtime;
                        var endtime_new = startime.AddDays(1);
                        divertime = startime_new.ToString();
                        predicate = predicate.And(t => t.IsEnable == 1 && t.Type == 2
                         && t.BayId == bay.Id
                         && t.ShiftStratTime > startime_new
                         && t.ShiftEndTime <= endtime_new);
                    }

                    //物料总量
                    var matSum = rcLocationMaterials.Where(predicate).Count();

                    var model = new ShiftModel()
                    {
                        id = bay.Id,
                        name = bay.Name,
                        matSum = matSum,
                        time = divertime
                    };
                    listmodel.Add(model);
                }
            }

            PageResult<ShiftModel> listResult = new()
            {
                Data = listmodel,
                Success = true,
                Total = listmodel.Count
            };

            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/{reportName}.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"{reportName}.xlsx"
            };
        }



    }
}
