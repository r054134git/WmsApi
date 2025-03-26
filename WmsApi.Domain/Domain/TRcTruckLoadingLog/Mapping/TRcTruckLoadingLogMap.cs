using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog" />
    /// </summary>
    public partial class TRcTruckLoadingLogMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcTruckLoadingLog>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcTruckLoadingLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_truck_loading_log");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.ParkingPlace)
                .HasColumnName("PARKING_PLACE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Count)
                .HasColumnName("COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.TruckNo)
                .HasColumnName("TRUCK_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.MainTruckLoadingNo)
                .HasColumnName("MAIN_TRUCK_LOADING_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.ArriveTime)
                .HasColumnName("ARRIVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.LoadingTime)
                .HasColumnName("LOADING_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.LeaveTime)
                .HasColumnName("LEAVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.PrepareTime)
                .HasColumnName("PREPARE_TIME")
                .HasColumnType("decimal(12,2)");

            builder.Property(t => t.LoadTime)
                .HasColumnName("LOAD_TIME")
                .HasColumnType("decimal(12,2)");

            builder.Property(t => t.FreeTime)
                .HasColumnName("FREE_TIME")
                .HasColumnType("decimal(12,2)");

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

            builder.Property(t => t.TruckOutTime)
                .HasColumnName("TRUCK_OUT_TIME")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog" /></summary>
            public const string Name = "t_rc_truck_loading_log";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.ParkingPlace" /></summary>
            public const string ParkingPlace = "PARKING_PLACE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.Count" /></summary>
            public const string Count = "COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.TruckNo" /></summary>
            public const string TruckNo = "TRUCK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.MainTruckLoadingNo" /></summary>
            public const string MainTruckLoadingNo = "MAIN_TRUCK_LOADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.ArriveTime" /></summary>
            public const string ArriveTime = "ARRIVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.LoadingTime" /></summary>
            public const string LoadingTime = "LOADING_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.LeaveTime" /></summary>
            public const string LeaveTime = "LEAVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.PrepareTime" /></summary>
            public const string PrepareTime = "PREPARE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.LoadTime" /></summary>
            public const string LoadTime = "LOAD_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.FreeTime" /></summary>
            public const string FreeTime = "FREE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.Remark" /></summary>
            public const string Remark = "REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog.TruckOutTime" /></summary>
            public const string TruckOutTime = "TRUCK_OUT_TIME";
        }
        #endregion
    }
}
