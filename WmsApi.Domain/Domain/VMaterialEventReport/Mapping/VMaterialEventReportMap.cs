using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.VMaterialEventReport" />
    /// </summary>
    public partial class VMaterialEventReportMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.VMaterialEventReport>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.VMaterialEventReport" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.VMaterialEventReport> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("v_material_event_report");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.CraneName)
                .HasColumnName("CRANE_NAME")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MaterialId)
                .IsRequired()
                .HasColumnName("MATERIAL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Dt)
                .IsRequired()
                .HasColumnName("DT")
                .HasColumnType("datetime");

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialNoOld)
                .HasColumnName("MATERIAL_NO_OLD")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.OperationType)
                .IsRequired()
                .HasColumnName("OPERATION_TYPE")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ContentType)
                .IsRequired()
                .HasColumnName("CONTENT_TYPE")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.FromLocationName)
                .HasColumnName("FROM_LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ToLocationName)
                .HasColumnName("TO_LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Description)
                .HasColumnName("DESCRIPTION")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.FromPosition)
                .HasColumnName("FROM_POSITION")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ToPosition)
                .HasColumnName("TO_POSITION")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Result)
                .IsRequired()
                .HasColumnName("RESULT")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Remark)
                .HasColumnName("REMARK")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Weight)
                .IsRequired()
                .HasColumnName("WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.MatDirection)
                .HasColumnName("MAT_DIRECTION")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.CustomerName)
                .HasColumnName("CUSTOMER_NAME")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.VMaterialEventReport" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.VMaterialEventReport" /></summary>
            public const string Name = "v_material_event_report";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.CraneName" /></summary>
            public const string CraneName = "CRANE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.Dt" /></summary>
            public const string Dt = "DT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.MaterialNoOld" /></summary>
            public const string MaterialNoOld = "MATERIAL_NO_OLD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.OperationType" /></summary>
            public const string OperationType = "OPERATION_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.ContentType" /></summary>
            public const string ContentType = "CONTENT_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.FromLocationName" /></summary>
            public const string FromLocationName = "FROM_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.ToLocationName" /></summary>
            public const string ToLocationName = "TO_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.Description" /></summary>
            public const string Description = "DESCRIPTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.FromPosition" /></summary>
            public const string FromPosition = "FROM_POSITION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.ToPosition" /></summary>
            public const string ToPosition = "TO_POSITION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.Result" /></summary>
            public const string Result = "RESULT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.Remark" /></summary>
            public const string Remark = "REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.Weight" /></summary>
            public const string Weight = "WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.MatDirection" /></summary>
            public const string MatDirection = "MAT_DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VMaterialEventReport.CustomerName" /></summary>
            public const string CustomerName = "CUSTOMER_NAME";
        }
        #endregion
    }
}
