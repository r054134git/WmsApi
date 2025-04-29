using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.Tagcopylist" />
    /// </summary>
    public partial class TagcopylistMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.Tagcopylist>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.Tagcopylist" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.Tagcopylist> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tagcopylist");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CoilNo)
                .IsRequired()
                .HasColumnName("CoilNo")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ProdCName)
                .HasColumnName("ProdCName")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.SgStd)
                .HasColumnName("SgStd")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Edge)
                .IsRequired()
                .HasColumnName("Edge")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.NewWt)
                .HasColumnName("NewWt")
                .HasColumnType("double(20,2)");

            builder.Property(t => t.GgossWt)
                .HasColumnName("GgossWt")
                .HasColumnType("double(20,2)");

            builder.Property(t => t.CodeDesc1Content)
                .HasColumnName("CodeDesc1Content")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.ProdTime)
                .IsRequired()
                .HasColumnName("ProdTime")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.Tagcopylist" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.Tagcopylist" /></summary>
            public const string Name = "tagcopylist";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.CoilNo" /></summary>
            public const string CoilNo = "CoilNo";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.ProdCName" /></summary>
            public const string ProdCName = "ProdCName";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.SgStd" /></summary>
            public const string SgStd = "SgStd";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.Edge" /></summary>
            public const string Edge = "Edge";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.NewWt" /></summary>
            public const string NewWt = "NewWt";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.GgossWt" /></summary>
            public const string GgossWt = "GgossWt";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.CodeDesc1Content" /></summary>
            public const string CodeDesc1Content = "CodeDesc1Content";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tagcopylist.ProdTime" /></summary>
            public const string ProdTime = "ProdTime";
        }
        #endregion
    }
}
