using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrUser" />
	/// </summary>
	public partial class TTrUserMap
        : IEntityTypeConfiguration<Entities.TTrUser>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrUser" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrUser> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_user");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ClientName)
                .HasColumnName("CLIENT_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.LoginUserId)
                .HasColumnName("LOGIN_USER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TeamId)
                .HasColumnName("TEAM_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ShiftId)
                .HasColumnName("SHIFT_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            // relationships
            builder.HasOne(t => t.ShiftTUmShift)
                .WithMany(t => t.ShiftTTrUsers)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("FK_TR_PARAMS_SHIFT");

            builder.HasOne(t => t.TeamTScDictionary)
                .WithMany(t => t.TeamTTrUsers)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK_TR_PARAMS_TEAM");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrUser" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrUser" /></summary>
            public const string Name = "t_tr_user";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrUser.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrUser.ClientName" /></summary>
            public const string ClientName = "CLIENT_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrUser.LoginUserId" /></summary>
            public const string LoginUserId = "LOGIN_USER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrUser.TeamId" /></summary>
            public const string TeamId = "TEAM_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrUser.ShiftId" /></summary>
            public const string ShiftId = "SHIFT_ID";
        }
        #endregion
    }
}
