using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain.Entities;
using WmsApi.Domain;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Cds.Contracts;
using WmsApi;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlCraneMaintenanceController : EntityControllerBase<TPlCraneMaintenance, TPlCraneMaintenanceReadModel, TPlCraneMaintenanceCreateModel, TPlCraneMaintenanceUpdateModel>
    {
        public TPlCraneMaintenanceController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlCraneMaintenanceCreateModel> createValidator, IValidator<TPlCraneMaintenanceUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> CreatePlan(TPlCraneMaintenanceCreateModel createModel, CancellationToken cancellationToken)
        {
            var operationResult = await CanCreate(createModel, cancellationToken);
            if (!operationResult.Success)
            {
                return operationResult;
            }
            var starttime = (DateTime)createModel.StartTime;
            var endtime = (DateTime)createModel.EndTime;
            createModel.StartTime = starttime.AddHours(8);
            createModel.EndTime = endtime.AddHours(8);
            SetCreateModelBasic(createModel);

            // validate model
            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);
            // create new entity from model
            var entity = Mapper.Map<TPlCraneMaintenance>(createModel);

            // add to data set, id should be generated
            await DataContext
                .Set<TPlCraneMaintenance>()
                .AddAsync(entity, cancellationToken);

            // save to database
            await DataContext
                .SaveChangesAsync(cancellationToken);
            return new OperationResult(true,$"{starttime},{endtime}");
        }

        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Apply(string id, CancellationToken cancellationToken)
        {
            var craneMaintenance = await DataContext.Set<TPlCraneMaintenance>().
                FirstOrDefaultAsync(t => t.Id == id && t.IsEnable == 1);
            if (craneMaintenance == null)
            {
                return new OperationResult(false, $"行车检修计划不存在");
            }
            if (craneMaintenance.State == 14)
            {
                return new OperationResult(false, $"集控中心已销案，无法申请");
            }
            craneMaintenance.State = 1;
            var trLocMats = DataContext.Set<TTrLocationMaterial>().Where(t => t.PointX > craneMaintenance.AreaMixX && t.PointX < craneMaintenance.AreaMaxX && t.IsEnable == 1).ToList();

            if (trLocMats.Count > 0)
            {
                var inStocks = trLocMats.Where(t => t.Type == 2).ToList();
                if ((decimal)inStocks.Count / trLocMats.Count > 0.5m)
                {
                    return new OperationResult(false, $"检修区域下方卷数量占比大于50%，请更换检修区域");
                }
                foreach (var loc in trLocMats)
                {
                    if (loc.StorageType == 1)
                        loc.StorageType = 203;
                }
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, $"行车{craneMaintenance.CraneName}检修申请完成");
        }

        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> Purge(string id, CancellationToken cancellationToken)
        {
            var craneMaintenance = await DataContext.Set<TPlCraneMaintenance>().
                FirstOrDefaultAsync(t => t.Id == id && t.IsEnable == 1);
            if (craneMaintenance == null)
            {
                return new OperationResult(false, $"行车检修计划不存在");
            }
            if (craneMaintenance.State != 1)
            {
                return new OperationResult(false, $"当前状态非申请状态，无法销案");
            }
            craneMaintenance.State = 14;
            var trLocMats = DataContext.Set<TTrLocationMaterial>().Where(t => t.PointX > craneMaintenance.AreaMixX && t.PointX < craneMaintenance.AreaMaxX && t.IsEnable == 1).ToList();

            if (trLocMats.Count > 0)
            {
                foreach (var loc in trLocMats)
                {
                    if (loc.StorageType == 203)
                        loc.StorageType = 1;
                }
            }
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, $"行车{craneMaintenance.CraneName}检修销案完成");
        }
    }
}
