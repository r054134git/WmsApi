using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcTrainNode"/> .
    /// </summary>
    public partial class TRcTrainNodeProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTrainNodeProfile"/> class.
        /// </summary>
        public TRcTrainNodeProfile()
        {
            CreateMap<TRcTrainNode, TRcTrainNodeReadModel>();

            CreateMap<TRcTrainNodeCreateModel, TRcTrainNode>();

            CreateMap<TRcTrainNode, TRcTrainNodeUpdateModel>();

            CreateMap<TRcTrainNodeUpdateModel, TRcTrainNode>();

            CreateMap<TRcTrainNodeReadModel, TRcTrainNodeUpdateModel>();

        }

    }
}
