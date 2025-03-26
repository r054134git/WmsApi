using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhWarehouse" />
	/// </summary>
	public partial class TWhWarehouseMap
        : IEntityTypeConfiguration<Entities.TWhWarehouse>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhWarehouse" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhWarehouse> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_warehouse");

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
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Company)
                .IsRequired()
                .HasColumnName("COMPANY")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Workshop)
                .IsRequired()
                .HasColumnName("WORKSHOP")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.LoadPriority)
                .IsRequired()
                .HasColumnName("LOAD_PRIORITY")
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
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhWarehouse" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhWarehouse" /></summary>
            public const string Name = "t_wh_warehouse";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.Company" /></summary>
            public const string Company = "COMPANY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.Workshop" /></summary>
            public const string Workshop = "WORKSHOP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.LoadPriority" /></summary>
            public const string LoadPriority = "LOAD_PRIORITY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhWarehouse.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
