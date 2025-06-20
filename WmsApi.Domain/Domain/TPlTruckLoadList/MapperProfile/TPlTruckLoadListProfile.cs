using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlTruckLoadList"/> .
    /// </summary>
    public partial class TPlTruckLoadListProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckLoadListProfile"/> class.
        /// </summary>
        public TPlTruckLoadListProfile()
        {
            CreateMap<TPlTruckLoadList, TPlTruckLoadListReadModel>();

            CreateMap<TPlTruckLoadListCreateModel, TPlTruckLoadList>();

            CreateMap<TPlTruckLoadList, TPlTruckLoadListUpdateModel>();

            CreateMap<TPlTruckLoadListUpdateModel, TPlTruckLoadList>();

            CreateMap<TPlTruckLoadListReadModel, TPlTruckLoadListUpdateModel>();

        }

    }
}
