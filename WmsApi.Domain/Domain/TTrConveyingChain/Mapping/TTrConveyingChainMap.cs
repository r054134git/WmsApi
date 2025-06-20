using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrConveyingChain" />
	/// </summary>
	public partial class TTrConveyingChainMap
        : IEntityTypeConfiguration<Entities.TTrConveyingChain>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrConveyingChain" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrConveyingChain> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_conveying_chain");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialId)
                .HasColumnName("MATERIAL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LocationId)
                .HasColumnName("LOCATION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OnlineTime)
                .HasColumnName("ONLINE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.ConveyorId)
                .HasColumnName("CONVEYOR_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            // relationships
            builder.HasOne(t => t.LocationTWhLocation)
                .WithMany(t => t.LocationTTrConveyingChains)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_TR_CHAIN_CURRENT_LOCATION");

            builder.HasOne(t => t.MaterialTPlMaterial)
                .WithMany(t => t.MaterialTTrConveyingChains)
                .HasForeignKey(d => d.MaterialId)
                .HasConstraintName("FK_TR_CHAIN_MATERIAL");

            builder.HasOne(t => t.ConveyorTWhStack)
                .WithMany(t => t.ConveyorTTrConveyingChains)
                .HasForeignKey(d => d.ConveyorId)
                .HasConstraintName("FK_TR_CHAIN_STACK");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrConveyingChain" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrConveyingChain" /></summary>
            public const string Name = "t_tr_conveying_chain";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrConveyingChain.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrConveyingChain.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrConveyingChain.LocationId" /></summary>
            public const string LocationId = "LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrConveyingChain.OnlineTime" /></summary>
            public const string OnlineTime = "ONLINE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrConveyingChain.ConveyorId" /></summary>
            public const string ConveyorId = "CONVEYOR_ID";
        }
        #endregion
    }
}
