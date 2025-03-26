using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TUmGroup" />
    /// </summary>
    public partial class TUmGroupMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TUmGroup>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TUmGroup" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TUmGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_um_group");

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

            builder.Property(t => t.Area)
                .IsRequired()
                .HasColumnName("AREA")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.GafferName)
                .IsRequired()
                .HasColumnName("GAFFER_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UserName)
                .IsRequired()
                .HasColumnName("USER_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UserAccount)
                .IsRequired()
                .HasColumnName("USER_ACCOUNT")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TUmGroup" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TUmGroup" /></summary>
            public const string Name = "t_um_group";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.Area" /></summary>
            public const string Area = "AREA";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.GafferName" /></summary>
            public const string GafferName = "GAFFER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.UserName" /></summary>
            public const string UserName = "USER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.UserAccount" /></summary>
            public const string UserAccount = "USER_ACCOUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TUmGroup.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
