using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTruckLoadListDetail"/> .
    /// </summary>
    public partial class TPlTruckLoadListDetailProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckLoadListDetailProfile"/> class.
        /// </summary>
        public TPlTruckLoadListDetailProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlTruckLoadListDetail, WmsApi.Contracts.Models.TPlTruckLoadListDetailReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckLoadListDetailCreateModel, WmsApi.Domain.Entities.TPlTruckLoadListDetail>();

            CreateMap<WmsApi.Domain.Entities.TPlTruckLoadListDetail, WmsApi.Contracts.Models.TPlTruckLoadListDetailUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckLoadListDetailUpdateModel, WmsApi.Domain.Entities.TPlTruckLoadListDetail>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckLoadListDetailReadModel, WmsApi.Contracts.Models.TPlTruckLoadListDetailUpdateModel>();

        }

    }
}
