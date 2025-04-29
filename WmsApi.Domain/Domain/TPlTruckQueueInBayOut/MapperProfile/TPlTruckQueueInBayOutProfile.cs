using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTruckQueueInBayOut"/> .
    /// </summary>
    public partial class TPlTruckQueueInBayOutProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckQueueInBayOutProfile"/> class.
        /// </summary>
        public TPlTruckQueueInBayOutProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlTruckQueueInBayOut, WmsApi.Contracts.Models.TPlTruckQueueInBayOutReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckQueueInBayOutCreateModel, WmsApi.Domain.Entities.TPlTruckQueueInBayOut>();

            CreateMap<WmsApi.Domain.Entities.TPlTruckQueueInBayOut, WmsApi.Contracts.Models.TPlTruckQueueInBayOutUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckQueueInBayOutUpdateModel, WmsApi.Domain.Entities.TPlTruckQueueInBayOut>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckQueueInBayOutReadModel, WmsApi.Contracts.Models.TPlTruckQueueInBayOutUpdateModel>();

        }

    }
}
