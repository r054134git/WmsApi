using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
	/// <summary>
	/// Mapper class for entity <see cref="TTrLocationMaterial"/> .
	/// </summary>
	public partial class CustomProfile : Profile
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TTrLocationMaterialProfile"/> class.
		/// </summary>
		public CustomProfile()
		{
			CreateMap<TPlMaterial, TTrLocationMaterial>()
				.ForMember(dest => dest.Id, options => options.Ignore())
				.ForMember(dest => dest.MaterialId, options => options.MapFrom(src => src.Id))
				.ForMember(dest => dest.MaterialNo, options => options.MapFrom(src => src.No));

			CreateMap<TWhLocationCreateModel, TTrLocationMaterialCreateModel>()
				.ForMember(dest => dest.Id, options => options.Ignore())
				.ForMember(dest => dest.LocationId, options => options.MapFrom(src => src.Id))
				.ForMember(dest => dest.LocationName, options => options.MapFrom(src => src.Name));

			CreateMap<TWhLocationUpdateModel, TTrLocationMaterial>()
				.ForMember(dest => dest.Id, options => options.Ignore())
				.ForMember(dest => dest.LocationId, options => options.MapFrom(src => src.Id))
				.ForMember(dest => dest.LocationName, options => options.MapFrom(src => src.Name));
		}

	}
}
