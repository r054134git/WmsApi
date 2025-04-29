using System;

// ReSharper disable once CheckNamespace
namespace WmsApi.Contracts.Models
{
	public class EntityUpdateModel : IHaveIdentifier, ITrackUpdated
	{
		public string Id { get; set; }

		public int IsEnable { get; set; }

		public DateTime UpdateTime { get; set; }

		public string UpdateUser { get; set; }
	}
}