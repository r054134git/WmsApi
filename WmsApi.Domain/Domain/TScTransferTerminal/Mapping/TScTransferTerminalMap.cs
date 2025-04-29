using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TScTransferTerminal" />
    /// </summary>
    public partial class TScTransferTerminalMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TScTransferTerminal>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TScTransferTerminal" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TScTransferTerminal> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_sc_transfer_terminal");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CodeNumber)
                .HasColumnName("CODE_NUMBER")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Code)
                .HasColumnName("CODE")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.CityName)
                .HasColumnName("CITY_NAME")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.BelongCityName)
                .HasColumnName("BELONG_CITY_NAME")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.IsEnable)
                .HasColumnName("IS_ENABLE")
                .HasColumnType("int(1)");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.CreateUser)
                .HasColumnName("CREATE_USER")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.UpdateTime)
                .HasColumnName("UPDATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.UpdateUser)
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TScTransferTerminal" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TScTransferTerminal" /></summary>
            public const string Name = "t_sc_transfer_terminal";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.CodeNumber" /></summary>
            public const string CodeNumber = "CODE_NUMBER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.Code" /></summary>
            public const string Code = "CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.CityName" /></summary>
            public const string CityName = "CITY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.BelongCityName" /></summary>
            public const string BelongCityName = "BELONG_CITY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScTransferTerminal.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
