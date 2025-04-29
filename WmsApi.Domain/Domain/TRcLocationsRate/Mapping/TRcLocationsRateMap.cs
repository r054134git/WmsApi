using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcLocationsRate" />
    /// </summary>
    public partial class TRcLocationsRateMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcLocationsRate>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcLocationsRate" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcLocationsRate> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_locations_rate");

            // key
            builder.HasKey(t => new { t.Id, t.Dt });

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Dt)
                .IsRequired()
                .HasColumnName("DT")
                .HasColumnType("datetime");

            builder.Property(t => t.BayCode)
                .IsRequired()
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.CountCoilsFloor1)
                .IsRequired()
                .HasColumnName("COUNT_COILS_FLOOR1")
                .HasColumnType("int(4)");

            builder.Property(t => t.CountLocationsFloor1)
                .IsRequired()
                .HasColumnName("COUNT_LOCATIONS_FLOOR1")
                .HasColumnType("int(4)");

            builder.Property(t => t.CountCoilsFloor2)
                .IsRequired()
                .HasColumnName("COUNT_COILS_FLOOR2")
                .HasColumnType("int(4)");

            builder.Property(t => t.CountLocationsFloor2)
                .IsRequired()
                .HasColumnName("COUNT_LOCATIONS_FLOOR2")
                .HasColumnType("int(4)");

            builder.Property(t => t.RateFloor1)
                .IsRequired()
                .HasColumnName("RATE_FLOOR1")
                .HasColumnType("decimal(5,3)");

            builder.Property(t => t.RateFloor2)
                .IsRequired()
                .HasColumnName("RATE_FLOOR2")
                .HasColumnType("decimal(5,3)");

            builder.Property(t => t.RateAll)
                .HasColumnName("RATE_ALL")
                .HasColumnType("decimal(5,3)");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcLocationsRate" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcLocationsRate" /></summary>
            public const string Name = "t_rc_locations_rate";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.Dt" /></summary>
            public const string Dt = "DT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.CountCoilsFloor1" /></summary>
            public const string CountCoilsFloor1 = "COUNT_COILS_FLOOR1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.CountLocationsFloor1" /></summary>
            public const string CountLocationsFloor1 = "COUNT_LOCATIONS_FLOOR1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.CountCoilsFloor2" /></summary>
            public const string CountCoilsFloor2 = "COUNT_COILS_FLOOR2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.CountLocationsFloor2" /></summary>
            public const string CountLocationsFloor2 = "COUNT_LOCATIONS_FLOOR2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.RateFloor1" /></summary>
            public const string RateFloor1 = "RATE_FLOOR1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.RateFloor2" /></summary>
            public const string RateFloor2 = "RATE_FLOOR2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.RateAll" /></summary>
            public const string RateAll = "RATE_ALL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationsRate.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
