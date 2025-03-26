using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrFenceDoor"/> .
    /// </summary>
    public partial class TTrFenceDoorProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrFenceDoorProfile"/> class.
        /// </summary>
        public TTrFenceDoorProfile()
        {
            CreateMap<TTrFenceDoor, TTrFenceDoorReadModel>();

            CreateMap<TTrFenceDoorCreateModel, TTrFenceDoor>();

            CreateMap<TTrFenceDoor, TTrFenceDoorUpdateModel>();

            CreateMap<TTrFenceDoorUpdateModel, TTrFenceDoor>();

            CreateMap<TTrFenceDoorReadModel, TTrFenceDoorUpdateModel>();

        }

    }
}
