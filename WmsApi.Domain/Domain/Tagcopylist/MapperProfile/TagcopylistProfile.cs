using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="Tagcopylist"/> .
    /// </summary>
    public partial class TagcopylistProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagcopylistProfile"/> class.
        /// </summary>
        public TagcopylistProfile()
        {
            CreateMap<WmsApi.Domain.Entities.Tagcopylist, WmsApi.Contracts.Models.TagcopylistReadModel>();

            CreateMap<WmsApi.Contracts.Models.TagcopylistCreateModel, WmsApi.Domain.Entities.Tagcopylist>();

            CreateMap<WmsApi.Domain.Entities.Tagcopylist, WmsApi.Contracts.Models.TagcopylistUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TagcopylistUpdateModel, WmsApi.Domain.Entities.Tagcopylist>();

            CreateMap<WmsApi.Contracts.Models.TagcopylistReadModel, WmsApi.Contracts.Models.TagcopylistUpdateModel>();

        }

    }
}
