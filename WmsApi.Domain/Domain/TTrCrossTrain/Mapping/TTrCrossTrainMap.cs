using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrCrossTrain" />
	/// </summary>
	public partial class TTrCrossTrainMap
        : IEntityTypeConfiguration<Entities.TTrCrossTrain>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrCrossTrain" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrCrossTrain> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_cross_train");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32)
                .HasDefaultValueSql("''");

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

            builder.Property(t => t.VehiclePlcName)
                .HasColumnName("VEHICLE_PLC_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ParkedState)
                .HasColumnName("PARKED_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.FromBayName)
                .HasColumnName("FROM_BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.DestBayName)
                .HasColumnName("DEST_BAY_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TaskType)
                .HasColumnName("TASK_TYPE")
                .HasColumnType("int(1)");

            builder.Property(t => t.StackId)
                .HasColumnName("STACK_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LaserDistance)
                .HasColumnName("LASER_DISTANCE")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.OperationMode)
                .HasColumnName("OPERATION_MODE")
                .HasColumnType("int(1)");

            builder.Property(t => t.IsLock)
                .HasColumnName("IS_LOCK")
                .HasColumnType("int(1)");

            builder.Property(t => t.FaultCode)
                .HasColumnName("FAULT_CODE")
                .HasColumnType("int(11)");

            builder.Property(t => t.FaultDesc)
                .HasColumnName("FAULT_DESC")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.TaskNoWms)
                .HasColumnName("TASK_NO_WMS")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TaskNoPlc)
                .HasColumnName("TASK_NO_PLC")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TaskState)
                .HasColumnName("TASK_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.TaskTime)
                .HasColumnName("TASK_TIME")
                .HasColumnType("datetime");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrCrossTrain" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrCrossTrain" /></summary>
            public const string Name = "t_tr_cross_train";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.VehicleId" /></summary>
            public const string VehicleId = "VEHICLE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.VehicleType" /></summary>
            public const string VehicleType = "VEHICLE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.VehicleName" /></summary>
            public const string VehicleName = "VEHICLE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.VehiclePlcName" /></summary>
            public const string VehiclePlcName = "VEHICLE_PLC_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.ParkedState" /></summary>
            public const string ParkedState = "PARKED_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.FromBayName" /></summary>
            public const string FromBayName = "FROM_BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.DestBayName" /></summary>
            public const string DestBayName = "DEST_BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.TaskType" /></summary>
            public const string TaskType = "TASK_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.StackId" /></summary>
            public const string StackId = "STACK_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.LaserDistance" /></summary>
            public const string LaserDistance = "LASER_DISTANCE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.OperationMode" /></summary>
            public const string OperationMode = "OPERATION_MODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.IsLock" /></summary>
            public const string IsLock = "IS_LOCK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.FaultCode" /></summary>
            public const string FaultCode = "FAULT_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.FaultDesc" /></summary>
            public const string FaultDesc = "FAULT_DESC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.TaskNoWms" /></summary>
            public const string TaskNoWms = "TASK_NO_WMS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.TaskNoPlc" /></summary>
            public const string TaskNoPlc = "TASK_NO_PLC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.TaskState" /></summary>
            public const string TaskState = "TASK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.TaskTime" /></summary>
            public const string TaskTime = "TASK_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrCrossTrain.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
