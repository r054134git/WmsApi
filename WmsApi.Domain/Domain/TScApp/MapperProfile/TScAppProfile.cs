using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TScApp"/> .
    /// </summary>
    public partial class TScAppProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScAppProfile"/> class.
        /// </summary>
        public TScAppProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TScApp, WmsApi.Contracts.Models.TScAppReadModel>();

            CreateMap<WmsApi.Contracts.Models.TScAppCreateModel, WmsApi.Domain.Entities.TScApp>();

            CreateMap<WmsApi.Domain.Entities.TScApp, WmsApi.Contracts.Models.TScAppUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TScAppUpdateModel, WmsApi.Domain.Entities.TScApp>();

            CreateMap<WmsApi.Contracts.Models.TScAppReadModel, WmsApi.Contracts.Models.TScAppUpdateModel>();

        }

    }
}
