using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TTrMessageReceived" />
    /// </summary>
    public partial class TTrMessageReceivedMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TTrMessageReceived>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TTrMessageReceived" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TTrMessageReceived> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_message_received");

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

            builder.Property(t => t.MessageContent)
                .IsRequired()
                .HasColumnName("MESSAGE_CONTENT")
                .HasColumnType("varchar(4096)")
                .HasMaxLength(4096);

            builder.Property(t => t.SummaryInfo)
                .HasColumnName("SUMMARY_INFO")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SendState)
                .IsRequired()
                .HasColumnName("SEND_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.SendCount)
                .HasColumnName("SEND_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.SendTime)
                .HasColumnName("SEND_TIME")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrMessageReceived" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrMessageReceived" /></summary>
            public const string Name = "t_tr_message_received";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.MessageId" /></summary>
            public const string MessageId = "MESSAGE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.MessageContent" /></summary>
            public const string MessageContent = "MESSAGE_CONTENT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.SummaryInfo" /></summary>
            public const string SummaryInfo = "SUMMARY_INFO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.SendState" /></summary>
            public const string SendState = "SEND_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.SendCount" /></summary>
            public const string SendCount = "SEND_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.SendTime" /></summary>
            public const string SendTime = "SEND_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrMessageReceived.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
