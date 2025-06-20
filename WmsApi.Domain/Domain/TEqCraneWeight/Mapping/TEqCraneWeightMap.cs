using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TEqCraneWeight" />
	/// </summary>
	public partial class TEqCraneWeightMap
        : IEntityTypeConfiguration<Entities.TEqCraneWeight>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TEqCraneWeight" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TEqCraneWeight> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_eq_crane_weight");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneId)
                .IsRequired()
                .HasColumnName("CRANE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MeterUpperLimit)
                .IsRequired()
                .HasColumnName("METER_UPPER_LIMIT")
                .HasColumnType("decimal(7,3)");

            builder.Property(t => t.MeterLowerLimit)
                .IsRequired()
                .HasColumnName("METER_LOWER_LIMIT")
                .HasColumnType("decimal(7,3)");

            builder.Property(t => t.WeightUpperLimit)
                .IsRequired()
                .HasColumnName("WEIGHT_UPPER_LIMIT")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.WeightLowerLimit)
                .IsRequired()
                .HasColumnName("WEIGHT_LOWER_LIMIT")
                .HasColumnType("decimal(10,3)");

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
            builder.HasOne(t => t.CraneTEqCrane)
                .WithMany(t => t.CraneTEqCraneWeights)
                .HasForeignKey(d => d.CraneId)
                .HasConstraintName("FK_CRANE_WEIGHT");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TEqCraneWeight" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TEqCraneWeight" /></summary>
            public const string Name = "t_eq_crane_weight";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.CraneId" /></summary>
            public const string CraneId = "CRANE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.MeterUpperLimit" /></summary>
            public const string MeterUpperLimit = "METER_UPPER_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.MeterLowerLimit" /></summary>
            public const string MeterLowerLimit = "METER_LOWER_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.WeightUpperLimit" /></summary>
            public const string WeightUpperLimit = "WEIGHT_UPPER_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.WeightLowerLimit" /></summary>
            public const string WeightLowerLimit = "WEIGHT_LOWER_LIMIT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqCraneWeight.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
