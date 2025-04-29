using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcCraneTask"/> .
    /// </summary>
    public partial class TRcCraneTaskProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcCraneTaskProfile"/> class.
        /// </summary>
        public TRcCraneTaskProfile()
        {
            CreateMap<TRcCraneTask, TRcCraneTaskReadModel>();

            CreateMap<TRcCraneTaskCreateModel, TRcCraneTask>();

            CreateMap<TRcCraneTask, TRcCraneTaskUpdateModel>();

            CreateMap<TRcCraneTaskUpdateModel, TRcCraneTask>();

            CreateMap<TRcCraneTaskReadModel, TRcCraneTaskUpdateModel>();

        }

    }
}
