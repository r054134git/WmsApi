using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="VCraneLocation"/> .
    /// </summary>
    public partial class VCraneLocationProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCraneLocationProfile"/> class.
        /// </summary>
        public VCraneLocationProfile()
        {
            CreateMap<WmsApi.Domain.Entities.VCraneLocation, WmsApi.Contracts.Models.VCraneLocationReadModel>();

            CreateMap<WmsApi.Contracts.Models.VCraneLocationCreateModel, WmsApi.Domain.Entities.VCraneLocation>();

            CreateMap<WmsApi.Domain.Entities.VCraneLocation, WmsApi.Contracts.Models.VCraneLocationUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.VCraneLocationUpdateModel, WmsApi.Domain.Entities.VCraneLocation>();

            CreateMap<WmsApi.Contracts.Models.VCraneLocationReadModel, WmsApi.Contracts.Models.VCraneLocationUpdateModel>();

        }

    }
}
