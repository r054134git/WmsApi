using System;
using System.Collections.Generic;
using System.Text;
using WmsApi.Contracts.Models;

namespace WmsApi.Contracts
{
	public class AddScanDetailResult
	{
		public TTrLocationMaterialReadModel TrModel { get; set; }
		
		public ItemResult<TRcInventoryReadModel> RcModel { get; set; }

		public AddScanDetailResult(TTrLocationMaterialReadModel trModel, ItemResult<TRcInventoryReadModel> rcModel)
		{
			TrModel = trModel;
			RcModel = rcModel;
		}
	}
}
