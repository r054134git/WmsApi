using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlOffline"/> .
    /// </summary>
    public partial class TPlOfflineProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlOfflineProfile"/> class.
        /// </summary>
        public TPlOfflineProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlOffline, WmsApi.Contracts.Models.TPlOfflineReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlOfflineCreateModel, WmsApi.Domain.Entities.TPlOffline>();

            CreateMap<WmsApi.Domain.Entities.TPlOffline, WmsApi.Contracts.Models.TPlOfflineUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlOfflineUpdateModel, WmsApi.Domain.Entities.TPlOffline>();

            CreateMap<WmsApi.Contracts.Models.TPlOfflineReadModel, WmsApi.Contracts.Models.TPlOfflineUpdateModel>();

        }

    }
}
