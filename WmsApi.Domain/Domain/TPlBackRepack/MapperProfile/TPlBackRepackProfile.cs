using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlBackRepack"/> .
    /// </summary>
    public partial class TPlBackRepackProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBackRepackProfile"/> class.
        /// </summary>
        public TPlBackRepackProfile()
        {
            CreateMap<TPlBackRepack, TPlBackRepackReadModel>();

            CreateMap<TPlBackRepackCreateModel, TPlBackRepack>();

            CreateMap<TPlBackRepack, TPlBackRepackUpdateModel>();

            CreateMap<TPlBackRepackUpdateModel, TPlBackRepack>();

            CreateMap<TPlBackRepackReadModel, TPlBackRepackUpdateModel>();

        }

    }
}
