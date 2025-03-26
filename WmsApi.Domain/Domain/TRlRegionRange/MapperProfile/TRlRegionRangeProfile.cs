using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRlRegionRange"/> .
    /// </summary>
    public partial class TRlRegionRangeProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlRegionRangeProfile"/> class.
        /// </summary>
        public TRlRegionRangeProfile()
        {
            CreateMap<TRlRegionRange, TRlRegionRangeReadModel>();

            CreateMap<TRlRegionRangeCreateModel, TRlRegionRange>();

            CreateMap<TRlRegionRange, TRlRegionRangeUpdateModel>();

            CreateMap<TRlRegionRangeUpdateModel, TRlRegionRange>();

            CreateMap<TRlRegionRangeReadModel, TRlRegionRangeUpdateModel>();

        }

    }
}
