using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcLocationMaterial"/> .
    /// </summary>
    public partial class TRcLocationMaterialProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLocationMaterialProfile"/> class.
        /// </summary>
        public TRcLocationMaterialProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcLocationMaterial, WmsApi.Contracts.Models.TRcLocationMaterialReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcLocationMaterialCreateModel, WmsApi.Domain.Entities.TRcLocationMaterial>();

            CreateMap<WmsApi.Domain.Entities.TRcLocationMaterial, WmsApi.Contracts.Models.TRcLocationMaterialUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcLocationMaterialUpdateModel, WmsApi.Domain.Entities.TRcLocationMaterial>();

            CreateMap<WmsApi.Contracts.Models.TRcLocationMaterialReadModel, WmsApi.Contracts.Models.TRcLocationMaterialUpdateModel>();

        }

    }
}
