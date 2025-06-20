using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Linq.Dynamic.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("equip/[controller]/[action]")]
    public class TEqFenceAreaController : EntityControllerBase<TEqFenceArea, TEqFenceAreaReadModel, TEqFenceAreaCreateModel, TEqFenceAreaUpdateModel>
    {
        public TEqFenceAreaController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqFenceAreaCreateModel> createValidator, IValidator<TEqFenceAreaUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [TokenActionFilter]
        [HttpPost("")]
        public override async Task<ActionResult<OperationResult>> Create(TEqFenceAreaCreateModel createModel, CancellationToken cancellationToken)
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
            var entity = Mapper.Map<TEqFenceArea>(createModel);

            // add to data set, id should be generated
            await DataContext
                .Set<TEqFenceArea>()
                .AddAsync(entity, cancellationToken);

            //保存到tr表中
            await TTrFenceAreaCreate(entity, cancellationToken);

            // save to database
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return operationResult;
        }

        //添加
        protected async Task TTrFenceAreaCreate(TEqFenceArea entity, CancellationToken cancellationToken)
        {
            var identityName = User.GetUserName() ?? "API";
            var fenceArea = new TTrFenceArea
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                FenceId = entity.Id,
                FenceSpaceState = 0,
                BayId = entity.OwnerId,
                IsEnable = entity.IsEnable,
                CreateTime = DateTime.Now,
                CreateUser = identityName,
                UpdateTime = DateTime.Now,
                UpdateUser = identityName,
            };
            await DataContext.Set<TTrFenceArea>().AddAsync(fenceArea, cancellationToken);
        }


        [TokenActionFilter]
        [HttpPut("{id}")]
        public override async Task<ActionResult<OperationResult>> Update(string id, TEqFenceAreaUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);

            // validate model
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

            // primary key
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TEqFenceArea>()
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
            {
                return new OperationResult(false, "数据不存在，更新失败。");
            }
            Mapper.Map(updateModel, entity);

            await TTrFenceAreaUpdate(entity, cancellationToken);
            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return new OperationResult(true, "数据更新成功。");
        }

        protected async Task TTrFenceAreaUpdate(TEqFenceArea entity, CancellationToken cancellationToken)
        {
            var identityName = User.GetUserName() ?? "API";
            var trFenceAreas = DataContext.Set<TTrFenceArea>();
            var area = await trFenceAreas.Where(t => t.FenceId == entity.Id).FirstOrDefaultAsync();
            if (area != null)
            {
                area.BayId = entity.OwnerId;
                area.IsEnable = entity.IsEnable;
                area.UpdateTime = DateTime.Now;
                area.UpdateUser = identityName;
            }
            else
            {
                await TTrFenceAreaCreate(entity, cancellationToken);
            }
        }


    }
}
