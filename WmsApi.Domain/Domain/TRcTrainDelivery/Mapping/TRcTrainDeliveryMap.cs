using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TRcTrainDelivery" />
	/// </summary>
	public partial class TRcTrainDeliveryMap
        : IEntityTypeConfiguration<Entities.TRcTrainDelivery>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TRcTrainDelivery" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TRcTrainDelivery> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_train_delivery");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.OperationMark)
                .HasColumnName("OPERATION_MARK")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.DeliveryDate)
                .HasColumnName("DELIVERY_DATE")
                .HasColumnType("datetime");

            builder.Property(t => t.SourceHouse)
                .HasColumnName("SOURCE_HOUSE")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.TargetHouse)
                .HasColumnName("TARGET_HOUSE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.TargetHouseType)
                .HasColumnName("TARGET_HOUSE_TYPE")
                .HasColumnType("varchar(11)")
                .HasMaxLength(11);

            builder.Property(t => t.Code)
                .HasColumnName("CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.CoilNo)
                .IsRequired()
                .HasColumnName("COIL_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CoilType)
                .HasColumnName("COIL_TYPE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.TrainId)
                .HasColumnName("TRAIN_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TrainNo)
                .HasColumnName("TRAIN_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.TrainLocationNo)
                .HasColumnName("TRAIN_LOCATION_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Operator)
                .HasColumnName("OPERATOR")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.State)
                .HasColumnName("STATE")
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

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcTrainDelivery" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcTrainDelivery" /></summary>
            public const string Name = "t_rc_train_delivery";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.OperationMark" /></summary>
            public const string OperationMark = "OPERATION_MARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.DeliveryDate" /></summary>
            public const string DeliveryDate = "DELIVERY_DATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.SourceHouse" /></summary>
            public const string SourceHouse = "SOURCE_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.TargetHouse" /></summary>
            public const string TargetHouse = "TARGET_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.TargetHouseType" /></summary>
            public const string TargetHouseType = "TARGET_HOUSE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.Code" /></summary>
            public const string Code = "CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.CoilNo" /></summary>
            public const string CoilNo = "COIL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.CoilType" /></summary>
            public const string CoilType = "COIL_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.TrainId" /></summary>
            public const string TrainId = "TRAIN_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.TrainNo" /></summary>
            public const string TrainNo = "TRAIN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.TrainLocationNo" /></summary>
            public const string TrainLocationNo = "TRAIN_LOCATION_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.Operator" /></summary>
            public const string Operator = "OPERATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.State" /></summary>
            public const string State = "STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainDelivery.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
