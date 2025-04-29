using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrTrafficLight"/> .
    /// </summary>
    public partial class TTrTrafficLightProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTrafficLightProfile"/> class.
        /// </summary>
        public TTrTrafficLightProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TTrTrafficLight, WmsApi.Contracts.Models.TTrTrafficLightReadModel>();

            CreateMap<WmsApi.Contracts.Models.TTrTrafficLightCreateModel, WmsApi.Domain.Entities.TTrTrafficLight>();

            CreateMap<WmsApi.Domain.Entities.TTrTrafficLight, WmsApi.Contracts.Models.TTrTrafficLightUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TTrTrafficLightUpdateModel, WmsApi.Domain.Entities.TTrTrafficLight>();

            CreateMap<WmsApi.Contracts.Models.TTrTrafficLightReadModel, WmsApi.Contracts.Models.TTrTrafficLightUpdateModel>();

        }

    }
}
