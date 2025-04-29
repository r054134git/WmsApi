using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTestPre"/> .
    /// </summary>
    public partial class TTestPreProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTestPreProfile"/> class.
        /// </summary>
        public TTestPreProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TTestPre, WmsApi.Contracts.Models.TTestPreReadModel>();

            CreateMap<WmsApi.Contracts.Models.TTestPreCreateModel, WmsApi.Domain.Entities.TTestPre>();

            CreateMap<WmsApi.Domain.Entities.TTestPre, WmsApi.Contracts.Models.TTestPreUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TTestPreUpdateModel, WmsApi.Domain.Entities.TTestPre>();

            CreateMap<WmsApi.Contracts.Models.TTestPreReadModel, WmsApi.Contracts.Models.TTestPreUpdateModel>();

        }

    }
}
