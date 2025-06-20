using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlFinishLine"/> .
    /// </summary>
    public partial class TPlFinishLineProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlFinishLineProfile"/> class.
        /// </summary>
        public TPlFinishLineProfile()
        {
            CreateMap<TPlFinishLine, TPlFinishLineReadModel>();

            CreateMap<TPlFinishLineCreateModel, TPlFinishLine>();

            CreateMap<TPlFinishLine, TPlFinishLineUpdateModel>();

            CreateMap<TPlFinishLineUpdateModel, TPlFinishLine>();

            CreateMap<TPlFinishLineReadModel, TPlFinishLineUpdateModel>();

        }

    }
}
