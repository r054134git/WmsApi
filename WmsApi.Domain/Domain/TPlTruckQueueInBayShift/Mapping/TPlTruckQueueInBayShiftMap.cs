using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift" />
    /// </summary>
    public partial class TPlTruckQueueInBayShiftMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TPlTruckQueueInBayShift>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TPlTruckQueueInBayShift> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_truck_queue_in_bay_shift");

            // key
            builder.HasKey(t => new { t.Id, t.OrderNo });

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

            builder.Property(t => t.OutHouse)
                .HasColumnName("OUT_HOUSE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.CardNo)
                .HasColumnName("CARD_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.VehicleNo)
                .HasColumnName("VEHICLE_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.ArriveNo)
                .HasColumnName("ARRIVE_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TruckLoadingNo)
                .HasColumnName("TRUCK_LOADING_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.TruckLoad)
                .HasColumnName("TRUCK_LOAD")
                .HasColumnType("decimal(8,2)");

            builder.Property(t => t.EntryHouse)
                .HasColumnName("ENTRY_HOUSE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.OrderNo)
                .IsRequired()
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DetailNo)
                .HasColumnName("DETAIL_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.No)
                .IsRequired()
                .HasColumnName("NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ItemCount)
                .HasColumnName("ITEM_COUNT")
                .HasColumnType("decimal(9,2)");

            builder.Property(t => t.WeightTotal)
                .HasColumnName("WEIGHT_TOTAL")
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

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift" /></summary>
            public const string Name = "t_pl_truck_queue_in_bay_shift";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.OperationMark" /></summary>
            public const string OperationMark = "OPERATION_MARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.OutHouse" /></summary>
            public const string OutHouse = "OUT_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.CardNo" /></summary>
            public const string CardNo = "CARD_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.VehicleNo" /></summary>
            public const string VehicleNo = "VEHICLE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.ArriveNo" /></summary>
            public const string ArriveNo = "ARRIVE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.TruckLoadingNo" /></summary>
            public const string TruckLoadingNo = "TRUCK_LOADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.TruckLoad" /></summary>
            public const string TruckLoad = "TRUCK_LOAD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.EntryHouse" /></summary>
            public const string EntryHouse = "ENTRY_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.DetailNo" /></summary>
            public const string DetailNo = "DETAIL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.No" /></summary>
            public const string No = "NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.ItemCount" /></summary>
            public const string ItemCount = "ITEM_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.WeightTotal" /></summary>
            public const string WeightTotal = "WEIGHT_TOTAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
