using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts
{
	public class MpPercentModel
	{
		public string Bay { get; set; }

		public double Percent { get; set; }

		public double PlanWeight { get; set; }

		public int PlanCount { get; set; }
	}
}
