using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;

namespace WmsApi
{
    /// <summary>
    /// 消息缓存服务的代理
    /// </summary>
    public class MbsProxy
    {
		private readonly IBusControl _bus;

		public MbsProxy(IBusControl bus)
		{
			_bus = bus;
		}

		public async Task Publish<T>(T message) where T : class
		{
			await _bus.Publish(message);
		}

		public async Task StartAsync()
		{
			await _bus.StartAsync();
		}

		public async Task StopAsync()
		{
			await _bus.StopAsync();
		}
	}
}
