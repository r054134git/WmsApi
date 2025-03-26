using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlDeliveryPlan"/> .
    /// </summary>
    public partial class TPlDeliveryPlanProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlDeliveryPlanProfile"/> class.
        /// </summary>
        public TPlDeliveryPlanProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlDeliveryPlan, WmsApi.Contracts.Models.TPlDeliveryPlanReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlDeliveryPlanCreateModel, WmsApi.Domain.Entities.TPlDeliveryPlan>();

            CreateMap<WmsApi.Domain.Entities.TPlDeliveryPlan, WmsApi.Contracts.Models.TPlDeliveryPlanUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlDeliveryPlanUpdateModel, WmsApi.Domain.Entities.TPlDeliveryPlan>();

            CreateMap<WmsApi.Contracts.Models.TPlDeliveryPlanReadModel, WmsApi.Contracts.Models.TPlDeliveryPlanUpdateModel>();

        }

    }
}
