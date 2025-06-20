using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TWhError" />
    /// </summary>
    public partial class TWhErrorMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TWhError>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TWhError" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TWhError> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_error");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.SourceType)
                .IsRequired()
                .HasColumnName("SOURCE_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ErrorCode)
                .IsRequired()
                .HasColumnName("ERROR_CODE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ErrorMessage)
                .IsRequired()
                .HasColumnName("ERROR_MESSAGE")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhError" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhError" /></summary>
            public const string Name = "t_wh_error";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.SourceType" /></summary>
            public const string SourceType = "SOURCE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.ErrorCode" /></summary>
            public const string ErrorCode = "ERROR_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.ErrorMessage" /></summary>
            public const string ErrorMessage = "ERROR_MESSAGE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhError.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
