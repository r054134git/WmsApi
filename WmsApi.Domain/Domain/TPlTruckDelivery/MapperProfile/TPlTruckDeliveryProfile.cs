using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTruckDelivery"/> .
    /// </summary>
    public partial class TPlTruckDeliveryProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckDeliveryProfile"/> class.
        /// </summary>
        public TPlTruckDeliveryProfile()
        {
            CreateMap<TPlTruckDelivery, TPlTruckDeliveryReadModel>();

            CreateMap<TPlTruckDeliveryCreateModel, TPlTruckDelivery>();

            CreateMap<TPlTruckDelivery, TPlTruckDeliveryUpdateModel>();

            CreateMap<TPlTruckDeliveryUpdateModel, TPlTruckDelivery>();

            CreateMap<TPlTruckDeliveryReadModel, TPlTruckDeliveryUpdateModel>();

        }

    }
}
