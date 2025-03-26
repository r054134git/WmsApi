using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlAutoCode" />
	/// </summary>
	public partial class TPlAutoCodeMap
        : IEntityTypeConfiguration<Entities.TPlAutoCode>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlAutoCode" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlAutoCode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_auto_code");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CodeType)
                .IsRequired()
                .HasColumnName("CODE_TYPE")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Owner)
                .IsRequired()
                .HasColumnName("OWNER")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.InitNum)
                .HasColumnName("INIT_NUM")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.InitCycle)
                .IsRequired()
                .HasColumnName("INIT_CYCLE")
                .HasColumnType("char(1)")
                .HasMaxLength(1);

            builder.Property(t => t.CurSernum)
                .IsRequired()
                .HasColumnName("CUR_SERNUM")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.ZeroFlg)
                .IsRequired()
                .HasColumnName("ZERO_FLG")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.SequenceStyle)
                .HasColumnName("SEQUENCE_STYLE")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Memo)
                .HasColumnName("MEMO")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.LastDate)
                .HasColumnName("LAST_DATE")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlAutoCode" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlAutoCode" /></summary>
            public const string Name = "t_pl_auto_code";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.CodeType" /></summary>
            public const string CodeType = "CODE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.Owner" /></summary>
            public const string Owner = "OWNER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.InitNum" /></summary>
            public const string InitNum = "INIT_NUM";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.InitCycle" /></summary>
            public const string InitCycle = "INIT_CYCLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.CurSernum" /></summary>
            public const string CurSernum = "CUR_SERNUM";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.ZeroFlg" /></summary>
            public const string ZeroFlg = "ZERO_FLG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.SequenceStyle" /></summary>
            public const string SequenceStyle = "SEQUENCE_STYLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.Memo" /></summary>
            public const string Memo = "MEMO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlAutoCode.LastDate" /></summary>
            public const string LastDate = "LAST_DATE";
        }
        #endregion
    }
}
