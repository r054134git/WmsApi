using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRlTransferPrewired"/> .
    /// </summary>
    public partial class TRlTransferPrewiredProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlTransferPrewiredProfile"/> class.
        /// </summary>
        public TRlTransferPrewiredProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRlTransferPrewired, WmsApi.Contracts.Models.TRlTransferPrewiredReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRlTransferPrewiredCreateModel, WmsApi.Domain.Entities.TRlTransferPrewired>();

            CreateMap<WmsApi.Domain.Entities.TRlTransferPrewired, WmsApi.Contracts.Models.TRlTransferPrewiredUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRlTransferPrewiredUpdateModel, WmsApi.Domain.Entities.TRlTransferPrewired>();

            CreateMap<WmsApi.Contracts.Models.TRlTransferPrewiredReadModel, WmsApi.Contracts.Models.TRlTransferPrewiredUpdateModel>();

        }

    }
}
