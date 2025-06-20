using System;
using System.Text;
using WmsApi.Contracts.Models;

namespace WmsApi.Contracts
{
	public class AreaStatModel
	{
		public string AreaCode { get; set; }

		public int LocationCount1 { get; set; }

		public int CoilCount1 { get; set; }

		public int LocationCount2 { get; set; }

		public int CoilCount2 { get; set; }
		public float Probability { get; set; }

    }
}
