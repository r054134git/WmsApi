using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TRlDispatchRules" />
	/// </summary>
	public partial class TRlDispatchRulesMap
        : IEntityTypeConfiguration<Entities.TRlDispatchRules>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TRlDispatchRules" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TRlDispatchRules> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rl_dispatch_rules");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.NextProcess)
                .IsRequired()
                .HasColumnName("NEXT_PROCESS")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.WidthMin)
                .HasColumnName("WIDTH_MIN")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.WidthMax)
                .HasColumnName("WIDTH_MAX")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.ThickMin)
                .HasColumnName("THICK_MIN")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.ThickMax)
                .HasColumnName("THICK_MAX")
                .HasColumnType("decimal(10,3)");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRlDispatchRules" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRlDispatchRules" /></summary>
            public const string Name = "t_rl_dispatch_rules";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.NextProcess" /></summary>
            public const string NextProcess = "NEXT_PROCESS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.WidthMin" /></summary>
            public const string WidthMin = "WIDTH_MIN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.WidthMax" /></summary>
            public const string WidthMax = "WIDTH_MAX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.ThickMin" /></summary>
            public const string ThickMin = "THICK_MIN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.ThickMax" /></summary>
            public const string ThickMax = "THICK_MAX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlDispatchRules.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
