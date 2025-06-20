using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcTrainDelivery"/> .
    /// </summary>
    public partial class TRcTrainDeliveryProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTrainDeliveryProfile"/> class.
        /// </summary>
        public TRcTrainDeliveryProfile()
        {
            CreateMap<TRcTrainDelivery, TRcTrainDeliveryReadModel>();

            CreateMap<TRcTrainDeliveryCreateModel, TRcTrainDelivery>();

            CreateMap<TRcTrainDelivery, TRcTrainDeliveryUpdateModel>();

            CreateMap<TRcTrainDeliveryUpdateModel, TRcTrainDelivery>();

            CreateMap<TRcTrainDeliveryReadModel, TRcTrainDeliveryUpdateModel>();

        }

    }
}
