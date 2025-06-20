using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcLog"/> .
    /// </summary>
    public partial class TRcLogProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLogProfile"/> class.
        /// </summary>
        public TRcLogProfile()
        {
            CreateMap<TRcLog, TRcLogReadModel>();

            CreateMap<TRcLogCreateModel, TRcLog>();

            CreateMap<TRcLog, TRcLogUpdateModel>();

            CreateMap<TRcLogUpdateModel, TRcLog>();

            CreateMap<TRcLogReadModel, TRcLogUpdateModel>();

        }

    }
}
