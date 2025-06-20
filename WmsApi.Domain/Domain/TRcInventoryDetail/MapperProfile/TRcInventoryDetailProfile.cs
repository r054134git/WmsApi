using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcInventoryDetail"/> .
    /// </summary>
    public partial class TRcInventoryDetailProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventoryDetailProfile"/> class.
        /// </summary>
        public TRcInventoryDetailProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcInventoryDetail, WmsApi.Contracts.Models.TRcInventoryDetailReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryDetailCreateModel, WmsApi.Domain.Entities.TRcInventoryDetail>();

            CreateMap<WmsApi.Domain.Entities.TRcInventoryDetail, WmsApi.Contracts.Models.TRcInventoryDetailUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryDetailUpdateModel, WmsApi.Domain.Entities.TRcInventoryDetail>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryDetailReadModel, WmsApi.Contracts.Models.TRcInventoryDetailUpdateModel>();

        }

    }
}
