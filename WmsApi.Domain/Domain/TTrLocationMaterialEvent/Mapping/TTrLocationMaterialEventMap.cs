using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrLocationMaterialEvent" />
	/// </summary>
	public partial class TTrLocationMaterialEventMap
        : IEntityTypeConfiguration<Entities.TTrLocationMaterialEvent>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrLocationMaterialEvent" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrLocationMaterialEvent> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_location_material_event");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CraneName)
                .HasColumnName("CRANE_NAME")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.LoadLocationNo)
                .HasColumnName("LOAD_LOCATION_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.LoadX)
                .HasColumnName("LOAD_X")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadY)
                .HasColumnName("LOAD_Y")
                .HasColumnType("int(11)");

            builder.Property(t => t.UnloadLocationNo)
                .HasColumnName("UNLOAD_LOCATION_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.UnloadX)
                .HasColumnName("UNLOAD_X")
                .HasColumnType("int(11)");

            builder.Property(t => t.UnloadY)
                .HasColumnName("UNLOAD_Y")
                .HasColumnType("int(11)");

            builder.Property(t => t.BayName)
                .HasColumnName("BAY_NAME")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.IsConfirmed)
                .HasColumnName("IS_CONFIRMED")
                .HasColumnType("int(11)");

            builder.Property(t => t.ConfirmTime)
                .HasColumnName("CONFIRM_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.Description)
                .HasColumnName("DESCRIPTION")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent" /></summary>
            public const string Name = "t_tr_location_material_event";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.LoadLocationNo" /></summary>
            public const string LoadLocationNo = "LOAD_LOCATION_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.LoadX" /></summary>
            public const string LoadX = "LOAD_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.LoadY" /></summary>
            public const string LoadY = "LOAD_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.UnloadLocationNo" /></summary>
            public const string UnloadLocationNo = "UNLOAD_LOCATION_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.UnloadX" /></summary>
            public const string UnloadX = "UNLOAD_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.UnloadY" /></summary>
            public const string UnloadY = "UNLOAD_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.IsConfirmed" /></summary>
            public const string IsConfirmed = "IS_CONFIRMED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.ConfirmTime" /></summary>
            public const string ConfirmTime = "CONFIRM_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent.Description" /></summary>
            public const string Description = "DESCRIPTION";
        }
        #endregion
    }
}
