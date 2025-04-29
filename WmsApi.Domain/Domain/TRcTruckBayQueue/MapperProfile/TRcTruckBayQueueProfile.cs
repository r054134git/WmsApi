using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcTruckBayQueue"/> .
    /// </summary>
    public partial class TRcTruckBayQueueProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruckBayQueueProfile"/> class.
        /// </summary>
        public TRcTruckBayQueueProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcTruckBayQueue, WmsApi.Contracts.Models.TRcTruckBayQueueReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckBayQueueCreateModel, WmsApi.Domain.Entities.TRcTruckBayQueue>();

            CreateMap<WmsApi.Domain.Entities.TRcTruckBayQueue, WmsApi.Contracts.Models.TRcTruckBayQueueUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckBayQueueUpdateModel, WmsApi.Domain.Entities.TRcTruckBayQueue>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckBayQueueReadModel, WmsApi.Contracts.Models.TRcTruckBayQueueUpdateModel>();

        }

    }
}
