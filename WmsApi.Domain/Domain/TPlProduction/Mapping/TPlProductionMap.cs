using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlProduction" />
	/// </summary>
	public partial class TPlProductionMap
        : IEntityTypeConfiguration<Entities.TPlProduction>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlProduction" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlProduction> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_production");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ProductionNo)
                .HasColumnName("PRODUCTION_NO")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ProductionSeq)
                .HasColumnName("PRODUCTION_SEQ")
                .HasColumnType("int(11)");

            builder.Property(t => t.PlanState)
                .HasColumnName("PLAN_STATE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.PlanCount)
                .HasColumnName("PLAN_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.UnitNo)
                .HasColumnName("UNIT_NO")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.NextProcessId)
                .HasColumnName("NEXT_PROCESS_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OrderNo)
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OrderItemNo)
                .HasColumnName("ORDER_ITEM_NO")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlProduction" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlProduction" /></summary>
            public const string Name = "t_pl_production";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.ProductionNo" /></summary>
            public const string ProductionNo = "PRODUCTION_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.ProductionSeq" /></summary>
            public const string ProductionSeq = "PRODUCTION_SEQ";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.PlanState" /></summary>
            public const string PlanState = "PLAN_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.PlanCount" /></summary>
            public const string PlanCount = "PLAN_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.UnitNo" /></summary>
            public const string UnitNo = "UNIT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.NextProcessId" /></summary>
            public const string NextProcessId = "NEXT_PROCESS_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.OrderItemNo" /></summary>
            public const string OrderItemNo = "ORDER_ITEM_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlProduction.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
