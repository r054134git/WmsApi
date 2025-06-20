using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlMaterial"/> .
    /// </summary>
    public partial class TPlMaterialProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlMaterialProfile"/> class.
        /// </summary>
        public TPlMaterialProfile()
        {
            CreateMap<TPlMaterial, TPlMaterialReadModel>();

            CreateMap<TPlMaterialCreateModel, TPlMaterial>();

            CreateMap<TPlMaterial, TPlMaterialUpdateModel>();

            CreateMap<TPlMaterialUpdateModel, TPlMaterial>();

            CreateMap<TPlMaterialReadModel, TPlMaterialUpdateModel>();

        }

    }
}
