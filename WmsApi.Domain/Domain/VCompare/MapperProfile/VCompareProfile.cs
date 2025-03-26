using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="VCompare"/> .
    /// </summary>
    public partial class VCompareProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCompareProfile"/> class.
        /// </summary>
        public VCompareProfile()
        {
            CreateMap<WmsApi.Domain.Entities.VCompare, WmsApi.Contracts.Models.VCompareReadModel>();

            CreateMap<WmsApi.Contracts.Models.VCompareCreateModel, WmsApi.Domain.Entities.VCompare>();

            CreateMap<WmsApi.Domain.Entities.VCompare, WmsApi.Contracts.Models.VCompareUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.VCompareUpdateModel, WmsApi.Domain.Entities.VCompare>();

            CreateMap<WmsApi.Contracts.Models.VCompareReadModel, WmsApi.Contracts.Models.VCompareUpdateModel>();

        }

    }
}
