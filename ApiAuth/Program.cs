using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using WmsApi;

namespace ApiAuth
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory());
			GlobalBuffer.WorkerId = 1;
			GlobalBuffer.DataCenterId = 2;

			GlobalBuffer.Config =
				 builder
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables()
				.Build();

			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseUrls("http://*:9002");
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