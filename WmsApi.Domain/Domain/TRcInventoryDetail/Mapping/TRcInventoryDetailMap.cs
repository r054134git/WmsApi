using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcInventoryDetail" />
    /// </summary>
    public partial class TRcInventoryDetailMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcInventoryDetail>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcInventoryDetail" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcInventoryDetail> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_inventory_detail");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.PlanId)
                .IsRequired()
                .HasColumnName("PLAN_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNo)
                .IsRequired()
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.BundleNo)
                .HasColumnName("BUNDLE_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IsScan)
                .HasColumnName("IS_SCAN")
                .HasColumnType("int(1)");

            builder.Property(t => t.IsWms)
                .HasColumnName("IS_WMS")
                .HasColumnType("int(1)");

            builder.Property(t => t.WmsLocationName)
                .HasColumnName("WMS_LOCATION_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.UserLocationName)
                .HasColumnName("USER_LOCATION_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.SystemComment)
                .HasColumnName("SYSTEM_COMMENT")
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
            builder.HasOne(t => t.PlanTRcInventory)
                .WithMany(t => t.PlanTRcInventoryDetails)
                .HasForeignKey(d => d.PlanId)
                .HasConstraintName("FK_RC_INVENTORY");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcInventoryDetail" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcInventoryDetail" /></summary>
            public const string Name = "t_rc_inventory_detail";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.PlanId" /></summary>
            public const string PlanId = "PLAN_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.BundleNo" /></summary>
            public const string BundleNo = "BUNDLE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.IsScan" /></summary>
            public const string IsScan = "IS_SCAN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.IsWms" /></summary>
            public const string IsWms = "IS_WMS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.WmsLocationName" /></summary>
            public const string WmsLocationName = "WMS_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.UserLocationName" /></summary>
            public const string UserLocationName = "USER_LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.SystemComment" /></summary>
            public const string SystemComment = "SYSTEM_COMMENT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcInventoryDetail.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
