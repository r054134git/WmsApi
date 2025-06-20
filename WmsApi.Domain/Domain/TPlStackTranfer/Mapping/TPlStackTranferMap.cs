using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TPlStackTranfer" />
    /// </summary>
    public partial class TPlStackTranferMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TPlStackTranfer>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TPlStackTranfer" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TPlStackTranfer> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_stack_tranfer");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayId)
                .IsRequired()
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.AreaId)
                .HasColumnName("AREA_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.StartStackId)
                .HasColumnName("START_STACK_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.EndStackId)
                .HasColumnName("END_STACK_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.StartColId)
                .HasColumnName("START_COL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.EndColId)
                .HasColumnName("END_COL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.FromPointX)
                .HasColumnName("FROM_POINT_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.FromPointY)
                .HasColumnName("FROM_POINT_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.DestPointX)
                .HasColumnName("DEST_POINT_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.DestPointY)
                .HasColumnName("DEST_POINT_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasColumnType("int(1)");

            builder.Property(t => t.PlanCount)
                .IsRequired()
                .HasColumnName("PLAN_COUNT")
                .HasColumnType("int(10)");

            builder.Property(t => t.TodoCount)
                .IsRequired()
                .HasColumnName("TODO_COUNT")
                .HasColumnType("int(10)");

            builder.Property(t => t.MaterialNoList)
                .HasColumnName("MATERIAL_NO_LIST")
                .HasColumnType("varchar(4000)")
                .HasMaxLength(4000);

            builder.Property(t => t.MaterialNoListAll)
                .HasColumnName("MATERIAL_NO_LIST_ALL")
                .HasColumnType("varchar(4000)")
                .HasMaxLength(4000);

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
                .HasColumnType("varchar(4000)")
                .HasMaxLength(4000);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlStackTranfer" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlStackTranfer" /></summary>
            public const string Name = "t_pl_stack_tranfer";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.AreaId" /></summary>
            public const string AreaId = "AREA_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.StartStackId" /></summary>
            public const string StartStackId = "START_STACK_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.EndStackId" /></summary>
            public const string EndStackId = "END_STACK_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.StartColId" /></summary>
            public const string StartColId = "START_COL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.EndColId" /></summary>
            public const string EndColId = "END_COL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.FromPointX" /></summary>
            public const string FromPointX = "FROM_POINT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.FromPointY" /></summary>
            public const string FromPointY = "FROM_POINT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.DestPointX" /></summary>
            public const string DestPointX = "DEST_POINT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.DestPointY" /></summary>
            public const string DestPointY = "DEST_POINT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.PlanCount" /></summary>
            public const string PlanCount = "PLAN_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.TodoCount" /></summary>
            public const string TodoCount = "TODO_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.MaterialNoList" /></summary>
            public const string MaterialNoList = "MATERIAL_NO_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.MaterialNoListAll" /></summary>
            public const string MaterialNoListAll = "MATERIAL_NO_LIST_ALL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlStackTranfer.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
