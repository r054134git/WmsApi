using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TUmMenu"/> .
    /// </summary>
    public partial class TUmMenuProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmMenuProfile"/> class.
        /// </summary>
        public TUmMenuProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TUmMenu, WmsApi.Contracts.Models.TUmMenuReadModel>();

            CreateMap<WmsApi.Contracts.Models.TUmMenuCreateModel, WmsApi.Domain.Entities.TUmMenu>();

            CreateMap<WmsApi.Domain.Entities.TUmMenu, WmsApi.Contracts.Models.TUmMenuUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TUmMenuUpdateModel, WmsApi.Domain.Entities.TUmMenu>();

            CreateMap<WmsApi.Contracts.Models.TUmMenuReadModel, WmsApi.Contracts.Models.TUmMenuUpdateModel>();

        }

    }
}
