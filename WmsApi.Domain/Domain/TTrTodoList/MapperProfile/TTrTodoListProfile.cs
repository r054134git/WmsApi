using System;
using AutoMapper;
using WmsApi.Contracts.Models;
using WmsApi.Domain.Entities;

namespace WmsApi.Domain.MapperProfile
{
    /// <summary>
    /// Mapper class for entity <see cref="TTrTodoList"/> .
    /// </summary>
    public partial class TTrTodoListProfile
        : Profile
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrTodoListProfile"/> class.
        /// </summary>
        public TTrTodoListProfile()
        {
            CreateMap<TTrTodoList, TTrTodoListReadModel>();

            CreateMap<TTrTodoListCreateModel, TTrTodoList>();

            CreateMap<TTrTodoList, TTrTodoListUpdateModel>();

            CreateMap<TTrTodoListUpdateModel, TTrTodoList>();

            CreateMap<TTrTodoListReadModel, TTrTodoListUpdateModel>();

        }

    }
}
