using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcBay" />
    /// </summary>
    public partial class TRcBayMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcBay>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcBay" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcBay> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_bay");

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

            builder.Property(t => t.LoadX)
                .HasColumnName("LOAD_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.LoadY)
                .HasColumnName("LOAD_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.UnloadLocationId)
                .HasColumnName("UNLOAD_LOCATION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.UnloadLocationName)
                .HasColumnName("UNLOAD_LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UnloadX)
                .HasColumnName("UNLOAD_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.UnloadY)
                .HasColumnName("UNLOAD_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.InOutType)
                .HasColumnName("IN_OUT_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.UserAccount)
                .HasColumnName("USER_ACCOUNT")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Shift)
                .HasColumnName("SHIFT")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Team)
                .HasColumnName("TEAM")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.FinishType)
                .HasColumnName("FINISH_TYPE")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcBay" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcBay" /></summary>
            public const string Name = "t_rc_bay";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.PlanNo" /></summary>
            public const string PlanNo = "PLAN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.PlanTypeId" /></summary>
            public const string PlanTypeId = "PLAN_TYPE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.PlanTypeName" /></summary>
            public const string PlanTypeName = "PLAN_TYPE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.SortIndex" /></summary>
            public const string SortIndex = "SORT_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.BayTransferPlanId" /></summary>
            public const string BayTransferPlanId = "BAY_TRANSFER_PLAN_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.TransferStep" /></summary>
            public const string TransferStep = "TRANSFER_STEP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.PlanState" /></summary>
            public const string PlanState = "PLAN_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.ExecState" /></summary>
            public const string ExecState = "EXEC_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.ResolveState" /></summary>
            public const string ResolveState = "RESOLVE_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.PriorityOperator" /></summary>
            public const string PriorityOperator = "PRIORITY_OPERATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.LoadLocationId" /></summary>
            public const string LoadLocationId = "LOAD_LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.LoadLocationName" /></summary>
            public const string LoadLocationName = "LOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.LoadX" /></summary>
            public const string LoadX = "LOAD_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.LoadY" /></summary>
            public const string LoadY = "LOAD_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.UnloadLocationId" /></summary>
            public const string UnloadLocationId = "UNLOAD_LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.UnloadLocationName" /></summary>
            public const string UnloadLocationName = "UNLOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.UnloadX" /></summary>
            public const string UnloadX = "UNLOAD_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.UnloadY" /></summary>
            public const string UnloadY = "UNLOAD_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.InOutType" /></summary>
            public const string InOutType = "IN_OUT_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.StartTime" /></summary>
            public const string StartTime = "START_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.EndTime" /></summary>
            public const string EndTime = "END_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.UserAccount" /></summary>
            public const string UserAccount = "USER_ACCOUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.Shift" /></summary>
            public const string Shift = "SHIFT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.Team" /></summary>
            public const string Team = "TEAM";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.FinishType" /></summary>
            public const string FinishType = "FINISH_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcBay.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
