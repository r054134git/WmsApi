using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan" />
    /// </summary>
    public partial class TPlDeliveryPlanMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TPlDeliveryPlan>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TPlDeliveryPlan> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_delivery_plan");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.House)
                .HasColumnName("HOUSE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.OrderNo)
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.PlanNum)
                .HasColumnName("PLAN_NUM")
                .HasColumnType("int(11)");

            builder.Property(t => t.PlanWeight)
                .HasColumnName("PLAN_WEIGHT")
                .HasColumnType("decimal(15,6)");

            builder.Property(t => t.PlanDate)
                .HasColumnName("PLAN_DATE")
                .HasColumnType("varchar(8)")
                .HasMaxLength(8);

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan" /></summary>
            public const string Name = "t_pl_delivery_plan";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.House" /></summary>
            public const string House = "HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.PlanNum" /></summary>
            public const string PlanNum = "PLAN_NUM";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.PlanWeight" /></summary>
            public const string PlanWeight = "PLAN_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.PlanDate" /></summary>
            public const string PlanDate = "PLAN_DATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
