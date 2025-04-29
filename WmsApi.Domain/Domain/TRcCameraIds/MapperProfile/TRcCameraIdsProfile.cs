using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TRcCameraIds"/> .
    /// </summary>
    public partial class TRcCameraIdsProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcCameraIdsProfile"/> class.
        /// </summary>
        public TRcCameraIdsProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TRcCameraIds, WmsApi.Contracts.Models.TRcCameraIdsReadModel>();

            CreateMap<WmsApi.Contracts.Models.TRcCameraIdsCreateModel, WmsApi.Domain.Entities.TRcCameraIds>();

            CreateMap<WmsApi.Domain.Entities.TRcCameraIds, WmsApi.Contracts.Models.TRcCameraIdsUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TRcCameraIdsUpdateModel, WmsApi.Domain.Entities.TRcCameraIds>();

            CreateMap<WmsApi.Contracts.Models.TRcCameraIdsReadModel, WmsApi.Contracts.Models.TRcCameraIdsUpdateModel>();

        }

    }
}
