using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTruckQueueInBayShift"/> .
    /// </summary>
    public partial class TPlTruckQueueInBayShiftProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckQueueInBayShiftProfile"/> class.
        /// </summary>
        public TPlTruckQueueInBayShiftProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlTruckQueueInBayShift, WmsApi.Contracts.Models.TPlTruckQueueInBayShiftReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckQueueInBayShiftCreateModel, WmsApi.Domain.Entities.TPlTruckQueueInBayShift>();

            CreateMap<WmsApi.Domain.Entities.TPlTruckQueueInBayShift, WmsApi.Contracts.Models.TPlTruckQueueInBayShiftUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckQueueInBayShiftUpdateModel, WmsApi.Domain.Entities.TPlTruckQueueInBayShift>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckQueueInBayShiftReadModel, WmsApi.Contracts.Models.TPlTruckQueueInBayShiftUpdateModel>();

        }

    }
}
