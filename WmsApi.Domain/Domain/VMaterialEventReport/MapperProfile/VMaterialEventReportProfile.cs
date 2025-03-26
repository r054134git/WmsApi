using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="VMaterialEventReport"/> .
    /// </summary>
    public partial class VMaterialEventReportProfile
        : AutoMapper.Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VMaterialEventReportProfile"/> class.
        /// </summary>
        public VMaterialEventReportProfile()
        {
            CreateMap<WmsApi.Domain.Entities.VMaterialEventReport, WmsApi.Contracts.Models.VMaterialEventReportReadModel>();

            CreateMap<WmsApi.Contracts.Models.VMaterialEventReportCreateModel, WmsApi.Domain.Entities.VMaterialEventReport>();

            CreateMap<WmsApi.Domain.Entities.VMaterialEventReport, WmsApi.Contracts.Models.VMaterialEventReportUpdateModel>();

            CreateMap<WmsApi.Contracts.Models.VMaterialEventReportUpdateModel, WmsApi.Domain.Entities.VMaterialEventReport>();

            CreateMap<WmsApi.Contracts.Models.VMaterialEventReportReadModel, WmsApi.Contracts.Models.VMaterialEventReportUpdateModel>();

        }

    }
}
