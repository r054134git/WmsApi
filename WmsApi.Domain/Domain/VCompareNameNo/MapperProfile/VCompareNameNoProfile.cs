using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="VCompareNameNo"/> .
    /// </summary>
    public partial class VCompareNameNoProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCompareNameNoProfile"/> class.
        /// </summary>
        public VCompareNameNoProfile()
        {
            CreateMap<WmsApi.Domain.Entities.VCompareNameNo, WmsApi.Contracts.Models.VCompareNameNoReadModel>();

            CreateMap<WmsApi.Contracts.Models.VCompareNameNoCreateModel, WmsApi.Domain.Entities.VCompareNameNo>();

            CreateMap<WmsApi.Domain.Entities.VCompareNameNo, WmsApi.Contracts.Models.VCompareNameNoUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.VCompareNameNoUpdateModel, WmsApi.Domain.Entities.VCompareNameNo>();

            CreateMap<WmsApi.Contracts.Models.VCompareNameNoReadModel, WmsApi.Contracts.Models.VCompareNameNoUpdateModel>();

        }

    }
}
