using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlBay"/> .
    /// </summary>
    public partial class TPlBayProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBayProfile"/> class.
        /// </summary>
        public TPlBayProfile()
        {
            CreateMap<TPlBay, TPlBayReadModel>();

            CreateMap<TPlBayCreateModel, TPlBay>();

            CreateMap<TPlBay, TPlBayUpdateModel>();

            CreateMap<TPlBayUpdateModel, TPlBay>();

            CreateMap<TPlBayReadModel, TPlBayUpdateModel>();

        }

    }
}
