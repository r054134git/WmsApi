using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRlDispatchRules"/> .
    /// </summary>
    public partial class TRlDispatchRulesProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlDispatchRulesProfile"/> class.
        /// </summary>
        public TRlDispatchRulesProfile()
        {
            CreateMap<TRlDispatchRules, TRlDispatchRulesReadModel>();

            CreateMap<TRlDispatchRulesCreateModel, TRlDispatchRules>();

            CreateMap<TRlDispatchRules, TRlDispatchRulesUpdateModel>();

            CreateMap<TRlDispatchRulesUpdateModel, TRlDispatchRules>();

            CreateMap<TRlDispatchRulesReadModel, TRlDispatchRulesUpdateModel>();

        }

    }
}
