using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqGateEntry"/> .
    /// </summary>
    public partial class TEqGateEntryProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqGateEntryProfile"/> class.
        /// </summary>
        public TEqGateEntryProfile()
        {
            CreateMap<TEqGateEntry, TEqGateEntryReadModel>();

            CreateMap<TEqGateEntryCreateModel, TEqGateEntry>();

            CreateMap<TEqGateEntry, TEqGateEntryUpdateModel>();

            CreateMap<TEqGateEntryUpdateModel, TEqGateEntry>();

            CreateMap<TEqGateEntryReadModel, TEqGateEntryUpdateModel>();

        }

    }
}
