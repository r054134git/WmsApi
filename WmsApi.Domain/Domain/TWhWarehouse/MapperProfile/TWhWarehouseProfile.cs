using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhWarehouse"/> .
    /// </summary>
    public partial class TWhWarehouseProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhWarehouseProfile"/> class.
        /// </summary>
        public TWhWarehouseProfile()
        {
            CreateMap<TWhWarehouse, TWhWarehouseReadModel>();

            CreateMap<TWhWarehouseCreateModel, TWhWarehouse>();

            CreateMap<TWhWarehouse, TWhWarehouseUpdateModel>();

            CreateMap<TWhWarehouseUpdateModel, TWhWarehouse>();

            CreateMap<TWhWarehouseReadModel, TWhWarehouseUpdateModel>();

        }

    }
}
