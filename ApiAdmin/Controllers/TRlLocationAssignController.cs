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

namespace WmsApi.Controllers
{
    [ApiController]
    [Route("admin/[controller]/[action]")]
    public class TRlLocationAssignController : EntityControllerBase<TRlLocationAssign, TRlLocationAssignReadModel, TRlLocationAssignCreateModel, TRlLocationAssignUpdateModel>
    {
        public TRlLocationAssignController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TRlLocationAssignCreateModel> createValidator, IValidator<TRlLocationAssignUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {

        }
        /// <summary>
        /// 更改规则开关
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> UpdateAssign(string id, CancellationToken cancellationToken)
        {
            var repo = DataContext.Set<TRlLocationAssign>();
            var state = repo.Where(t => t.Id == id).FirstOrDefault();
            if (state != null)
            {
                if (state.IsEnable == 1)
                {
                    state.IsEnable = 0;
                }
                else
                {
                    state.IsEnable = 1;
                }
                var count = await DataContext.SaveChangesAsync();
                return new OperationResult(false, "更改成功");
            }
            return new OperationResult(false, "数据不存在，更改失败");
        }
    }
}
