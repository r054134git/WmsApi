using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhLocation" />
	/// </summary>
	public partial class TWhLocationMap
        : IEntityTypeConfiguration<Entities.TWhLocation>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhLocation" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhLocation> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_location");

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
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.BayCode)
                .IsRequired()
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.AreaCode)
                .IsRequired()
                .HasColumnName("AREA_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.RowNo)
                .IsRequired()
                .HasColumnName("ROW_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.ColNo)
                .IsRequired()
                .HasColumnName("COL_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.FloorNo)
                .IsRequired()
                .HasColumnName("FLOOR_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.PointX)
                .IsRequired()
                .HasColumnName("POINT_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.PointY)
                .IsRequired()
                .HasColumnName("POINT_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.PointZ)
                .IsRequired()
                .HasColumnName("POINT_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.DevX)
                .HasColumnName("DEV_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.DevY)
                .HasColumnName("DEV_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.Angle)
                .IsRequired()
                .HasColumnName("ANGLE")
                .HasColumnType("int(11)");

            builder.Property(t => t.Orientation)
                .IsRequired()
                .HasColumnName("ORIENTATION")
                .HasColumnType("int(11)");

            builder.Property(t => t.MaxZ)
                .HasColumnName("MAX_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BaseWidth)
                .IsRequired()
                .HasColumnName("BASE_WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BaseLength)
                .IsRequired()
                .HasColumnName("BASE_LENGTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BaseHeight)
                .IsRequired()
                .HasColumnName("BASE_HEIGHT")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.AreaId)
                .IsRequired()
                .HasColumnName("AREA_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayId)
                .IsRequired()
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.StorageType)
                .IsRequired()
                .HasColumnName("STORAGE_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadType)
                .IsRequired()
                .HasColumnName("LOAD_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.OwnerBussinessName)
                .IsRequired()
                .HasColumnName("OWNER_BUSSINESS_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.IsVirtual)
                .IsRequired()
                .HasColumnName("IS_VIRTUAL")
                .HasColumnType("int(1)");

            builder.Property(t => t.IsSharedToC3)
                .IsRequired()
                .HasColumnName("IS_SHARED_TO_C3")
                .HasColumnType("int(1)");

            builder.Property(t => t.AreaCodeC3)
                .HasColumnName("AREA_CODE_C3")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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
                .WithMany(t => t.OwnerTWhLocations)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_LOCATION_STACK");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhLocation" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhLocation" /></summary>
            public const string Name = "t_wh_location";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.AreaCode" /></summary>
            public const string AreaCode = "AREA_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.RowNo" /></summary>
            public const string RowNo = "ROW_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.ColNo" /></summary>
            public const string ColNo = "COL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.FloorNo" /></summary>
            public const string FloorNo = "FLOOR_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.PointX" /></summary>
            public const string PointX = "POINT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.PointY" /></summary>
            public const string PointY = "POINT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.PointZ" /></summary>
            public const string PointZ = "POINT_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.DevX" /></summary>
            public const string DevX = "DEV_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.DevY" /></summary>
            public const string DevY = "DEV_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.Angle" /></summary>
            public const string Angle = "ANGLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.Orientation" /></summary>
            public const string Orientation = "ORIENTATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.MaxZ" /></summary>
            public const string MaxZ = "MAX_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.BaseWidth" /></summary>
            public const string BaseWidth = "BASE_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.BaseLength" /></summary>
            public const string BaseLength = "BASE_LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.BaseHeight" /></summary>
            public const string BaseHeight = "BASE_HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.AreaId" /></summary>
            public const string AreaId = "AREA_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.StorageType" /></summary>
            public const string StorageType = "STORAGE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.LoadType" /></summary>
            public const string LoadType = "LOAD_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.OwnerBussinessName" /></summary>
            public const string OwnerBussinessName = "OWNER_BUSSINESS_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.IsVirtual" /></summary>
            public const string IsVirtual = "IS_VIRTUAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.IsSharedToC3" /></summary>
            public const string IsSharedToC3 = "IS_SHARED_TO_C3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.AreaCodeC3" /></summary>
            public const string AreaCodeC3 = "AREA_CODE_C3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhLocation.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
