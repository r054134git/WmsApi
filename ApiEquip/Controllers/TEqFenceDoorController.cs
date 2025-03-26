using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("equip/[controller]/[action]")]
    public class TEqFenceDoorController : EntityControllerBase<TEqFenceDoor, TEqFenceDoorReadModel, TEqFenceDoorCreateModel, TEqFenceDoorUpdateModel>
    {
        public TEqFenceDoorController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TEqFenceDoorCreateModel> createValidator, IValidator<TEqFenceDoorUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        [TokenActionFilter]
        [HttpPost("")]
        public override async Task<ActionResult<OperationResult>> Create(TEqFenceDoorCreateModel createModel, CancellationToken cancellationToken)
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
            var entity = Mapper.Map<TEqFenceDoor>(createModel);

            // add to data set, id should be generated
            await DataContext
                .Set<TEqFenceDoor>()
                .AddAsync(entity, cancellationToken);

            //保存到tr表中
            await TTrFenceDoorCreate(entity, cancellationToken);

            // save to database
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return operationResult;
        }

        //添加
        protected async Task TTrFenceDoorCreate(TEqFenceDoor entity, CancellationToken cancellationToken)
        {
            var identityName = User.GetUserName() ?? "API";
            var fenceDoor = new TTrFenceDoor
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                FenceId = entity.OwnerId,
                FenceDoorId = entity.Id,
                FenceDoorCode = entity.Code,
                FenceDoorState = 0,
                FenceDoorRequest = 0,
                RequestSource = 0,
                IsEnable = entity.IsEnable,
                CreateTime = DateTime.Now,
                CreateUser = identityName,
                UpdateTime = DateTime.Now,
                UpdateUser = identityName,
            };
            await DataContext.Set<TTrFenceDoor>().AddAsync(fenceDoor, cancellationToken);
        }


        [TokenActionFilter]
        [HttpPut("{id}")]
        public override async Task<ActionResult<OperationResult>> Update(string id, TEqFenceDoorUpdateModel updateModel, CancellationToken cancellationToken)
        {
            SetUpdateModelBasic(updateModel);

            // validate model
            await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

            // primary key
            var keyValue = new object[] { id };

            // find entity to update by id, not model id
            var entity = await DataContext
                .Set<TEqFenceDoor>()
                .FindAsync(keyValue, cancellationToken);

            if (entity == null)
            {
                return new OperationResult(false, "数据不存在，更新失败。");
            }
            Mapper.Map(updateModel, entity);

            await TTrFenceDoorUpdate(entity, cancellationToken);
            // save updates
            await DataContext
                .SaveChangesAsync(cancellationToken);

            return new OperationResult(true, "数据更新成功。");
        }

        protected async Task TTrFenceDoorUpdate(TEqFenceDoor entity, CancellationToken cancellationToken)
        {
            var identityName = User.GetUserName() ?? "API";
            var trFenceDoor = DataContext.Set<TTrFenceDoor>();
            var door = await trFenceDoor.Where(t => t.FenceDoorId == entity.Id).FirstOrDefaultAsync();
            if (door != null)
            {
                door.FenceId = entity.OwnerId;
                door.FenceDoorCode = entity.Code;
                door.IsEnable = entity.IsEnable;
                door.CreateTime = DateTime.Now;
                door.CreateUser = identityName;
                door.UpdateTime = DateTime.Now;
                door.UpdateUser = identityName;
            }
            else
            {
                await TTrFenceDoorCreate(entity, cancellationToken);
            }
        }


    }
}
