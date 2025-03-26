using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhBay"/> .
    /// </summary>
    public partial class TWhBayProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhBayProfile"/> class.
        /// </summary>
        public TWhBayProfile()
        {
            CreateMap<TWhBay, TWhBayReadModel>();

            CreateMap<TWhBayCreateModel, TWhBay>();

            CreateMap<TWhBay, TWhBayUpdateModel>();

            CreateMap<TWhBayUpdateModel, TWhBay>();

            CreateMap<TWhBayReadModel, TWhBayUpdateModel>();

        }

    }
}
