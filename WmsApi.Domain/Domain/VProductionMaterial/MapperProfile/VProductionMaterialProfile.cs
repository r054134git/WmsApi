using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="VProductionMaterial"/> .
    /// </summary>
    public partial class VProductionMaterialProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VProductionMaterialProfile"/> class.
        /// </summary>
        public VProductionMaterialProfile()
        {
            CreateMap<WmsApi.Domain.Entities.VProductionMaterial, WmsApi.Contracts.Models.VProductionMaterialReadModel>();

            CreateMap<WmsApi.Contracts.Models.VProductionMaterialCreateModel, WmsApi.Domain.Entities.VProductionMaterial>();

            CreateMap<WmsApi.Domain.Entities.VProductionMaterial, WmsApi.Contracts.Models.VProductionMaterialUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.VProductionMaterialUpdateModel, WmsApi.Domain.Entities.VProductionMaterial>();

            CreateMap<WmsApi.Contracts.Models.VProductionMaterialReadModel, WmsApi.Contracts.Models.VProductionMaterialUpdateModel>();

        }

    }
}
