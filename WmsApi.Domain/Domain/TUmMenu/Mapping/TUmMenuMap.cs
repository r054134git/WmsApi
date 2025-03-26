using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TUmMenu" />
    /// </summary>
    public partial class TUmMenuMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TUmMenu>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TUmMenu" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TUmMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_um_menu");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32)
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Path)
                .HasColumnName("PATH")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255)
                .HasDefaultValueSql("''");

            builder.Property(t => t.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Icon)
                .HasColumnName("ICON")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255)
                .HasDefaultValueSql("''");

            builder.Property(t => t.IsShow)
                .IsRequired()
                .HasColumnName("IS_SHOW")
                .HasColumnType("int(1)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.IsRouter)
                .IsRequired()
                .HasColumnName("IS_ROUTER")
                .HasColumnType("int(1)");

            builder.Property(t => t.Description)
                .HasColumnName("DESCRIPTION")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255)
                .HasDefaultValueSql("''");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TUmMenu" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TUmMenu" /></summary>
            public const string Name = "t_um_menu";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.Code" /></summary>
            public const string Code = "CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.Path" /></summary>
            public const string Path = "PATH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.Seq" /></summary>
            public const string Seq = "SEQ";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.Icon" /></summary>
            public const string Icon = "ICON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.IsShow" /></summary>
            public const string IsShow = "IS_SHOW";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.IsRouter" /></summary>
            public const string IsRouter = "IS_ROUTER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.Description" /></summary>
            public const string Description = "DESCRIPTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmMenu.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
