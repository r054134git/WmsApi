using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrFenceArea" />
	/// </summary>
	public partial class TTrFenceAreaMap
        : IEntityTypeConfiguration<Entities.TTrFenceArea>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrFenceArea" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrFenceArea> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_fence_area");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.FenceId)
                .IsRequired()
                .HasColumnName("FENCE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.FenceSpaceState)
                .IsRequired()
                .HasColumnName("FENCE_SPACE_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.FenceUsers)
                .HasColumnName("FENCE_USERS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.BayId)
                .IsRequired()
                .HasColumnName("BAY_ID")
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
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrFenceArea" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrFenceArea" /></summary>
            public const string Name = "t_tr_fence_area";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.FenceId" /></summary>
            public const string FenceId = "FENCE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.FenceSpaceState" /></summary>
            public const string FenceSpaceState = "FENCE_SPACE_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.FenceUsers" /></summary>
            public const string FenceUsers = "FENCE_USERS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceArea.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
