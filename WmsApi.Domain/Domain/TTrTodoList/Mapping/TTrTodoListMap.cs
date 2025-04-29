using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrTodoList" />
	/// </summary>
	public partial class TTrTodoListMap
        : IEntityTypeConfiguration<Entities.TTrTodoList>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrTodoList" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrTodoList> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_todo_list");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayName)
                .HasColumnName("BAY_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.Description)
                .HasColumnName("DESCRIPTION")
                .HasColumnType("varchar(2000)")
                .HasMaxLength(2000);

            builder.Property(t => t.EventNo)
                .HasColumnName("EVENT_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.Sender)
                .HasColumnName("SENDER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrTodoList" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrTodoList" /></summary>
            public const string Name = "t_tr_todo_list";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTodoList.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTodoList.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTodoList.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTodoList.Description" /></summary>
            public const string Description = "DESCRIPTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTodoList.EventNo" /></summary>
            public const string EventNo = "EVENT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTodoList.Sender" /></summary>
            public const string Sender = "SENDER";
        }
        #endregion
    }
}
