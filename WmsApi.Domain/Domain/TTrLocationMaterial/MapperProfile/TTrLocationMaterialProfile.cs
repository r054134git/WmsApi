using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrLocationMaterial"/> .
    /// </summary>
    public partial class TTrLocationMaterialProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrLocationMaterialProfile"/> class.
        /// </summary>
        public TTrLocationMaterialProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TTrLocationMaterial, WmsApi.Contracts.Models.TTrLocationMaterialReadModel>();

            CreateMap<WmsApi.Contracts.Models.TTrLocationMaterialCreateModel, WmsApi.Domain.Entities.TTrLocationMaterial>();

            CreateMap<WmsApi.Domain.Entities.TTrLocationMaterial, WmsApi.Contracts.Models.TTrLocationMaterialUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TTrLocationMaterialUpdateModel, WmsApi.Domain.Entities.TTrLocationMaterial>();

            CreateMap<WmsApi.Contracts.Models.TTrLocationMaterialReadModel, WmsApi.Contracts.Models.TTrLocationMaterialUpdateModel>();

        }

    }
}
