using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrMessageReceived"/> .
    /// </summary>
    public partial class TTrMessageReceivedProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrMessageReceivedProfile"/> class.
        /// </summary>
        public TTrMessageReceivedProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TTrMessageReceived, WmsApi.Contracts.Models.TTrMessageReceivedReadModel>();

            CreateMap<WmsApi.Contracts.Models.TTrMessageReceivedCreateModel, WmsApi.Domain.Entities.TTrMessageReceived>();

            CreateMap<WmsApi.Domain.Entities.TTrMessageReceived, WmsApi.Contracts.Models.TTrMessageReceivedUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TTrMessageReceivedUpdateModel, WmsApi.Domain.Entities.TTrMessageReceived>();

            CreateMap<WmsApi.Contracts.Models.TTrMessageReceivedReadModel, WmsApi.Contracts.Models.TTrMessageReceivedUpdateModel>();

        }

    }
}
