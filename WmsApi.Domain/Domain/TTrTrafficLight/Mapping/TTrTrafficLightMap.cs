using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TTrTrafficLight" />
    /// </summary>
    public partial class TTrTrafficLightMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TTrTrafficLight>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TTrTrafficLight" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TTrTrafficLight> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_traffic_light");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Name)
                .HasColumnName("NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PlcName)
                .HasColumnName("PLC_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayId)
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.State)
                .HasColumnName("STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.LastCmd)
                .HasColumnName("LAST_CMD")
                .HasColumnType("int(1)");

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
            builder.HasOne(t => t.BayTWhBay)
                .WithMany(t => t.BayTTrTrafficLights)
                .HasForeignKey(d => d.BayId)
                .HasConstraintName("t_tr_traffic_light_ibfk_1");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrTrafficLight" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrTrafficLight" /></summary>
            public const string Name = "t_tr_traffic_light";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.PlcName" /></summary>
            public const string PlcName = "PLC_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.State" /></summary>
            public const string State = "STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.LastCmd" /></summary>
            public const string LastCmd = "LAST_CMD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrafficLight.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
