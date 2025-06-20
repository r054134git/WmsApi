using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.VCompareNameNo" />
    /// </summary>
    public partial class VCompareNameNoMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.VCompareNameNo>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.VCompareNameNo" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.VCompareNameNo> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("v_compare_name_no");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.LocationNameWms)
                .IsRequired()
                .HasColumnName("LOCATION_NAME_WMS")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255)
                .HasDefaultValueSql("''");

            builder.Property(t => t.LocationNameMes)
                .HasColumnName("LOCATION_NAME_MES")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.MatNoWms)
                .HasColumnName("MAT_NO_WMS")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MatNoMes)
                .HasColumnName("MAT_NO_MES")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.IsEnableWms)
                .IsRequired()
                .HasColumnName("IS_ENABLE_WMS")
                .HasColumnType("int(11)");

            builder.Property(t => t.BayIdWms)
                .IsRequired()
                .HasColumnName("BAY_ID_WMS")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32)
                .HasDefaultValueSql("''");

            builder.Property(t => t.StockNoWms)
                .IsRequired()
                .HasColumnName("STOCK_NO_WMS")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32)
                .HasDefaultValueSql("''");

            builder.Property(t => t.StockNoMes)
                .HasColumnName("STOCK_NO_MES")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("type")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.VCompareNameNo" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.VCompareNameNo" /></summary>
            public const string Name = "v_compare_name_no";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.LocationNameWms" /></summary>
            public const string LocationNameWms = "LOCATION_NAME_WMS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.LocationNameMes" /></summary>
            public const string LocationNameMes = "LOCATION_NAME_MES";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.MatNoWms" /></summary>
            public const string MatNoWms = "MAT_NO_WMS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.MatNoMes" /></summary>
            public const string MatNoMes = "MAT_NO_MES";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.IsEnableWms" /></summary>
            public const string IsEnableWms = "IS_ENABLE_WMS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.BayIdWms" /></summary>
            public const string BayIdWms = "BAY_ID_WMS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.StockNoWms" /></summary>
            public const string StockNoWms = "STOCK_NO_WMS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.StockNoMes" /></summary>
            public const string StockNoMes = "STOCK_NO_MES";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VCompareNameNo.Type" /></summary>
            public const string Type = "type";
        }
        #endregion
    }
}
