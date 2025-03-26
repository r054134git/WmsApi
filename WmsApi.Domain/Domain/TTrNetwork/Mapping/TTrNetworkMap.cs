using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TTrNetwork" />
    /// </summary>
    public partial class TTrNetworkMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TTrNetwork>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TTrNetwork" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TTrNetwork> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_network");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IpAddress)
                .HasColumnName("IP_ADDRESS")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IsConnected)
                .IsRequired()
                .HasColumnName("IS_CONNECTED")
                .HasColumnType("int(1)");

            builder.Property(t => t.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.IsEnable)
                .IsRequired()
                .HasColumnName("IS_ENABLE")
                .HasColumnType("int(1)");

            builder.Property(t => t.Sort)
                .IsRequired()
                .HasColumnName("SORT")
                .HasColumnType("int(11)");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrNetwork" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrNetwork" /></summary>
            public const string Name = "t_tr_network";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.IpAddress" /></summary>
            public const string IpAddress = "IP_ADDRESS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.IsConnected" /></summary>
            public const string IsConnected = "IS_CONNECTED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.Sort" /></summary>
            public const string Sort = "SORT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrNetwork.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
