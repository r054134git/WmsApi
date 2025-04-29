using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TEqGateParking"/> .
    /// </summary>
    public partial class TEqGateParkingProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TEqGateParkingProfile"/> class.
        /// </summary>
        public TEqGateParkingProfile()
        {
            CreateMap<TEqGateParking, TEqGateParkingReadModel>();

            CreateMap<TEqGateParkingCreateModel, TEqGateParking>();

            CreateMap<TEqGateParking, TEqGateParkingUpdateModel>();

            CreateMap<TEqGateParkingUpdateModel, TEqGateParking>();

            CreateMap<TEqGateParkingReadModel, TEqGateParkingUpdateModel>();

        }

    }
}
