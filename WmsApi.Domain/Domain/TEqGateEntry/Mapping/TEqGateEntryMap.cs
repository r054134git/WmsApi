using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TEqGateEntry" />
	/// </summary>
	public partial class TEqGateEntryMap
        : IEntityTypeConfiguration<Entities.TEqGateEntry>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TEqGateEntry" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TEqGateEntry> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_eq_gate_entry");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Name)
                .HasColumnName("NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Code)
                .HasColumnName("CODE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.GateId)
                .HasColumnName("GATE_ID")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IpGate)
                .HasColumnName("IP_GATE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IpLed)
                .HasColumnName("IP_LED")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.EntryBayIdList)
                .HasColumnName("ENTRY_BAY_ID_LIST")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IsEnable)
                .HasColumnName("IS_ENABLE")
                .HasColumnType("int(1)");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.CreateUser)
                .HasColumnName("CREATE_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UpdateTime)
                .HasColumnName("UPDATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.UpdateUser)
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TEqGateEntry" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TEqGateEntry" /></summary>
            public const string Name = "t_eq_gate_entry";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.Code" /></summary>
            public const string Code = "CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.GateId" /></summary>
            public const string GateId = "GATE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.IpGate" /></summary>
            public const string IpGate = "IP_GATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.IpLed" /></summary>
            public const string IpLed = "IP_LED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.EntryBayIdList" /></summary>
            public const string EntryBayIdList = "ENTRY_BAY_ID_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateEntry.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
