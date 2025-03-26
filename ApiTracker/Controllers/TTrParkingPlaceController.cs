using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cds.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
	public class TTrParkingPlaceController : EntityControllerBase<TTrParkingPlace, TTrParkingPlaceReadModel, TTrParkingPlaceCreateModel, TTrParkingPlaceUpdateModel>
	{
		public TTrParkingPlaceController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrParkingPlaceCreateModel> createValidator, IValidator<TTrParkingPlaceUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
		}
		/// <summary>
		/// 更改车位道闸开关
		/// </summary>
		/// <returns></returns>
		[HttpPut("")]
		public async Task<ActionResult<int>>UpdateGateParking(string name, CancellationToken cancellationToken)
		{
			var repo = DataContext.Set<TTrParkingPlace>();
			var state = repo.Where(t => t.ParkingPlaceName == name).FirstOrDefault();
			if (state != null)
			{
                if (state.GateState==1)
                {
					state.GateState = 0;
				}
				else
				{
					state.GateState = 1;
				}
				var count = await DataContext.SaveChangesAsync();
				return count;
			}
			return null;
		}

		/// <summary>
		/// 获取车位道闸
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[HttpGet("")]	
		public async Task<ActionResult<PageResult<TTrParkingPlaceReadModel>>> GetGateParking(CancellationToken cancellationToken)
        {
			var predicate = ExpressionBuilder.True<TTrParkingPlace>();
			var query = GetQueryOrderByIdDesc(predicate);
			var listResult = await QueryListModel(query, cancellationToken);
			return Ok(listResult);
		}
	}
}
