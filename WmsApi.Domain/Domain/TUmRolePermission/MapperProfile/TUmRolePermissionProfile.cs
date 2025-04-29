using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TUmRolePermission"/> .
    /// </summary>
    public partial class TUmRolePermissionProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmRolePermissionProfile"/> class.
        /// </summary>
        public TUmRolePermissionProfile()
        {
            CreateMap<TUmRolePermission, TUmRolePermissionReadModel>();

            CreateMap<TUmRolePermissionCreateModel, TUmRolePermission>();

            CreateMap<TUmRolePermission, TUmRolePermissionUpdateModel>();

            CreateMap<TUmRolePermissionUpdateModel, TUmRolePermission>();

            CreateMap<TUmRolePermissionReadModel, TUmRolePermissionUpdateModel>();

        }

    }
}
