using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TTrMessageSend" />
    /// </summary>
    public partial class TTrMessageSendMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TTrMessageSend>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TTrMessageSend" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TTrMessageSend> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_message_send");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MessageId)
                .IsRequired()
                .HasColumnName("MESSAGE_ID")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.FromLocation)
                .HasColumnName("FROM_LOCATION")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.DestLocation)
                .HasColumnName("DEST_LOCATION")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.BusinessName)
                .HasColumnName("BUSINESS_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Area)
                .HasColumnName("AREA")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Row)
                .HasColumnName("ROW")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Col)
                .HasColumnName("COL")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Floor)
                .HasColumnName("FLOOR")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.Type)
                .HasColumnName("TYPE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Operator)
                .HasColumnName("OPERATOR")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ReturnType)
                .HasColumnName("RETURN_TYPE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ReturnReason)
                .HasColumnName("RETURN_REASON")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrMessageSend" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrMessageSend" /></summary>
            public const string Name = "t_tr_message_send";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.MessageId" /></summary>
            public const string MessageId = "MESSAGE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.FromLocation" /></summary>
            public const string FromLocation = "FROM_LOCATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.DestLocation" /></summary>
            public const string DestLocation = "DEST_LOCATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.BusinessName" /></summary>
            public const string BusinessName = "BUSINESS_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.Area" /></summary>
            public const string Area = "AREA";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.Row" /></summary>
            public const string Row = "ROW";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.Col" /></summary>
            public const string Col = "COL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.Floor" /></summary>
            public const string Floor = "FLOOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.Operator" /></summary>
            public const string Operator = "OPERATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.ReturnType" /></summary>
            public const string ReturnType = "RETURN_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.ReturnReason" /></summary>
            public const string ReturnReason = "RETURN_REASON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageSend.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
