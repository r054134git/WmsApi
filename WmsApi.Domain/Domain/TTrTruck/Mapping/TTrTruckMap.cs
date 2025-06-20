using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrTruck" />
	/// </summary>
	public partial class TTrTruckMap
        : IEntityTypeConfiguration<Entities.TTrTruck>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrTruck" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrTruck> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_truck");

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
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CardNo)
                .HasColumnName("CARD_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MainTruckLoadingNo)
                .HasColumnName("MAIN_TRUCK_LOADING_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.TruckBackNo)
                .HasColumnName("TRUCK_BACK_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.TransferNo)
                .HasColumnName("TRANSFER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.EnterTime)
                .HasColumnName("ENTER_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.ArriveTime)
                .HasColumnName("ARRIVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.InOutType)
                .HasColumnName("IN_OUT_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.DispatchState)
                .HasColumnName("DISPATCH_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.CraneEnabled)
                .HasColumnName("CRANE_ENABLED")
                .HasColumnType("int(1)");

            builder.Property(t => t.ParkingEnabled)
                .HasColumnName("PARKING_ENABLED")
                .HasColumnType("int(1)");

            builder.Property(t => t.GateEntryCode)
                .HasColumnName("GATE_ENTRY_CODE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.GateEntryId)
                .HasColumnName("GATE_ENTRY_ID")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SortIndex)
                .HasColumnName("SORT_INDEX")
                .HasColumnType("int(11)");

            builder.Property(t => t.HasPicked)
                .HasColumnName("HAS_PICKED")
                .HasColumnType("int(11)");

            builder.Property(t => t.PositionState)
                .HasColumnName("POSITION_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.InboundCheckState)
                .HasColumnName("INBOUND_CHECK_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsPickedCoilConfirmed)
                .HasColumnName("IS_PICKED_COIL_CONFIRMED")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsLoadPlansConfirmed)
                .HasColumnName("IS_LOAD_PLANS_CONFIRMED")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsDriverCheckIn)
                .HasColumnName("IS_DRIVER_CHECK_IN")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadBussinessNameList)
                .HasColumnName("LOAD_BUSSINESS_NAME_LIST")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.LoadBayCodeList)
                .HasColumnName("LOAD_BAY_CODE_LIST")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.FinishBusinessNameList)
                .HasColumnName("FINISH_BUSINESS_NAME_LIST")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.FinishBayCodeList)
                .HasColumnName("FINISH_BAY_CODE_LIST")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ParkingNoSuggest)
                .HasColumnName("PARKING_NO_SUGGEST")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ParkingNoCurrent)
                .HasColumnName("PARKING_NO_CURRENT")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.TruckLoadType)
                .HasColumnName("TRUCK_LOAD_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsTruckTransfer)
                .HasColumnName("IS_TRUCK_TRANSFER")
                .HasColumnType("int(11)");

            builder.Property(t => t.Direction)
                .HasColumnName("DIRECTION")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrTruck" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrTruck" /></summary>
            public const string Name = "t_tr_truck";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.TruckNo" /></summary>
            public const string TruckNo = "TRUCK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.CardNo" /></summary>
            public const string CardNo = "CARD_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.MainTruckLoadingNo" /></summary>
            public const string MainTruckLoadingNo = "MAIN_TRUCK_LOADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.TruckBackNo" /></summary>
            public const string TruckBackNo = "TRUCK_BACK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.TransferNo" /></summary>
            public const string TransferNo = "TRANSFER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.EnterTime" /></summary>
            public const string EnterTime = "ENTER_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.ArriveTime" /></summary>
            public const string ArriveTime = "ARRIVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.InOutType" /></summary>
            public const string InOutType = "IN_OUT_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.DispatchState" /></summary>
            public const string DispatchState = "DISPATCH_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.CraneEnabled" /></summary>
            public const string CraneEnabled = "CRANE_ENABLED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.ParkingEnabled" /></summary>
            public const string ParkingEnabled = "PARKING_ENABLED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.GateEntryCode" /></summary>
            public const string GateEntryCode = "GATE_ENTRY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.GateEntryId" /></summary>
            public const string GateEntryId = "GATE_ENTRY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.SortIndex" /></summary>
            public const string SortIndex = "SORT_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.HasPicked" /></summary>
            public const string HasPicked = "HAS_PICKED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.PositionState" /></summary>
            public const string PositionState = "POSITION_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.InboundCheckState" /></summary>
            public const string InboundCheckState = "INBOUND_CHECK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.IsPickedCoilConfirmed" /></summary>
            public const string IsPickedCoilConfirmed = "IS_PICKED_COIL_CONFIRMED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.IsLoadPlansConfirmed" /></summary>
            public const string IsLoadPlansConfirmed = "IS_LOAD_PLANS_CONFIRMED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.IsDriverCheckIn" /></summary>
            public const string IsDriverCheckIn = "IS_DRIVER_CHECK_IN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.LoadBussinessNameList" /></summary>
            public const string LoadBussinessNameList = "LOAD_BUSSINESS_NAME_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.LoadBayCodeList" /></summary>
            public const string LoadBayCodeList = "LOAD_BAY_CODE_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.FinishBusinessNameList" /></summary>
            public const string FinishBusinessNameList = "FINISH_BUSINESS_NAME_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.FinishBayCodeList" /></summary>
            public const string FinishBayCodeList = "FINISH_BAY_CODE_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.ParkingNoSuggest" /></summary>
            public const string ParkingNoSuggest = "PARKING_NO_SUGGEST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.ParkingNoCurrent" /></summary>
            public const string ParkingNoCurrent = "PARKING_NO_CURRENT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.TruckLoadType" /></summary>
            public const string TruckLoadType = "TRUCK_LOAD_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.IsTruckTransfer" /></summary>
            public const string IsTruckTransfer = "IS_TRUCK_TRANSFER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.Direction" /></summary>
            public const string Direction = "DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruck.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
