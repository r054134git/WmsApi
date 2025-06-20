using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TEqCrane" />
	/// </summary>
	public partial class TEqCraneMap
        : IEntityTypeConfiguration<Entities.TEqCrane>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TEqCrane" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TEqCrane> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_eq_crane");

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
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.No)
                .IsRequired()
                .HasColumnName("NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.OrderX)
                .IsRequired()
                .HasColumnName("ORDER_X")
                .HasColumnType("int(1)");

            builder.Property(t => t.Width)
                .IsRequired()
                .HasColumnName("WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinX)
                .IsRequired()
                .HasColumnName("MIN_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxX)
                .IsRequired()
                .HasColumnName("MAX_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinXBoth)
                .HasColumnName("MIN_X_BOTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxXBoth)
                .HasColumnName("MAX_X_BOTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinXTriple)
                .HasColumnName("MIN_X_TRIPLE")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxXTriple)
                .HasColumnName("MAX_X_TRIPLE")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinY)
                .IsRequired()
                .HasColumnName("MIN_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxY)
                .IsRequired()
                .HasColumnName("MAX_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinZ)
                .IsRequired()
                .HasColumnName("MIN_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxZ)
                .IsRequired()
                .HasColumnName("MAX_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinAngle)
                .HasColumnName("MIN_ANGLE")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxAngle)
                .HasColumnName("MAX_ANGLE")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinWeight)
                .HasColumnName("MIN_WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.MaxWeight)
                .HasColumnName("MAX_WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.AccSpeed)
                .IsRequired()
                .HasColumnName("ACC_SPEED")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.Speed)
                .IsRequired()
                .HasColumnName("SPEED")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.StandbyX)
                .IsRequired()
                .HasColumnName("STANDBY_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.StandbyY)
                .IsRequired()
                .HasColumnName("STANDBY_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.StandbyAngle)
                .IsRequired()
                .HasColumnName("STANDBY_ANGLE")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaintainceX)
                .IsRequired()
                .HasColumnName("MAINTAINCE_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaintainceY)
                .IsRequired()
                .HasColumnName("MAINTAINCE_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.IsAvoidCab)
                .HasColumnName("IS_AVOID_CAB")
                .HasColumnType("int(10)");

            builder.Property(t => t.CabMinY)
                .HasColumnName("CAB_MIN_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.CabMaxY)
                .HasColumnName("CAB_MAX_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.CabSafeZ)
                .HasColumnName("CAB_SAFE_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.IsAutoStandbyEnable)
                .IsRequired()
                .HasColumnName("IS_AUTO_STANDBY_ENABLE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsMixModeAvoidEnable)
                .IsRequired()
                .HasColumnName("IS_MIX_MODE_AVOID_ENABLE")
                .HasColumnType("int(11)");

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.StandbyXDriver)
                .HasColumnName("STANDBY_X_DRIVER")
                .HasColumnType("int(11)");

            builder.Property(t => t.StandbyYDriver)
                .HasColumnName("STANDBY_Y_DRIVER")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsDriverStandby)
                .HasColumnName("IS_DRIVER_STANDBY")
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
            builder.HasOne(t => t.OwnerTWhBay)
                .WithMany(t => t.OwnerTEqCranes)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_WH_CRANE_BAY");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TEqCrane" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TEqCrane" /></summary>
            public const string Name = "t_eq_crane";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.No" /></summary>
            public const string No = "NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.OrderX" /></summary>
            public const string OrderX = "ORDER_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MinX" /></summary>
            public const string MinX = "MIN_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaxX" /></summary>
            public const string MaxX = "MAX_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MinXBoth" /></summary>
            public const string MinXBoth = "MIN_X_BOTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaxXBoth" /></summary>
            public const string MaxXBoth = "MAX_X_BOTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MinXTriple" /></summary>
            public const string MinXTriple = "MIN_X_TRIPLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaxXTriple" /></summary>
            public const string MaxXTriple = "MAX_X_TRIPLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MinY" /></summary>
            public const string MinY = "MIN_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaxY" /></summary>
            public const string MaxY = "MAX_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MinZ" /></summary>
            public const string MinZ = "MIN_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaxZ" /></summary>
            public const string MaxZ = "MAX_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MinAngle" /></summary>
            public const string MinAngle = "MIN_ANGLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaxAngle" /></summary>
            public const string MaxAngle = "MAX_ANGLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MinWeight" /></summary>
            public const string MinWeight = "MIN_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaxWeight" /></summary>
            public const string MaxWeight = "MAX_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.AccSpeed" /></summary>
            public const string AccSpeed = "ACC_SPEED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.Speed" /></summary>
            public const string Speed = "SPEED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.StandbyX" /></summary>
            public const string StandbyX = "STANDBY_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.StandbyY" /></summary>
            public const string StandbyY = "STANDBY_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.StandbyAngle" /></summary>
            public const string StandbyAngle = "STANDBY_ANGLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaintainceX" /></summary>
            public const string MaintainceX = "MAINTAINCE_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.MaintainceY" /></summary>
            public const string MaintainceY = "MAINTAINCE_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.IsAvoidCab" /></summary>
            public const string IsAvoidCab = "IS_AVOID_CAB";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.CabMinY" /></summary>
            public const string CabMinY = "CAB_MIN_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.CabMaxY" /></summary>
            public const string CabMaxY = "CAB_MAX_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.CabSafeZ" /></summary>
            public const string CabSafeZ = "CAB_SAFE_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.IsAutoStandbyEnable" /></summary>
            public const string IsAutoStandbyEnable = "IS_AUTO_STANDBY_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.IsMixModeAvoidEnable" /></summary>
            public const string IsMixModeAvoidEnable = "IS_MIX_MODE_AVOID_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.StandbyXDriver" /></summary>
            public const string StandbyXDriver = "STANDBY_X_DRIVER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.StandbyYDriver" /></summary>
            public const string StandbyYDriver = "STANDBY_Y_DRIVER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.IsDriverStandby" /></summary>
            public const string IsDriverStandby = "IS_DRIVER_STANDBY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCrane.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
