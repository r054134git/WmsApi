using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlBayTransfer" />
	/// </summary>
	public partial class TPlBayTransferMap
        : IEntityTypeConfiguration<Entities.TPlBayTransfer>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlBayTransfer" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlBayTransfer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_bay_transfer");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.No)
                .HasColumnName("NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialId)
                .HasColumnName("MATERIAL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.PlanTypeId)
                .IsRequired()
                .HasColumnName("PLAN_TYPE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PlanTypeName)
                .HasColumnName("PLAN_TYPE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.FromBayId)
                .IsRequired()
                .HasColumnName("FROM_BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.FromBayName)
                .HasColumnName("FROM_BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.DestBayId)
                .IsRequired()
                .HasColumnName("DEST_BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.DestBayName)
                .HasColumnName("DEST_BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TransType)
                .HasColumnName("TRANS_TYPE")
                .HasColumnType("int(1)");

            builder.Property(t => t.VehicleTypeId)
                .HasColumnName("VEHICLE_TYPE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.VehicleTypeName)
                .HasColumnName("VEHICLE_TYPE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.PlanState)
                .IsRequired()
                .HasColumnName("PLAN_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ResolveState)
                .IsRequired()
                .HasColumnName("RESOLVE_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ExecState)
                .IsRequired()
                .HasColumnName("EXEC_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.CrossBayTaskId)
                .HasColumnName("CROSS_BAY_TASK_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PriorityOperator)
                .HasColumnName("PRIORITY_OPERATOR")
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
            builder.HasOne(t => t.VehicleTypeTEqCrossVehicle)
                .WithMany(t => t.VehicleTypeTPlBayTransfers)
                .HasForeignKey(d => d.VehicleTypeId)
                .HasConstraintName("FK_CROSS_VEHICLE_TYPE");

            builder.HasOne(t => t.DestBayTWhBay)
                .WithMany(t => t.DestBayTPlBayTransfers)
                .HasForeignKey(d => d.DestBayId)
                .HasConstraintName("FK_PL_WAREHOUSE_DEST_BAY");

            builder.HasOne(t => t.FromBayTWhBay)
                .WithMany(t => t.FromBayTPlBayTransfers)
                .HasForeignKey(d => d.FromBayId)
                .HasConstraintName("FK_PL_WAREHOUSE_FROM_BAY");

            builder.HasOne(t => t.PlanTypeTWhPlanType)
                .WithMany(t => t.PlanTypeTPlBayTransfers)
                .HasForeignKey(d => d.PlanTypeId)
                .HasConstraintName("FK_PL_WAREHOUSE_PLAN_TYPE");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlBayTransfer" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlBayTransfer" /></summary>
            public const string Name = "t_pl_bay_transfer";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.No" /></summary>
            public const string No = "NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.PlanTypeId" /></summary>
            public const string PlanTypeId = "PLAN_TYPE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.PlanTypeName" /></summary>
            public const string PlanTypeName = "PLAN_TYPE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.FromBayId" /></summary>
            public const string FromBayId = "FROM_BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.FromBayName" /></summary>
            public const string FromBayName = "FROM_BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.DestBayId" /></summary>
            public const string DestBayId = "DEST_BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.DestBayName" /></summary>
            public const string DestBayName = "DEST_BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.TransType" /></summary>
            public const string TransType = "TRANS_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.VehicleTypeId" /></summary>
            public const string VehicleTypeId = "VEHICLE_TYPE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.VehicleTypeName" /></summary>
            public const string VehicleTypeName = "VEHICLE_TYPE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.PlanState" /></summary>
            public const string PlanState = "PLAN_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.ResolveState" /></summary>
            public const string ResolveState = "RESOLVE_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.ExecState" /></summary>
            public const string ExecState = "EXEC_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.CrossBayTaskId" /></summary>
            public const string CrossBayTaskId = "CROSS_BAY_TASK_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.PriorityOperator" /></summary>
            public const string PriorityOperator = "PRIORITY_OPERATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBayTransfer.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
