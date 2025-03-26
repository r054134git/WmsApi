using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlBackReturn"/> .
    /// </summary>
    public partial class TPlBackReturnProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBackReturnProfile"/> class.
        /// </summary>
        public TPlBackReturnProfile()
        {
            CreateMap<TPlBackReturn, TPlBackReturnReadModel>();

            CreateMap<TPlBackReturnCreateModel, TPlBackReturn>();

            CreateMap<TPlBackReturn, TPlBackReturnUpdateModel>();

            CreateMap<TPlBackReturnUpdateModel, TPlBackReturn>();

            CreateMap<TPlBackReturnReadModel, TPlBackReturnUpdateModel>();

        }

    }
}
