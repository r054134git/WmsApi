using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcTrainDeliveryPick"/> .
    /// </summary>
    public partial class TRcTrainDeliveryPickProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTrainDeliveryPickProfile"/> class.
        /// </summary>
        public TRcTrainDeliveryPickProfile()
        {
            CreateMap<TRcTrainDeliveryPick, TRcTrainDeliveryPickReadModel>();

            CreateMap<TRcTrainDeliveryPickCreateModel, TRcTrainDeliveryPick>();

            CreateMap<TRcTrainDeliveryPick, TRcTrainDeliveryPickUpdateModel>();

            CreateMap<TRcTrainDeliveryPickUpdateModel, TRcTrainDeliveryPick>();

            CreateMap<TRcTrainDeliveryPickReadModel, TRcTrainDeliveryPickUpdateModel>();

        }

    }
}
