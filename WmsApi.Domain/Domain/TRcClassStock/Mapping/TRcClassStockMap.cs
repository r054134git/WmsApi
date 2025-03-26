using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcClassStock" />
    /// </summary>
    public partial class TRcClassStockMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcClassStock>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcClassStock" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcClassStock> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_class_stock");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.HouseNo)
                .HasColumnName("HOUSE_NO")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.SaveTime)
                .HasColumnName("SAVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.TakeStockCount)
                .HasColumnName("TAKE_STOCK_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.TakeStockWeight)
                .HasColumnName("TAKE_STOCK_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.HandStockCount)
                .HasColumnName("HAND_STOCK_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.HandStockWeight)
                .HasColumnName("HAND_STOCK_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.DeliveryCount)
                .HasColumnName("DELIVERY_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.DeliveryWeight)
                .HasColumnName("DELIVERY_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.HandTakeDiffcount)
                .HasColumnName("HAND_TAKE_DIFFCOUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.HandTakeDiffweight)
                .HasColumnName("HAND_TAKE_DIFFWEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.MakeStockCount)
                .HasColumnName("MAKE_STOCK_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.MakeStockWeight)
                .HasColumnName("MAKE_STOCK_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.LockStockCount)
                .HasColumnName("LOCK_STOCK_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.LockStockWeight)
                .HasColumnName("LOCK_STOCK_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.PickStockCount)
                .HasColumnName("PICK_STOCK_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.PickStockWeight)
                .HasColumnName("PICK_STOCK_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.BayCplCount)
                .HasColumnName("BAY_CPL_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.BayPickedCount)
                .HasColumnName("BAY_PICKED_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.BayStackCount)
                .HasColumnName("BAY_STACK_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.BayProduceCount)
                .HasColumnName("BAY_PRODUCE_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.BayLbWeight)
                .HasColumnName("BAY_LB_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.BayLsWeight)
                .HasColumnName("BAY_LS_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.BayLqWeight)
                .HasColumnName("BAY_LQ_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.BayLyWeight)
                .HasColumnName("BAY_LY_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.BayRzWeight)
                .HasColumnName("BAY_RZ_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.BayTrainWeight)
                .HasColumnName("BAY_TRAIN_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.BayTruckWeight)
                .HasColumnName("BAY_TRUCK_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.BayNoneWeight)
                .HasColumnName("BAY_NONE_WEIGHT")
                .HasColumnType("decimal(11,2)");

            builder.Property(t => t.CurrentClasses)
                .HasColumnName("CURRENT_CLASSES")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcClassStock" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcClassStock" /></summary>
            public const string Name = "t_rc_class_stock";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.HouseNo" /></summary>
            public const string HouseNo = "HOUSE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.SaveTime" /></summary>
            public const string SaveTime = "SAVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.TakeStockCount" /></summary>
            public const string TakeStockCount = "TAKE_STOCK_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.TakeStockWeight" /></summary>
            public const string TakeStockWeight = "TAKE_STOCK_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.HandStockCount" /></summary>
            public const string HandStockCount = "HAND_STOCK_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.HandStockWeight" /></summary>
            public const string HandStockWeight = "HAND_STOCK_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.DeliveryCount" /></summary>
            public const string DeliveryCount = "DELIVERY_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.DeliveryWeight" /></summary>
            public const string DeliveryWeight = "DELIVERY_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.HandTakeDiffcount" /></summary>
            public const string HandTakeDiffcount = "HAND_TAKE_DIFFCOUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.HandTakeDiffweight" /></summary>
            public const string HandTakeDiffweight = "HAND_TAKE_DIFFWEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.MakeStockCount" /></summary>
            public const string MakeStockCount = "MAKE_STOCK_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.MakeStockWeight" /></summary>
            public const string MakeStockWeight = "MAKE_STOCK_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.LockStockCount" /></summary>
            public const string LockStockCount = "LOCK_STOCK_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.LockStockWeight" /></summary>
            public const string LockStockWeight = "LOCK_STOCK_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.PickStockCount" /></summary>
            public const string PickStockCount = "PICK_STOCK_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.PickStockWeight" /></summary>
            public const string PickStockWeight = "PICK_STOCK_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayCplCount" /></summary>
            public const string BayCplCount = "BAY_CPL_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayPickedCount" /></summary>
            public const string BayPickedCount = "BAY_PICKED_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayStackCount" /></summary>
            public const string BayStackCount = "BAY_STACK_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayProduceCount" /></summary>
            public const string BayProduceCount = "BAY_PRODUCE_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayLbWeight" /></summary>
            public const string BayLbWeight = "BAY_LB_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayLsWeight" /></summary>
            public const string BayLsWeight = "BAY_LS_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayLqWeight" /></summary>
            public const string BayLqWeight = "BAY_LQ_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayLyWeight" /></summary>
            public const string BayLyWeight = "BAY_LY_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayRzWeight" /></summary>
            public const string BayRzWeight = "BAY_RZ_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayTrainWeight" /></summary>
            public const string BayTrainWeight = "BAY_TRAIN_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayTruckWeight" /></summary>
            public const string BayTruckWeight = "BAY_TRUCK_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.BayNoneWeight" /></summary>
            public const string BayNoneWeight = "BAY_NONE_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.CurrentClasses" /></summary>
            public const string CurrentClasses = "CURRENT_CLASSES";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcClassStock.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
