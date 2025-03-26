using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRlTransferPrewired" />
    /// </summary>
    public partial class TRlTransferPrewiredMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRlTransferPrewired>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRlTransferPrewired" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRlTransferPrewired> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rl_transfer_prewired");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.StowageType)
                .HasColumnName("STOWAGE_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsDistributionShip)
                .HasColumnName("IS_DISTRIBUTION_SHIP")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsSpec)
                .HasColumnName("IS_SPEC")
                .HasColumnType("int(11)");

            builder.Property(t => t.PortLotNumber)
                .HasColumnName("PORT_LOT_NUMBER")
                .HasColumnType("int(11)");

            builder.Property(t => t.OrderNo)
                .HasColumnName("ORDER_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.WeightLimit)
                .HasColumnName("WEIGHT_LIMIT")
                .HasColumnType("int(11)");

            builder.Property(t => t.NumberLimit)
                .HasColumnName("NUMBER_LIMIT")
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
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRlTransferPrewired" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRlTransferPrewired" /></summary>
            public const string Name = "t_rl_transfer_prewired";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.StowageType" /></summary>
            public const string StowageType = "STOWAGE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.IsDistributionShip" /></summary>
            public const string IsDistributionShip = "IS_DISTRIBUTION_SHIP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.IsSpec" /></summary>
            public const string IsSpec = "IS_SPEC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.PortLotNumber" /></summary>
            public const string PortLotNumber = "PORT_LOT_NUMBER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.WeightLimit" /></summary>
            public const string WeightLimit = "WEIGHT_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.NumberLimit" /></summary>
            public const string NumberLimit = "NUMBER_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRlTransferPrewired.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
