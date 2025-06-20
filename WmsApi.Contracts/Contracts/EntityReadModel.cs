using System;

// ReSharper disable once CheckNamespace
namespace WmsApi.Contracts.Models
{
	public class EntityReadModel : IHaveIdentifier, ITrackCreated, ITrackUpdated
	{
		public string Id { get; set; }

		public int IsEnable { get; set; }

		public DateTime CreateTime { get; set; } = DateTime.Now;

		public string CreateUser { get; set; }

		public DateTime UpdateTime { get; set; } = DateTime.Now;

		public string UpdateUser { get; set; }

	}
}