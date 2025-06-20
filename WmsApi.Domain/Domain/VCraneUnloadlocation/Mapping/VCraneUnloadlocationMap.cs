using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation" />
    /// </summary>
    public partial class VCraneUnloadlocationMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.VCraneUnloadlocation>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.VCraneUnloadlocation> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("v_crane_unloadlocation");

            // key
            builder.HasNoKey();

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

            builder.Property(t => t.CraneName)
                .HasColumnName("CRANE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.PlanTypeName)
                .HasColumnName("PLAN_TYPE_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.LoadLocationName)
                .HasColumnName("LOAD_LOCATION_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.UnloadLocationName)
                .HasColumnName("UNLOAD_LOCATION_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CreateTypeDesc)
                .IsRequired()
                .HasColumnName("CREATE_TYPE_DESC")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.UpdateTypeDesc)
                .HasColumnName("UPDATE_TYPE_DESC")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.BayName)
                .HasColumnName("BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ExecState)
                .HasColumnName("EXEC_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.TeamName)
                .HasColumnName("TEAM_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ShiftName)
                .HasColumnName("SHIFT_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.UserName)
                .HasColumnName("USER_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

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

            builder.Property(t => t.PointX)
                .IsRequired()
                .HasColumnName("POINT_X")
                .HasColumnType("decimal(10,3)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation" /></summary>
            public const string Name = "v_crane_unloadlocation";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.TaskNo" /></summary>
            public const string TaskNo = "TASK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.PlanTypeName" /></summary>
            public const string PlanTypeName = "PLAN_TYPE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.LoadLocationName" /></summary>
            public const string LoadLocationName = "LOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.UnloadLocationName" /></summary>
            public const string UnloadLocationName = "UNLOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.CreateTypeDesc" /></summary>
            public const string CreateTypeDesc = "CREATE_TYPE_DESC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.UpdateTypeDesc" /></summary>
            public const string UpdateTypeDesc = "UPDATE_TYPE_DESC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.ExecState" /></summary>
            public const string ExecState = "EXEC_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.StartTime" /></summary>
            public const string StartTime = "START_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.EndTime" /></summary>
            public const string EndTime = "END_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.TeamName" /></summary>
            public const string TeamName = "TEAM_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.ShiftName" /></summary>
            public const string ShiftName = "SHIFT_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.UserName" /></summary>
            public const string UserName = "USER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.Remark" /></summary>
            public const string Remark = "REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation.PointX" /></summary>
            public const string PointX = "POINT_X";
        }
        #endregion
    }
}
