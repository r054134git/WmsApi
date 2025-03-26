using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrMessageSend"/> .
    /// </summary>
    public partial class TTrMessageSendProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrMessageSendProfile"/> class.
        /// </summary>
        public TTrMessageSendProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TTrMessageSend, WmsApi.Contracts.Models.TTrMessageSendReadModel>();

            CreateMap<WmsApi.Contracts.Models.TTrMessageSendCreateModel, WmsApi.Domain.Entities.TTrMessageSend>();

            CreateMap<WmsApi.Domain.Entities.TTrMessageSend, WmsApi.Contracts.Models.TTrMessageSendUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TTrMessageSendUpdateModel, WmsApi.Domain.Entities.TTrMessageSend>();

            CreateMap<WmsApi.Contracts.Models.TTrMessageSendReadModel, WmsApi.Contracts.Models.TTrMessageSendUpdateModel>();

        }

    }
}
