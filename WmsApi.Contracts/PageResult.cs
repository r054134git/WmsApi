using System.Collections.Generic;

namespace WmsApi
{
	public class PageResult<T>
	{
		public IReadOnlyList<T> Data { get; set; }

		public bool Success { get; set; }

		public string Message { get; set; }

		public int Total { get; set; }
	}
}
