using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrCpl" />
	/// </summary>
	public partial class TTrCplMap
        : IEntityTypeConfiguration<Entities.TTrCpl>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrCpl" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrCpl> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_cpl");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CplNo)
                .IsRequired()
                .HasColumnName("CPL_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.EntryTime)
                .HasColumnName("ENTRY_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.EntryInterval)
                .HasColumnName("ENTRY_INTERVAL")
                .HasColumnType("int(11)");

            builder.Property(t => t.LeaveTime)
                .HasColumnName("LEAVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.BufferTotoalCount)
                .IsRequired()
                .HasColumnName("BUFFER_TOTOAL_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.BufferUsedCount)
                .IsRequired()
                .HasColumnName("BUFFER_USED_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.BufferLastUsedNo)
                .IsRequired()
                .HasColumnName("BUFFER_LAST_USED_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.AddPriority)
                .IsRequired()
                .HasColumnName("ADD_PRIORITY")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsAddPriorityManual)
                .IsRequired()
                .HasColumnName("IS_ADD_PRIORITY_MANUAL")
                .HasColumnType("int(1)");

            builder.Property(t => t.IsEnable)
                .IsRequired()
                .HasColumnName("IS_ENABLE")
                .HasColumnType("int(1)");

            builder.Property(t => t.CreateTime)
                .IsRequired()
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.CreateUser)
                .IsRequired()
                .HasColumnName("CREATE_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UpdateTime)
                .IsRequired()
                .HasColumnName("UPDATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.UpdateUser)
                .IsRequired()
                .HasColumnName("UPDATE_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Remark)
                .HasColumnName("REMARK")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrCpl" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrCpl" /></summary>
            public const string Name = "t_tr_cpl";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.CplNo" /></summary>
            public const string CplNo = "CPL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.EntryTime" /></summary>
            public const string EntryTime = "ENTRY_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.EntryInterval" /></summary>
            public const string EntryInterval = "ENTRY_INTERVAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.LeaveTime" /></summary>
            public const string LeaveTime = "LEAVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.BufferTotoalCount" /></summary>
            public const string BufferTotoalCount = "BUFFER_TOTOAL_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.BufferUsedCount" /></summary>
            public const string BufferUsedCount = "BUFFER_USED_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.BufferLastUsedNo" /></summary>
            public const string BufferLastUsedNo = "BUFFER_LAST_USED_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.AddPriority" /></summary>
            public const string AddPriority = "ADD_PRIORITY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.IsAddPriorityManual" /></summary>
            public const string IsAddPriorityManual = "IS_ADD_PRIORITY_MANUAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCpl.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
