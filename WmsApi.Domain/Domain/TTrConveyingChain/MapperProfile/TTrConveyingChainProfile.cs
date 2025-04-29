using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrConveyingChain"/> .
    /// </summary>
    public partial class TTrConveyingChainProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrConveyingChainProfile"/> class.
        /// </summary>
        public TTrConveyingChainProfile()
        {
            CreateMap<TTrConveyingChain, TTrConveyingChainReadModel>();

            CreateMap<TTrConveyingChainCreateModel, TTrConveyingChain>();

            CreateMap<TTrConveyingChain, TTrConveyingChainUpdateModel>();

            CreateMap<TTrConveyingChainUpdateModel, TTrConveyingChain>();

            CreateMap<TTrConveyingChainReadModel, TTrConveyingChainUpdateModel>();

        }

    }
}
