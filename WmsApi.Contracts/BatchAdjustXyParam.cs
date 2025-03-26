namespace WmsApi.Contracts
{
	public class BatchAdjustXyParam
	{
		public string BayId { get; set; }

		public string AreaId { get; set; }

		public string StackId { get; set; }

		public int ToStackNo { get; set; } 

		public int FromColNo { get; set; }  //起点行

		public int ToColNo { get; set; }  //终点行

		public decimal OffsetX { get; set; } //X调整

		public decimal OffsetY { get; set; } //Y调整
	}
}
