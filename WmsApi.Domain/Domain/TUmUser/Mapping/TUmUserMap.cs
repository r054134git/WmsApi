using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TUmUser" />
    /// </summary>
    public partial class TUmUserMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TUmUser>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TUmUser" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TUmUser> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_um_user");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Account)
                .IsRequired()
                .HasColumnName("ACCOUNT")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Password)
                .IsRequired()
                .HasColumnName("PASSWORD")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.TeamId)
                .IsRequired()
                .HasColumnName("TEAM_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Department)
                .HasColumnName("Department")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.RoleId)
                .IsRequired()
                .HasColumnName("ROLE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LastLoginTime)
                .HasColumnName("LAST_LOGIN_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.BayIdNameList)
                .HasColumnName("BAY_ID_NAME_LIST")
                .HasColumnType("varchar(1024)")
                .HasMaxLength(1024);

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
            builder.HasOne(t => t.RoleTUmRole)
                .WithMany(t => t.RoleTUmUsers)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_USER_ROLE");

            builder.HasOne(t => t.TeamTScDictionary)
                .WithMany(t => t.TeamTUmUsers)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK_USER_TEAM");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TUmUser" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TUmUser" /></summary>
            public const string Name = "t_um_user";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.Account" /></summary>
            public const string Account = "ACCOUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.Password" /></summary>
            public const string Password = "PASSWORD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.TeamId" /></summary>
            public const string TeamId = "TEAM_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.Department" /></summary>
            public const string Department = "Department";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.RoleId" /></summary>
            public const string RoleId = "ROLE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.LastLoginTime" /></summary>
            public const string LastLoginTime = "LAST_LOGIN_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.BayIdNameList" /></summary>
            public const string BayIdNameList = "BAY_ID_NAME_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmUser.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
