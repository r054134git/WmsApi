using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts
{
	public enum PackTypes
	{
		None,

		/// <summary>
		/// 提前进手包区
		/// </summary>
		HandPacking,

		/// <summary>
		/// 手包完成
		/// </summary>
		HandPacked,

		/// <summary>
		/// 重上包装线
		/// </summary>
		Repack,

		/// <summary>
		/// 包装异常，不能在包装线出口自动吊取
		/// </summary>
		PackFault,

		/// <summary>
		/// 未判定合格，不能入成品库
		/// </summary>
		NoPassToY8,

		/// <summary>
		/// 判定合格，入成品库
		/// </summary>
		PassedToC3
	}
}
