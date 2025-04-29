using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("admin/[controller]/[action]")]
    public class TUmUserController : EntityControllerBase<TUmUser, TUmUserReadModel, TUmUserCreateModel, TUmUserUpdateModel>
    {
        public TUmUserController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TUmUserCreateModel> createValidator, IValidator<TUmUserUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        protected override async Task<OperationResult> CanCreate(TUmUserCreateModel createModel, CancellationToken cancellationToken)
        {
            var isExist = await DataContext.Set<TUmUser>().AnyAsync(t => t.Account == createModel.Account);
            if (isExist)
            {
                return new OperationResult(false, $"{createModel.Account}的用户账号已经存在，创建失败！");
            }
            return new OperationResult(true, $"{createModel.Account}的用户账号创建成功！");
        }

        [TokenActionFilter]
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TUmUserReadModel>>> GetPageQuery
            ([FromQuery] PageParam pageParam, string account, string name, string department, [FromQuery] string[] teamName, CancellationToken cancellationToken)
        {
            try
            {
                var identityName = User.GetUserName();

                var predicate = ExpressionBuilder.True<TUmUser>();
                if (account.IsValidValue())
                {
                    predicate = predicate.And(t => t.Account == account);
                }
                if (name.IsValidValue())
                {
                    predicate = predicate.And(t => t.Name == name);
                }
                if (department.IsValidValue())
                {
                    predicate = predicate.And(t => t.Department == department);
                }
                if (teamName != null)
                {
                    if (teamName.Length > 1)
                    {
                        predicate = predicate.And(t => teamName.Contains(t.TeamTScDictionary.Value));
                    }
                    if (teamName.Length == 1 && teamName.First().IsValidValue())
                    {
                        var tname = teamName.First();
                        predicate = predicate.And(t => t.TeamTScDictionary.Value == tname);
                    }
                }

                var query = GetQueryOrderByIdDesc(predicate);
                    //.OrderByDescending(t => t.Id).Include(t => t.TeamTScDictionary).Include(T => T.RoleTUmRole);

                var listResult = await QueryPageModel(query, pageParam, cancellationToken);
                foreach (var item in listResult.Data)
                {
                    if (item.BayIdNameList.IsValidValue())
                    {

                        item.BayIdNames = JsonConvert.DeserializeObject<List<BayIdName>>(item.BayIdNameList);
                    }
                }

                return Ok(listResult);
            }
            catch (Exception ex)
            {
                return NoContent();
            }

        }
        [HttpGet("")]
        public async Task<ActionResult<PageResult<TUmUserReadModel>>> GetUserInfo(TUmUserReadModel user, CancellationToken cancellationToken)
        {
            var predicate = ExpressionBuilder.True<TUmUser>();
            predicate = predicate.And(t => t.Name == user.Name);
            var query = GetQueryOrderByIdDesc(predicate);
            var listResult = await ReadModel(query, cancellationToken);
            return Ok(listResult);
        }
    }
}
