using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlCraneTask" />
	/// </summary>
	public partial class TPlCraneTaskMap
        : IEntityTypeConfiguration<Entities.TPlCraneTask>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlCraneTask" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlCraneTask> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_crane_task");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TaskNo)
                .HasColumnName("TASK_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.BayId)
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayName)
                .HasColumnName("BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.CraneId)
                .HasColumnName("CRANE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneName)
                .HasColumnName("CRANE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.UserCraneId)
                .HasColumnName("USER_CRANE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialId)
                .HasColumnName("MATERIAL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MatWidth)
                .HasColumnName("MAT_WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.MatDiameter)
                .HasColumnName("MAT_DIAMETER")
                .HasColumnType("int(11)");

            builder.Property(t => t.MatWeight)
                .HasColumnName("MAT_WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadLocationId)
                .HasColumnName("LOAD_LOCATION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LoadLocationName)
                .HasColumnName("LOAD_LOCATION_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.LoadX)
                .HasColumnName("LOAD_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.LoadY)
                .HasColumnName("LOAD_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.LoadZ)
                .HasColumnName("LOAD_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.UnloadLocationId)
                .HasColumnName("UNLOAD_LOCATION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.UnloadLocationName)
                .HasColumnName("UNLOAD_LOCATION_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.UnloadX)
                .HasColumnName("UNLOAD_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.UnloadY)
                .HasColumnName("UNLOAD_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.UnloadZ)
                .HasColumnName("UNLOAD_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.PlanTypeId)
                .HasColumnName("PLAN_TYPE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PlanTypeName)
                .HasColumnName("PLAN_TYPE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.SortIndexInOwner)
                .HasColumnName("SORT_INDEX_IN_OWNER")
                .HasColumnType("int(11)");

            builder.Property(t => t.ExecState)
                .HasColumnName("EXEC_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.PriorityDefault)
                .HasColumnName("PRIORITY_DEFAULT")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.PriorityOperator)
                .HasColumnName("PRIORITY_OPERATOR")
                .HasColumnType("int(11)");

            builder.Property(t => t.AssignState)
                .HasColumnName("ASSIGN_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.CreateType)
                .IsRequired()
                .HasColumnName("CREATE_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.UpdateType)
                .HasColumnName("UPDATE_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsFrozon)
                .HasColumnName("IS_FROZON")
                .HasColumnType("int(1)");

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
            builder.HasOne(t => t.LoadLocationTWhLocation)
                .WithMany(t => t.LoadLocationTPlCraneTasks)
                .HasForeignKey(d => d.LoadLocationId)
                .HasConstraintName("FK_PL_CTASK_LOAD_LOCATION");

            builder.HasOne(t => t.MaterialTPlMaterial)
                .WithMany(t => t.MaterialTPlCraneTasks)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_PL_CTASK_MATERIAL");

            builder.HasOne(t => t.OwnerTPlBay)
                .WithMany(t => t.OwnerTPlCraneTasks)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_PL_CTASK_PL_BAY");

            builder.HasOne(t => t.UnloadLocationTWhLocation)
                .WithMany(t => t.UnloadLocationTPlCraneTasks)
                .HasForeignKey(d => d.UnloadLocationId)
                .HasConstraintName("FK_PL_CTASK_UNLOAD_LOCATION");

            builder.HasOne(t => t.BayTWhBay)
                .WithMany(t => t.BayTPlCraneTasks)
                .HasForeignKey(d => d.BayId)
                .HasConstraintName("FK_PL_CTASK_WH_BAY");

            builder.HasOne(t => t.CraneTEqCrane)
                .WithMany(t => t.CraneTPlCraneTasks)
                .HasForeignKey(d => d.CraneId)
                .HasConstraintName("FK_PL_CTASK_WH_CRANE");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlCraneTask" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlCraneTask" /></summary>
            public const string Name = "t_pl_crane_task";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.TaskNo" /></summary>
            public const string TaskNo = "TASK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.CraneId" /></summary>
            public const string CraneId = "CRANE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UserCraneId" /></summary>
            public const string UserCraneId = "USER_CRANE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.MatWidth" /></summary>
            public const string MatWidth = "MAT_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.MatDiameter" /></summary>
            public const string MatDiameter = "MAT_DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.MatWeight" /></summary>
            public const string MatWeight = "MAT_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.LoadLocationId" /></summary>
            public const string LoadLocationId = "LOAD_LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.LoadLocationName" /></summary>
            public const string LoadLocationName = "LOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.LoadX" /></summary>
            public const string LoadX = "LOAD_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.LoadY" /></summary>
            public const string LoadY = "LOAD_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.LoadZ" /></summary>
            public const string LoadZ = "LOAD_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UnloadLocationId" /></summary>
            public const string UnloadLocationId = "UNLOAD_LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UnloadLocationName" /></summary>
            public const string UnloadLocationName = "UNLOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UnloadX" /></summary>
            public const string UnloadX = "UNLOAD_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UnloadY" /></summary>
            public const string UnloadY = "UNLOAD_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UnloadZ" /></summary>
            public const string UnloadZ = "UNLOAD_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.PlanTypeId" /></summary>
            public const string PlanTypeId = "PLAN_TYPE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.PlanTypeName" /></summary>
            public const string PlanTypeName = "PLAN_TYPE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.SortIndexInOwner" /></summary>
            public const string SortIndexInOwner = "SORT_INDEX_IN_OWNER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.ExecState" /></summary>
            public const string ExecState = "EXEC_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.PriorityDefault" /></summary>
            public const string PriorityDefault = "PRIORITY_DEFAULT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.PriorityOperator" /></summary>
            public const string PriorityOperator = "PRIORITY_OPERATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.AssignState" /></summary>
            public const string AssignState = "ASSIGN_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.CreateType" /></summary>
            public const string CreateType = "CREATE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UpdateType" /></summary>
            public const string UpdateType = "UPDATE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.IsFrozon" /></summary>
            public const string IsFrozon = "IS_FROZON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCraneTask.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
