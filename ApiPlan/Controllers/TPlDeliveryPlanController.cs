using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain.Entities;
using WmsApi.Domain;
using WmsApi;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts;
using System.Collections.Generic;
using System.Linq;
using static MassTransit.ValidationResultExtensions;

namespace ApiPlan.Controllers
{
	[ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlDeliveryPlanController : EntityControllerBase<TPlDeliveryPlan, TPlDeliveryPlanReadModel, TPlDeliveryPlanCreateModel, TPlDeliveryPlanUpdateModel>
    {
        public TPlDeliveryPlanController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlDeliveryPlanCreateModel> createValidator, IValidator<TPlDeliveryPlanUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }


		/// <summary>
		/// 备料，发货量统计
		/// </summary>
		[HttpGet("")]

		public async Task<ActionResult<MpStatModels>>
			GetMpAnalysis(string pHouse, string planDate, CancellationToken cancellationToken)
		{
			var result = MpAnalysis(pHouse, planDate);

			return result;
		}

		private MpStatModels MpAnalysis(string pHouse, string planDate)
		{
			MpStatModels result = new MpStatModels();
			List<string> bays = new List<string>();
			switch (pHouse)
			{
				case "P5":
					bays.AddRange(new string[] { "16", "17" });
					result.Percent = "16库:40,17库:60";
					break;
				case "P6":
					bays.AddRange(new string[] { "21", "22", "23", "24" });
					result.Percent = "21库:40,22库:25,23库:25,24库:10";
					break;
				case "P8":
					bays.AddRange(new string[] { "25", "26", "27" });
					result.Percent = "25库:25,26库:40,27库:35";
					break;
				default:
					return result;
			}
			var repoDeliveryPlan = DataContext.Set<TPlDeliveryPlan>();
			var repoTrLm = DataContext.Set<TTrLocationMaterial>();
			var plans = repoDeliveryPlan.Where(t => t.House == pHouse && t.PlanDate == planDate).ToList();
			var trlms = new Dictionary<string, List<MpStatModelSingleBay>>();
			foreach (var bay in bays)
			{
				var list = repoTrLm.Where(t => t.BayCode == bay && t.Type == 2 && t.IsEnable == 1)
					.GroupBy(t => t.OrderNo).Select(g => (
					new MpStatModelSingleBay
					{
						OrderNo = g.Key,
						Count = g.Count(),
						Weight = Convert.ToDecimal(g.Sum(t => t.Weight) ?? 0)/1000m
					})).ToList();
				trlms.Add(bay, list);
			}

			var mpStatModelsSingleBay = new List<MpStatModelSingleBay>();
			var mpStatModelsAllBay = new List<MpStatModelAllBay>();
			foreach (var plan in plans)
			{
				var statAllBay = new MpStatModelAllBay();
				var index = 0;
				foreach (var bay in bays)
				{
					var orderMat = trlms[bay].Find(t => t.OrderNo == plan.OrderNo);
					statAllBay.OrderNo = plan.OrderNo;
					statAllBay.PlanDate = plan.PlanDate;
					statAllBay.PlanCount = plan.PlanNum ?? 0;
					statAllBay.PlanWeight = plan.PlanWeight ?? 0m;
					switch (index)
					{
						case 0:
							{
								statAllBay.BayName1 = bay;
								statAllBay.Count1 = orderMat?.Count ?? 0;
								statAllBay.Weight1 = orderMat?.Weight ?? 0;
								if (statAllBay.Count1 >= plan.PlanNum && statAllBay.Weight1 >= plan.PlanWeight)
								{
									statAllBay.IsMp1 = true;
								}
								break;
							}

						case 1:
							{
								statAllBay.BayName2 = bay;
								statAllBay.Count2 = orderMat?.Count ?? 0;
								statAllBay.Weight2 = orderMat?.Weight ?? 0;
								if (statAllBay.Count2 >= plan.PlanNum && statAllBay.Weight2 >= plan.PlanWeight)
								{
									statAllBay.IsMp2 = true;
								}
								break;
							}

						case 2:
							{
								statAllBay.BayName3 = bay;
								statAllBay.Count3 = orderMat?.Count ?? 0;
								statAllBay.Weight3 = orderMat?.Weight ?? 0;
								if (statAllBay.Count3 >= plan.PlanNum && statAllBay.Weight3 >= plan.PlanWeight)
								{
									statAllBay.IsMp3 = true;
								}
								break;
							}

						case 3:
							{
								statAllBay.BayName4 = bay;
								statAllBay.Count4 = orderMat?.Count ?? 0;
								statAllBay.Weight4 = orderMat?.Weight ?? 0;
								if (statAllBay.Count4 >= plan.PlanNum && statAllBay.Weight4 >= plan.PlanWeight)
								{
									statAllBay.IsMp4 = true;
								}
								break;
							}
					}
					index++;

					if (orderMat != null && orderMat.Count > 0 )
					{
						var statSingleBay = new MpStatModelSingleBay
						{
							BayName = bay,
							PlanDate = plan.PlanDate,
							PlanCount = plan.PlanNum ?? 0,
							PlanWeight = plan.PlanWeight ?? 0,
							OrderNo = plan.OrderNo,
							Count = orderMat.Count,
							Weight = orderMat.Weight
						};
						mpStatModelsSingleBay.Add(statSingleBay);
					}
				}
				if (!statAllBay.IsMp1 && !statAllBay.IsMp2 && !statAllBay.IsMp3 && !statAllBay.IsMp4)
				{
					if (statAllBay.Count1 > 0)
					{
						statAllBay.IsMp1 = true;
					}
					if (statAllBay.Count2 > 0)
					{
						statAllBay.IsMp2 = true;
					}
					if (statAllBay.Count3 > 0)
					{
						statAllBay.IsMp3 = true;
					}
					if (statAllBay.Count4 > 0)
					{
						statAllBay.IsMp4 = true;
					}
				}
				mpStatModelsAllBay.Add(statAllBay);
			}

			var groupedSingleBay = mpStatModelsSingleBay.GroupBy(x => x.OrderNo)
				.Select(g => (new { orderNo = g.Key, count = g.Count() }));
			var groupedOnlyBay = groupedSingleBay.Where(t => t.count == 1).ToList();

			foreach (var gsb in groupedOnlyBay)
			{
				var mssb = mpStatModelsSingleBay.First(s => s.OrderNo == gsb.orderNo);
				result.Only.Add(mssb);
				mpStatModelsAllBay.RemoveAll(t => t.OrderNo == gsb.orderNo);
			}
			result.Shared.AddRange(mpStatModelsAllBay);


			return result;
		}


		/// <summary>
		/// 备料占比订单
		/// </summary>
		[HttpGet("")]

		public async Task<ActionResult<List<MpStatModelAllBay>>>
			GetPlanMaterialPercentOrder(string pHouse, string planDate, string percent, CancellationToken cancellationToken)
		{
			var dictPercent = new Dictionary<string, int>();
			List<string> bays = new List<string>();
			switch (pHouse)
			{
				case "P5":
					bays.AddRange(new string[] { "16", "17" });
					if (percent.Contains("16库:") && percent.Contains("17库:"))
					{
						var list = percent.Split(",");
						if (list.Count() == 2)
						{
							foreach (var l in list)
							{
								var pair = l.Split(":");
								if (pair.Length == 2)
								{
									dictPercent.Add(pair[0].Replace("库", ""), Convert.ToInt32(pair[1]));
								}
							}
						}
					}
					break;
				case "P6":
					bays.AddRange(new string[] { "21", "22", "23", "24" });
					if (percent.Contains("21库:") && percent.Contains("22库:") && percent.Contains("23库:") && percent.Contains("24库:"))
					{
						var list = percent.Split(",");
						if (list.Count() == 4)
						{
							foreach (var l in list)
							{
								var pair = l.Split(":");
								if (pair.Length == 2)
								{
									dictPercent.Add(pair[0].Replace("库", ""), Convert.ToInt32(pair[1]));
								}
							}
						}
					}
					break;
				case "P8":
					bays.AddRange(new string[] { "25", "26", "27" });
					if (percent.Contains("25库:") && percent.Contains("26库:") && percent.Contains("27库:"))
					{
						var list = percent.Split(",");
						if (list.Count() == 3)
						{
							foreach (var l in list)
							{
								var pair = l.Split(":");
								if (pair.Length == 2)
								{
									dictPercent.Add(pair[0].Replace("库", ""), Convert.ToInt32(pair[1]));
								}
							}
						}
					}
					break;
				default:
					return NotFound();
			}
			if (!dictPercent.Any())
			{
				return NotFound();
			}

			//计算每个库的确定性发货重量
			//var dictBayWeight = new Dictionary<string, double>();
			//var analysisResult = MpAnalysis(pHouse, planDate);
			//foreach (var dp in dictPercent)
			//{
			//	var weight = analysisResult.Only.Where(t => t.BayName == dp.Key).Sum(t => t.Weight);
			//	dictBayWeight.Add(dp.Key, weight);
			//}

			return Ok();
		}
	}
}
