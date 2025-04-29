using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts
{
	public class GateControlResult
	{
		public bool Success { get; set; }

		public int Code { get; set; }

		public string ErrMsg { get; set; }

		public bool Data { get; set; }

		public int IsEncrypt { get; set; }

		public GateControlResult() { }
	}
}
