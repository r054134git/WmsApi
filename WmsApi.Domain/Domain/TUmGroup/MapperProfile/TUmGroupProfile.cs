using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TUmGroup"/> .
    /// </summary>
    public partial class TUmGroupProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmGroupProfile"/> class.
        /// </summary>
        public TUmGroupProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TUmGroup, WmsApi.Contracts.Models.TUmGroupReadModel>();

            CreateMap<WmsApi.Contracts.Models.TUmGroupCreateModel, WmsApi.Domain.Entities.TUmGroup>();

            CreateMap<WmsApi.Domain.Entities.TUmGroup, WmsApi.Contracts.Models.TUmGroupUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TUmGroupUpdateModel, WmsApi.Domain.Entities.TUmGroup>();

            CreateMap<WmsApi.Contracts.Models.TUmGroupReadModel, WmsApi.Contracts.Models.TUmGroupUpdateModel>();

        }

    }
}
