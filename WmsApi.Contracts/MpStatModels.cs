using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts
{
	public  class MpStatModels
	{
		public List<MpStatModelSingleBay> Only { get; set; } = new List<MpStatModelSingleBay>();

		public List<MpStatModelAllBay> Shared { get; set; } = new List<MpStatModelAllBay>();

		public string Percent { get; set; }
	}
}
