using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Threading;
using WmsApi.Contracts.Models;
using WmsApi.Domain;
using WmsApi.Domain.Entities;
using WmsApi.Utils;
using System.Linq;

namespace WmsApi.Controllers
{
	[ApiController]
	[Route("tracker/[controller]/[action]")]
	public class TTrMessageSendController : EntityControllerBase<TTrMessageSend, TTrMessageSendReadModel, TTrMessageSendCreateModel, TTrMessageSendUpdateModel>
	{
		public TTrMessageSendController(IServiceProvider serviceProvider, WmspcrContext dataContext, IMapper mapper, IValidator<TTrMessageSendCreateModel> createValidator, IValidator<TTrMessageSendUpdateModel> updateValidator)
			: base(serviceProvider, dataContext, mapper, createValidator, updateValidator)
		{

		}
        /// <summary>
        /// ��������/����=========���·���
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        [TokenActionFilter]
        public async Task<ActionResult<OperationResult>> UpdateIsabled([FromQuery] string[] ids, int isEnable, CancellationToken cancellationToken)
        {
            var trMessages = DataContext.Set<TTrMessageSend>();
            var identityName = User.GetUserName();
            var isE = isEnable == 1 ? "����" : "����";
            foreach (var item in ids)
            {
                var model = trMessages.Where(t => t.Id == item).FirstOrDefault();
                model.IsEnable = isEnable;
                model.UpdateTime = DateTime.Now;
                model.UpdateUser = identityName;
            }
            var count = await DataContext.SaveChangesAsync(cancellationToken);
            return count > 0 ? new OperationResult(true, $"�������·��ͳɹ���") : new OperationResult(false, $"�������·���ʧ�ܡ�");
        }
    }
}
