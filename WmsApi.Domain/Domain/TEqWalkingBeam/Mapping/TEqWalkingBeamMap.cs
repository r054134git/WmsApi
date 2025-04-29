using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TEqWalkingBeam" />
	/// </summary>
	public partial class TEqWalkingBeamMap
        : IEntityTypeConfiguration<Entities.TEqWalkingBeam>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TEqWalkingBeam" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TEqWalkingBeam> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_eq_walking_beam");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MoveForwardAddress)
                .HasColumnName("MOVE_FORWARD_ADDRESS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.MoveBackwardAddress)
                .HasColumnName("MOVE_BACKWARD_ADDRESS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.GoUpAddress)
                .HasColumnName("GO_UP_ADDRESS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.GoDownAddress)
                .HasColumnName("GO_DOWN_ADDRESS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.LockStatusAddress)
                .HasColumnName("LOCK_STATUS_ADDRESS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.LockCmdAddress)
                .HasColumnName("LOCK_CMD_ADDRESS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.OwnerTWhStack)
                .WithMany(t => t.OwnerTEqWalkingBeams)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_WB_STACK");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TEqWalkingBeam" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TEqWalkingBeam" /></summary>
            public const string Name = "t_eq_walking_beam";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqWalkingBeam.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqWalkingBeam.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqWalkingBeam.MoveForwardAddress" /></summary>
            public const string MoveForwardAddress = "MOVE_FORWARD_ADDRESS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqWalkingBeam.MoveBackwardAddress" /></summary>
            public const string MoveBackwardAddress = "MOVE_BACKWARD_ADDRESS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqWalkingBeam.GoUpAddress" /></summary>
            public const string GoUpAddress = "GO_UP_ADDRESS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqWalkingBeam.GoDownAddress" /></summary>
            public const string GoDownAddress = "GO_DOWN_ADDRESS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqWalkingBeam.LockStatusAddress" /></summary>
            public const string LockStatusAddress = "LOCK_STATUS_ADDRESS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqWalkingBeam.LockCmdAddress" /></summary>
            public const string LockCmdAddress = "LOCK_CMD_ADDRESS";
        }
        #endregion
    }
}
