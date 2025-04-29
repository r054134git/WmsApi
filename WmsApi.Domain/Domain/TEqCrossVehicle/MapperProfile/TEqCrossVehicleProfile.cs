using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqCrossVehicle"/> .
    /// </summary>
    public partial class TEqCrossVehicleProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCrossVehicleProfile"/> class.
        /// </summary>
        public TEqCrossVehicleProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TEqCrossVehicle, WmsApi.Contracts.Models.TEqCrossVehicleReadModel>();

            CreateMap<WmsApi.Contracts.Models.TEqCrossVehicleCreateModel, WmsApi.Domain.Entities.TEqCrossVehicle>();

            CreateMap<WmsApi.Domain.Entities.TEqCrossVehicle, WmsApi.Contracts.Models.TEqCrossVehicleUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TEqCrossVehicleUpdateModel, WmsApi.Domain.Entities.TEqCrossVehicle>();

            CreateMap<WmsApi.Contracts.Models.TEqCrossVehicleReadModel, WmsApi.Contracts.Models.TEqCrossVehicleUpdateModel>();

        }

    }
}
