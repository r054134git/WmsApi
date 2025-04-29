using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhTrainLocation" />
	/// </summary>
	public partial class TWhTrainLocationMap
        : IEntityTypeConfiguration<Entities.TWhTrainLocation>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhTrainLocation" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhTrainLocation> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_train_location");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LocationId)
                .HasColumnName("LOCATION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.XInCar)
                .HasColumnName("X_IN_CAR")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.YInCar)
                .HasColumnName("Y_IN_CAR")
                .HasColumnType("decimal(10,3)");

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
            builder.HasOne(t => t.LocationTWhLocation)
                .WithMany(t => t.LocationTWhTrainLocations)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_LOCATION_CAR");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhTrainLocation" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhTrainLocation" /></summary>
            public const string Name = "t_wh_train_location";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.LocationId" /></summary>
            public const string LocationId = "LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.XInCar" /></summary>
            public const string XInCar = "X_IN_CAR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.YInCar" /></summary>
            public const string YInCar = "Y_IN_CAR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTrainLocation.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
