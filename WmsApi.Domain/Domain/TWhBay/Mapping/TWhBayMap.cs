using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhBay" />
	/// </summary>
	public partial class TWhBayMap
        : IEntityTypeConfiguration<Entities.TWhBay>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhBay" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhBay> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_bay");

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
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.No)
                .IsRequired()
                .HasColumnName("NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PointX)
                .IsRequired()
                .HasColumnName("POINT_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.PointY)
                .IsRequired()
                .HasColumnName("POINT_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.Length)
                .IsRequired()
                .HasColumnName("LENGTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.Width)
                .IsRequired()
                .HasColumnName("WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.Height)
                .IsRequired()
                .HasColumnName("HEIGHT")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.TrainY)
                .HasColumnName("TRAIN_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.LastUploadStockTime)
                .HasColumnName("LAST_UPLOAD_STOCK_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.LastUploadDefectTime)
                .HasColumnName("LAST_UPLOAD_DEFECT_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.LastUploadWeightTime)
                .HasColumnName("LAST_UPLOAD_WEIGHT_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.AutoPickCount)
                .HasColumnName("AUTO_PICK_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.LocationNameFormat)
                .HasColumnName("LOCATION_NAME_FORMAT")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IsAxisLinkageEnabled)
                .HasColumnName("IS_AXIS_LINKAGE_ENABLED")
                .HasColumnType("int(11)");

            builder.Property(t => t.AxisLinkageRectX)
                .HasColumnName("AXIS_LINKAGE_RECT_X")
                .HasColumnType("int(11)");

            builder.Property(t => t.AxisLinkageRectY)
                .HasColumnName("AXIS_LINKAGE_RECT_Y")
                .HasColumnType("int(11)");

            builder.Property(t => t.AxisLinkageRectZ)
                .HasColumnName("AXIS_LINKAGE_RECT_Z")
                .HasColumnType("int(11)");

            builder.Property(t => t.AvoidRectX)
                .HasColumnName("AVOID_RECT_X")
                .HasColumnType("int(11)");

            builder.Property(t => t.AvoidRectY)
                .HasColumnName("AVOID_RECT_Y")
                .HasColumnType("int(11)");

            builder.Property(t => t.AvoidRectZ)
                .HasColumnName("AVOID_RECT_Z")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadMovingZ)
                .HasColumnName("LOAD_MOVING_Z")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadHoveringHeight)
                .HasColumnName("LOAD_HOVERING_HEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.UnloadMovingZ)
                .HasColumnName("UNLOAD_MOVING_Z")
                .HasColumnType("int(11)");

            builder.Property(t => t.UnloadHoveringHeight)
                .HasColumnName("UNLOAD_HOVERING_HEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.PositioningLimitX)
                .HasColumnName("POSITIONING_LIMIT_X")
                .HasColumnType("int(11)");

            builder.Property(t => t.PositioningLimitY)
                .HasColumnName("POSITIONING_LIMIT_Y")
                .HasColumnType("int(11)");

            builder.Property(t => t.PositioningLimitZ)
                .HasColumnName("POSITIONING_LIMIT_Z")
                .HasColumnType("int(11)");

            builder.Property(t => t.MinDistanceBetweenCrane)
                .HasColumnName("MIN_DISTANCE_BETWEEN_CRANE")
                .HasColumnType("int(11)");

            builder.Property(t => t.CrossTrainPositionLimit)
                .HasColumnName("CROSS_TRAIN_POSITION_LIMIT")
                .HasColumnType("int(11)");

            builder.Property(t => t.ServerIp)
                .HasColumnName("SERVER_IP")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IsCalcDestLocation)
                .HasColumnName("IS_CALC_DEST_LOCATION")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsScriptLocationAssign)
                .HasColumnName("IS_SCRIPT_LOCATION_ASSIGN")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsScrapAssignLocation)
                .HasColumnName("IS_SCRAP_ASSIGN_LOCATION")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsSafetyDoorEnabled)
                .HasColumnName("IS_SAFETY_DOOR_ENABLED")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsAutoToC3)
                .IsRequired()
                .HasColumnName("IS_AUTO_TO_C3")
                .HasColumnType("int(1)");

            builder.Property(t => t.IsL2LocationTriangle)
                .HasColumnName("IS_L2_LOCATION_TRIANGLE")
                .HasColumnType("int(11)");

            builder.Property(t => t.MaxCoilHeight)
                .HasColumnName("MAX_COIL_HEIGHT")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.TrackingG3Index)
                .HasColumnName("TRACKING_G3_INDEX")
                .HasColumnType("int(2)");

            builder.Property(t => t.TrackingG2Index)
                .HasColumnName("TRACKING_G2_INDEX")
                .HasColumnType("int(2)");

            builder.Property(t => t.TruckSafetyWidth)
                .HasColumnName("TRUCK_SAFETY_WIDTH")
                .HasColumnType("int(3)");

            builder.Property(t => t.TruckDevToEnd)
                .HasColumnName("TRUCK_DEV_TO_END")
                .HasColumnType("int(3)");

            builder.Property(t => t.WarningLocsFloor1)
                .IsRequired()
                .HasColumnName("WARNING_LOCS_FLOOR1")
                .HasColumnType("decimal(3,3)");

            builder.Property(t => t.WarningLocsFloor2)
                .IsRequired()
                .HasColumnName("WARNING_LOCS_FLOOR2")
                .HasColumnType("decimal(3,3)");

            builder.Property(t => t.WarningLocsAll)
                .IsRequired()
                .HasColumnName("WARNING_LOCS_ALL")
                .HasColumnType("decimal(3,3)");

            builder.Property(t => t.AllowTruckloadingNum)
                .HasColumnName("ALLOW_TRUCKLOADING_NUM")
                .HasColumnType("int(3)");

            builder.Property(t => t.IsEnable)
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
            builder.HasOne(t => t.OwnerTWhWarehouse)
                .WithMany(t => t.OwnerTWhBays)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_WH_BAY_WH_INFO");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhBay" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhBay" /></summary>
            public const string Name = "t_wh_bay";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.Code" /></summary>
            public const string Code = "CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.No" /></summary>
            public const string No = "NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.PointX" /></summary>
            public const string PointX = "POINT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.PointY" /></summary>
            public const string PointY = "POINT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.Length" /></summary>
            public const string Length = "LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.Height" /></summary>
            public const string Height = "HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.TrainY" /></summary>
            public const string TrainY = "TRAIN_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.LocationCode" /></summary>
            public const string LocationCode = "LOCATION_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.LastUploadStockTime" /></summary>
            public const string LastUploadStockTime = "LAST_UPLOAD_STOCK_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.LastUploadDefectTime" /></summary>
            public const string LastUploadDefectTime = "LAST_UPLOAD_DEFECT_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.LastUploadWeightTime" /></summary>
            public const string LastUploadWeightTime = "LAST_UPLOAD_WEIGHT_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.AutoPickCount" /></summary>
            public const string AutoPickCount = "AUTO_PICK_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.LocationNameFormat" /></summary>
            public const string LocationNameFormat = "LOCATION_NAME_FORMAT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.IsAxisLinkageEnabled" /></summary>
            public const string IsAxisLinkageEnabled = "IS_AXIS_LINKAGE_ENABLED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.AxisLinkageRectX" /></summary>
            public const string AxisLinkageRectX = "AXIS_LINKAGE_RECT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.AxisLinkageRectY" /></summary>
            public const string AxisLinkageRectY = "AXIS_LINKAGE_RECT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.AxisLinkageRectZ" /></summary>
            public const string AxisLinkageRectZ = "AXIS_LINKAGE_RECT_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.AvoidRectX" /></summary>
            public const string AvoidRectX = "AVOID_RECT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.AvoidRectY" /></summary>
            public const string AvoidRectY = "AVOID_RECT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.AvoidRectZ" /></summary>
            public const string AvoidRectZ = "AVOID_RECT_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.LoadMovingZ" /></summary>
            public const string LoadMovingZ = "LOAD_MOVING_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.LoadHoveringHeight" /></summary>
            public const string LoadHoveringHeight = "LOAD_HOVERING_HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.UnloadMovingZ" /></summary>
            public const string UnloadMovingZ = "UNLOAD_MOVING_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.UnloadHoveringHeight" /></summary>
            public const string UnloadHoveringHeight = "UNLOAD_HOVERING_HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.PositioningLimitX" /></summary>
            public const string PositioningLimitX = "POSITIONING_LIMIT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.PositioningLimitY" /></summary>
            public const string PositioningLimitY = "POSITIONING_LIMIT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.PositioningLimitZ" /></summary>
            public const string PositioningLimitZ = "POSITIONING_LIMIT_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.MinDistanceBetweenCrane" /></summary>
            public const string MinDistanceBetweenCrane = "MIN_DISTANCE_BETWEEN_CRANE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.CrossTrainPositionLimit" /></summary>
            public const string CrossTrainPositionLimit = "CROSS_TRAIN_POSITION_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.ServerIp" /></summary>
            public const string ServerIp = "SERVER_IP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.IsCalcDestLocation" /></summary>
            public const string IsCalcDestLocation = "IS_CALC_DEST_LOCATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.IsScriptLocationAssign" /></summary>
            public const string IsScriptLocationAssign = "IS_SCRIPT_LOCATION_ASSIGN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.IsScrapAssignLocation" /></summary>
            public const string IsScrapAssignLocation = "IS_SCRAP_ASSIGN_LOCATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.IsSafetyDoorEnabled" /></summary>
            public const string IsSafetyDoorEnabled = "IS_SAFETY_DOOR_ENABLED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.IsAutoToC3" /></summary>
            public const string IsAutoToC3 = "IS_AUTO_TO_C3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.IsL2LocationTriangle" /></summary>
            public const string IsL2LocationTriangle = "IS_L2_LOCATION_TRIANGLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.MaxCoilHeight" /></summary>
            public const string MaxCoilHeight = "MAX_COIL_HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.TrackingG3Index" /></summary>
            public const string TrackingG3Index = "TRACKING_G3_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.TrackingG2Index" /></summary>
            public const string TrackingG2Index = "TRACKING_G2_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.TruckSafetyWidth" /></summary>
            public const string TruckSafetyWidth = "TRUCK_SAFETY_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.TruckDevToEnd" /></summary>
            public const string TruckDevToEnd = "TRUCK_DEV_TO_END";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.WarningLocsFloor1" /></summary>
            public const string WarningLocsFloor1 = "WARNING_LOCS_FLOOR1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.WarningLocsFloor2" /></summary>
            public const string WarningLocsFloor2 = "WARNING_LOCS_FLOOR2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.WarningLocsAll" /></summary>
            public const string WarningLocsAll = "WARNING_LOCS_ALL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.AllowTruckloadingNum" /></summary>
            public const string AllowTruckloadingNum = "ALLOW_TRUCKLOADING_NUM";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhBay.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
