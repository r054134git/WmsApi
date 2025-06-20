using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TRcWorkMode" />
	/// </summary>
	public partial class TRcWorkModeMap
        : IEntityTypeConfiguration<Entities.TRcWorkMode>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TRcWorkMode" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TRcWorkMode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_work_mode");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneName)
                .IsRequired()
                .HasColumnName("CRANE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.FromMode)
                .IsRequired()
                .HasColumnName("FROM_MODE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ToMode)
                .IsRequired()
                .HasColumnName("TO_MODE")
                .HasColumnType("int(11)");

            builder.Property(t => t.CreateTime)
                .IsRequired()
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcWorkMode" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcWorkMode" /></summary>
            public const string Name = "t_rc_work_mode";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcWorkMode.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcWorkMode.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcWorkMode.FromMode" /></summary>
            public const string FromMode = "FROM_MODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcWorkMode.ToMode" /></summary>
            public const string ToMode = "TO_MODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcWorkMode.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
        }
        #endregion
    }
}
