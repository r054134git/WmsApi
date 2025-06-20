using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhDestHouse"/> .
    /// </summary>
    public partial class TWhDestHouseProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhDestHouseProfile"/> class.
        /// </summary>
        public TWhDestHouseProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TWhDestHouse, WmsApi.Contracts.Models.TWhDestHouseReadModel>();

            CreateMap<WmsApi.Contracts.Models.TWhDestHouseCreateModel, WmsApi.Domain.Entities.TWhDestHouse>();

            CreateMap<WmsApi.Domain.Entities.TWhDestHouse, WmsApi.Contracts.Models.TWhDestHouseUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TWhDestHouseUpdateModel, WmsApi.Domain.Entities.TWhDestHouse>();

            CreateMap<WmsApi.Contracts.Models.TWhDestHouseReadModel, WmsApi.Contracts.Models.TWhDestHouseUpdateModel>();

        }

    }
}
