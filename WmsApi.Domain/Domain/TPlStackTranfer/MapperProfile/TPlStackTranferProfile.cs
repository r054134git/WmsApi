using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TPlStackTranfer"/> .
    /// </summary>
    public partial class TPlStackTranferProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlStackTranferProfile"/> class.
        /// </summary>
        public TPlStackTranferProfile()
        {
            CreateMap<WmsApi.Domain.Entities.TPlStackTranfer, WmsApi.Contracts.Models.TPlStackTranferReadModel>();

            CreateMap<WmsApi.Contracts.Models.TPlStackTranferCreateModel, WmsApi.Domain.Entities.TPlStackTranfer>();

            CreateMap<WmsApi.Domain.Entities.TPlStackTranfer, WmsApi.Contracts.Models.TPlStackTranferUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.TPlStackTranferUpdateModel, WmsApi.Domain.Entities.TPlStackTranfer>();

            CreateMap<WmsApi.Contracts.Models.TPlStackTranferReadModel, WmsApi.Contracts.Models.TPlStackTranferUpdateModel>();

        }

    }
}
