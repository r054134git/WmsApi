using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqFenceDoor"/> .
    /// </summary>
    public partial class TEqFenceDoorProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqFenceDoorProfile"/> class.
        /// </summary>
        public TEqFenceDoorProfile()
        {
            CreateMap<TEqFenceDoor, TEqFenceDoorReadModel>();

            CreateMap<TEqFenceDoorCreateModel, TEqFenceDoor>();

            CreateMap<TEqFenceDoor, TEqFenceDoorUpdateModel>();

            CreateMap<TEqFenceDoorUpdateModel, TEqFenceDoor>();

            CreateMap<TEqFenceDoorReadModel, TEqFenceDoorUpdateModel>();

        }

    }
}
