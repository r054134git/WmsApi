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
    public class TTrFenceDoorController : EntityControllerBase<TTrFenceDoor, TTrFenceDoorReadModel, TTrFenceDoorCreateModel, TTrFenceDoorUpdateModel>
    {
        public TTrFenceDoorController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrFenceDoorCreateModel> createValidator, IValidator<TTrFenceDoorUpdateModel> updateValidator)
            : base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
        {
        }

        /// <summary>
        /// 手持机扫码请求开门
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> ScanOpenDoor(string fenceDoorCode, string userName, CancellationToken cancellationToken)
        {
            var repo = DataContext.Set<TTrFenceDoor>();
            var fenceDoor = repo.FirstOrDefault(t => t.FenceDoorCode == fenceDoorCode);
            if (fenceDoor == null)
            {
                return new OperationResult(false, $"开门失败，安全门信息不存在！");
            }
            fenceDoor.RequestSource = 1;//手持机请求
            fenceDoor.FenceDoorRequest = 1;
            fenceDoor.RequestTime = DateTime.Now;
            fenceDoor.RequestUser = userName;
            fenceDoor.UpdateTime= DateTime.Now;
            fenceDoor.UpdateUser = "API";
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, $"请求成功，等待开门！");
        }
    }
}
