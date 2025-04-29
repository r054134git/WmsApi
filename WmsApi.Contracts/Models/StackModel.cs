using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
	public class StackModel
	{
		public string StackName { get; set; }

		public int RowNo { get; set; }

		public int ColNo { get; set; }

		public int SlabNum { get; set; }

		public List<SlabModel> Slabs { get; set; }
	}
}
