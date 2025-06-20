using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcClassStock"/> .
    /// </summary>
    public partial class TRcClassStockProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcClassStockProfile"/> class.
        /// </summary>
        public TRcClassStockProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcClassStock, WmsApi.Contracts.Models.TRcClassStockReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcClassStockCreateModel, WmsApi.Domain.Entities.TRcClassStock>();

            CreateMap<WmsApi.Domain.Entities.TRcClassStock, WmsApi.Contracts.Models.TRcClassStockUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcClassStockUpdateModel, WmsApi.Domain.Entities.TRcClassStock>();

            CreateMap<WmsApi.Contracts.Models.TRcClassStockReadModel, WmsApi.Contracts.Models.TRcClassStockUpdateModel>();

        }

    }
}
