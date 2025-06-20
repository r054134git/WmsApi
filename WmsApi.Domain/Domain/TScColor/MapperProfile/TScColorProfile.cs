using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TScColor"/> .
    /// </summary>
    public partial class TScColorProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TScColorProfile"/> class.
        /// </summary>
        public TScColorProfile()
        {
            CreateMap<TScColor, TScColorReadModel>();

            CreateMap<TScColorCreateModel, TScColor>();

            CreateMap<TScColor, TScColorUpdateModel>();

            CreateMap<TScColorUpdateModel, TScColor>();

            CreateMap<TScColorReadModel, TScColorUpdateModel>();

        }

    }
}
