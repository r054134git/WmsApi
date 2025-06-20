using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlCrossBayTask"/> .
    /// </summary>
    public partial class TPlCrossBayTaskProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCrossBayTaskProfile"/> class.
        /// </summary>
        public TPlCrossBayTaskProfile()
        {
            CreateMap<TPlCrossBayTask, TPlCrossBayTaskReadModel>();

            CreateMap<TPlCrossBayTaskCreateModel, TPlCrossBayTask>();

            CreateMap<TPlCrossBayTask, TPlCrossBayTaskUpdateModel>();

            CreateMap<TPlCrossBayTaskUpdateModel, TPlCrossBayTask>();

            CreateMap<TPlCrossBayTaskReadModel, TPlCrossBayTaskUpdateModel>();

        }

    }
}
