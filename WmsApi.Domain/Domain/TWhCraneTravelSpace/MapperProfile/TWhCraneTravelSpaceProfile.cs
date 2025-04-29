using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhCraneTravelSpace"/> .
    /// </summary>
    public partial class TWhCraneTravelSpaceProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhCraneTravelSpaceProfile"/> class.
        /// </summary>
        public TWhCraneTravelSpaceProfile()
        {
            CreateMap<TWhCraneTravelSpace, TWhCraneTravelSpaceReadModel>();

            CreateMap<TWhCraneTravelSpaceCreateModel, TWhCraneTravelSpace>();

            CreateMap<TWhCraneTravelSpace, TWhCraneTravelSpaceUpdateModel>();

            CreateMap<TWhCraneTravelSpaceUpdateModel, TWhCraneTravelSpace>();

            CreateMap<TWhCraneTravelSpaceReadModel, TWhCraneTravelSpaceUpdateModel>();

        }

    }
}
