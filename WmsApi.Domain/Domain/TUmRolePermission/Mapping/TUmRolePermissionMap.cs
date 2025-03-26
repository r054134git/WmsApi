using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TUmRolePermission" />
	/// </summary>
	public partial class TUmRolePermissionMap
        : IEntityTypeConfiguration<Entities.TUmRolePermission>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TUmRolePermission" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TUmRolePermission> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_um_role_permission");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.RoleId)
                .HasColumnName("ROLE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PermissionId)
                .HasColumnName("PERMISSION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

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
            builder.HasOne(t => t.PermissionTUmMenu)
                .WithMany(t => t.PermissionTUmRolePermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_UM_MENU");

            builder.HasOne(t => t.RoleTUmRole)
                .WithMany(t => t.RoleTUmRolePermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_UM_ROLE");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TUmRolePermission" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TUmRolePermission" /></summary>
            public const string Name = "t_um_role_permission";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.RoleId" /></summary>
            public const string RoleId = "ROLE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.PermissionId" /></summary>
            public const string PermissionId = "PERMISSION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmRolePermission.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
