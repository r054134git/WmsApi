using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlCrossBayTask" />
	/// </summary>
	public partial class TPlCrossBayTaskMap
        : IEntityTypeConfiguration<Entities.TPlCrossBayTask>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlCrossBayTask" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlCrossBayTask> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_cross_bay_task");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TaskNo)
                .IsRequired()
                .HasColumnName("TASK_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.VehicleId)
                .IsRequired()
                .HasColumnName("VEHICLE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.VehicleType)
                .IsRequired()
                .HasColumnName("VEHICLE_TYPE")
                .HasColumnType("int(1)");

            builder.Property(t => t.VehicleName)
                .IsRequired()
                .HasColumnName("VEHICLE_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.FromBayId)
                .IsRequired()
                .HasColumnName("FROM_BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.FromBayName)
                .IsRequired()
                .HasColumnName("FROM_BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.DestBayId)
                .IsRequired()
                .HasColumnName("DEST_BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.DestBayName)
                .IsRequired()
                .HasColumnName("DEST_BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TaskState)
                .IsRequired()
                .HasColumnName("TASK_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.DispatchState)
                .IsRequired()
                .HasColumnName("DISPATCH_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.MaterialNoPlan)
                .HasColumnName("MATERIAL_NO_PLAN")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.MaterialNoLoaded)
                .HasColumnName("MATERIAL_NO_LOADED")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

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
            builder.HasOne(t => t.DestBayTWhBay)
                .WithMany(t => t.DestBayTPlCrossBayTasks)
                .HasForeignKey(d => d.DestBayId)
                .HasConstraintName("FK_PL_CTT_WH_DEST_BAY");

            builder.HasOne(t => t.FromBayTWhBay)
                .WithMany(t => t.FromBayTPlCrossBayTasks)
                .HasForeignKey(d => d.FromBayId)
                .HasConstraintName("FK_PL_CTT_WH_FROM_BAY");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlCrossBayTask" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlCrossBayTask" /></summary>
            public const string Name = "t_pl_cross_bay_task";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.TaskNo" /></summary>
            public const string TaskNo = "TASK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.VehicleId" /></summary>
            public const string VehicleId = "VEHICLE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.VehicleType" /></summary>
            public const string VehicleType = "VEHICLE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.VehicleName" /></summary>
            public const string VehicleName = "VEHICLE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.FromBayId" /></summary>
            public const string FromBayId = "FROM_BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.FromBayName" /></summary>
            public const string FromBayName = "FROM_BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.DestBayId" /></summary>
            public const string DestBayId = "DEST_BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.DestBayName" /></summary>
            public const string DestBayName = "DEST_BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.TaskState" /></summary>
            public const string TaskState = "TASK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.DispatchState" /></summary>
            public const string DispatchState = "DISPATCH_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.MaterialNoPlan" /></summary>
            public const string MaterialNoPlan = "MATERIAL_NO_PLAN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.MaterialNoLoaded" /></summary>
            public const string MaterialNoLoaded = "MATERIAL_NO_LOADED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlCrossBayTask.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
