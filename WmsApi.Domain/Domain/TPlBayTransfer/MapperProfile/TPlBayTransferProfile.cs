using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlBayTransfer"/> .
    /// </summary>
    public partial class TPlBayTransferProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlBayTransferProfile"/> class.
        /// </summary>
        public TPlBayTransferProfile()
        {
            CreateMap<TPlBayTransfer, TPlBayTransferReadModel>();

            CreateMap<TPlBayTransferCreateModel, TPlBayTransfer>();

            CreateMap<TPlBayTransfer, TPlBayTransferUpdateModel>();

            CreateMap<TPlBayTransferUpdateModel, TPlBayTransfer>();

            CreateMap<TPlBayTransferReadModel, TPlBayTransferUpdateModel>();

        }

    }
}
