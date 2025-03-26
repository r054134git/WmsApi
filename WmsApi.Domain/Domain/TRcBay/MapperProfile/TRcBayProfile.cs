using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcBay"/> .
    /// </summary>
    public partial class TRcBayProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcBayProfile"/> class.
        /// </summary>
        public TRcBayProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcBay, WmsApi.Contracts.Models.TRcBayReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcBayCreateModel, WmsApi.Domain.Entities.TRcBay>();

            CreateMap<WmsApi.Domain.Entities.TRcBay, WmsApi.Contracts.Models.TRcBayUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcBayUpdateModel, WmsApi.Domain.Entities.TRcBay>();

            CreateMap<WmsApi.Contracts.Models.TRcBayReadModel, WmsApi.Contracts.Models.TRcBayUpdateModel>();

        }

    }
}
