using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TEqTrainCar" />
	/// </summary>
	public partial class TEqTrainCarMap
        : IEntityTypeConfiguration<Entities.TEqTrainCar>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TEqTrainCar" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TEqTrainCar> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_eq_train_car");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CarType)
                .HasColumnName("CAR_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.State)
                .HasColumnName("STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.Height)
                .HasColumnName("HEIGHT")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxLoad)
                .HasColumnName("MAX_LOAD")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.SaddleCount)
                .HasColumnName("SADDLE_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

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
            builder.HasOne(t => t.OwnerTWhStack)
                .WithMany(t => t.OwnerTEqTrainCars)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_WH_OWNER_ID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TEqTrainCar" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TEqTrainCar" /></summary>
            public const string Name = "t_eq_train_car";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.CarType" /></summary>
            public const string CarType = "CAR_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.State" /></summary>
            public const string State = "STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.Height" /></summary>
            public const string Height = "HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.MaxLoad" /></summary>
            public const string MaxLoad = "MAX_LOAD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.SaddleCount" /></summary>
            public const string SaddleCount = "SADDLE_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrainCar.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
