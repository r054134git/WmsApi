using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TUmPermission"/> .
    /// </summary>
    public partial class TUmPermissionProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmPermissionProfile"/> class.
        /// </summary>
        public TUmPermissionProfile()
        {
            CreateMap<TUmPermission, TUmPermissionReadModel>();

            CreateMap<TUmPermissionCreateModel, TUmPermission>();

            CreateMap<TUmPermission, TUmPermissionUpdateModel>();

            CreateMap<TUmPermissionUpdateModel, TUmPermission>();

            CreateMap<TUmPermissionReadModel, TUmPermissionUpdateModel>();

        }

    }
}
