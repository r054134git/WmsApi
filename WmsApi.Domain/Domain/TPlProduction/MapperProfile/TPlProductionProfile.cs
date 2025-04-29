using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlProduction"/> .
    /// </summary>
    public partial class TPlProductionProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlProductionProfile"/> class.
        /// </summary>
        public TPlProductionProfile()
        {
            CreateMap<TPlProduction, TPlProductionReadModel>();

            CreateMap<TPlProductionCreateModel, TPlProduction>();

            CreateMap<TPlProduction, TPlProductionUpdateModel>();

            CreateMap<TPlProductionUpdateModel, TPlProduction>();

            CreateMap<TPlProductionReadModel, TPlProductionUpdateModel>();

        }

    }
}
