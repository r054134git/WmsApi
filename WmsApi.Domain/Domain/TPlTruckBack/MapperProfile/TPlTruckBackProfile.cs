using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTruckBack"/> .
    /// </summary>
    public partial class TPlTruckBackProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckBackProfile"/> class.
        /// </summary>
        public TPlTruckBackProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlTruckBack, WmsApi.Contracts.Models.TPlTruckBackReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckBackCreateModel, WmsApi.Domain.Entities.TPlTruckBack>();

            CreateMap<WmsApi.Domain.Entities.TPlTruckBack, WmsApi.Contracts.Models.TPlTruckBackUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckBackUpdateModel, WmsApi.Domain.Entities.TPlTruckBack>();

            CreateMap<WmsApi.Contracts.Models.TPlTruckBackReadModel, WmsApi.Contracts.Models.TPlTruckBackUpdateModel>();

        }

    }
}
