using System;

namespace WmsApi
{
	public interface ITrackUpdated
	{
		int IsEnable { get; set; }
		DateTime UpdateTime { get; set; }
		string UpdateUser { get; set; }
	}
}