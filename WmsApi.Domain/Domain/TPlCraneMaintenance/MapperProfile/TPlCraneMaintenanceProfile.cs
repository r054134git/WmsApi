using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlCraneMaintenance"/> .
    /// </summary>
    public partial class TPlCraneMaintenanceProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCraneMaintenanceProfile"/> class.
        /// </summary>
        public TPlCraneMaintenanceProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlCraneMaintenance, WmsApi.Contracts.Models.TPlCraneMaintenanceReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlCraneMaintenanceCreateModel, WmsApi.Domain.Entities.TPlCraneMaintenance>();

            CreateMap<WmsApi.Domain.Entities.TPlCraneMaintenance, WmsApi.Contracts.Models.TPlCraneMaintenanceUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlCraneMaintenanceUpdateModel, WmsApi.Domain.Entities.TPlCraneMaintenance>();

            CreateMap<WmsApi.Contracts.Models.TPlCraneMaintenanceReadModel, WmsApi.Contracts.Models.TPlCraneMaintenanceUpdateModel>();

        }

    }
}
