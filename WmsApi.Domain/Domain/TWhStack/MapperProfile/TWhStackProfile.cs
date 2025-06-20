using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
	/// <summary>
	/// Mapper class for entity <see cref="TWhStack"/> .
	/// </summary>
	public partial class TWhStackProfile
		: Profile
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TWhStackProfile"/> class.
		/// </summary>
		public TWhStackProfile()
		{
			CreateMap<TWhStack, TWhStackReadModel>()
				.ForMember(dest => dest.LocationCount, options => options.MapFrom(
							src => src.OwnerTWhLocations != null ? src.OwnerTWhLocations.Count : 0));

			CreateMap<TWhStackCreateModel, TWhStack>();

			CreateMap<TWhStack, TWhStackUpdateModel>();

			CreateMap<TWhStackUpdateModel, TWhStack>();

			CreateMap<TWhStackReadModel, TWhStackUpdateModel>();

		}

	}
}
