using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Threading.Tasks;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("report/[controller]/[action]")]
    public class TRcCameraController : EntityControllerBase<TRcCameraIds, TRcCameraIdsReadModel, TRcCameraIdsCreateModel, TRcCameraIdsUpdateModel>
    {
        public TRcCameraController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRcCameraIdsCreateModel> createValidator, IValidator<TRcCameraIdsUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bayName"></param>
        /// <param name="dtStart"></param>
        /// <param name="dtEnd"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TRcCameraIdsReadModel>>> GetCameraRecord(string bayName, DateTime? dtStart, DateTime? dtEnd, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TRcCameraIds>();
            if (bayName.IsValidValue())
            {
                predicate = predicate.And(x => x.BayName == bayName); //¿âÃû³Æ
            }
            if (dtStart != null)
            {
                predicate = predicate.And(x => x.CreateTime >= dtStart); 
            }
            if (dtEnd != null)
            {
                predicate = predicate.And(x => x.CreateTime <= dtEnd); 
            }
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

    }





}
