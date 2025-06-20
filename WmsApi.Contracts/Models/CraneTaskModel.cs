using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
	public class CraneTaskModel
	{
		public string TaskNo { get; set; }

		public string MaterialNo { get; set; }

		public string CraneName { get; set; }

		public string LoadLocationName { get; set; }

		public string UnloadLocationName { get; set; }

		public string StartTime { get; set; }

		public string PlanTypeName { get; set; }

	}
}
