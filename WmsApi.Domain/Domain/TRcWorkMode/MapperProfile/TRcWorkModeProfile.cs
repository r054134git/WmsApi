using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcWorkMode"/> .
    /// </summary>
    public partial class TRcWorkModeProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcWorkModeProfile"/> class.
        /// </summary>
        public TRcWorkModeProfile()
        {
            CreateMap<TRcWorkMode, TRcWorkModeReadModel>();

            CreateMap<TRcWorkModeCreateModel, TRcWorkMode>();

            CreateMap<TRcWorkMode, TRcWorkModeUpdateModel>();

            CreateMap<TRcWorkModeUpdateModel, TRcWorkMode>();

            CreateMap<TRcWorkModeReadModel, TRcWorkModeUpdateModel>();

        }

    }
}
