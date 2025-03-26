using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhCranePassage"/> .
    /// </summary>
    public partial class TWhCranePassageProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhCranePassageProfile"/> class.
        /// </summary>
        public TWhCranePassageProfile()
        {
            CreateMap<TWhCranePassage, TWhCranePassageReadModel>();

            CreateMap<TWhCranePassageCreateModel, TWhCranePassage>();

            CreateMap<TWhCranePassage, TWhCranePassageUpdateModel>();

            CreateMap<TWhCranePassageUpdateModel, TWhCranePassage>();

            CreateMap<TWhCranePassageReadModel, TWhCranePassageUpdateModel>();

        }

    }
}
