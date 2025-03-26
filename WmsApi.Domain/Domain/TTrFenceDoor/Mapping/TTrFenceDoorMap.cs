using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrFenceDoor" />
	/// </summary>
	public partial class TTrFenceDoorMap
        : IEntityTypeConfiguration<Entities.TTrFenceDoor>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrFenceDoor" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrFenceDoor> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_fence_door");

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

            builder.Property(t => t.FenceDoorId)
                .IsRequired()
                .HasColumnName("FENCE_DOOR_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.FenceDoorCode)
                .HasColumnName("FENCE_DOOR_CODE")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FenceDoorState)
                .IsRequired()
                .HasColumnName("FENCE_DOOR_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.FenceDoorRequest)
                .IsRequired()
                .HasColumnName("FENCE_DOOR_REQUEST")
                .HasColumnType("int(1)");

            builder.Property(t => t.RequestSource)
                .IsRequired()
                .HasColumnName("REQUEST_SOURCE")
                .HasColumnType("int(1)");

            builder.Property(t => t.RequestUser)
                .HasColumnName("REQUEST_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.RequestTime)
                .HasColumnName("REQUEST_TIME")
                .HasColumnType("datetime");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrFenceDoor" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrFenceDoor" /></summary>
            public const string Name = "t_tr_fence_door";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.FenceId" /></summary>
            public const string FenceId = "FENCE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.FenceDoorId" /></summary>
            public const string FenceDoorId = "FENCE_DOOR_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.FenceDoorCode" /></summary>
            public const string FenceDoorCode = "FENCE_DOOR_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.FenceDoorState" /></summary>
            public const string FenceDoorState = "FENCE_DOOR_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.FenceDoorRequest" /></summary>
            public const string FenceDoorRequest = "FENCE_DOOR_REQUEST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.RequestSource" /></summary>
            public const string RequestSource = "REQUEST_SOURCE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.RequestUser" /></summary>
            public const string RequestUser = "REQUEST_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.RequestTime" /></summary>
            public const string RequestTime = "REQUEST_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrFenceDoor.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
