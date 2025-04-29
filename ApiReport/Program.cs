using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiReport
{
	public class Program
	{
		public static void Main(string[] args)
		{
			WmsApi.GlobalBuffer.WorkerId = 1;
			WmsApi.GlobalBuffer.DataCenterId = 5;
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseUrls("http://*:9005/");
					webBuilder.UseStartup<Startup>();
				});
	}
}
