using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TWhPlanType" />
	/// </summary>
	public partial class TWhPlanTypeMap
        : IEntityTypeConfiguration<Entities.TWhPlanType>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TWhPlanType" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TWhPlanType> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_wh_plan_type");

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

            builder.Property(t => t.SimpleName)
                .IsRequired()
                .HasColumnName("SIMPLE_NAME")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.ClassLabel)
                .IsRequired()
                .HasColumnName("CLASS_LABEL")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.FromLocationType)
                .IsRequired()
                .HasColumnName("FROM_LOCATION_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.DestLocationType)
                .IsRequired()
                .HasColumnName("DEST_LOCATION_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.FromBayId)
                .IsRequired()
                .HasColumnName("FROM_BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.DestBayId)
                .IsRequired()
                .HasColumnName("DEST_BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.InOutType)
                .IsRequired()
                .HasColumnName("IN_OUT_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsCrossBay)
                .IsRequired()
                .HasColumnName("IS_CROSS_BAY")
                .HasColumnType("int(11)");

            builder.Property(t => t.TransType)
                .IsRequired()
                .HasColumnName("TRANS_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.BackGroundColor)
                .HasColumnName("BACK_GROUND_COLOR")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.SortSeq)
                .IsRequired()
                .HasColumnName("SORT_SEQ")
                .HasColumnType("int(11)");

            builder.Property(t => t.DefaultPriority)
                .IsRequired()
                .HasColumnName("DEFAULT_PRIORITY")
                .HasColumnType("int(11)");

            builder.Property(t => t.OwnerId)
                .IsRequired()
                .HasColumnName("OWNER_ID")
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
            builder.HasOne(t => t.OwnerTWhWarehouse)
                .WithMany(t => t.OwnerTWhPlanTypes)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_PLAN_TYPE_INFO");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TWhPlanType" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TWhPlanType" /></summary>
            public const string Name = "t_wh_plan_type";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.Name" /></summary>
            public const string Name = "NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.SimpleName" /></summary>
            public const string SimpleName = "SIMPLE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.ClassLabel" /></summary>
            public const string ClassLabel = "CLASS_LABEL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.FromLocationType" /></summary>
            public const string FromLocationType = "FROM_LOCATION_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.DestLocationType" /></summary>
            public const string DestLocationType = "DEST_LOCATION_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.FromBayId" /></summary>
            public const string FromBayId = "FROM_BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.DestBayId" /></summary>
            public const string DestBayId = "DEST_BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.InOutType" /></summary>
            public const string InOutType = "IN_OUT_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.IsCrossBay" /></summary>
            public const string IsCrossBay = "IS_CROSS_BAY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.TransType" /></summary>
            public const string TransType = "TRANS_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.BackGroundColor" /></summary>
            public const string BackGroundColor = "BACK_GROUND_COLOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.SortSeq" /></summary>
            public const string SortSeq = "SORT_SEQ";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.DefaultPriority" /></summary>
            public const string DefaultPriority = "DEFAULT_PRIORITY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.OwnerId" /></summary>
            public const string OwnerId = "OWNER_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TWhPlanType.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
