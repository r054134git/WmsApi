using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TRcLog" />
	/// </summary>
	public partial class TRcLogMap
        : IEntityTypeConfiguration<Entities.TRcLog>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TRcLog" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TRcLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_log");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Dt)
                .IsRequired()
                .HasColumnName("DT")
                .HasColumnType("datetime");

            builder.Property(t => t.EventNo)
                .IsRequired()
                .HasColumnName("EVENT_NO")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.WarningLevel)
                .IsRequired()
                .HasColumnName("WARNING_LEVEL")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Message)
                .IsRequired()
                .HasColumnName("MESSAGE")
                .HasColumnType("text");

            builder.Property(t => t.Description)
                .HasColumnName("DESCRIPTION")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Source)
                .IsRequired()
                .HasColumnName("SOURCE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcLog" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcLog" /></summary>
            public const string Name = "t_rc_log";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLog.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLog.Dt" /></summary>
            public const string Dt = "DT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLog.EventNo" /></summary>
            public const string EventNo = "EVENT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLog.WarningLevel" /></summary>
            public const string WarningLevel = "WARNING_LEVEL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLog.Message" /></summary>
            public const string Message = "MESSAGE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLog.Description" /></summary>
            public const string Description = "DESCRIPTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLog.Source" /></summary>
            public const string Source = "SOURCE";
        }
        #endregion
    }
}
