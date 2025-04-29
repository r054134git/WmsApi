using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqTrain"/> .
    /// </summary>
    public partial class TEqTrainProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqTrainProfile"/> class.
        /// </summary>
        public TEqTrainProfile()
        {
            CreateMap<TEqTrain, TEqTrainReadModel>();

            CreateMap<TEqTrainCreateModel, TEqTrain>();

            CreateMap<TEqTrain, TEqTrainUpdateModel>();

            CreateMap<TEqTrainUpdateModel, TEqTrain>();

            CreateMap<TEqTrainReadModel, TEqTrainUpdateModel>();

        }

    }
}
