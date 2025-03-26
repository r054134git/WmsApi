using System.Threading.Tasks;
using Contracts;
using MassTransit;
using Microsoft.Extensions.Logging;
using WmsApi.Contracts;
using WmsApi.Controllers;

namespace ApiTracker
{
	public class TrackerConsumer : IConsumer<ParkingGateCommand>
	{
		private IGateApi _gateApi;
		private IGateTokenApi _gateTokenApi;

        private readonly ILogger<TrackerConsumer> _logger;

		public TrackerConsumer(ILogger<TrackerConsumer> logger, IGateApi gate, IGateTokenApi token)
		{
            _logger = logger;
			_gateApi = gate;
            _gateTokenApi = token;

        }

		public async Task Consume(ConsumeContext<ParkingGateCommand> context)
		{
            var command = context.Message;
            _logger?.LogInformation($"道闸{command.GateCode}, 发出请求{command.OperateType}");
            if (string.IsNullOrWhiteSpace(ParkingLotController._accessToken))
            {
                var tokenResult = await _gateTokenApi.GetToken("system");
                if (tokenResult != null)
                {
                    if (tokenResult.Success)
                    {
                        ParkingLotController._accessToken = tokenResult.Data.AccessToken;
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace(ParkingLotController._accessToken))
            {
                var para = new GateControlParas();
                para.ChannelId = command.ChannelId;
                para.DisplayInfo = command.DisplayInfo;
                para.OperateType = command.OperateType;
                var result = await _gateApi.GateControl(para, ParkingLotController._accessToken);
                if (result != null)
                {
                    _logger?.LogInformation($"道闸{command.GateCode}, 返回结果{result.Success}");
                }
            }
        }
	}
}
