using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue" />
    /// </summary>
    public partial class TRcTruckBayQueueMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcTruckBayQueue>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcTruckBayQueue> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_truck_bay_queue");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TruckNo)
                .HasColumnName("TRUCK_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MainLoadingNo)
                .HasColumnName("MAIN_LOADING_NO")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.HouseNo)
                .HasColumnName("HOUSE_NO")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.DispatchStepState)
                .HasColumnName("DISPATCH_STEP_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.TruckHeight)
                .HasColumnName("TRUCK_HEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.EntryTime)
                .HasColumnName("ENTRY_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.OutTime)
                .HasColumnName("OUT_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.EntryBayTime)
                .HasColumnName("ENTRY_BAY_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.ArriveParkingTime)
                .HasColumnName("ARRIVE_PARKING_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.StartLoadingTime)
                .HasColumnName("START_LOADING_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.OutBayTime)
                .HasColumnName("OUT_BAY_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.ConfirmOutTime)
                .HasColumnName("CONFIRM_OUT_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.TruckType)
                .HasColumnName("TRUCK_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsMoreBay)
                .HasColumnName("IS_MORE_BAY")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.SortNo)
                .HasColumnName("SORT_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.CallTime)
                .HasColumnName("CALL_TIME")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue" /></summary>
            public const string Name = "t_rc_truck_bay_queue";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.TruckNo" /></summary>
            public const string TruckNo = "TRUCK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.MainLoadingNo" /></summary>
            public const string MainLoadingNo = "MAIN_LOADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.HouseNo" /></summary>
            public const string HouseNo = "HOUSE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.DispatchStepState" /></summary>
            public const string DispatchStepState = "DISPATCH_STEP_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.TruckHeight" /></summary>
            public const string TruckHeight = "TRUCK_HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.EntryTime" /></summary>
            public const string EntryTime = "ENTRY_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.OutTime" /></summary>
            public const string OutTime = "OUT_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.EntryBayTime" /></summary>
            public const string EntryBayTime = "ENTRY_BAY_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.ArriveParkingTime" /></summary>
            public const string ArriveParkingTime = "ARRIVE_PARKING_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.StartLoadingTime" /></summary>
            public const string StartLoadingTime = "START_LOADING_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.OutBayTime" /></summary>
            public const string OutBayTime = "OUT_BAY_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.ConfirmOutTime" /></summary>
            public const string ConfirmOutTime = "CONFIRM_OUT_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.TruckType" /></summary>
            public const string TruckType = "TRUCK_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.IsMoreBay" /></summary>
            public const string IsMoreBay = "IS_MORE_BAY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.SortNo" /></summary>
            public const string SortNo = "SORT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.CallTime" /></summary>
            public const string CallTime = "CALL_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
