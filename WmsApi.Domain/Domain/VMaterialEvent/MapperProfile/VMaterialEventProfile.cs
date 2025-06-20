using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="VMaterialEvent"/> .
    /// </summary>
    public partial class VMaterialEventProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMaterialEventProfile"/> class.
        /// </summary>
        public VMaterialEventProfile()
        {
            CreateMap<WmsApi.Domain.Entities.VMaterialEvent, WmsApi.Contracts.Models.VMaterialEventReadModel>();

            CreateMap<WmsApi.Contracts.Models.VMaterialEventCreateModel, WmsApi.Domain.Entities.VMaterialEvent>();

            CreateMap<WmsApi.Domain.Entities.VMaterialEvent, WmsApi.Contracts.Models.VMaterialEventUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.VMaterialEventUpdateModel, WmsApi.Domain.Entities.VMaterialEvent>();

            CreateMap<WmsApi.Contracts.Models.VMaterialEventReadModel, WmsApi.Contracts.Models.VMaterialEventUpdateModel>();

        }

    }
}
