using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcMaterial"/> .
    /// </summary>
    public partial class TRcMaterialProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcMaterialProfile"/> class.
        /// </summary>
        public TRcMaterialProfile()
        {
            CreateMap<TRcMaterial, TRcMaterialReadModel>();

            CreateMap<TRcMaterialCreateModel, TRcMaterial>();

            CreateMap<TRcMaterial, TRcMaterialUpdateModel>();

            CreateMap<TRcMaterialUpdateModel, TRcMaterial>();

            CreateMap<TRcMaterialReadModel, TRcMaterialUpdateModel>();

        }

    }
}
