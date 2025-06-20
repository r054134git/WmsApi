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

namespace ApiTracker
{
    public class ToHoldConsumer : IConsumer<MessageToHold>
    {
        private readonly ILogger<ToHoldConsumer> _logger;
        private readonly IHubContext<ChatHub> _hubContext;
        private IServiceProvider _serviceProvider { get; set; }
        public ToHoldConsumer(ILogger<ToHoldConsumer> logger, IHubContext<ChatHub> hubContext, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _hubContext = hubContext;
            _serviceProvider = serviceProvider;
        }

        public async Task Consume(ConsumeContext<MessageToHold> context)
        {
            var message = context.Message;
            _logger?.LogInformation("ToHoldConsumer:"+ message.MessageInfo);
            await _hubContext.Clients.All.SendAsync("ToHoldMessage", message.MessageInfo);
        }

        private async Task<string> GetChainPage(string key)
        {
            var dataContext = _serviceProvider.GetService<WmspcrContext>();
            var predicate = ExpressionBuilder.True<TScDictionary>();
            predicate = predicate.And(t => t.Key == key);
            var plLoadList = await dataContext.Set<TScDictionary>().AsNoTracking().Where(predicate).FirstOrDefaultAsync();
            return plLoadList?.Value;
        }
    }
}