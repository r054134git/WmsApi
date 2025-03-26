using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcInventory"/> .
    /// </summary>
    public partial class TRcInventoryProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcInventoryProfile"/> class.
        /// </summary>
        public TRcInventoryProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcInventory, WmsApi.Contracts.Models.TRcInventoryReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryCreateModel, WmsApi.Domain.Entities.TRcInventory>();

            CreateMap<WmsApi.Domain.Entities.TRcInventory, WmsApi.Contracts.Models.TRcInventoryUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryUpdateModel, WmsApi.Domain.Entities.TRcInventory>();

            CreateMap<WmsApi.Contracts.Models.TRcInventoryReadModel, WmsApi.Contracts.Models.TRcInventoryUpdateModel>();

        }

    }
}
