using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhArea"/> .
    /// </summary>
    public partial class TWhAreaProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhAreaProfile"/> class.
        /// </summary>
        public TWhAreaProfile()
        {
            CreateMap<TWhArea, TWhAreaReadModel>();

            CreateMap<TWhAreaCreateModel, TWhArea>();

            CreateMap<TWhArea, TWhAreaUpdateModel>();

            CreateMap<TWhAreaUpdateModel, TWhArea>();

            CreateMap<TWhAreaReadModel, TWhAreaUpdateModel>();

        }

    }
}
