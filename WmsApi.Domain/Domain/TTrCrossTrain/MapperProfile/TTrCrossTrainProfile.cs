using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrCrossTrain"/> .
    /// </summary>
    public partial class TTrCrossTrainProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCrossTrainProfile"/> class.
        /// </summary>
        public TTrCrossTrainProfile()
        {
            CreateMap<TTrCrossTrain, TTrCrossTrainReadModel>();

            CreateMap<TTrCrossTrainCreateModel, TTrCrossTrain>();

            CreateMap<TTrCrossTrain, TTrCrossTrainUpdateModel>();

            CreateMap<TTrCrossTrainUpdateModel, TTrCrossTrain>();

            CreateMap<TTrCrossTrainReadModel, TTrCrossTrainUpdateModel>();

        }

    }
}
