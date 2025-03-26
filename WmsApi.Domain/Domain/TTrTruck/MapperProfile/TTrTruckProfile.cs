using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrTruck"/> .
    /// </summary>
    public partial class TTrTruckProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTruckProfile"/> class.
        /// </summary>
        public TTrTruckProfile()
        {
            CreateMap<TTrTruck, TTrTruckReadModel>();

            CreateMap<TTrTruckCreateModel, TTrTruck>();

            CreateMap<TTrTruck, TTrTruckUpdateModel>();

            CreateMap<TTrTruckUpdateModel, TTrTruck>();

            CreateMap<TTrTruckReadModel, TTrTruckUpdateModel>();

        }

    }
}
