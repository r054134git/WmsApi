using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRlLocationAssign"/> .
    /// </summary>
    public partial class TRlLocationAssignProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlLocationAssignProfile"/> class.
        /// </summary>
        public TRlLocationAssignProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRlLocationAssign, WmsApi.Contracts.Models.TRlLocationAssignReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRlLocationAssignCreateModel, WmsApi.Domain.Entities.TRlLocationAssign>();

            CreateMap<WmsApi.Domain.Entities.TRlLocationAssign, WmsApi.Contracts.Models.TRlLocationAssignUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRlLocationAssignUpdateModel, WmsApi.Domain.Entities.TRlLocationAssign>();

            CreateMap<WmsApi.Contracts.Models.TRlLocationAssignReadModel, WmsApi.Contracts.Models.TRlLocationAssignUpdateModel>();

        }

    }
}
