using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTruckTransfer"/> .
    /// </summary>
    public partial class TPlTruckTransferProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckTransferProfile"/> class.
        /// </summary>
        public TPlTruckTransferProfile()
        {
            CreateMap<TPlTruckTransfer, TPlTruckTransferReadModel>();

            CreateMap<TPlTruckTransferCreateModel, TPlTruckTransfer>();

            CreateMap<TPlTruckTransfer, TPlTruckTransferUpdateModel>();

            CreateMap<TPlTruckTransferUpdateModel, TPlTruckTransfer>();

            CreateMap<TPlTruckTransferReadModel, TPlTruckTransferUpdateModel>();

        }

    }
}
