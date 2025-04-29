using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqTrainCar"/> .
    /// </summary>
    public partial class TEqTrainCarProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqTrainCarProfile"/> class.
        /// </summary>
        public TEqTrainCarProfile()
        {
            CreateMap<TEqTrainCar, TEqTrainCarReadModel>();

            CreateMap<TEqTrainCarCreateModel, TEqTrainCar>();

            CreateMap<TEqTrainCar, TEqTrainCarUpdateModel>();

            CreateMap<TEqTrainCarUpdateModel, TEqTrainCar>();

            CreateMap<TEqTrainCarReadModel, TEqTrainCarUpdateModel>();

        }

    }
}
