using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut" />
    /// </summary>
    public partial class TPlTruckQueueInBayOutMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TPlTruckQueueInBayOut>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TPlTruckQueueInBayOut> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_truck_queue_in_bay_out");

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
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.TruckLoadingNo)
                .HasColumnName("TRUCK_LOADING_NO")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DoorNo)
                .HasColumnName("DOOR_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

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

            builder.Property(t => t.Location)
                .HasColumnName("LOCATION")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut" /></summary>
            public const string Name = "t_pl_truck_queue_in_bay_out";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.OperationMark" /></summary>
            public const string OperationMark = "OPERATION_MARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.TruckLoadingNo" /></summary>
            public const string TruckLoadingNo = "TRUCK_LOADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.DoorNo" /></summary>
            public const string DoorNo = "DOOR_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.DetailNo" /></summary>
            public const string DetailNo = "DETAIL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.No" /></summary>
            public const string No = "NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.Location" /></summary>
            public const string Location = "LOCATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
