using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.VProductionMaterial" />
    /// </summary>
    public partial class VProductionMaterialMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.VProductionMaterial>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.VProductionMaterial" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.VProductionMaterial> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("v_production_material");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.No)
                .IsRequired()
                .HasColumnName("NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ProductionNo)
                .HasColumnName("PRODUCTION_NO")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialId)
                .HasColumnName("MATERIAL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNo)
                .IsRequired()
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ProductionCoilSeq)
                .HasColumnName("PRODUCTION_COIL_SEQ")
                .HasColumnType("int(11)");

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

            builder.Property(t => t.Thick)
                .IsRequired()
                .HasColumnName("THICK")
                .HasColumnType("decimal(7,2)");

            builder.Property(t => t.Width)
                .IsRequired()
                .HasColumnName("WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.Weight)
                .IsRequired()
                .HasColumnName("WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.Length)
                .HasColumnName("LENGTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.Diameter)
                .HasColumnName("DIAMETER")
                .HasColumnType("int(11)");

            builder.Property(t => t.InnerDiameter)
                .HasColumnName("INNER_DIAMETER")
                .HasColumnType("int(11)");

            builder.Property(t => t.PortLotNumber)
                .HasColumnName("PORT_LOT_NUMBER")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.MatDirection)
                .HasColumnName("MAT_DIRECTION")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.VProductionMaterial" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.VProductionMaterial" /></summary>
            public const string Name = "v_production_material";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.No" /></summary>
            public const string No = "NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.ProductionNo" /></summary>
            public const string ProductionNo = "PRODUCTION_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.ProductionCoilSeq" /></summary>
            public const string ProductionCoilSeq = "PRODUCTION_COIL_SEQ";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.Remark" /></summary>
            public const string Remark = "REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.Thick" /></summary>
            public const string Thick = "THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.Weight" /></summary>
            public const string Weight = "WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.Length" /></summary>
            public const string Length = "LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.Diameter" /></summary>
            public const string Diameter = "DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.InnerDiameter" /></summary>
            public const string InnerDiameter = "INNER_DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.PortLotNumber" /></summary>
            public const string PortLotNumber = "PORT_LOT_NUMBER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VProductionMaterial.MatDirection" /></summary>
            public const string MatDirection = "MAT_DIRECTION";
        }
        #endregion
    }
}
