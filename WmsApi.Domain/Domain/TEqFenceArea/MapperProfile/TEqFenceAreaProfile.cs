using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqFenceArea"/> .
    /// </summary>
    public partial class TEqFenceAreaProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqFenceAreaProfile"/> class.
        /// </summary>
        public TEqFenceAreaProfile()
        {
            CreateMap<TEqFenceArea, TEqFenceAreaReadModel>();

            CreateMap<TEqFenceAreaCreateModel, TEqFenceArea>();

            CreateMap<TEqFenceArea, TEqFenceAreaUpdateModel>();

            CreateMap<TEqFenceAreaUpdateModel, TEqFenceArea>();

            CreateMap<TEqFenceAreaReadModel, TEqFenceAreaUpdateModel>();

        }

    }
}
