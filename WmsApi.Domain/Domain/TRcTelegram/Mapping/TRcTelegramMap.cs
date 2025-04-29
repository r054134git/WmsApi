using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TRcTelegram" />
	/// </summary>
	public partial class TRcTelegramMap
        : IEntityTypeConfiguration<Entities.TRcTelegram>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TRcTelegram" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TRcTelegram> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_telegram");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LocalCode)
                .HasColumnName("LOCAL_CODE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PartnerCode)
                .HasColumnName("PARTNER_CODE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.RsType)
                .HasColumnName("RS_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.TelegramId)
                .HasColumnName("TELEGRAM_ID")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.TelegramTime)
                .HasColumnName("TELEGRAM_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.Content)
                .HasColumnName("CONTENT")
                .HasColumnType("varchar(8000)")
                .HasMaxLength(8000);

            builder.Property(t => t.Result)
                .HasColumnName("RESULT")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Response)
                .HasColumnName("RESPONSE")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.LastTime)
                .HasColumnName("LAST_TIME")
                .HasColumnType("datetime");

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
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcTelegram" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcTelegram" /></summary>
            public const string Name = "t_rc_telegram";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.LocalCode" /></summary>
            public const string LocalCode = "LOCAL_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.PartnerCode" /></summary>
            public const string PartnerCode = "PARTNER_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.RsType" /></summary>
            public const string RsType = "RS_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.TelegramId" /></summary>
            public const string TelegramId = "TELEGRAM_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.TelegramTime" /></summary>
            public const string TelegramTime = "TELEGRAM_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.Content" /></summary>
            public const string Content = "CONTENT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.Result" /></summary>
            public const string Result = "RESULT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.Response" /></summary>
            public const string Response = "RESPONSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.LastTime" /></summary>
            public const string LastTime = "LAST_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTelegram.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
