using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLog.Web.LayoutRenderers;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using WmsApi;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcLogController : EntityControllerBase<TRcLog, TRcLogReadModel, TRcLogCreateModel, TRcLogUpdateModel>
    {
        public TRcLogController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcLogCreateModel> createValidator, IValidator<TRcLogUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
        [HttpGet]
        public async Task<ActionResult<PageResult<TRcLogReadModel>>> GetPageBy20w([FromQuery] PageParam pageParam, [FromQuery] string[] time, string message, CancellationToken cancellationToken)
        {
            var rcLogs = DataContext.Set<TRcLog>();
            var predicate = ExpressionBuilder.True<TRcLog>();
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 09:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");
            if (time.Length > 0)
            {
                startime = Convert.ToDateTime(time[0]);
                endtime = Convert.ToDateTime(time[1]);
            }
            predicate = predicate.And(t => t.Dt > startime && t.Dt <= endtime);
            if (message != "" && message != null)
            {
                predicate = predicate.And(t => t.Message.Contains(message));
            }
            var query = rcLogs.AsNoTracking();
            if (predicate != null)
            {
                query = query.Where(predicate).OrderBy(t => t.Dt).Take(200000);
            }
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> CreateLog(string message, CancellationToken cancellationToken)
        {

            var rcLog = DataContext.Set<TRcLog>();
            var log = new TRcLog()
            {
                Id = DateTime.Now.ToFileTime().ToString(),
                Dt = DateTime.Now,
                EventNo = "1000",
                WarningLevel = "Info",
                Message = message,
                Source = "Client"
            };
            rcLog.Add(log);
            var count = DataContext.SaveChanges();
            if (count > 0)
            {
                return new OperationResult(true, "");
            }
            return new OperationResult(false, "");
        }
    }
}
