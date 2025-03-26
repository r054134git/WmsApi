using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="VCraneUnloadlocation"/> .
    /// </summary>
    public partial class VCraneUnloadlocationProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCraneUnloadlocationProfile"/> class.
        /// </summary>
        public VCraneUnloadlocationProfile()
        {
            CreateMap<WmsApi.Domain.Entities.VCraneUnloadlocation, WmsApi.Contracts.Models.VCraneUnloadlocationReadModel>();

            CreateMap<WmsApi.Contracts.Models.VCraneUnloadlocationCreateModel, WmsApi.Domain.Entities.VCraneUnloadlocation>();

            CreateMap<WmsApi.Domain.Entities.VCraneUnloadlocation, WmsApi.Contracts.Models.VCraneUnloadlocationUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.VCraneUnloadlocationUpdateModel, WmsApi.Domain.Entities.VCraneUnloadlocation>();

            CreateMap<WmsApi.Contracts.Models.VCraneUnloadlocationReadModel, WmsApi.Contracts.Models.VCraneUnloadlocationUpdateModel>();

        }

    }
}
