using Cds.Contracts;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;
using WmsApi.Contracts.Models;
using WmsApi;
using Contracts;
using System.Collections.Generic;
using System.Threading;
using WmsApi.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using WmsApi.Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApiPlan
{
    public class ToClientConsumer : IConsumer<MessageToClient>
    {
        private readonly ILogger<ToClientConsumer> _logger;
        private readonly IHubContext<ChatHub> _hubContext;
        private IServiceProvider _serviceProvider { get; set; }
        public ToClientConsumer(ILogger<ToClientConsumer> logger, IHubContext<ChatHub> hubContext, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _hubContext = hubContext;
            _serviceProvider = serviceProvider;
        }

        public async Task Consume(ConsumeContext<MessageToClient> context)
        {
            var message = context.Message;
            _logger?.LogInformation(message.MessageInfo);
            if(message.MessageType== MessageType.CplsCoils.ToString())
            {
                await SendClientCplsCoils(message);
            }
            if (message.MessageType == MessageType.VirtualCoils.ToString())
            {
                await SendClientVirtualCoils(message);
            }
            if (message.MessageType == MessageType.CommErrorToG2.ToString())
            {
                await SendClientCommErrorToG2(message);
            }
            if (message.MessageType == MessageType.EquipRoad16.ToString())
            {
                await SendClientEquipRoad16(message);
            }
        }

        //包装线
        private async Task SendClientCplsCoils(MessageToClient message)
        {
            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Code = message.Spare1,
                No=message.Spare2,
                Title = await GetChainPage(message.Spare1) + "报警提示！",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = false,
               Type= MessageType.CplsCoils.ToString(),
                Description = message.MessageInfo
            };
            await _hubContext.Clients.All.SendAsync("ToClientPush", noticeIconItem);
        }
        private async Task<string> GetChainPage(string key)
        {
            var dataContext = _serviceProvider.GetService<WmspcrContext>();
            var predicate = ExpressionBuilder.True<TScDictionary>();
            predicate = predicate.And(t => t.Key == key);
            var plLoadList = await dataContext.Set<TScDictionary>().AsNoTracking().Where(predicate).FirstOrDefaultAsync();
            return plLoadList?.Value;
        }

        //虚拟卷
        private async Task SendClientVirtualCoils(MessageToClient message)
        {
            var dataContext = _serviceProvider.GetService<WmspcrContext>();
            var trLocationMaterials = dataContext.Set<TTrLocationMaterial>();
            var whBays = dataContext.Set<TWhBay>();
            string[] noBayCode = { "18", "19", "20" };
            var bayquery = whBays.Where(t => t.IsEnable == 1 && noBayCode.Contains(t.Code) == false);
            var baylist = await bayquery.ToListAsync();
            var listmodel = new List<MaterialVirtualModel>();
            foreach (var bay in baylist)
            {
                var query = trLocationMaterials.Where(t => t.BayCode == bay.Code && t.Type == 2 && t.OwnerBussinessName != "P4" && t.IsVirtual == 0);              
                //虚拟卷
                var virtual_count = query.Where(t => t.MaterialNo.StartsWith("Q")).Count();
                if (virtual_count > 0)
                {
                    await SendClientVirtualCoilsNotice(bay.Code, virtual_count);
                }
                var model = new MaterialVirtualModel()
                {
                    Id = bay.Id,
                    Name = bay.Name,
                    Code = bay.Code,
                    VirtualCount = virtual_count
                };
                listmodel.Add(model);
            }
            await SendClientVirtualCoilsNoticeData(listmodel);
        }
        private async Task SendClientVirtualCoilsNotice(string baycode, int count)
        {
            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Code = baycode,
                Title = $"{baycode}库虚拟卷报警",
                Description = $"虚拟卷数量：{count}",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = false,
                Type = MessageType.VirtualCoils.ToString(),
            };
            await _hubContext.Clients.All.SendAsync("GetMaterialVirtual", noticeIconItem);
        }
        private async Task SendClientVirtualCoilsNoticeData(List<MaterialVirtualModel> listmodel)
        {
            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Title = $"全库虚拟卷数据实时传输",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = false,
                Type = MessageType.VirtualCoils.ToString(),
                Data = listmodel
            };
            await _hubContext.Clients.All.SendAsync("GetMaterialVirtualData", noticeIconItem);
        }

        //二代天车通讯异常报警
        private async Task SendClientCommErrorToG2(MessageToClient message)
        {
            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Title = "行车通讯异常报警",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = false,
                Type = MessageType.CommErrorToG2.ToString(),
                Description = message.MessageInfo
            };
            await _hubContext.Clients.All.SendAsync("ToClientPushCommErrorToG2", noticeIconItem);
        }

        //南北通道平扫设备
        private async Task SendClientEquipRoad16(MessageToClient message)
        {
            NoticeIconItem noticeIconItem = new()
            {
                Id = IdWorkerGenerator.Instance.NextId().ToString(),
                Avatar = "",
                Title = "南北通道平扫设备",
                Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Read = false,
                Type = MessageType.EquipRoad16.ToString(),
                Description = message.MessageInfo
            };
            await _hubContext.Clients.All.SendAsync("ToClientPushEquipRoad16", noticeIconItem);
        }

    }
}
