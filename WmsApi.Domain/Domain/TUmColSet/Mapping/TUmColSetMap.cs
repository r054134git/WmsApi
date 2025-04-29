using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TUmColSet" />
    /// </summary>
    public partial class TUmColSetMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TUmColSet>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TUmColSet" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TUmColSet> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_um_col_set");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("TITLE")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.DataIndex)
                .IsRequired()
                .HasColumnName("DATA_INDEX")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.HideInSearch)
                .HasColumnName("HIDE_IN_SEARCH")
                .HasColumnType("int(1)");

            builder.Property(t => t.HideInTable)
                .HasColumnName("HIDE_IN_TABLE")
                .HasColumnType("int(1)");

            builder.Property(t => t.Filters)
                .HasColumnName("FILTERS")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Selects)
                .HasColumnName("SELECTS")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("int(3)");

            builder.Property(t => t.Sort)
                .HasColumnName("SORT")
                .HasColumnType("int(3)");

            builder.Property(t => t.HideInEdit)
                .HasColumnName("HIDE_IN_EDIT")
                .HasColumnType("int(1)");

            builder.Property(t => t.Rules)
                .HasColumnName("RULES")
                .HasColumnType("int(11)");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TUmColSet" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TUmColSet" /></summary>
            public const string Name = "t_um_col_set";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.TableName" /></summary>
            public const string TableName = "TABLE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Title" /></summary>
            public const string Title = "TITLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.DataIndex" /></summary>
            public const string DataIndex = "DATA_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.HideInSearch" /></summary>
            public const string HideInSearch = "HIDE_IN_SEARCH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.HideInTable" /></summary>
            public const string HideInTable = "HIDE_IN_TABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Filters" /></summary>
            public const string Filters = "FILTERS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Selects" /></summary>
            public const string Selects = "SELECTS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Sort" /></summary>
            public const string Sort = "SORT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.HideInEdit" /></summary>
            public const string HideInEdit = "HIDE_IN_EDIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Rules" /></summary>
            public const string Rules = "RULES";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmColSet.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
