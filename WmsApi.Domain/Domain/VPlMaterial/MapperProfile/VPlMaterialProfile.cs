using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="VPlMaterial"/> .
    /// </summary>
    public partial class VPlMaterialProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VPlMaterialProfile"/> class.
        /// </summary>
        public VPlMaterialProfile()
        {
            CreateMap<WmsApi.Domain.Entities.VPlMaterial, WmsApi.Contracts.Models.VPlMaterialReadModel>();

            CreateMap<WmsApi.Contracts.Models.VPlMaterialCreateModel, WmsApi.Domain.Entities.VPlMaterial>();

            CreateMap<WmsApi.Domain.Entities.VPlMaterial, WmsApi.Contracts.Models.VPlMaterialUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.VPlMaterialUpdateModel, WmsApi.Domain.Entities.VPlMaterial>();

            CreateMap<WmsApi.Contracts.Models.VPlMaterialReadModel, WmsApi.Contracts.Models.VPlMaterialUpdateModel>();

        }

    }
}
