using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.VCraneLocation" />
    /// </summary>
    public partial class VCraneLocationMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.VCraneLocation>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.VCraneLocation" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.VCraneLocation> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("v_crane_location");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.VCraneLocation" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.VCraneLocation" /></summary>
            public const string Name = "v_crane_location";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.TaskNo" /></summary>
            public const string TaskNo = "TASK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.PlanTypeName" /></summary>
            public const string PlanTypeName = "PLAN_TYPE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.LoadLocationName" /></summary>
            public const string LoadLocationName = "LOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.UnloadLocationName" /></summary>
            public const string UnloadLocationName = "UNLOAD_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.CreateTypeDesc" /></summary>
            public const string CreateTypeDesc = "CREATE_TYPE_DESC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.UpdateTypeDesc" /></summary>
            public const string UpdateTypeDesc = "UPDATE_TYPE_DESC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.ExecState" /></summary>
            public const string ExecState = "EXEC_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.StartTime" /></summary>
            public const string StartTime = "START_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.EndTime" /></summary>
            public const string EndTime = "END_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.TeamName" /></summary>
            public const string TeamName = "TEAM_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.ShiftName" /></summary>
            public const string ShiftName = "SHIFT_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.UserName" /></summary>
            public const string UserName = "USER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.Remark" /></summary>
            public const string Remark = "REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCraneLocation.PointX" /></summary>
            public const string PointX = "POINT_X";
        }
        #endregion
    }
}
