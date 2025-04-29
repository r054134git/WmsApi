using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrUser"/> .
    /// </summary>
    public partial class TTrUserProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrUserProfile"/> class.
        /// </summary>
        public TTrUserProfile()
        {
            CreateMap<TTrUser, TTrUserReadModel>();

            CreateMap<TTrUserCreateModel, TTrUser>();

            CreateMap<TTrUser, TTrUserUpdateModel>();

            CreateMap<TTrUserUpdateModel, TTrUser>();

            CreateMap<TTrUserReadModel, TTrUserUpdateModel>();

        }

    }
}
