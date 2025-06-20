using AutoMapper;
using Cds.Contracts;
using Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ucp.Contracts;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using static MassTransit.ValidationResultExtensions;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("equip/[controller]/[action]")]
    public class TEqCraneController : EntityControllerBase<TEqCrane, TEqCraneReadModel, TEqCraneCreateModel, TEqCraneUpdateModel>
    {
        public TEqCraneController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqCraneCreateModel> createValidator, IValidator<TEqCraneUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {

        }

        [HttpGet("")]
        public async Task<ActionResult<PageResult<TEqCraneReadModel>>> GetListOfBay(string bayId, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TEqCrane>();
            if (bayId.IsValidValue())
            {
                predicate = predicate.And(t => t.OwnerId == bayId);
            }

            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await QueryListModel(query, cancellationToken);

            return Ok(listResult);
        }


        [HttpPost("")]
        public override async Task<ActionResult<OperationResult>> Create(TEqCraneCreateModel createModel, CancellationToken cancellationToken)
        {
            var operationResult = await CanCreate(createModel, cancellationToken);
            if (!operationResult.Success)
            {
                return operationResult;
            }
            SetCreateModelBasic(createModel);
            // validate model
            await CreateValidator.ValidateAndThrowAsync(createModel, cancellationToken);
            // create new entity from model
            var entity = Mapper.Map<TEqCrane>(createModel);
            //t_tr_crane
            var trCrane = new TTrCrane();
            trCrane.CraneId = entity.Id;
            trCrane.CraneName = entity.Name;
            trCrane.BayId = entity.OwnerId;
            trCrane.Id = IdWorkerGenerator.Instance.NextId().ToString();
            trCrane.IsEnable = 1;
            trCrane.CreateTime = DateTime.Now;
            trCrane.CreateUser = "API";
            trCrane.UpdateTime = DateTime.Now;
            trCrane.UpdateUser = "API";
            // add to data set, id should be generated
            await DataContext
                .Set<TEqCrane>()
                .AddAsync(entity, cancellationToken);
            await DataContext.Set<TTrCrane>()
                .AddAsync(trCrane, cancellationToken);

            // save to database
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return operationResult;
        }

        [HttpPut("{id}")]
        public override async Task<ActionResult<OperationResult>> Update(string id, TEqCraneUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);

            // validate model
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

            // primary key
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TEqCrane>()
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
            {
                return new OperationResult(false, "���ݲ����ڣ�����ʧ�ܡ�");
            }

            // copy updates from model to entity
            Mapper.Map(updateModel, entity);

            var entitytr = DataContext
                .Set<TTrCrane>()
                .Where(t => t.CraneId == id)
                .FirstOrDefault();
            if (entitytr == null)
            {
                return new OperationResult(false, "�������ݲ����ڣ�����ʧ�ܡ�");
            }

            entitytr.CraneName = entity.Name;
            entitytr.BayId = entity.OwnerId;
            entitytr.UpdateTime = DateTime.Now;
            entitytr.UpdateUser = "API"; ;

            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return new OperationResult(true, "���ݸ��³ɹ���");
        }

        /// <summary>
        /// �г�ǰ������λ
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<OperationResult>> SendCraneCmd([FromQuery] string craneId, int cmd, CancellationToken cancellationToken)
        {
            var repoEq = DataContext.Set<TEqCrane>();
            var repoRl = DataContext.Set<TRlCranePlanType>();
            if (!craneId.IsNullOrEmpty())
            {
                var eqCrane = repoEq.Where(t => t.Id == craneId.ToString()).FirstOrDefault();
                var rlCrane = repoRl.Where(t => t.CraneId == craneId.ToString()).FirstOrDefault();
                var mbs = ServiceProvider.GetService<MbsProxy>();
                if (cmd == 1) //����λ
                {
                    var key = new Ucp.Contracts.Key(eqCrane.Id, eqCrane.Name,0);

                    var payLoad = new CraneDriverStandbyCommand()
                    {
                        CraneKey = key
                    };
                    await mbs.Publish(payLoad);

                    //rlCrane.PlanTypeName1 = null;
                    //rlCrane.PlanTypeName2 = null;
                    //rlCrane.PlanTypeName3 = null;
                    //rlCrane.PlanTypeName4 = null;
                    //rlCrane.PlanTypeName5 = null;
                    //rlCrane.PlanTypeName6 = null;
                    //rlCrane.PlanTypeName7 = null;
                    //rlCrane.PlanTypeName8 = null;
                    //rlCrane.PlanTypeName9 = null;
                    //rlCrane.PlanTypeName10 = null;

                    eqCrane.IsDriverStandby = cmd;

                    await DataContext.SaveChangesAsync();
                    return new OperationResult(true, $"{eqCrane.Name}����ǰ������λ");
                }
                if (cmd == 0)//����
                {
                    //rlCrane.PlanTypeName1 = "����";
                    //rlCrane.PlanTypeName2 = "װ������";
                    //rlCrane.PlanTypeName3 = "��䵹��";
                    //rlCrane.PlanTypeName4 = "��������";
                    //rlCrane.PlanTypeName5 = "�־�����";

                    eqCrane.IsDriverStandby = cmd;
                }
                await DataContext.SaveChangesAsync();
                return new OperationResult(true, $"{eqCrane.Name}�ָ�����");

            }
            return new OperationResult(false, "�г�Id����Ϊ��");
        }
    }
}
