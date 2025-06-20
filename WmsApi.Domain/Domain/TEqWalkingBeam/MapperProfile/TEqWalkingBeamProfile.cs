using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqWalkingBeam"/> .
    /// </summary>
    public partial class TEqWalkingBeamProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqWalkingBeamProfile"/> class.
        /// </summary>
        public TEqWalkingBeamProfile()
        {
            CreateMap<TEqWalkingBeam, TEqWalkingBeamReadModel>();

            CreateMap<TEqWalkingBeamCreateModel, TEqWalkingBeam>();

            CreateMap<TEqWalkingBeam, TEqWalkingBeamUpdateModel>();

            CreateMap<TEqWalkingBeamUpdateModel, TEqWalkingBeam>();

            CreateMap<TEqWalkingBeamReadModel, TEqWalkingBeamUpdateModel>();

        }

    }
}
