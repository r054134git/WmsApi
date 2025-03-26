using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhTruckPassage"/> .
    /// </summary>
    public partial class TWhTruckPassageProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTruckPassageProfile"/> class.
        /// </summary>
        public TWhTruckPassageProfile()
        {
            CreateMap<TWhTruckPassage, TWhTruckPassageReadModel>();

            CreateMap<TWhTruckPassageCreateModel, TWhTruckPassage>();

            CreateMap<TWhTruckPassage, TWhTruckPassageUpdateModel>();

            CreateMap<TWhTruckPassageUpdateModel, TWhTruckPassage>();

            CreateMap<TWhTruckPassageReadModel, TWhTruckPassageUpdateModel>();

        }

    }
}
