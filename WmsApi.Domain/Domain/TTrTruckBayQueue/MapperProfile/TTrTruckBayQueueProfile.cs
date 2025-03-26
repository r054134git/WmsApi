using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrTruckBayQueue"/> .
    /// </summary>
    public partial class TTrTruckBayQueueProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTruckBayQueueProfile"/> class.
        /// </summary>
        public TTrTruckBayQueueProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TTrTruckBayQueue, WmsApi.Contracts.Models.TTrTruckBayQueueReadModel>();

            CreateMap<WmsApi.Contracts.Models.TTrTruckBayQueueCreateModel, WmsApi.Domain.Entities.TTrTruckBayQueue>();

            CreateMap<WmsApi.Domain.Entities.TTrTruckBayQueue, WmsApi.Contracts.Models.TTrTruckBayQueueUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TTrTruckBayQueueUpdateModel, WmsApi.Domain.Entities.TTrTruckBayQueue>();

            CreateMap<WmsApi.Contracts.Models.TTrTruckBayQueueReadModel, WmsApi.Contracts.Models.TTrTruckBayQueueUpdateModel>();

        }

    }
}
