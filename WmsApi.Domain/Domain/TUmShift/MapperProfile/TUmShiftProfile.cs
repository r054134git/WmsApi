using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TUmShift"/> .
    /// </summary>
    public partial class TUmShiftProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TUmShiftProfile"/> class.
        /// </summary>
        public TUmShiftProfile()
        {
            CreateMap<TUmShift, TUmShiftReadModel>();

            CreateMap<TUmShiftCreateModel, TUmShift>();

            CreateMap<TUmShift, TUmShiftUpdateModel>();

            CreateMap<TUmShiftUpdateModel, TUmShift>();

            CreateMap<TUmShiftReadModel, TUmShiftUpdateModel>();

        }

    }
}
