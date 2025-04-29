using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcMaterialEvent"/> .
    /// </summary>
    public partial class TRcMaterialEventProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcMaterialEventProfile"/> class.
        /// </summary>
        public TRcMaterialEventProfile()
        {
            CreateMap<TRcMaterialEvent, TRcMaterialEventReadModel>();

            CreateMap<TRcMaterialEventCreateModel, TRcMaterialEvent>();

            CreateMap<TRcMaterialEvent, TRcMaterialEventUpdateModel>();

            CreateMap<TRcMaterialEventUpdateModel, TRcMaterialEvent>();

            CreateMap<TRcMaterialEventReadModel, TRcMaterialEventUpdateModel>();

        }

    }
}
