using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance" />
    /// </summary>
    public partial class TPlCraneMaintenanceMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TPlCraneMaintenance>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TPlCraneMaintenance> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_crane_maintenance");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayId)
                .IsRequired()
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayName)
                .HasColumnName("BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.CraneId)
                .HasColumnName("CRANE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneName)
                .HasColumnName("CRANE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.AreaMixX)
                .HasColumnName("AREA_MIX_X")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.AreaMaxX)
                .HasColumnName("AREA_MAX_X")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.AreaZ)
                .HasColumnName("AREA_Z")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.State)
                .HasColumnName("STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("datetime");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance" /></summary>
            public const string Name = "t_pl_crane_maintenance";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.CraneId" /></summary>
            public const string CraneId = "CRANE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.AreaMixX" /></summary>
            public const string AreaMixX = "AREA_MIX_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.AreaMaxX" /></summary>
            public const string AreaMaxX = "AREA_MAX_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.AreaZ" /></summary>
            public const string AreaZ = "AREA_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.State" /></summary>
            public const string State = "STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.StartTime" /></summary>
            public const string StartTime = "START_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.EndTime" /></summary>
            public const string EndTime = "END_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
