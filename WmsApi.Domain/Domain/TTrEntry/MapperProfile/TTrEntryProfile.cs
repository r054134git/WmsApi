using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrEntry"/> .
    /// </summary>
    public partial class TTrEntryProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrEntryProfile"/> class.
        /// </summary>
        public TTrEntryProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TTrEntry, WmsApi.Contracts.Models.TTrEntryReadModel>();

            CreateMap<WmsApi.Contracts.Models.TTrEntryCreateModel, WmsApi.Domain.Entities.TTrEntry>();

            CreateMap<WmsApi.Domain.Entities.TTrEntry, WmsApi.Contracts.Models.TTrEntryUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TTrEntryUpdateModel, WmsApi.Domain.Entities.TTrEntry>();

            CreateMap<WmsApi.Contracts.Models.TTrEntryReadModel, WmsApi.Contracts.Models.TTrEntryUpdateModel>();

        }

    }
}
