using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;
using WmsApi.Domain;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using Aspose.Cells;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcLocationsRateController : EntityControllerBase<TRcLocationsRate, TRcLocationsRateReadModel, TRcLocationsRateCreateModel, TRcLocationsRateUpdateModel>
    {
        public TRcLocationsRateController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcLocationsRateCreateModel> createValidator, IValidator<TRcLocationsRateUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcLocationsRateReadModel>>>GetPageBySearchTime([FromQuery] PageParam pageParam, [FromQuery] string[] dt, [FromQuery] string[] bayCode, string orders ,CancellationToken cancellationToken)
        {
            var trcLocations = DataContext.Set<TRcLocationsRate>();
            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 08:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");

            var query = trcLocations.AsNoTracking();
            if (orders != null && orders.Any())
            {
                query = GetQueryByString("", orders);
            }
            if (dt.Length > 0 && dt != null)
            {
                startime = Convert.ToDateTime(dt[0]);
                endtime = Convert.ToDateTime(dt[1]);
            }
            query = query.Where(t => t.Dt > startime && t.Dt <= endtime);
            if (bayCode.Length > 0 && bayCode != null)
            {
                query = query.Where(t => bayCode.Contains(t.BayCode));
            }   
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);
            return Ok(listResult);
        }
    }
}
