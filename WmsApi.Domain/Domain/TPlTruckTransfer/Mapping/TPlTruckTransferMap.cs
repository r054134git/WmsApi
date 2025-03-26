using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlTruckTransfer" />
	/// </summary>
	public partial class TPlTruckTransferMap
        : IEntityTypeConfiguration<Entities.TPlTruckTransfer>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlTruckTransfer" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlTruckTransfer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_truck_transfer");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OperationMark)
                .HasColumnName("OPERATION_MARK")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.TransferNo)
                .HasColumnName("TRANSFER_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.OrderNo)
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.PickCount)
                .HasColumnName("PICK_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.WeightMax)
                .HasColumnName("WEIGHT_MAX")
                .HasColumnType("int(11)");

            builder.Property(t => t.CardNo)
                .HasColumnName("CARD_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.TruckNo)
                .HasColumnName("TRUCK_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.SourceHouse)
                .HasColumnName("SOURCE_HOUSE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.FakeLoadingNo)
                .HasColumnName("FAKE_LOADING_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.DestHouse)
                .HasColumnName("DEST_HOUSE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.SaddlesCount)
                .HasColumnName("SADDLES_COUNT")
                .HasColumnType("int(2)");

            builder.Property(t => t.CreateTimeTransfer)
                .HasColumnName("CREATE_TIME_TRANSFER")
                .HasColumnType("datetime");

            builder.Property(t => t.PickState)
                .HasColumnName("PICK_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsSpecifyCoilNo)
                .HasColumnName("IS_SPECIFY_COIL_NO")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PrepickType)
                .HasColumnName("PREPICK_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsDirectTruck)
                .HasColumnName("IS_DIRECT_TRUCK")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsReplaceCoil)
                .HasColumnName("IS_REPLACE_COIL")
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
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckTransfer" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckTransfer" /></summary>
            public const string Name = "t_pl_truck_transfer";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.OperationMark" /></summary>
            public const string OperationMark = "OPERATION_MARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.TransferNo" /></summary>
            public const string TransferNo = "TRANSFER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.PickCount" /></summary>
            public const string PickCount = "PICK_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.WeightMax" /></summary>
            public const string WeightMax = "WEIGHT_MAX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.CardNo" /></summary>
            public const string CardNo = "CARD_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.TruckNo" /></summary>
            public const string TruckNo = "TRUCK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.SourceHouse" /></summary>
            public const string SourceHouse = "SOURCE_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.FakeLoadingNo" /></summary>
            public const string FakeLoadingNo = "FAKE_LOADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.DestHouse" /></summary>
            public const string DestHouse = "DEST_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.SaddlesCount" /></summary>
            public const string SaddlesCount = "SADDLES_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.CreateTimeTransfer" /></summary>
            public const string CreateTimeTransfer = "CREATE_TIME_TRANSFER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.PickState" /></summary>
            public const string PickState = "PICK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.IsSpecifyCoilNo" /></summary>
            public const string IsSpecifyCoilNo = "IS_SPECIFY_COIL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.PrepickType" /></summary>
            public const string PrepickType = "PREPICK_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.IsDirectTruck" /></summary>
            public const string IsDirectTruck = "IS_DIRECT_TRUCK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.IsReplaceCoil" /></summary>
            public const string IsReplaceCoil = "IS_REPLACE_COIL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckTransfer.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
