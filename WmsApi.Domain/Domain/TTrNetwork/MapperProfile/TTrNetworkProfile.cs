using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrNetwork"/> .
    /// </summary>
    public partial class TTrNetworkProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrNetworkProfile"/> class.
        /// </summary>
        public TTrNetworkProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TTrNetwork, WmsApi.Contracts.Models.TTrNetworkReadModel>();

            CreateMap<WmsApi.Contracts.Models.TTrNetworkCreateModel, WmsApi.Domain.Entities.TTrNetwork>();

            CreateMap<WmsApi.Domain.Entities.TTrNetwork, WmsApi.Contracts.Models.TTrNetworkUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TTrNetworkUpdateModel, WmsApi.Domain.Entities.TTrNetwork>();

            CreateMap<WmsApi.Contracts.Models.TTrNetworkReadModel, WmsApi.Contracts.Models.TTrNetworkUpdateModel>();

        }

    }
}
