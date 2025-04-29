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
        /// �ֳֻ�ɨ��������
        /// </summary>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<ActionResult<OperationResult>> ScanOpenDoor(string fenceDoorCode, string userName, CancellationToken cancellationToken)
        {
            var repo = DataContext.Set<TTrFenceDoor>();
            var fenceDoor = repo.FirstOrDefault(t => t.FenceDoorCode == fenceDoorCode);
            if (fenceDoor == null)
            {
                return new OperationResult(false, $"����ʧ�ܣ���ȫ����Ϣ�����ڣ�");
            }
            fenceDoor.RequestSource = 1;//�ֳֻ�����
            fenceDoor.FenceDoorRequest = 1;
            fenceDoor.RequestTime = DateTime.Now;
            fenceDoor.RequestUser = userName;
            fenceDoor.UpdateTime= DateTime.Now;
            fenceDoor.UpdateUser = "API";
            await DataContext.SaveChangesAsync(cancellationToken);
            return new OperationResult(true, $"����ɹ����ȴ����ţ�");
        }
    }
}
