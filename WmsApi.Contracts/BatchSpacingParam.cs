namespace WmsApi.Contracts
{
	public class BatchSpacingParam
	{
		public string BayId { get; set; }

		public string AreaId { get; set; }

		public string StackId { get; set; }

		public int FromColNo { get; set; } //起点行

		public int ToColNo { get; set; } //终点行

		public decimal FromX { get; set; }  //起点X

		public decimal ToX { get; set; } //终点X

		public decimal ToY { get; set; } //终点Y

		public int Count { get; set; } //行数
	}
}
