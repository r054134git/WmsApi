using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcInventory" />
    /// </summary>
    public partial class TRcInventoryMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcInventory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcInventory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcInventory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_inventory");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PlanNo)
                .IsRequired()
                .HasColumnName("PLAN_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.UserAccount)
                .IsRequired()
                .HasColumnName("USER_ACCOUNT")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.UserName)
                .IsRequired()
                .HasColumnName("USER_NAME")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.BayCode)
                .IsRequired()
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ScanCount)
                .IsRequired()
                .HasColumnName("SCAN_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.WmsCount)
                .IsRequired()
                .HasColumnName("WMS_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.ScanNotInWmsCount)
                .IsRequired()
                .HasColumnName("SCAN_NOT_IN_WMS_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.ScanInWmsCount)
                .IsRequired()
                .HasColumnName("SCAN_IN_WMS_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.WmsNotInScanCount)
                .IsRequired()
                .HasColumnName("WMS_NOT_IN_SCAN_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsFinished)
                .IsRequired()
                .HasColumnName("IS_FINISHED")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcInventory" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcInventory" /></summary>
            public const string Name = "t_rc_inventory";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.PlanNo" /></summary>
            public const string PlanNo = "PLAN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.UserAccount" /></summary>
            public const string UserAccount = "USER_ACCOUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.UserName" /></summary>
            public const string UserName = "USER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.ScanCount" /></summary>
            public const string ScanCount = "SCAN_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.WmsCount" /></summary>
            public const string WmsCount = "WMS_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.ScanNotInWmsCount" /></summary>
            public const string ScanNotInWmsCount = "SCAN_NOT_IN_WMS_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.ScanInWmsCount" /></summary>
            public const string ScanInWmsCount = "SCAN_IN_WMS_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.WmsNotInScanCount" /></summary>
            public const string WmsNotInScanCount = "WMS_NOT_IN_SCAN_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.IsFinished" /></summary>
            public const string IsFinished = "IS_FINISHED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventory.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
