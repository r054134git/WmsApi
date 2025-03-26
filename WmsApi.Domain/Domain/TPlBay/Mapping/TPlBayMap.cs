using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlBay" />
	/// </summary>
	public partial class TPlBayMap
        : IEntityTypeConfiguration<Entities.TPlBay>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlBay" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlBay> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_bay");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PlanNo)
                .IsRequired()
                .HasColumnName("PLAN_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialId)
                .IsRequired()
                .HasColumnName("MATERIAL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNo)
                .IsRequired()
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.PlanTypeId)
                .IsRequired()
                .HasColumnName("PLAN_TYPE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PlanTypeName)
                .IsRequired()
                .HasColumnName("PLAN_TYPE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.BayId)
                .IsRequired()
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayName)
                .HasColumnName("BAY_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SortIndex)
                .IsRequired()
                .HasColumnName("SORT_INDEX")
                .HasColumnType("int(11)");

            builder.Property(t => t.BayTransferPlanId)
                .HasColumnName("BAY_TRANSFER_PLAN_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TransferStep)
                .IsRequired()
                .HasColumnName("TRANSFER_STEP")
                .HasColumnType("int(11)");

            builder.Property(t => t.PlanState)
                .IsRequired()
                .HasColumnName("PLAN_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ExecState)
                .IsRequired()
                .HasColumnName("EXEC_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ResolveState)
                .IsRequired()
                .HasColumnName("RESOLVE_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.PriorityOperator)
                .IsRequired()
                .HasColumnName("PRIORITY_OPERATOR")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadLocationId)
                .HasColumnName("LOAD_LOCATION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LoadLocationName)
                .HasColumnName("LOAD_LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UnloadLocationId)
                .HasColumnName("UNLOAD_LOCATION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.UnloadLocationName)
                .HasColumnName("UNLOAD_LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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

            builder.Property(t => t.IsTruckLoadFixed)
                .HasColumnName("IS_TRUCK_LOAD_FIXED")
                .HasColumnType("int(11)");

            builder.Property(t => t.TruckNo)
                .HasColumnName("TRUCK_NO")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.BayTWhBay)
                .WithMany(t => t.BayTPlBays)
                .HasForeignKey(d => d.BayId)
                .HasConstraintName("FK_PL_BAY_FROM_BAY");

            builder.HasOne(t => t.LoadLocationTWhLocation)
                .WithMany(t => t.LoadLocationTPlBays)
                .HasForeignKey(d => d.LoadLocationId)
                .HasConstraintName("FK_PL_BAY_LOAD");

            builder.HasOne(t => t.PlanTypeTWhPlanType)
                .WithMany(t => t.PlanTypeTPlBays)
                .HasForeignKey(d => d.PlanTypeId)
                .HasConstraintName("FK_PL_BAY_PLAN_TYPE");

            builder.HasOne(t => t.MaterialTPlMaterial)
                .WithMany(t => t.MaterialTPlBays)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_PL_BAY_PL_MATERIAL");

            builder.HasOne(t => t.UnloadLocationTWhLocation)
                .WithMany(t => t.UnloadLocationTPlBays)
                .HasForeignKey(d => d.UnloadLocationId)
                .HasConstraintName("FK_PL_BAY_UNLOAD");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlBay" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlBay" /></summary>
            public const string Name = "t_pl_bay";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.PlanNo" /></summary>
            public const string PlanNo = "PLAN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.PlanTypeId" /></summary>
            public const string PlanTypeId = "PLAN_TYPE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.PlanTypeName" /></summary>
            public const string PlanTypeName = "PLAN_TYPE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.SortIndex" /></summary>
            public const string SortIndex = "SORT_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.BayTransferPlanId" /></summary>
            public const string BayTransferPlanId = "BAY_TRANSFER_PLAN_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.TransferStep" /></summary>
            public const string TransferStep = "TRANSFER_STEP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.PlanState" /></summary>
            public const string PlanState = "PLAN_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.ExecState" /></summary>
            public const string ExecState = "EXEC_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.ResolveState" /></summary>
            public const string ResolveState = "RESOLVE_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.PriorityOperator" /></summary>
            public const string PriorityOperator = "PRIORITY_OPERATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.LoadLocationId" /></summary>
            public const string LoadLocationId = "LOAD_LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.LoadLocationName" /></summary>
            public const string LoadLocationName = "LOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.UnloadLocationId" /></summary>
            public const string UnloadLocationId = "UNLOAD_LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.UnloadLocationName" /></summary>
            public const string UnloadLocationName = "UNLOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.Remark" /></summary>
            public const string Remark = "REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.IsTruckLoadFixed" /></summary>
            public const string IsTruckLoadFixed = "IS_TRUCK_LOAD_FIXED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBay.TruckNo" /></summary>
            public const string TruckNo = "TRUCK_NO";
        }
        #endregion
    }
}
