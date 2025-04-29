using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhTrainLocation"/> .
    /// </summary>
    public partial class TWhTrainLocationProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTrainLocationProfile"/> class.
        /// </summary>
        public TWhTrainLocationProfile()
        {
            CreateMap<TWhTrainLocation, TWhTrainLocationReadModel>();

            CreateMap<TWhTrainLocationCreateModel, TWhTrainLocation>();

            CreateMap<TWhTrainLocation, TWhTrainLocationUpdateModel>();

            CreateMap<TWhTrainLocationUpdateModel, TWhTrainLocation>();

            CreateMap<TWhTrainLocationReadModel, TWhTrainLocationUpdateModel>();

        }

    }
}
