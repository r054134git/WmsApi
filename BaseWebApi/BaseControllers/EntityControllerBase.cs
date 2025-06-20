using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WmsApi.Contracts.Models;
using WmsApi.Domain;

namespace WmsApi.Controllers
{
	[ApiController]
	[Produces("application/json")]
	[Route("api/[controller]/[action]")]
	public abstract class EntityControllerBase<TEntity, TReadModel, TCreateModel, TUpdateModel> : QueryControllerBase<TEntity, TReadModel, TCreateModel, TUpdateModel>
		where TEntity : class, IHaveIdentifier
		where TReadModel : EntityReadModel
		where TCreateModel : EntityCreateModel
		where TUpdateModel : EntityUpdateModel

	{
		protected EntityControllerBase(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TCreateModel> createValidator, IValidator<TUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{
			CreateValidator = createValidator;
			UpdateValidator = updateValidator;
		}

		public IValidator<TCreateModel> CreateValidator { get; }

		public IValidator<TUpdateModel> UpdateValidator { get; }

		[TokenActionFilter]
		[HttpPost("")]
		public virtual async Task<ActionResult<OperationResult>> Create(TCreateModel createModel, CancellationToken cancellationToken)
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
			var entity = Mapper.Map<TEntity>(createModel);

			// add to data set, id should be generated
			await DataContext
				.Set<TEntity>()
				.AddAsync(entity, cancellationToken);

			// save to database
			await DataContext
				.SaveChangesAsync(cancellationToken);

			return operationResult;
		}

		protected virtual async Task<OperationResult> CanCreate(TCreateModel createModel, CancellationToken cancellationToken)
		{
			return new OperationResult(true, "数据添加成功");
		}

		protected void SetCreateModelBasic(EntityCreateModel createModel)
		{
            var identityName = User.GetUserName() ?? "API";

            createModel.Id = IdWorkerGenerator.Instance.NextId().ToString();
			createModel.IsEnable = 1;
			createModel.CreateTime = DateTime.Now;
			createModel.CreateUser = identityName;
			createModel.UpdateTime = DateTime.Now;
			createModel.UpdateUser = identityName;
		}

		[TokenActionFilter]
		[HttpPut("{id}")]
		public virtual async Task<ActionResult<OperationResult>> Update(string id, TUpdateModel updateModel, CancellationToken cancellationToken)
		{
			SetUpdateModelBasic(updateModel);

			// validate model
			await UpdateValidator.ValidateAndThrowAsync(updateModel, cancellationToken: cancellationToken);

			// primary key
			var keyValue = new object[] { id };

			// find entity to update by id, not model id
			var entity = await DataContext
				.Set<TEntity>()
				.FindAsync(keyValue, cancellationToken);

			if (entity == null)
			{
				return new OperationResult(false, "数据不存在，更新失败。");
			}

			// copy updates from model to entity
			Mapper.Map(updateModel, entity);

			// save updates
			await DataContext
				.SaveChangesAsync(cancellationToken);

			return new OperationResult(true, "数据更新成功。");
		}

		protected void SetUpdateModelBasic(EntityUpdateModel updateModel)
		{
            var identityName = User.GetUserName() ?? "API";
            updateModel.UpdateTime = DateTime.Now;
			updateModel.UpdateUser = identityName;
		}

		[TokenActionFilter]
		[HttpDelete]
		public virtual async Task<ActionResult<OperationResult>> Delete([FromQuery] string[] ids, CancellationToken cancellationToken)
		{
			var dbSet = DataContext
				.Set<TEntity>();

			var idsString = string.Join(",", ids);

			try
			{
				foreach (var id in ids)
				{
					// find entity to delete by id
					var entity = await dbSet
						.FindAsync(new[] { id }, cancellationToken);

					if (entity == null)
					{
						return new OperationResult(false, $"id {idsString} 的数据不存在！");
					}

					// delete entry
					dbSet.Remove(entity);
				}
				// save
				await DataContext
					.SaveChangesAsync(cancellationToken);
			}
			catch (Exception ex)
			{
				return new OperationResult(false, ex.Message);
			}

			return new OperationResult(true, $"id {idsString} 的数据删除成功！");
		}
	}
}