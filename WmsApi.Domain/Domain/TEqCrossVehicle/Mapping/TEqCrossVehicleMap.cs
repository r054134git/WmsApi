using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TEqCrossVehicle" />
    /// </summary>
    public partial class TEqCrossVehicleMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TEqCrossVehicle>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TEqCrossVehicle" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TEqCrossVehicle> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_eq_cross_vehicle");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasColumnType("int(1)");

            builder.Property(t => t.BayDistanceConfig)
                .HasColumnName("BAY_DISTANCE_CONFIG")
                .HasColumnType("varchar(4096)")
                .HasMaxLength(4096);

            builder.Property(t => t.FenceAreaId)
                .HasColumnName("FENCE_AREA_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LocationCount)
                .IsRequired()
                .HasColumnName("LOCATION_COUNT")
                .HasColumnType("int(11)");

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
            builder.HasOne(t => t.FenceAreaTEqFenceArea)
                .WithMany(t => t.FenceAreaTEqCrossVehicles)
                .HasForeignKey(d => d.FenceAreaId)
                .HasConstraintName("FK_CROSS_TRAIN_FENCE");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TEqCrossVehicle" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TEqCrossVehicle" /></summary>
            public const string Name = "t_eq_cross_vehicle";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.BayDistanceConfig" /></summary>
            public const string BayDistanceConfig = "BAY_DISTANCE_CONFIG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.FenceAreaId" /></summary>
            public const string FenceAreaId = "FENCE_AREA_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.LocationCount" /></summary>
            public const string LocationCount = "LOCATION_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrossVehicle.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
