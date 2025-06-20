using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhCraneTravelSpace" />
	/// </summary>
	public partial class TWhCraneTravelSpaceMap
        : IEntityTypeConfiguration<Entities.TWhCraneTravelSpace>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhCraneTravelSpace" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhCraneTravelSpace> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_crane_travel_space");

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

            builder.Property(t => t.Seq)
                .IsRequired()
                .HasColumnName("SEQ")
                .HasColumnType("int(11)");

            builder.Property(t => t.OriginX)
                .IsRequired()
                .HasColumnName("ORIGIN_X")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.OriginY)
                .IsRequired()
                .HasColumnName("ORIGIN_Y")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.LengthX)
                .IsRequired()
                .HasColumnName("LENGTH_X")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.LengthY)
                .IsRequired()
                .HasColumnName("LENGTH_Y")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.MinZ)
                .IsRequired()
                .HasColumnName("MIN_Z")
                .HasColumnType("decimal(10,2)");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.EntryType)
                .HasColumnName("ENTRY_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

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
            builder.HasOne(t => t.OwnerTWhBay)
                .WithMany(t => t.OwnerTWhCraneTravelSpaces)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_ATRSPACE_WH_BAY");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace" /></summary>
            public const string Name = "t_wh_crane_travel_space";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.Seq" /></summary>
            public const string Seq = "SEQ";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.OriginX" /></summary>
            public const string OriginX = "ORIGIN_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.OriginY" /></summary>
            public const string OriginY = "ORIGIN_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.LengthX" /></summary>
            public const string LengthX = "LENGTH_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.LengthY" /></summary>
            public const string LengthY = "LENGTH_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.MinZ" /></summary>
            public const string MinZ = "MIN_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.EntryType" /></summary>
            public const string EntryType = "ENTRY_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
