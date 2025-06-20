using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TRlRegionRange" />
	/// </summary>
	public partial class TRlRegionRangeMap
        : IEntityTypeConfiguration<Entities.TRlRegionRange>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TRlRegionRange" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TRlRegionRange> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rl_region_range");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Region)
                .HasColumnName("REGION")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.RowMin)
                .HasColumnName("ROW_MIN")
                .HasColumnType("int(11)");

            builder.Property(t => t.RowMax)
                .HasColumnName("ROW_MAX")
                .HasColumnType("int(11)");

            builder.Property(t => t.ColMax)
                .HasColumnName("COL_MAX")
                .HasColumnType("int(11)");

            builder.Property(t => t.ColMin)
                .HasColumnName("COL_MIN")
                .HasColumnType("int(11)");

            builder.Property(t => t.SortIndex)
                .HasColumnName("SORT_INDEX")
                .HasColumnType("int(11)");

            builder.Property(t => t.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.RowOrderType)
                .HasColumnName("ROW_ORDER_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ColOrderType)
                .HasColumnName("COL_ORDER_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsFillFirst)
                .HasColumnName("IS_FILL_FIRST")
                .HasColumnType("int(11)");

            builder.Property(t => t.StationNo)
                .HasColumnName("STATION_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.AllowL2)
                .HasColumnName("ALLOW_L2")
                .HasColumnType("int(11)");

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
            builder.HasOne(t => t.OwnerTRlDispatchRules)
                .WithMany(t => t.OwnerTRlRegionRanges)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_RANGE_RULE");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRlRegionRange" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRlRegionRange" /></summary>
            public const string Name = "t_rl_region_range";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.Region" /></summary>
            public const string Region = "REGION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.RowMin" /></summary>
            public const string RowMin = "ROW_MIN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.RowMax" /></summary>
            public const string RowMax = "ROW_MAX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.ColMax" /></summary>
            public const string ColMax = "COL_MAX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.ColMin" /></summary>
            public const string ColMin = "COL_MIN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.SortIndex" /></summary>
            public const string SortIndex = "SORT_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.RowOrderType" /></summary>
            public const string RowOrderType = "ROW_ORDER_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.ColOrderType" /></summary>
            public const string ColOrderType = "COL_ORDER_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.IsFillFirst" /></summary>
            public const string IsFillFirst = "IS_FILL_FIRST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.StationNo" /></summary>
            public const string StationNo = "STATION_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.AllowL2" /></summary>
            public const string AllowL2 = "ALLOW_L2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlRegionRange.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
