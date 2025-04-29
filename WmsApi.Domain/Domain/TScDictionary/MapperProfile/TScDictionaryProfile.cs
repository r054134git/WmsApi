using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TScDictionary"/> .
    /// </summary>
    public partial class TScDictionaryProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TScDictionaryProfile"/> class.
        /// </summary>
        public TScDictionaryProfile()
        {
            CreateMap<TScDictionary, TScDictionaryReadModel>()
                .ForMember(dest => dest.OwnerValue, options => options.MapFrom(
                            src => src.OwnerTScDictionary != null ? src.OwnerTScDictionary.Value : "")); 

            CreateMap<TScDictionaryCreateModel, TScDictionary>();

            CreateMap<TScDictionary, TScDictionaryUpdateModel>();

            CreateMap<TScDictionaryUpdateModel, TScDictionary>();

            CreateMap<TScDictionaryReadModel, TScDictionaryUpdateModel>();

        }

    }
}
