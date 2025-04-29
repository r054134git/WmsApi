using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts
{
	public class MpStatModelAllBay
	{
		public string OrderNo { get; set; }

		public string PlanDate { get; set; }

		public int PlanCount { get; set; }

		public decimal PlanWeight { get; set; }

		public string BayName1 { get; set; }
		public int Count1 { get; set; }

		public decimal Weight1 { get; set; }

		public bool IsMp1 { get; set; }

		public string BayName2 { get; set; }
		public int Count2 { get; set; }

		public bool IsMp2 { get; set; }

		public decimal Weight2 { get; set; }

		public string BayName3 { get; set; }
		public int Count3 { get; set; }

		public bool IsMp3 { get; set; }

		public decimal Weight3 { get; set; }

		public string BayName4 { get; set; }
		public int Count4 { get; set; }

		public decimal Weight4 { get; set; }

		public bool IsMp4 { get; set; }
	}

	public class MpStatModelSingleBay
	{
		public string OrderNo { get; set; }

		public int PlanCount { get; set; }

		public decimal PlanWeight { get; set; }

		public int Count { get; set; }

		public decimal Weight { get; set; }

		public string PlanDate { get; set; }

		public string BayName { get; set; }

	}
}
