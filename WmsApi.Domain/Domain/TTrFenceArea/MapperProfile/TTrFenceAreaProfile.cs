using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrFenceArea"/> .
    /// </summary>
    public partial class TTrFenceAreaProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrFenceAreaProfile"/> class.
        /// </summary>
        public TTrFenceAreaProfile()
        {
            CreateMap<TTrFenceArea, TTrFenceAreaReadModel>();

            CreateMap<TTrFenceAreaCreateModel, TTrFenceArea>();

            CreateMap<TTrFenceArea, TTrFenceAreaUpdateModel>();

            CreateMap<TTrFenceAreaUpdateModel, TTrFenceArea>();

            CreateMap<TTrFenceAreaReadModel, TTrFenceAreaUpdateModel>();

        }

    }
}
