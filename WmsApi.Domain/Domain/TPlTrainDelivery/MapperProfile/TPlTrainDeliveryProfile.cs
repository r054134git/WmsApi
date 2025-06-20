using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTrainDelivery"/> .
    /// </summary>
    public partial class TPlTrainDeliveryProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTrainDeliveryProfile"/> class.
        /// </summary>
        public TPlTrainDeliveryProfile()
        {
            CreateMap<TPlTrainDelivery, TPlTrainDeliveryReadModel>();

            CreateMap<TPlTrainDeliveryCreateModel, TPlTrainDelivery>();

            CreateMap<TPlTrainDelivery, TPlTrainDeliveryUpdateModel>();

            CreateMap<TPlTrainDeliveryUpdateModel, TPlTrainDelivery>();

            CreateMap<TPlTrainDeliveryReadModel, TPlTrainDeliveryUpdateModel>();

        }

    }
}
