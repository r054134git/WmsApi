
namespace WmsApi
{
	public static class IdWorkerGenerator
	{
		public static readonly IdWorker Instance = new IdWorker(GlobalBuffer.WorkerId, GlobalBuffer.DataCenterId);
	}
}
