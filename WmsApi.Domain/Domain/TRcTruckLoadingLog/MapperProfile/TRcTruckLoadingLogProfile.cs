using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcTruckLoadingLog"/> .
    /// </summary>
    public partial class TRcTruckLoadingLogProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruckLoadingLogProfile"/> class.
        /// </summary>
        public TRcTruckLoadingLogProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcTruckLoadingLog, WmsApi.Contracts.Models.TRcTruckLoadingLogReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckLoadingLogCreateModel, WmsApi.Domain.Entities.TRcTruckLoadingLog>();

            CreateMap<WmsApi.Domain.Entities.TRcTruckLoadingLog, WmsApi.Contracts.Models.TRcTruckLoadingLogUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckLoadingLogUpdateModel, WmsApi.Domain.Entities.TRcTruckLoadingLog>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckLoadingLogReadModel, WmsApi.Contracts.Models.TRcTruckLoadingLogUpdateModel>();

        }

    }
}
