using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TScTransferTerminal"/> .
    /// </summary>
    public partial class TScTransferTerminalProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScTransferTerminalProfile"/> class.
        /// </summary>
        public TScTransferTerminalProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TScTransferTerminal, WmsApi.Contracts.Models.TScTransferTerminalReadModel>();

            CreateMap<WmsApi.Contracts.Models.TScTransferTerminalCreateModel, WmsApi.Domain.Entities.TScTransferTerminal>();

            CreateMap<WmsApi.Domain.Entities.TScTransferTerminal, WmsApi.Contracts.Models.TScTransferTerminalUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TScTransferTerminalUpdateModel, WmsApi.Domain.Entities.TScTransferTerminal>();

            CreateMap<WmsApi.Contracts.Models.TScTransferTerminalReadModel, WmsApi.Contracts.Models.TScTransferTerminalUpdateModel>();

        }

    }
}
