using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhArea" />
	/// </summary>
	public partial class TWhAreaMap
        : IEntityTypeConfiguration<Entities.TWhArea>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhArea" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhArea> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_area");

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

            builder.Property(t => t.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.OwnerBussinessName)
                .IsRequired()
                .HasColumnName("OWNER_BUSSINESS_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.IsVirtual)
                .IsRequired()
                .HasColumnName("IS_VIRTUAL")
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
            builder.HasOne(t => t.OwnerTWhBay)
                .WithMany(t => t.OwnerTWhAreas)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_WH_AREA_BAY");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhArea" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhArea" /></summary>
            public const string Name = "t_wh_area";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.Code" /></summary>
            public const string Code = "CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.OwnerBussinessName" /></summary>
            public const string OwnerBussinessName = "OWNER_BUSSINESS_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.IsVirtual" /></summary>
            public const string IsVirtual = "IS_VIRTUAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhArea.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
