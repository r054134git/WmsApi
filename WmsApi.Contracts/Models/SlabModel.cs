using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
	public class SlabModel
	{
		public string slabName { get; set; }

		public int length { get; set; }

		public decimal thick { get; set; }

		public int width { get; set; }

		public int weight { get; set; }

	}
}
