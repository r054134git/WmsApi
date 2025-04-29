using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRlLocation"/> .
    /// </summary>
    public partial class TRlLocationProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlLocationProfile"/> class.
        /// </summary>
        public TRlLocationProfile()
        {
            CreateMap<TRlLocation, TRlLocationReadModel>();

            CreateMap<TRlLocationCreateModel, TRlLocation>();

            CreateMap<TRlLocation, TRlLocationUpdateModel>();

            CreateMap<TRlLocationUpdateModel, TRlLocation>();

            CreateMap<TRlLocationReadModel, TRlLocationUpdateModel>();

        }

    }
}
