using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TEqTrain" />
	/// </summary>
	public partial class TEqTrainMap
        : IEntityTypeConfiguration<Entities.TEqTrain>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TEqTrain" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TEqTrain> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_eq_train");

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
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.SortIndex)
                .HasColumnName("SORT_INDEX")
                .HasColumnType("int(11)");

            builder.Property(t => t.Car1Id)
                .HasColumnName("CAR1_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car2Id)
                .HasColumnName("CAR2_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car3Id)
                .HasColumnName("CAR3_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car4Id)
                .HasColumnName("CAR4_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car5Id)
                .HasColumnName("CAR5_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car6Id)
                .HasColumnName("CAR6_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car7Id)
                .HasColumnName("CAR7_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car8Id)
                .HasColumnName("CAR8_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car9Id)
                .HasColumnName("CAR9_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car10Id)
                .HasColumnName("CAR10_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car11Id)
                .HasColumnName("CAR11_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car12Id)
                .HasColumnName("CAR12_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car13Id)
                .HasColumnName("CAR13_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car14Id)
                .HasColumnName("CAR14_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Car15Id)
                .HasColumnName("CAR15_ID")
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
            builder.HasOne(t => t.Car10TWhStack)
                .WithMany(t => t.Car10TEqTrains)
                .HasForeignKey(d => d.Car10Id)
                .HasConstraintName("FK_WH_CAR10_ID");

            builder.HasOne(t => t.Car11TWhStack)
                .WithMany(t => t.Car11TEqTrains)
                .HasForeignKey(d => d.Car11Id)
                .HasConstraintName("FK_WH_CAR11_ID");

            builder.HasOne(t => t.Car12TWhStack)
                .WithMany(t => t.Car12TEqTrains)
                .HasForeignKey(d => d.Car12Id)
                .HasConstraintName("FK_WH_CAR12_ID");

            builder.HasOne(t => t.Car13TWhStack)
                .WithMany(t => t.Car13TEqTrains)
                .HasForeignKey(d => d.Car13Id)
                .HasConstraintName("FK_WH_CAR13_ID");

            builder.HasOne(t => t.Car14TWhStack)
                .WithMany(t => t.Car14TEqTrains)
                .HasForeignKey(d => d.Car14Id)
                .HasConstraintName("FK_WH_CAR14_ID");

            builder.HasOne(t => t.Car15TWhStack)
                .WithMany(t => t.Car15TEqTrains)
                .HasForeignKey(d => d.Car15Id)
                .HasConstraintName("FK_WH_CAR15_ID");

            builder.HasOne(t => t.Car1TWhStack)
                .WithMany(t => t.Car1TEqTrains)
                .HasForeignKey(d => d.Car1Id)
                .HasConstraintName("FK_WH_CAR1_ID");

            builder.HasOne(t => t.Car2TWhStack)
                .WithMany(t => t.Car2TEqTrains)
                .HasForeignKey(d => d.Car2Id)
                .HasConstraintName("FK_WH_CAR2_ID");

            builder.HasOne(t => t.Car3TWhStack)
                .WithMany(t => t.Car3TEqTrains)
                .HasForeignKey(d => d.Car3Id)
                .HasConstraintName("FK_WH_CAR3_ID");

            builder.HasOne(t => t.Car4TWhStack)
                .WithMany(t => t.Car4TEqTrains)
                .HasForeignKey(d => d.Car4Id)
                .HasConstraintName("FK_WH_CAR4_ID");

            builder.HasOne(t => t.Car5TWhStack)
                .WithMany(t => t.Car5TEqTrains)
                .HasForeignKey(d => d.Car5Id)
                .HasConstraintName("FK_WH_CAR5_ID");

            builder.HasOne(t => t.Car6TWhStack)
                .WithMany(t => t.Car6TEqTrains)
                .HasForeignKey(d => d.Car6Id)
                .HasConstraintName("FK_WH_CAR6_ID");

            builder.HasOne(t => t.Car7TWhStack)
                .WithMany(t => t.Car7TEqTrains)
                .HasForeignKey(d => d.Car7Id)
                .HasConstraintName("FK_WH_CAR7_ID");

            builder.HasOne(t => t.Car8TWhStack)
                .WithMany(t => t.Car8TEqTrains)
                .HasForeignKey(d => d.Car8Id)
                .HasConstraintName("FK_WH_CAR8_ID");

            builder.HasOne(t => t.Car9TWhStack)
                .WithMany(t => t.Car9TEqTrains)
                .HasForeignKey(d => d.Car9Id)
                .HasConstraintName("FK_WH_CAR9_ID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TEqTrain" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TEqTrain" /></summary>
            public const string Name = "t_eq_train";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.SortIndex" /></summary>
            public const string SortIndex = "SORT_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car1Id" /></summary>
            public const string Car1Id = "CAR1_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car2Id" /></summary>
            public const string Car2Id = "CAR2_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car3Id" /></summary>
            public const string Car3Id = "CAR3_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car4Id" /></summary>
            public const string Car4Id = "CAR4_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car5Id" /></summary>
            public const string Car5Id = "CAR5_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car6Id" /></summary>
            public const string Car6Id = "CAR6_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car7Id" /></summary>
            public const string Car7Id = "CAR7_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car8Id" /></summary>
            public const string Car8Id = "CAR8_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car9Id" /></summary>
            public const string Car9Id = "CAR9_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car10Id" /></summary>
            public const string Car10Id = "CAR10_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car11Id" /></summary>
            public const string Car11Id = "CAR11_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car12Id" /></summary>
            public const string Car12Id = "CAR12_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car13Id" /></summary>
            public const string Car13Id = "CAR13_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car14Id" /></summary>
            public const string Car14Id = "CAR14_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Car15Id" /></summary>
            public const string Car15Id = "CAR15_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TEqTrain.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
