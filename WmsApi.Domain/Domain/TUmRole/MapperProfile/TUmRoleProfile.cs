using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TUmRole"/> .
    /// </summary>
    public partial class TUmRoleProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmRoleProfile"/> class.
        /// </summary>
        public TUmRoleProfile()
        {
            CreateMap<TUmRole, TUmRoleReadModel>();

            CreateMap<TUmRoleCreateModel, TUmRole>();

            CreateMap<TUmRole, TUmRoleUpdateModel>();

            CreateMap<TUmRoleUpdateModel, TUmRole>();

            CreateMap<TUmRoleReadModel, TUmRoleUpdateModel>();

        }

    }
}
