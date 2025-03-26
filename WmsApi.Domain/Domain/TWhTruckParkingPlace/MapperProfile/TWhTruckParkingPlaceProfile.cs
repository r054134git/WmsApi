using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhTruckParkingPlace"/> .
    /// </summary>
    public partial class TWhTruckParkingPlaceProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhTruckParkingPlaceProfile"/> class.
        /// </summary>
        public TWhTruckParkingPlaceProfile()
        {
            CreateMap<TWhTruckParkingPlace, TWhTruckParkingPlaceReadModel>();

            CreateMap<TWhTruckParkingPlaceCreateModel, TWhTruckParkingPlace>();

            CreateMap<TWhTruckParkingPlace, TWhTruckParkingPlaceUpdateModel>();

            CreateMap<TWhTruckParkingPlaceUpdateModel, TWhTruckParkingPlace>();

            CreateMap<TWhTruckParkingPlaceReadModel, TWhTruckParkingPlaceUpdateModel>();

        }

    }
}
