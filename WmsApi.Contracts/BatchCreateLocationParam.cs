namespace WmsApi.Contracts
{
	public class BatchCreateLocationParam
	{
		public string BayId { get; set; }

		public string AreaId { get; set; }

		public int FromStackNo { get; set; }

		public int ToStackNo { get; set; }

		public int FromColNo { get; set; }

		public int ToColNo { get; set; }

		public int FloorNo { get; set; }

		public decimal FromY { get; set; }

		public decimal ToY { get; set; }

		public decimal FromX { get; set; }

		public decimal ToX { get; set; }

		public int Angle { get; set; }

		public int Orientation { get; set; }

		public decimal BaseWidth { get; set; }

		public decimal BaseLength { get; set; }

		public decimal BaseHeight { get; set; }

		public int StorageType { get; set; }

		public int LoadType { get; set; }
	}
}
