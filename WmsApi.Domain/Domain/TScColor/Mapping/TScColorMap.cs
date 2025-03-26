using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TScColor" />
	/// </summary>
	public partial class TScColorMap
        : IEntityTypeConfiguration<Entities.TScColor>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TScColor" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TScColor> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_sc_color");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.NormalCoilColor)
                .HasColumnName("NORMAL_COIL_COLOR")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.SelectedCoilColor)
                .HasColumnName("SELECTED_COIL_COLOR")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.PlanCoilColor)
                .HasColumnName("PLAN_COIL_COLOR")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.LockedCoilColor)
                .HasColumnName("LOCKED_COIL_COLOR")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.NormalLocationColor)
                .HasColumnName("NORMAL_LOCATION_COLOR")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.SelectedLocationColor)
                .HasColumnName("SELECTED_LOCATION_COLOR")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Name)
                .HasColumnName("NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IsDefault)
                .HasColumnName("IS_DEFAULT")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TScColor" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TScColor" /></summary>
            public const string Name = "t_sc_color";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.NormalCoilColor" /></summary>
            public const string NormalCoilColor = "NORMAL_COIL_COLOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.SelectedCoilColor" /></summary>
            public const string SelectedCoilColor = "SELECTED_COIL_COLOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.PlanCoilColor" /></summary>
            public const string PlanCoilColor = "PLAN_COIL_COLOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.LockedCoilColor" /></summary>
            public const string LockedCoilColor = "LOCKED_COIL_COLOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.NormalLocationColor" /></summary>
            public const string NormalLocationColor = "NORMAL_LOCATION_COLOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.SelectedLocationColor" /></summary>
            public const string SelectedLocationColor = "SELECTED_LOCATION_COLOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TScColor.IsDefault" /></summary>
            public const string IsDefault = "IS_DEFAULT";
        }
        #endregion
    }
}
