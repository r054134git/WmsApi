using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlAutoCode"/> .
    /// </summary>
    public partial class TPlAutoCodeProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlAutoCodeProfile"/> class.
        /// </summary>
        public TPlAutoCodeProfile()
        {
            CreateMap<TPlAutoCode, TPlAutoCodeReadModel>();

            CreateMap<TPlAutoCodeCreateModel, TPlAutoCode>();

            CreateMap<TPlAutoCode, TPlAutoCodeUpdateModel>();

            CreateMap<TPlAutoCodeUpdateModel, TPlAutoCode>();

            CreateMap<TPlAutoCodeReadModel, TPlAutoCodeUpdateModel>();

        }

    }
}
