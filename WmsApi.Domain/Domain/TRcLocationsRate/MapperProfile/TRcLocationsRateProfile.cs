using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcLocationsRate"/> .
    /// </summary>
    public partial class TRcLocationsRateProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLocationsRateProfile"/> class.
        /// </summary>
        public TRcLocationsRateProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcLocationsRate, WmsApi.Contracts.Models.TRcLocationsRateReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcLocationsRateCreateModel, WmsApi.Domain.Entities.TRcLocationsRate>();

            CreateMap<WmsApi.Domain.Entities.TRcLocationsRate, WmsApi.Contracts.Models.TRcLocationsRateUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcLocationsRateUpdateModel, WmsApi.Domain.Entities.TRcLocationsRate>();

            CreateMap<WmsApi.Contracts.Models.TRcLocationsRateReadModel, WmsApi.Contracts.Models.TRcLocationsRateUpdateModel>();

        }

    }
}
