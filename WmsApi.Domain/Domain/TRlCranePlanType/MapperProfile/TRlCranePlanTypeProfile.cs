using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRlCranePlanType"/> .
    /// </summary>
    public partial class TRlCranePlanTypeProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlCranePlanTypeProfile"/> class.
        /// </summary>
        public TRlCranePlanTypeProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRlCranePlanType, WmsApi.Contracts.Models.TRlCranePlanTypeReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRlCranePlanTypeCreateModel, WmsApi.Domain.Entities.TRlCranePlanType>();

            CreateMap<WmsApi.Domain.Entities.TRlCranePlanType, WmsApi.Contracts.Models.TRlCranePlanTypeUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRlCranePlanTypeUpdateModel, WmsApi.Domain.Entities.TRlCranePlanType>();

            CreateMap<WmsApi.Contracts.Models.TRlCranePlanTypeReadModel, WmsApi.Contracts.Models.TRlCranePlanTypeUpdateModel>();

        }

    }
}
