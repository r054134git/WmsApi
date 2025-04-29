using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
	public class CraneActualReturn
	{
		public string ID { get; set; }

		public float Position1 { get; set; }

		public float Position2 { get; set; }

		public float Position3 { get; set; }

		public string Num { get; set; }

		public string CraneState { get; set; }
	}
}
