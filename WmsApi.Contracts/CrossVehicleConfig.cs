using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts
{
	public class CrossVehicleConfig
	{
		public string BayId { get; set; }

		public string BayName { get; set; }

		public string StackId { get; set; }

		public int LaserDistance { get; set; }
	}
}
