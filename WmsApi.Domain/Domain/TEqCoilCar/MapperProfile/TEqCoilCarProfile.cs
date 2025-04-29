using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqCoilCar"/> .
    /// </summary>
    public partial class TEqCoilCarProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqCoilCarProfile"/> class.
        /// </summary>
        public TEqCoilCarProfile()
        {
            CreateMap<TEqCoilCar, TEqCoilCarReadModel>();

            CreateMap<TEqCoilCarCreateModel, TEqCoilCar>();

            CreateMap<TEqCoilCar, TEqCoilCarUpdateModel>();

            CreateMap<TEqCoilCarUpdateModel, TEqCoilCar>();

            CreateMap<TEqCoilCarReadModel, TEqCoilCarUpdateModel>();

        }

    }
}
