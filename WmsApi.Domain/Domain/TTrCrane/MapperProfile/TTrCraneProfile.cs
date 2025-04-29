using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrCrane"/> .
    /// </summary>
    public partial class TTrCraneProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCraneProfile"/> class.
        /// </summary>
        public TTrCraneProfile()
        {
            CreateMap<TTrCrane, TTrCraneReadModel>();

            CreateMap<TTrCraneCreateModel, TTrCrane>();

            CreateMap<TTrCrane, TTrCraneUpdateModel>();

            CreateMap<TTrCraneUpdateModel, TTrCrane>();

            CreateMap<TTrCraneReadModel, TTrCraneUpdateModel>();

        }

    }
}
