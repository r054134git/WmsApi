using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlTruckDeliveryDetail" />
	/// </summary>
	public partial class TPlTruckDeliveryDetailMap
        : IEntityTypeConfiguration<Entities.TPlTruckDeliveryDetail>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlTruckDeliveryDetail" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlTruckDeliveryDetail> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_truck_delivery_detail");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CoilNo)
                .HasColumnName("COIL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IsPicked)
                .HasColumnName("IS_PICKED")
                .HasColumnType("int(11)");

            builder.Property(t => t.PikcedTime)
                .HasColumnName("PIKCED_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.IsLoaded)
                .HasColumnName("IS_LOADED")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadedTime)
                .HasColumnName("LOADED_TIME")
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
            builder.HasOne(t => t.OwnerTPlTruckDelivery)
                .WithMany(t => t.OwnerTPlTruckDeliveryDetails)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_TRUCK_D_DETAIL");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail" /></summary>
            public const string Name = "t_pl_truck_delivery_detail";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.CoilNo" /></summary>
            public const string CoilNo = "COIL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.IsPicked" /></summary>
            public const string IsPicked = "IS_PICKED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.PikcedTime" /></summary>
            public const string PikcedTime = "PIKCED_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.IsLoaded" /></summary>
            public const string IsLoaded = "IS_LOADED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.LoadedTime" /></summary>
            public const string LoadedTime = "LOADED_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
