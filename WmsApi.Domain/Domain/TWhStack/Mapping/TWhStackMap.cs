using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhStack" />
	/// </summary>
	public partial class TWhStackMap
        : IEntityTypeConfiguration<Entities.TWhStack>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhStack" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhStack> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_stack");

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
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Width)
                .IsRequired()
                .HasColumnName("WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.Length)
                .IsRequired()
                .HasColumnName("LENGTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.PointX)
                .IsRequired()
                .HasColumnName("POINT_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.PointY)
                .IsRequired()
                .HasColumnName("POINT_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayId)
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaxFloor)
                .IsRequired()
                .HasColumnName("MAX_FLOOR")
                .HasColumnType("int(11)");

            builder.Property(t => t.UnloadMinWidth)
                .HasColumnName("UNLOAD_MIN_WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.StackNo)
                .IsRequired()
                .HasColumnName("STACK_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.Orientation)
                .IsRequired()
                .HasColumnName("ORIENTATION")
                .HasColumnType("int(11)");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsLockable)
                .HasColumnName("IS_LOCKABLE")
                .HasColumnType("int(11)");

            builder.Property(t => t.AreaNo)
                .HasColumnName("AREA_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.LoadOrder)
                .IsRequired()
                .HasColumnName("LOAD_ORDER")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IS_ENABLE")
                .HasColumnType("int(1)");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.CreateUser)
                .HasColumnName("CREATE_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UpdateTime)
                .HasColumnName("UPDATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Remark)
                .HasColumnName("REMARK")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.OwnerTWhArea)
                .WithMany(t => t.OwnerTWhStacks)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_STACK_BAY");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhStack" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhStack" /></summary>
            public const string Name = "t_wh_stack";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.Length" /></summary>
            public const string Length = "LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.PointX" /></summary>
            public const string PointX = "POINT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.PointY" /></summary>
            public const string PointY = "POINT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.MaxFloor" /></summary>
            public const string MaxFloor = "MAX_FLOOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.UnloadMinWidth" /></summary>
            public const string UnloadMinWidth = "UNLOAD_MIN_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.StackNo" /></summary>
            public const string StackNo = "STACK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.Orientation" /></summary>
            public const string Orientation = "ORIENTATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.IsLockable" /></summary>
            public const string IsLockable = "IS_LOCKABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.AreaNo" /></summary>
            public const string AreaNo = "AREA_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.LoadOrder" /></summary>
            public const string LoadOrder = "LOAD_ORDER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhStack.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
