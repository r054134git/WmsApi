using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.DynamicLinq;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using WmsApi;
using WmsApi.Contracts.Models;
using WmsApi.Controllers;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace ApiPlan.Controllers
{
    [ApiController]
    [Route("plan/[controller]/[action]")]
    public class TPlMaterialController : EntityControllerBase<TPlMaterial, TPlMaterialReadModel, TPlMaterialCreateModel, TPlMaterialUpdateModel>
    {
        public TPlMaterialController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TPlMaterialCreateModel> createValidator, IValidator<TPlMaterialUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [TokenActionFilter]
        [HttpPut("{id}")]
        public async Task<ActionResult<OperationResult>> UpdateMat(string id, TPlMaterialUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);

            // validate model
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

            // primary key
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TPlMaterial>()
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
            {
                return new OperationResult(false, "数据不存在，更新失败。");
            }

            // copy updates from model to entity
            Mapper.Map(updateModel, entity);

            await UpdateLocationMaterial(entity, cancellationToken);

            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return new OperationResult(true, "数据更新成功。");
        }


        /// <summary>
        /// 更新库存表数据
        /// </summary>
        /// <returns></returns>
        private async Task UpdateLocationMaterial(TPlMaterial entity, CancellationToken cancellationToken)
        {
            var identityName = User.GetUserName() ?? "API";
            var dbSet = DataContext.Set<TTrLocationMaterial>();
            var locationMaterial = await dbSet.Where(t => t.MaterialNo == entity.No).FirstOrDefaultAsync(cancellationToken: cancellationToken);
            if (locationMaterial != null)
            {
                locationMaterial.Width = entity.Width;
                locationMaterial.Diameter = entity.Diameter;
                locationMaterial.UpdateTime = DateTime.Now;
                locationMaterial.UpdateUser = identityName;
            }
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlMaterialReadModel>>> GetListByNo(string materialNo, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlMaterial>();
            predicate = predicate.And(t => t.No.StartsWith("H"));
            if (!materialNo.IsValidValue())
            {
                return NotFound();
            }

            predicate = predicate.And(t => t.No.Contains(materialNo));
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        [HttpGet("")]
        public override async Task<ActionResult<PageResult<TPlMaterialReadModel>>>
            GetPageByString([FromQuery] PageParam pageParam, string where,
                            string orders, CancellationToken cancellationToken)
        {
            //if (!string.IsNullOrEmpty(where))
            //{
            //    where = where + " and NO like \"H%\"";
            //}
            var query = GetQueryByString(where, orders);
            query = query.Where(t => !string.IsNullOrEmpty(t.No) && t.No.StartsWith("H"));
            var listResult = await QueryPageModel(query, pageParam, cancellationToken);

            return Ok(listResult);
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlMaterialReadModel>>> GetListByDefectType(CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlMaterial>();
            predicate = predicate.And(t => t.DefectType == 2);
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }

        [HttpGet("")]
        public async Task<ActionResult<TPlMaterialReadModel>> GetCoilState(string materialId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlMaterial>();
            if (!materialId.IsValidValue())
            {
                predicate = predicate.And(t => t.Id.Contains(materialId));
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);

            return listResult;
        }

        [HttpGet("")]
        public async Task<ActionResult<int>> GetMaterialDefectDesc(string materialId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlMaterial>();
            if (!materialId.IsValidValue())
            {
                predicate = predicate.And(t => t.Id.Contains(materialId));
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);
            if (listResult.DefectType == null)
            {
                return 0;
            }
            else
            {
                return (int)listResult.DefectType;
            }
        }

        [HttpGet("")]
        public async Task<ActionResult<int>> UpdateCoilState(TPlMaterialReadModel pl, CancellationToken cancellationToken)
        {
            var predicate = DataContext.Set<TPlMaterial>();

            var result = predicate.Where(t => t.Id == pl.Id);
            if (result != null)
            {
                Mapper.Map(pl, result);
                var count = await DataContext.SaveChangesAsync();
                return count;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 更改物料信息
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> UpdateCoilInfo(TPlMaterialUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);
            var repoPl = await DataContext.Set<TPlMaterial>().FirstOrDefaultAsync(t => t.No == updateModel.No);
            var repoTr = await DataContext.Set<TTrLocationMaterial>().FirstOrDefaultAsync(t => t.MaterialNo == updateModel.No);
            if (repoPl == null)
            {
                return new OperationResult(false, "选择的目标物料不存在！");
            }
            repoPl.No = updateModel.No;
            repoPl.Thick = updateModel.Thick;
            repoPl.Width = updateModel.Width;
            repoPl.Weight = updateModel.Weight;
            repoPl.SteelGrade = updateModel.SteelGrade;
            repoPl.Diameter = updateModel.Diameter;
            repoPl.InnerDiameter = updateModel.InnerDiameter;
            repoPl.OrderNo = updateModel.OrderNo;
            repoPl.HoldFlag = updateModel.HoldFlag;
            repoPl.HoldCauseCode = updateModel.HoldCauseCode;
            repoPl.MatDisposeCode = updateModel.MatDisposeCode;
            repoPl.ComplexDecideCode = updateModel.ComplexDecideCode;

            var identityName = User?.Identity?.Name ?? "API";
            if (repoTr != null)
            {
                repoTr.Thick = updateModel.Thick;
                repoTr.Width = updateModel.Width;
                repoTr.Weight = updateModel.Weight;
                repoTr.SteelGrade = updateModel.SteelGrade;
                repoTr.Diameter = updateModel.Diameter;
                repoTr.InnerDiameter = updateModel.InnerDiameter;
                repoTr.OrderNo = updateModel.OrderNo;
                repoTr.HoldFlag = updateModel.HoldFlag;
                repoTr.HoldCauseCode = updateModel.HoldCauseCode;
                repoTr.MatDisposeCode = updateModel.MatDisposeCode;
                repoTr.ComplexDecideCode = updateModel.ComplexDecideCode;
                repoTr.UpdateTime = DateTime.Now;
                repoTr.UpdateUser = "API";
            }
            await DataContext
                .SaveChangesAsync(cancellationToken);
            return new OperationResult(true, "物料信息修改成功！");
        }

        /// <summary>
        /// 获取物料信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<ActionResult<int>> GetMaterialWeight(string materialNo, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TPlMaterial>();
            predicate = predicate.And(t => t.No == materialNo);
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);
            if (listResult != null)
            {
                return Ok(listResult);
            }
            else
            {
                return 0;
            }

        }

        [HttpGet("")]
        public async Task<bool> ConfirmOut(string bayName, string coilNo, CancellationToken cancellationToken)
        {
            return false;
        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TPlMaterialReadModel>>> GetQueryPageList([FromQuery] string[] time, [FromQuery] PageParam pageParam, CancellationToken cancellationToken)
        {
            //var query11 = (from b in DataContext.Set<TPlMaterial>()
            //               join p in DataContext.Set<TTrLocationMaterial>()
            //                   on b.No! equals p.MaterialNo
            //               where b.CreateTime > Convert.ToDateTime("2023-01-31 08:13:40")
            //               where p.Type == 2
            //               where b.No!=p.MaterialNo
            //               select new PetsDetails { PetName = b.No }).ToList();

            //var query12221 = (from b in DataContext.Set<TPlMaterial>()
            //                  from p in DataContext.Set<TTrLocationMaterial>()  
            //               where b.CreateTime > Convert.ToDateTime("2023-01-31 08:13:40")
            //               where p.Type == 2
            //               where b.No != p.MaterialNo
            //               select new PetsDetails { PetName = b.No }).ToList();

            var startime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 09:00:00");
            var endtime = Convert.ToDateTime($"{DateTime.Now:yyyy-MM-dd} 18:00:00");
            if (time.Length > 0 && time != null)
            {
                startime = Convert.ToDateTime(time[0]);
                endtime = Convert.ToDateTime(time[1]);
            }

            var sql = $" SELECT * from t_pl_material where CREATE_TIME>='{startime}' and CREATE_TIME<='{endtime}' and  NO not like 'Q%' " +
              "and NO not in (SELECT MATERIAL_NO from t_tr_location_material WHERE type='2') ";

            var query = DataContext.Set<TPlMaterial>().FromSqlRaw(sql);
            var listResult = await QueryPageModel(query, pageParam);
            return Ok(listResult);
        }



    }
}
