using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlFinishLine" />
	/// </summary>
	public partial class TPlFinishLineMap
        : IEntityTypeConfiguration<Entities.TPlFinishLine>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlFinishLine" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlFinishLine> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_finish_line");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LineNo)
                .HasColumnName("LINE_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.PlanNo)
                .HasColumnName("PLAN_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.PlanState)
                .HasColumnName("PLAN_STATE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PlanType)
                .HasColumnName("PLAN_TYPE")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialSortIndex)
                .HasColumnName("MATERIAL_SORT_INDEX")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlFinishLine" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlFinishLine" /></summary>
            public const string Name = "t_pl_finish_line";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.LineNo" /></summary>
            public const string LineNo = "LINE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.PlanNo" /></summary>
            public const string PlanNo = "PLAN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.PlanState" /></summary>
            public const string PlanState = "PLAN_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.PlanType" /></summary>
            public const string PlanType = "PLAN_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.MaterialSortIndex" /></summary>
            public const string MaterialSortIndex = "MATERIAL_SORT_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlFinishLine.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
