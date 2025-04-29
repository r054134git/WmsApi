using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TScClient"/> .
    /// </summary>
    public partial class TScClientProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TScClientProfile"/> class.
        /// </summary>
        public TScClientProfile()
        {
            CreateMap<TScClient, TScClientReadModel>();

            CreateMap<TScClientCreateModel, TScClient>();

            CreateMap<TScClient, TScClientUpdateModel>();

            CreateMap<TScClientUpdateModel, TScClient>();

            CreateMap<TScClientReadModel, TScClientUpdateModel>();

        }

    }
}
