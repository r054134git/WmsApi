using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhLocation"/> .
    /// </summary>
    public partial class TWhLocationProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhLocationProfile"/> class.
        /// </summary>
        public TWhLocationProfile()
        {
            CreateMap<TWhLocation, TWhLocationReadModel>();

            CreateMap<TWhLocationCreateModel, TWhLocation>();

            CreateMap<TWhLocation, TWhLocationUpdateModel>();

            CreateMap<TWhLocationUpdateModel, TWhLocation>();

            CreateMap<TWhLocationReadModel, TWhLocationUpdateModel>();

        }

    }
}
