using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcInventoryTemp"/> .
    /// </summary>
    public partial class TRcInventoryTempProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventoryTempProfile"/> class.
        /// </summary>
        public TRcInventoryTempProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcInventoryTemp, WmsApi.Contracts.Models.TRcInventoryTempReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryTempCreateModel, WmsApi.Domain.Entities.TRcInventoryTemp>();

            CreateMap<WmsApi.Domain.Entities.TRcInventoryTemp, WmsApi.Contracts.Models.TRcInventoryTempUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryTempUpdateModel, WmsApi.Domain.Entities.TRcInventoryTemp>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryTempReadModel, WmsApi.Contracts.Models.TRcInventoryTempUpdateModel>();

        }

    }
}
