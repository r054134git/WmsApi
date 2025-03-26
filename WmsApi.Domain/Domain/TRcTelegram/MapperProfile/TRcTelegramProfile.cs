using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcTelegram"/> .
    /// </summary>
    public partial class TRcTelegramProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTelegramProfile"/> class.
        /// </summary>
        public TRcTelegramProfile()
        {
            CreateMap<TRcTelegram, TRcTelegramReadModel>();

            CreateMap<TRcTelegramCreateModel, TRcTelegram>();

            CreateMap<TRcTelegram, TRcTelegramUpdateModel>();

            CreateMap<TRcTelegramUpdateModel, TRcTelegram>();

            CreateMap<TRcTelegramReadModel, TRcTelegramUpdateModel>();

        }

    }
}
