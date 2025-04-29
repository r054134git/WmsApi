using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhPlanType"/> .
    /// </summary>
    public partial class TWhPlanTypeProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhPlanTypeProfile"/> class.
        /// </summary>
        public TWhPlanTypeProfile()
        {
            CreateMap<TWhPlanType, TWhPlanTypeReadModel>();

            CreateMap<TWhPlanTypeCreateModel, TWhPlanType>();

            CreateMap<TWhPlanType, TWhPlanTypeUpdateModel>();

            CreateMap<TWhPlanTypeUpdateModel, TWhPlanType>();

            CreateMap<TWhPlanTypeReadModel, TWhPlanTypeUpdateModel>();

        }

    }
}
