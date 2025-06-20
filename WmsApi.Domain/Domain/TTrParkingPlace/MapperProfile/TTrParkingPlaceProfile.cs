using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrParkingPlace"/> .
    /// </summary>
    public partial class TTrParkingPlaceProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrParkingPlaceProfile"/> class.
        /// </summary>
        public TTrParkingPlaceProfile()
        {
            CreateMap<TTrParkingPlace, TTrParkingPlaceReadModel>();

            CreateMap<TTrParkingPlaceCreateModel, TTrParkingPlace>();

            CreateMap<TTrParkingPlace, TTrParkingPlaceUpdateModel>();

            CreateMap<TTrParkingPlaceUpdateModel, TTrParkingPlace>();

            CreateMap<TTrParkingPlaceReadModel, TTrParkingPlaceUpdateModel>();

        }

    }
}
