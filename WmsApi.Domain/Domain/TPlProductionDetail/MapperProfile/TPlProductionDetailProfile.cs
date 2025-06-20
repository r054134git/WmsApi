using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlProductionDetail"/> .
    /// </summary>
    public partial class TPlProductionDetailProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlProductionDetailProfile"/> class.
        /// </summary>
        public TPlProductionDetailProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlProductionDetail, WmsApi.Contracts.Models.TPlProductionDetailReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlProductionDetailCreateModel, WmsApi.Domain.Entities.TPlProductionDetail>();

            CreateMap<WmsApi.Domain.Entities.TPlProductionDetail, WmsApi.Contracts.Models.TPlProductionDetailUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlProductionDetailUpdateModel, WmsApi.Domain.Entities.TPlProductionDetail>();

            CreateMap<WmsApi.Contracts.Models.TPlProductionDetailReadModel, WmsApi.Contracts.Models.TPlProductionDetailUpdateModel>();

        }

    }
}
