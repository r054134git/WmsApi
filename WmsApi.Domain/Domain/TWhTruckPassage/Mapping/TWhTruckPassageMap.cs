using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhTruckPassage" />
	/// </summary>
	public partial class TWhTruckPassageMap
        : IEntityTypeConfiguration<Entities.TWhTruckPassage>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhTruckPassage" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhTruckPassage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_truck_passage");

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
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Code)
                .HasColumnName("CODE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaxX)
                .IsRequired()
                .HasColumnName("MAX_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinX)
                .IsRequired()
                .HasColumnName("MIN_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxY)
                .IsRequired()
                .HasColumnName("MAX_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MinY)
                .IsRequired()
                .HasColumnName("MIN_Y")
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
            builder.HasOne(t => t.OwnerTWhBay)
                .WithMany(t => t.OwnerTWhTruckPassages)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_WH_CAR_PASSAGE");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhTruckPassage" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhTruckPassage" /></summary>
            public const string Name = "t_wh_truck_passage";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.Code" /></summary>
            public const string Code = "CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.MaxX" /></summary>
            public const string MaxX = "MAX_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.MinX" /></summary>
            public const string MinX = "MIN_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.MaxY" /></summary>
            public const string MaxY = "MAX_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.MinY" /></summary>
            public const string MinY = "MIN_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhTruckPassage.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
