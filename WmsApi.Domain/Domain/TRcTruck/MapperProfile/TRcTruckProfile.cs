using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcTruck"/> .
    /// </summary>
    public partial class TRcTruckProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTruckProfile"/> class.
        /// </summary>
        public TRcTruckProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcTruck, WmsApi.Contracts.Models.TRcTruckReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckCreateModel, WmsApi.Domain.Entities.TRcTruck>();

            CreateMap<WmsApi.Domain.Entities.TRcTruck, WmsApi.Contracts.Models.TRcTruckUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckUpdateModel, WmsApi.Domain.Entities.TRcTruck>();

            CreateMap<WmsApi.Contracts.Models.TRcTruckReadModel, WmsApi.Contracts.Models.TRcTruckUpdateModel>();

        }

    }
}
