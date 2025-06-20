using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.IO;
using System.Net;
using MiniExcelLibs;
using System.Collections.Generic;
using Microsoft.IdentityModel.Tokens;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections;
using AutoMapper.QueryableExtensions;
using Aspose.Cells.Drawing;
using Microsoft.AspNetCore.Http;
using System.Runtime.Intrinsics.X86;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcMaterialEventController : EntityControllerBase<TRcMaterialEvent, TRcMaterialEventReadModel, TRcMaterialEventCreateModel, TRcMaterialEventUpdateModel>
    {
        public TRcMaterialEventController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcMaterialEventCreateModel> createValidator, IValidator<TRcMaterialEventUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        private static TOut TransReflection<TIn, TOut>(TIn tIn)
        {
            TOut tOut = Activator.CreateInstance<TOut>();
            var tInType = tIn.GetType();
            foreach (var itemOut in tOut.GetType().GetProperties())
            {
                var itemIn = tInType.GetProperty(itemOut.Name); ;
                if (itemIn != null)
                {
                    itemOut.SetValue(tOut, itemIn.GetValue(tIn));
                }
            }
            return tOut;
        }

        private List<TRcMaterialEvent> getFunMat(string materialNo, List<string> matNoList)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            predicate = predicate.And(t => t.MaterialNo == materialNo);
            var query = rcMaterialEvents.AsNoTracking();
            query = query.Where(predicate);
            var list = query.ToList();

            List<string> matArrNo = new();
            List<TRcMaterialEvent> matArrNoList = new();
            matArrNo.AddRange(matNoList);
            foreach (var item in list)
            {
                if (!item.MaterialNoOld.IsNullOrEmpty())
                {
                    if (!matArrNo.Contains(item.MaterialNoOld))
                    {
                        matArrNoList.AddRange(getFunMat(item.MaterialNoOld, matArrNo));
                    }
                }
                if (!item.MaterialNo.IsNullOrEmpty() && !matArrNo.Contains(item.MaterialNo))
                {
                    matArrNo.Add(item.MaterialNo);
                }
            }
            list.AddRange(matArrNoList);
            return list;
        }

        private List<TRcMaterialEventReadModel> GetPageByStringCommon(string materialNo, CancellationToken cancellationToken)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            if (materialNo.Contains("Q"))
            {
                var materialOldList = rcMaterialEvents.AsNoTracking().Where(t => t.MaterialNoOld == materialNo).ToList();
                var oldList = new List<string>();
                foreach (var item in materialOldList)
                {
                    oldList.Add(item.MaterialNo);
                }
                if (oldList.Count > 0)
                {
                    predicate = predicate.And(t => oldList.Contains(t.MaterialNo));
                }
                else
                {
                    predicate = predicate.And(t => t.MaterialNo == materialNo);
                }
            }
            else
            {
                predicate = predicate.And(t => t.MaterialNo == materialNo);
            }
            var list = rcMaterialEvents.AsNoTracking().Where(predicate).ToList();
            List<string> matArr = new();
            List<string> matArrNo = new();
            foreach (var item in list)
            {
                if (!item.MaterialNoOld.IsNullOrEmpty() && !matArr.Contains(item.MaterialNoOld))
                {
                    if (item.MaterialNoOld != materialNo)
                    {
                        matArr.Add(item.MaterialNoOld);
                    }
                }
                if (!item.MaterialNo.IsNullOrEmpty() && !matArrNo.Contains(item.MaterialNo))
                {
                    matArrNo.Add(item.MaterialNo);
                }
            }
            foreach (var item in matArr)
            {
                list.AddRange(getFunMat(item, matArrNo));
            }
            List<TRcMaterialEventReadModel> listEventRead = new List<TRcMaterialEventReadModel>();
            for (int i = 0; i < list.Count; i++)
            {
                TRcMaterialEventReadModel rcMaterialEventRead = TransReflection<TRcMaterialEvent, TRcMaterialEventReadModel>(list[i]);
                listEventRead.Add(rcMaterialEventRead);
            }
            return listEventRead;
        }

        private IQueryable<TRcMaterialEvent> GetPageByStringCommonEmpty(string materialNo, string[] operationType, string fromLocationName, string toLocationName, CancellationToken cancellationToken)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(t => t.MaterialNo.Contains(materialNo));
            }
            if (operationType.Length == 0)
            {
                predicate = predicate.And(t => (t.OperationType.Contains("自动") || t.OperationType.Contains("人工")));
            }
            else if (operationType.Length > 0 && operationType != null)
            {
                predicate = predicate.And(t => operationType.Contains(t.OperationType));
            }
            if (fromLocationName.IsValidValue())
            {
                predicate = predicate.And(t => t.FromLocationName.Contains(fromLocationName));
            }
            if (toLocationName.IsValidValue())
            {
                predicate = predicate.And(t => t.ToLocationName.Contains(toLocationName));
            }
            var query = rcMaterialEvents.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderByDescending(t => t.Dt);
            }
            return query;

        }

        /// 物料履历查询
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcMaterialEventReadModel>>> GetPageByStringQ([FromQuery] PageParam pageParam, [FromQuery] string materialNo,
            [FromQuery] string[] operationType, [FromQuery] string fromLocationName, [FromQuery] string toLocationName, CancellationToken cancellationToken)
        {
            if (materialNo.IsValidValue())
            {
                var listEventRead = GetPageByStringCommon(materialNo, cancellationToken);
                return new PageResult<TRcMaterialEventReadModel>
                {
                    Data = listEventRead.OrderByDescending(t => t.Dt).Skip((pageParam.Current - 1) * pageParam.PageSize).Take(pageParam.PageSize).ToList(),
                    Success = true,
                    Total = listEventRead.Count
                };
            }
            else
            {
                var query = GetPageByStringCommonEmpty(materialNo, operationType, fromLocationName, toLocationName, cancellationToken);
                var listResult = await QueryPageModel(query, pageParam, cancellationToken);
                return Ok(listResult);
            }
        }

        /// 物料履历下载
        [HttpGet("")]
        public async Task<ActionResult> GetPageByStringQExcel([FromQuery] string materialNo, [FromQuery] string[] operationType, [FromQuery] string fromLocationName, [FromQuery] string toLocationName, string reportName, CancellationToken cancellationToken)
        {
            var data = new List<TRcMaterialEventReadModel>();
            if (materialNo.IsValidValue())
            {
                var listEventRead = GetPageByStringCommon(materialNo, cancellationToken);
                data = listEventRead.OrderByDescending(t => t.Dt).ToList();
            }
            else
            {
                var query = GetPageByStringCommonEmpty(materialNo, operationType, fromLocationName, toLocationName, cancellationToken);
                data = await query.ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            }
            var result = new PageResult<TRcMaterialEventReadModel>
            {
                Data = data,
                Success = true,
            };
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/{reportName}.xlsx", result);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"{reportName}.xlsx"
            };
        }


        /// 自动手动查询占比
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcMaterialEventReadModel>>> GetPageByStringBayCode([FromQuery] PageParam pageParam, [FromQuery] string[] time,
            [FromQuery] string[] bayCode, [FromQuery] string materialNo, [FromQuery] string[] operationType, [FromQuery] string[] contentType, CancellationToken cancellationToken)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 09:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");
            if (time.Length > 0 && time != null)
            {
                startime = Convert.ToDateTime(time[0]);
                endtime = Convert.ToDateTime(time[1]);
            }
            predicate = predicate.And(t => t.Dt > startime && t.Dt <= endtime);
            predicate = predicate.And(t => string.IsNullOrEmpty(t.BayCode) == false);
            if (bayCode.Length > 0 && bayCode != null)
            {
                predicate = predicate.And(t => bayCode.Contains(t.BayCode));
            }
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(t => t.MaterialNo.Contains(materialNo));
            }
            if (operationType.Length == 0)
            {
                predicate = predicate.And(t => (t.OperationType.Contains("自动") || t.OperationType.Contains("人工")));
            }
            else if (operationType.Length > 0 && operationType != null)
            {
                predicate = predicate.And(t => operationType.Contains(t.OperationType));
            }
            if (contentType.Length == 0)
            {
                predicate = predicate.And(t => (t.ContentType.Contains("入库") || t.ContentType.Contains("倒垛") || t.ContentType.Contains("出库")));
            }
            else if (contentType.Length > 0 && contentType != null)
            {
                predicate = predicate.And(t => contentType.Contains(t.ContentType));
            }
            var query = rcMaterialEvents.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderBy(t => t.Dt);
            }
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }

        /// 自动手动查询占比
        [HttpGet("")]
        public async Task<PageResult<TRcMaterialEventReadModel>> GetPageByStringBayCodeCommon([FromQuery] string[] time,
            [FromQuery] string[] bayCode, [FromQuery] string materialNo, [FromQuery] string[] operationType, [FromQuery] string[] contentType, CancellationToken cancellationToken)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 09:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");
            if (time.Length > 0 && time != null)
            {
                startime = Convert.ToDateTime(time[0]);
                endtime = Convert.ToDateTime(time[1]);
            }
            predicate = predicate.And(t => t.Dt > startime && t.Dt <= endtime);
            predicate = predicate.And(t => string.IsNullOrEmpty(t.BayCode) == false);
            if (bayCode.Length > 0 && bayCode != null)
            {
                predicate = predicate.And(t => bayCode.Contains(t.BayCode));
            }
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(t => t.MaterialNo.Contains(materialNo));
            }
            if (operationType.Length == 0)
            {
                predicate = predicate.And(t => (t.OperationType.Contains("自动") || t.OperationType.Contains("人工")));
            }
            else if (operationType.Length > 0 && operationType != null)
            {
                predicate = predicate.And(t => operationType.Contains(t.OperationType));
            }
            if (contentType.Length == 0)
            {
                predicate = predicate.And(t => (t.ContentType.Contains("入库") || t.ContentType.Contains("倒垛") || t.ContentType.Contains("出库")));
            }
            else if (contentType.Length > 0 && contentType != null)
            {
                predicate = predicate.And(t => contentType.Contains(t.ContentType));
            }
            var query = rcMaterialEvents.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderBy(t => t.Dt);
            }
            var results = await query
                .ProjectTo<TRcMaterialEventReadModel>(Mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new PageResult<TRcMaterialEventReadModel>
            {
                Data = results,
                Success = true,
                Total = results.Count
            };
        }

        /// <summary>
        /// 自动手动下载
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public virtual async Task<ActionResult> GetPageByStringBayCodeExcel([FromQuery] string[] time, [FromQuery] string[] bayCode, [FromQuery] string materialNo,
            [FromQuery] string[] operationType, [FromQuery] string[] contentType, CancellationToken cancellationToken)
        {
            var listResult = await GetPageByStringBayCodeCommon(time, bayCode, materialNo, operationType, contentType, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/自动手动.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"自动手动.xlsx"
            };
        }

        /// <summary>
        /// 物料信息追溯
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcMaterialEventReadModel>>> GetTracePageList([FromQuery] PageParam pageParam,
          [FromQuery] string materialNo, [FromQuery] string[] operationType, [FromQuery] string[] contentType, [FromQuery] DateTime[] dt,
          CancellationToken cancellationToken)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(t => t.MaterialNo.Contains(materialNo));
            }
            //人工/自动
            if (operationType.Length == 0)
            {
                predicate = predicate.And(t => (t.OperationType.Contains("自动") || t.OperationType.Contains("人工")) && (t.ContentType == ("出库") || t.ContentType.Contains("入库") || t.ContentType.Contains("倒垛")));
            }
            else if (operationType.Length > 0 && operationType != null)
            {
                predicate = predicate.And(t => operationType.Contains(t.OperationType));
            }
            //生产计划
            if (contentType.Length == 1)
            {
                predicate = predicate.And(t => EF.Functions.Like(t.ContentType, contentType[0]));
            }
            //else if (contentType.Length == 2 || contentType.Length == 0)
            //{
            //    predicate = predicate.And(t => (EF.Functions.Like(t.FromLocationName, "%0M%") || EF.Functions.Like(t.FromLocationName, "%0N%")
            //         || EF.Functions.Like(t.ToLocationName, "%P1%") || EF.Functions.Like(t.ToLocationName, "%P2%") || EF.Functions.Like(t.ToLocationName, "%P3%")));
            //}
            if (dt.Length > 0)
            {
                predicate = predicate.And(t => t.Dt >= dt[0] && t.Dt <= dt[1]);
            }
            var query = rcMaterialEvents.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderByDescending(t => t.Dt);
            }

            var listResult = await QueryPageModel(query, pageParam, cancellationToken);

            return Ok(listResult);
        }


        //物料信息追溯
        [HttpGet("")]
        public async Task<ActionResult> GetTraceReport([FromQuery] string materialNo, [FromQuery] string[] operationType, [FromQuery] string[] contentType, [FromQuery] DateTime[] dt, string reportName, CancellationToken cancellationToken)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(t => t.MaterialNo.Contains(materialNo));
            }
            //人工/自动
            if (operationType.Length == 0)
            {
                predicate = predicate.And(t => (t.OperationType.Contains("自动") || t.OperationType.Contains("人工")));
            }
            else if (operationType.Length > 0 && operationType != null)
            {
                predicate = predicate.And(t => operationType.Contains(t.OperationType));
            }
            //生产计划
            if (contentType.Length == 1)
            {
                if (contentType.Contains("入库"))
                {
                    predicate = predicate.And(t => (t.Description.Contains("拾取") || t.Description.Contains("执行开始"))
                    && (EF.Functions.Like(t.FromLocationName, "%0M%") || EF.Functions.Like(t.FromLocationName, "%0N%")));
                }
                if (contentType.Contains("出库"))
                {
                    predicate = predicate.And(t => EF.Functions.Like(t.ToLocationName, "%P1%")
                    || EF.Functions.Like(t.ToLocationName, "%P2%") || EF.Functions.Like(t.ToLocationName, "%P3%"));
                }
            }
            else if (contentType.Length == 2 || contentType.Length == 0)
            {
                predicate = predicate.And(t => EF.Functions.Like(t.FromLocationName, "%0M%") || EF.Functions.Like(t.FromLocationName, "%0N%")
                     || EF.Functions.Like(t.ToLocationName, "%P1%") || EF.Functions.Like(t.ToLocationName, "%P2%") || EF.Functions.Like(t.ToLocationName, "%P3%"));
            }
            if (dt.Length > 0)
            {
                predicate = predicate.And(t => t.Dt >= dt[0] && t.Dt <= dt[1]);
            }
            var query = rcMaterialEvents.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderByDescending(t => t.Dt);
            }

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
        /// 发货履历查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcMaterialEventReadModel>>> GetDeliveryPageList([FromQuery] PageParam pageParam,
          [FromQuery] string materialNo, [FromQuery] string[] operationType, [FromQuery] DateTime[] dt,
          CancellationToken cancellationToken)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(t => t.MaterialNo.Contains(materialNo));
            }
            //人工/自动
            if (operationType.Length == 0)
            {
                predicate = predicate.And(t => (t.OperationType.Contains("自动") || t.OperationType.Contains("人工")));
            }
            else if (operationType.Length > 0 && operationType != null)
            {
                predicate = predicate.And(t => operationType.Contains(t.OperationType));
            }
            predicate = predicate.And(t => t.Result == "成功");
            predicate = predicate.And(t => EF.Functions.Like(t.ToLocationName, "%P%"));
            if (dt.Length > 0)
            {
                predicate = predicate.And(t => t.Dt >= dt[0] && t.Dt <= dt[1]);
            }
            var query = rcMaterialEvents.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderByDescending(t => t.Dt);
            }

            var listResult = await QueryPageModel(query, pageParam, cancellationToken);

            return Ok(listResult);
        }

        /// <summary>
        /// 发运的物料展示
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcMaterialEventReadModel>>> GetOutMatList([FromQuery] PageParam pageParam, [FromQuery] string bayid, [FromQuery] string[] time, CancellationToken cancellationToken)
        {
            // 查询指定ID的库区信息
            var whBays = DataContext.Set<TWhBay>();
            var bay = await whBays.Where(t => t.Id == bayid).FirstOrDefaultAsync();

            // 初始化物料事件查询
            var dbSet = DataContext.Set<TRcMaterialEvent>();
            var query = dbSet.AsNoTracking();

            // 构建查询条件
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            var startime = Convert.ToDateTime(time[0]);
            var endtime = Convert.ToDateTime(time[1]);
            predicate = predicate.And(t => t.OperationType == "自动" && t.ContentType == "出库"
                        && (EF.Functions.Like(t.FromLocationName, "" + bay.Code + "%")
                        || EF.Functions.Like(t.ToLocationName, "" + bay.Code + "%"))
                         && t.Dt > startime
                         && t.Dt <= endtime);
            query = query.Where(predicate);

            // 执行分页查询并返回结果
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }

        /// <summary>
        /// 生成物料相关报表
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult> CreateOutMatReportExcel([FromQuery] string time, [FromQuery] string end, [FromQuery] string type, [FromQuery] string reportName, CancellationToken cancellationToken)
        {
            reportName = WebUtility.UrlDecode(reportName);
            var dbSet = DataContext.Set<TRcMaterialEvent>();
            var query = dbSet.AsNoTracking();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            var startime = Convert.ToDateTime(time);
            var endtime = Convert.ToDateTime(end);

            predicate = predicate.And(t => t.OperationType == "自动" && t.ContentType == "出库"
                         && t.Dt > startime
                         && t.Dt <= endtime);
            query = query.Where(predicate);
            var listResult = await QueryListModel(query, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/{reportName}.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"{reportName}.xlsx"
            };
        }

        //发货履历
        [HttpGet("")]
        public async Task<ActionResult> CreateReportExcelDelivery([FromQuery] string materialNo, [FromQuery] string[] operationType, [FromQuery] DateTime[] dt, string reportName, CancellationToken cancellationToken)
        {
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(t => t.MaterialNo.Contains(materialNo));
            }
            //人工/自动
            if (operationType.Length == 0)
            {
                predicate = predicate.And(t => (t.OperationType.Contains("自动") || t.OperationType.Contains("人工")));
            }
            else if (operationType.Length > 0 && operationType != null)
            {
                predicate = predicate.And(t => operationType.Contains(t.OperationType));
            }
            predicate = predicate.And(t => t.Result == "成功");
            predicate = predicate.And(t => EF.Functions.Like(t.ToLocationName, "%P%"));
            if (dt.Length > 0)
            {
                predicate = predicate.And(t => t.Dt >= dt[0] && t.Dt <= dt[1]);
            }
            var query = rcMaterialEvents.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderByDescending(t => t.Dt);
            }

            var listResult = await QueryListModel(query, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/{reportName}.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"{reportName}.xlsx"
            };
        }


        private IQueryable<TRcMaterialEvent> GetPrePickPageListCommon(string materialNo, string truckNo, string truckLoadingNo, DateTime[] dt, CancellationToken cancellationToken)
        {
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 00:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:G}");
            if (dt != null && dt.Length > 0)
            {
                startime = dt[0];
                endtime = dt[1];
            }
            var rcMaterialEvents = DataContext.Set<TRcMaterialEvent>();
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            if (materialNo.IsValidValue())
            {
                predicate = predicate.And(t => t.MaterialNo.Contains(materialNo));
            }
            if (truckNo.IsValidValue())
            {
                predicate = predicate.And(t => t.Description.Contains(truckNo));
            }
            if (truckLoadingNo.IsValidValue())
            {
                predicate = predicate.And(t => t.Description.Contains(truckLoadingNo));
            }
            predicate = predicate.And(t => t.Dt >= startime && t.Dt <= endtime);
            predicate = predicate.And(t => (t.ContentType.Contains("预挑") || t.ContentType.Contains("取消")));
            var query = rcMaterialEvents.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderByDescending(t => t.Dt);
            }
            return query;
        }
        /// <summary>
        /// 挑库履历查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcMaterialEventReadModel>>> GetPrePickPageList([FromQuery] PageParam pageParam, [FromQuery] string materialNo, [FromQuery] string truckNo, [FromQuery] string truckLoadingNo, [FromQuery] DateTime[] dt, CancellationToken cancellationToken)
        {
            var query = GetPrePickPageListCommon(materialNo, truckNo, truckLoadingNo, dt, cancellationToken);
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }

        //挑库履历导出
        [HttpGet("")]
        public async Task<ActionResult> GetPrePickPageListExcel([FromQuery] string materialNo, [FromQuery] string truckNo, [FromQuery] string truckLoadingNo, [FromQuery] DateTime[] dt, string reportName, CancellationToken cancellationToken)
        {
            var query = GetPrePickPageListCommon(materialNo, truckNo, truckLoadingNo, dt, cancellationToken);
            var listResult = await QueryListModel(query, cancellationToken);
            var memoryStream = new MemoryStream();
            memoryStream.SaveAsByTemplate($"excel/{reportName}.xlsx", listResult);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"{reportName}.xlsx"
            };
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcMaterialEventReadModel>>>
            GetListByLocation(string locationName, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TRcMaterialEvent>();
            if (locationName.IsValidValue())
            {
                predicate = predicate.And(t => t.ToLocationName == locationName);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken,100);

            return Ok(listResult);
        }

    }
}
