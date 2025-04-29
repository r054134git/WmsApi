using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrTrain"/> .
    /// </summary>
    public partial class TTrTrainProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTrainProfile"/> class.
        /// </summary>
        public TTrTrainProfile()
        {
            CreateMap<TTrTrain, TTrTrainReadModel>();

            CreateMap<TTrTrainCreateModel, TTrTrain>();

            CreateMap<TTrTrain, TTrTrainUpdateModel>();

            CreateMap<TTrTrainUpdateModel, TTrTrain>();

            CreateMap<TTrTrainReadModel, TTrTrainUpdateModel>();

        }

    }
}
