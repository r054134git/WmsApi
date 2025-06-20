using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTruckDeliveryDetail"/> .
    /// </summary>
    public partial class TPlTruckDeliveryDetailProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckDeliveryDetailProfile"/> class.
        /// </summary>
        public TPlTruckDeliveryDetailProfile()
        {
            CreateMap<TPlTruckDeliveryDetail, TPlTruckDeliveryDetailReadModel>();

            CreateMap<TPlTruckDeliveryDetailCreateModel, TPlTruckDeliveryDetail>();

            CreateMap<TPlTruckDeliveryDetail, TPlTruckDeliveryDetailUpdateModel>();

            CreateMap<TPlTruckDeliveryDetailUpdateModel, TPlTruckDeliveryDetail>();

            CreateMap<TPlTruckDeliveryDetailReadModel, TPlTruckDeliveryDetailUpdateModel>();

        }

    }
}
