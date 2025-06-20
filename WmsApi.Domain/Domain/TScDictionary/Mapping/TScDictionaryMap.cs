using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TScDictionary" />
    /// </summary>
    public partial class TScDictionaryMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TScDictionary>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TScDictionary" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TScDictionary> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_sc_dictionary");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Key)
                .IsRequired()
                .HasColumnName("KEY")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Value)
                .IsRequired()
                .HasColumnName("VALUE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Seq)
                .IsRequired()
                .HasColumnName("SEQ")
                .HasColumnType("int(11)");

            builder.Property(t => t.Owner)
                .HasColumnName("OWNER")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            // relationships
            builder.HasOne(t => t.OwnerTScDictionary)
                .WithMany(t => t.OwnerTScDictionaries)
                .HasForeignKey(d => d.Owner)
                .HasConstraintName("FK_SC_DICT");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TScDictionary" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TScDictionary" /></summary>
            public const string Name = "t_sc_dictionary";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScDictionary.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScDictionary.Key" /></summary>
            public const string Key = "KEY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScDictionary.Value" /></summary>
            public const string Value = "VALUE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScDictionary.Seq" /></summary>
            public const string Seq = "SEQ";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScDictionary.Owner" /></summary>
            public const string Owner = "OWNER";
        }
        #endregion
    }
}
