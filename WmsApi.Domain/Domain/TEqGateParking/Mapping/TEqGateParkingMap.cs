using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TEqGateParking" />
	/// </summary>
	public partial class TEqGateParkingMap
        : IEntityTypeConfiguration<Entities.TEqGateParking>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TEqGateParking" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TEqGateParking> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_eq_gate_parking");

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

            builder.Property(t => t.IpEntry)
                .HasColumnName("IP_ENTRY")
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

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TEqGateParking" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TEqGateParking" /></summary>
            public const string Name = "t_eq_gate_parking";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.Code" /></summary>
            public const string Code = "CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.GateId" /></summary>
            public const string GateId = "GATE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.IpEntry" /></summary>
            public const string IpEntry = "IP_ENTRY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.IpLed" /></summary>
            public const string IpLed = "IP_LED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqGateParking.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
