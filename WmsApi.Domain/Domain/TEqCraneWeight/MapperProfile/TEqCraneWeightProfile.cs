using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqCraneWeight"/> .
    /// </summary>
    public partial class TEqCraneWeightProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCraneWeightProfile"/> class.
        /// </summary>
        public TEqCraneWeightProfile()
        {
            CreateMap<TEqCraneWeight, TEqCraneWeightReadModel>();

            CreateMap<TEqCraneWeightCreateModel, TEqCraneWeight>();

            CreateMap<TEqCraneWeight, TEqCraneWeightUpdateModel>();

            CreateMap<TEqCraneWeightUpdateModel, TEqCraneWeight>();

            CreateMap<TEqCraneWeightReadModel, TEqCraneWeightUpdateModel>();

        }

    }
}
