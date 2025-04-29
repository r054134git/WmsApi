using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TScTransferSpec"/> .
    /// </summary>
    public partial class TScTransferSpecProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScTransferSpecProfile"/> class.
        /// </summary>
        public TScTransferSpecProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TScTransferSpec, WmsApi.Contracts.Models.TScTransferSpecReadModel>();

            CreateMap<WmsApi.Contracts.Models.TScTransferSpecCreateModel, WmsApi.Domain.Entities.TScTransferSpec>();

            CreateMap<WmsApi.Domain.Entities.TScTransferSpec, WmsApi.Contracts.Models.TScTransferSpecUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TScTransferSpecUpdateModel, WmsApi.Domain.Entities.TScTransferSpec>();

            CreateMap<WmsApi.Contracts.Models.TScTransferSpecReadModel, WmsApi.Contracts.Models.TScTransferSpecUpdateModel>();

        }

    }
}
