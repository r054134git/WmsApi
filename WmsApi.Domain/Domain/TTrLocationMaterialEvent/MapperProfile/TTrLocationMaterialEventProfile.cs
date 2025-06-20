using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrLocationMaterialEvent"/> .
    /// </summary>
    public partial class TTrLocationMaterialEventProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrLocationMaterialEventProfile"/> class.
        /// </summary>
        public TTrLocationMaterialEventProfile()
        {
            CreateMap<TTrLocationMaterialEvent, TTrLocationMaterialEventReadModel>();

            CreateMap<TTrLocationMaterialEventCreateModel, TTrLocationMaterialEvent>();

            CreateMap<TTrLocationMaterialEvent, TTrLocationMaterialEventUpdateModel>();

            CreateMap<TTrLocationMaterialEventUpdateModel, TTrLocationMaterialEvent>();

            CreateMap<TTrLocationMaterialEventReadModel, TTrLocationMaterialEventUpdateModel>();

        }

    }
}
