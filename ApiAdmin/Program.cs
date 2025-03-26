using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace ApiAdmin
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WmsApi.GlobalBuffer.WorkerId = 1;
			WmsApi.GlobalBuffer.DataCenterId = 1;

			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseUrls("http://*:9001/");
					webBuilder.UseStartup<Startup>();
				})
				.ConfigureLogging(logging =>
				{
					logging.ClearProviders();
					logging.SetMinimumLevel(LogLevel.Trace);
				})
				.UseNLog();
	}
}
