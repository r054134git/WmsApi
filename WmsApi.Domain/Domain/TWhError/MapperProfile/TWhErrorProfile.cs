using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TWhError"/> .
    /// </summary>
    public partial class TWhErrorProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TWhErrorProfile"/> class.
        /// </summary>
        public TWhErrorProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TWhError, WmsApi.Contracts.Models.TWhErrorReadModel>();

            CreateMap<WmsApi.Contracts.Models.TWhErrorCreateModel, WmsApi.Domain.Entities.TWhError>();

            CreateMap<WmsApi.Domain.Entities.TWhError, WmsApi.Contracts.Models.TWhErrorUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TWhErrorUpdateModel, WmsApi.Domain.Entities.TWhError>();

            CreateMap<WmsApi.Contracts.Models.TWhErrorReadModel, WmsApi.Contracts.Models.TWhErrorUpdateModel>();

        }

    }
}
