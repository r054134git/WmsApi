using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRlCranePlanType" />
    /// </summary>
    public partial class TRlCranePlanTypeMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRlCranePlanType>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRlCranePlanType" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRlCranePlanType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rl_crane_plan_type");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneId)
                .HasColumnName("CRANE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneName)
                .HasColumnName("CRANE_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PlanTypeName1)
                .HasColumnName("PLAN_TYPE_NAME1")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName2)
                .HasColumnName("PLAN_TYPE_NAME2")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName3)
                .HasColumnName("PLAN_TYPE_NAME3")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName4)
                .HasColumnName("PLAN_TYPE_NAME4")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName5)
                .HasColumnName("PLAN_TYPE_NAME5")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName6)
                .HasColumnName("PLAN_TYPE_NAME6")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName7)
                .HasColumnName("PLAN_TYPE_NAME7")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName8)
                .HasColumnName("PLAN_TYPE_NAME8")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName9)
                .HasColumnName("PLAN_TYPE_NAME9")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName10)
                .HasColumnName("PLAN_TYPE_NAME10")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName11)
                .HasColumnName("PLAN_TYPE_NAME11")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PlanTypeName12)
                .HasColumnName("PLAN_TYPE_NAME12")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.AreaCode)
                .HasColumnName("AREA_CODE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UnloadAreaCode)
                .HasColumnName("UNLOAD_AREA_CODE")
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

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRlCranePlanType" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRlCranePlanType" /></summary>
            public const string Name = "t_rl_crane_plan_type";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.CraneId" /></summary>
            public const string CraneId = "CRANE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName1" /></summary>
            public const string PlanTypeName1 = "PLAN_TYPE_NAME1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName2" /></summary>
            public const string PlanTypeName2 = "PLAN_TYPE_NAME2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName3" /></summary>
            public const string PlanTypeName3 = "PLAN_TYPE_NAME3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName4" /></summary>
            public const string PlanTypeName4 = "PLAN_TYPE_NAME4";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName5" /></summary>
            public const string PlanTypeName5 = "PLAN_TYPE_NAME5";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName6" /></summary>
            public const string PlanTypeName6 = "PLAN_TYPE_NAME6";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName7" /></summary>
            public const string PlanTypeName7 = "PLAN_TYPE_NAME7";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName8" /></summary>
            public const string PlanTypeName8 = "PLAN_TYPE_NAME8";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName9" /></summary>
            public const string PlanTypeName9 = "PLAN_TYPE_NAME9";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName10" /></summary>
            public const string PlanTypeName10 = "PLAN_TYPE_NAME10";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName11" /></summary>
            public const string PlanTypeName11 = "PLAN_TYPE_NAME11";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.PlanTypeName12" /></summary>
            public const string PlanTypeName12 = "PLAN_TYPE_NAME12";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.AreaCode" /></summary>
            public const string AreaCode = "AREA_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.UnloadAreaCode" /></summary>
            public const string UnloadAreaCode = "UNLOAD_AREA_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlCranePlanType.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
