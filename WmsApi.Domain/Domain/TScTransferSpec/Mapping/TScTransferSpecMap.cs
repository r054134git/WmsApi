using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TScTransferSpec" />
    /// </summary>
    public partial class TScTransferSpecMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TScTransferSpec>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TScTransferSpec" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TScTransferSpec> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_sc_transfer_spec");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.SpecWidth)
                .HasColumnName("SPEC_WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.BelongSpecWidth)
                .HasColumnName("BELONG_SPEC_WIDTH")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TScTransferSpec" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TScTransferSpec" /></summary>
            public const string Name = "t_sc_transfer_spec";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferSpec.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferSpec.SpecWidth" /></summary>
            public const string SpecWidth = "SPEC_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferSpec.BelongSpecWidth" /></summary>
            public const string BelongSpecWidth = "BELONG_SPEC_WIDTH";
        }
        #endregion
    }
}
