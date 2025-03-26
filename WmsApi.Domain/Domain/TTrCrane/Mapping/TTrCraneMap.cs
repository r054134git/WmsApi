using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrCrane" />
	/// </summary>
	public partial class TTrCraneMap
        : IEntityTypeConfiguration<Entities.TTrCrane>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrCrane" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrCrane> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_crane");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneId)
                .HasColumnName("CRANE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneName)
                .HasColumnName("CRANE_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CranePlcName)
                .HasColumnName("CRANE_PLC_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.G)
                .HasColumnName("G")
                .HasColumnType("int(11)");

            builder.Property(t => t.BayId)
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OpMode)
                .HasColumnName("OP_MODE")
                .HasColumnType("int(11)");

            builder.Property(t => t.X)
                .HasColumnName("X")
                .HasColumnType("int(11)");

            builder.Property(t => t.Y)
                .HasColumnName("Y")
                .HasColumnType("int(11)");

            builder.Property(t => t.Z)
                .HasColumnName("Z")
                .HasColumnType("int(11)");

            builder.Property(t => t.Weight)
                .HasColumnName("WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.GantryCmd)
                .HasColumnName("GANTRY_CMD")
                .HasColumnType("int(1)");

            builder.Property(t => t.TrolleyCmd)
                .HasColumnName("TROLLEY_CMD")
                .HasColumnType("int(1)");

            builder.Property(t => t.HoistCmd)
                .HasColumnName("HOIST_CMD")
                .HasColumnType("int(1)");

            builder.Property(t => t.SlingCmd)
                .HasColumnName("SLING_CMD")
                .HasColumnType("int(1)");

            builder.Property(t => t.HoistCurrent)
                .HasColumnName("HOIST_CURRENT")
                .HasColumnType("int(11)");

            builder.Property(t => t.TargetX)
                .HasColumnName("TARGET_X")
                .HasColumnType("int(11)");

            builder.Property(t => t.TargetY)
                .HasColumnName("TARGET_Y")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadLocationName)
                .HasColumnName("LOAD_LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.TargetLocationName)
                .HasColumnName("TARGET_LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.TargetLocationTips)
                .HasColumnName("TARGET_LOCATION_TIPS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.MaterialId)
                .HasColumnName("MATERIAL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialIdByUser)
                .HasColumnName("MATERIAL_ID__BY_USER")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNoByUser)
                .HasColumnName("MATERIAL_NO_BY_USER")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IsLoaded)
                .HasColumnName("IS_LOADED")
                .HasColumnType("int(11)");

            builder.Property(t => t.TrackingIndex)
                .HasColumnName("TRACKING_INDEX")
                .HasColumnType("int(2)");

            builder.Property(t => t.LoadableCoils)
                .HasColumnName("LOADABLE_COILS")
                .HasColumnType("varchar(4000)")
                .HasMaxLength(4000);

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
            builder.HasOne(t => t.BayTWhBay)
                .WithMany(t => t.BayTTrCranes)
                .HasForeignKey(d => d.BayId)
                .HasConstraintName("FK_WH_BAY");

            builder.HasOne(t => t.CraneTEqCrane)
                .WithMany(t => t.CraneTTrCranes)
                .HasForeignKey(d => d.CraneId)
                .HasConstraintName("t_tr_crane_ibfk_1");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrCrane" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrCrane" /></summary>
            public const string Name = "t_tr_crane";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.CraneId" /></summary>
            public const string CraneId = "CRANE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.CranePlcName" /></summary>
            public const string CranePlcName = "CRANE_PLC_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.G" /></summary>
            public const string G = "G";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.OpMode" /></summary>
            public const string OpMode = "OP_MODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.X" /></summary>
            public const string X = "X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.Y" /></summary>
            public const string Y = "Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.Z" /></summary>
            public const string Z = "Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.Weight" /></summary>
            public const string Weight = "WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.GantryCmd" /></summary>
            public const string GantryCmd = "GANTRY_CMD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.TrolleyCmd" /></summary>
            public const string TrolleyCmd = "TROLLEY_CMD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.HoistCmd" /></summary>
            public const string HoistCmd = "HOIST_CMD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.SlingCmd" /></summary>
            public const string SlingCmd = "SLING_CMD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.HoistCurrent" /></summary>
            public const string HoistCurrent = "HOIST_CURRENT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.TargetX" /></summary>
            public const string TargetX = "TARGET_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.TargetY" /></summary>
            public const string TargetY = "TARGET_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.LoadLocationName" /></summary>
            public const string LoadLocationName = "LOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.TargetLocationName" /></summary>
            public const string TargetLocationName = "TARGET_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.TargetLocationTips" /></summary>
            public const string TargetLocationTips = "TARGET_LOCATION_TIPS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.MaterialIdByUser" /></summary>
            public const string MaterialIdByUser = "MATERIAL_ID__BY_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.MaterialNoByUser" /></summary>
            public const string MaterialNoByUser = "MATERIAL_NO_BY_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.IsLoaded" /></summary>
            public const string IsLoaded = "IS_LOADED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.TrackingIndex" /></summary>
            public const string TrackingIndex = "TRACKING_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.LoadableCoils" /></summary>
            public const string LoadableCoils = "LOADABLE_COILS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrane.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
