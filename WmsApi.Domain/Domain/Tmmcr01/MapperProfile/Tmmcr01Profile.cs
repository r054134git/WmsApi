using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="Tmmcr01"/> .
    /// </summary>
    public partial class Tmmcr01Profile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmmcr01Profile"/> class.
        /// </summary>
        public Tmmcr01Profile()
        {
            CreateMap<WmsApi.Domain.Entities.Tmmcr01, WmsApi.Contracts.Models.Tmmcr01ReadModel>();

            CreateMap<WmsApi.Contracts.Models.Tmmcr01CreateModel, WmsApi.Domain.Entities.Tmmcr01>();

            CreateMap<WmsApi.Domain.Entities.Tmmcr01, WmsApi.Contracts.Models.Tmmcr01UpdateModel>();

            CreateMap<WmsApi.Contracts.Models.Tmmcr01UpdateModel, WmsApi.Domain.Entities.Tmmcr01>();

            CreateMap<WmsApi.Contracts.Models.Tmmcr01ReadModel, WmsApi.Contracts.Models.Tmmcr01UpdateModel>();

        }

    }
}
