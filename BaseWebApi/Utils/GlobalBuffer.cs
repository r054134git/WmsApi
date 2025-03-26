using Microsoft.Extensions.Configuration;

namespace WmsApi
{
	public static class GlobalBuffer
	{
		public static IConfigurationRoot Config { get; set; }

		public static int WorkerId = 1;

		public static int DataCenterId = 1;
	}
}
