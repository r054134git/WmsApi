using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqCrane"/> .
    /// </summary>
    public partial class TEqCraneProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCraneProfile"/> class.
        /// </summary>
        public TEqCraneProfile()
        {
            CreateMap<TEqCrane, TEqCraneReadModel>();

            CreateMap<TEqCraneCreateModel, TEqCrane>();

            CreateMap<TEqCrane, TEqCraneUpdateModel>();

            CreateMap<TEqCraneUpdateModel, TEqCrane>();

            CreateMap<TEqCraneReadModel, TEqCraneUpdateModel>();

        }

    }
}
