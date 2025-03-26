using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrCpl"/> .
    /// </summary>
    public partial class TTrCplProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCplProfile"/> class.
        /// </summary>
        public TTrCplProfile()
        {
            CreateMap<TTrCpl, TTrCplReadModel>();

            CreateMap<TTrCplCreateModel, TTrCpl>();

            CreateMap<TTrCpl, TTrCplUpdateModel>();

            CreateMap<TTrCplUpdateModel, TTrCpl>();

            CreateMap<TTrCplReadModel, TTrCplUpdateModel>();

        }

    }
}
