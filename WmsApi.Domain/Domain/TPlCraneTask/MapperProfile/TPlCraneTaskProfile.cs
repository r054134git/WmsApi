using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlCraneTask"/> .
    /// </summary>
    public partial class TPlCraneTaskProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCraneTaskProfile"/> class.
        /// </summary>
        public TPlCraneTaskProfile()
        {
            CreateMap<TPlCraneTask, TPlCraneTaskReadModel>();

            CreateMap<TPlCraneTaskCreateModel, TPlCraneTask>();

            CreateMap<TPlCraneTask, TPlCraneTaskUpdateModel>();

            CreateMap<TPlCraneTaskUpdateModel, TPlCraneTask>();

            CreateMap<TPlCraneTaskReadModel, TPlCraneTaskUpdateModel>();

        }

    }
}
