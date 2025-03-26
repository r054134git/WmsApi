using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrTruckQueue"/> .
    /// </summary>
    public partial class TTrTruckQueueProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTruckQueueProfile"/> class.
        /// </summary>
        public TTrTruckQueueProfile()
        {
            CreateMap<TTrTruckQueue, TTrTruckQueueReadModel>();

            CreateMap<TTrTruckQueueCreateModel, TTrTruckQueue>();

            CreateMap<TTrTruckQueue, TTrTruckQueueUpdateModel>();

            CreateMap<TTrTruckQueueUpdateModel, TTrTruckQueue>();

            CreateMap<TTrTruckQueueReadModel, TTrTruckQueueUpdateModel>();

        }

    }
}
