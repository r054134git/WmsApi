using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TUmColSet"/> .
    /// </summary>
    public partial class TUmColSetProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmColSetProfile"/> class.
        /// </summary>
        public TUmColSetProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TUmColSet, WmsApi.Contracts.Models.TUmColSetReadModel>();

            CreateMap<WmsApi.Contracts.Models.TUmColSetCreateModel, WmsApi.Domain.Entities.TUmColSet>();

            CreateMap<WmsApi.Domain.Entities.TUmColSet, WmsApi.Contracts.Models.TUmColSetUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TUmColSetUpdateModel, WmsApi.Domain.Entities.TUmColSet>();

            CreateMap<WmsApi.Contracts.Models.TUmColSetReadModel, WmsApi.Contracts.Models.TUmColSetUpdateModel>();

        }

    }
}
