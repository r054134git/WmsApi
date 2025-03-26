using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
	/// <summary>
	/// Mapper class for entity <see cref="TUmUser"/> .
	/// </summary>
	public partial class TUmUserProfile
		: Profile
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TUmUserProfile"/> class.
		/// </summary>
		public TUmUserProfile()
		{
			CreateMap<TUmUser, TUmUserReadModel>()
				.ForMember(dest => dest.TeamName, options => options.MapFrom(
							src => src.TeamTScDictionary.Value))
			.ForMember(dest => dest.RoleName, options => options.MapFrom(
							src => src.RoleTUmRole.Name));

			CreateMap<TUmUserCreateModel, TUmUser>();

			CreateMap<TUmUser, TUmUserUpdateModel>();

			CreateMap<TUmUserUpdateModel, TUmUser>();

			CreateMap<TUmUserReadModel, TUmUserUpdateModel>();

		}

	}
}
