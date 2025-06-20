using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcMaterialEventMigrate"/> .
    /// </summary>
    public partial class TRcMaterialEventMigrateProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcMaterialEventMigrateProfile"/> class.
        /// </summary>
        public TRcMaterialEventMigrateProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcMaterialEventMigrate, WmsApi.Contracts.Models.TRcMaterialEventMigrateReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcMaterialEventMigrateCreateModel, WmsApi.Domain.Entities.TRcMaterialEventMigrate>();

            CreateMap<WmsApi.Domain.Entities.TRcMaterialEventMigrate, WmsApi.Contracts.Models.TRcMaterialEventMigrateUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcMaterialEventMigrateUpdateModel, WmsApi.Domain.Entities.TRcMaterialEventMigrate>();

            CreateMap<WmsApi.Contracts.Models.TRcMaterialEventMigrateReadModel, WmsApi.Contracts.Models.TRcMaterialEventMigrateUpdateModel>();

        }

    }
}
