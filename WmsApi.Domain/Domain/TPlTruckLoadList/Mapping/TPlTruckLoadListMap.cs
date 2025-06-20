using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlTruckLoadList" />
	/// </summary>
	public partial class TPlTruckLoadListMap
        : IEntityTypeConfiguration<Entities.TPlTruckLoadList>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlTruckLoadList" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlTruckLoadList> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_truck_load_list");

            // key
            builder.HasKey(t => new { t.Id, t.OrderNo });

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

            builder.Property(t => t.CardNo)
                .HasColumnName("CARD_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.TruckLoadingNo)
                .HasColumnName("TRUCK_LOADING_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.MainTruckLoadingNo)
                .HasColumnName("MAIN_TRUCK_LOADING_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.VehicleNo)
                .HasColumnName("VEHICLE_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.SourceHouse)
                .HasColumnName("SOURCE_HOUSE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.DeliveryOrderNo)
                .HasColumnName("DELIVERY_ORDER_NO")
                .HasColumnType("varchar(13)")
                .HasMaxLength(13);

            builder.Property(t => t.ReplyInfo)
                .HasColumnName("REPLY_INFO")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.OrderNo)
                .IsRequired()
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DetailNo)
                .HasColumnName("DETAIL_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.Count)
                .HasColumnName("COUNT")
                .HasColumnType("varchar(9)")
                .HasMaxLength(9);

            builder.Property(t => t.PlanOutBoundWeight)
                .HasColumnName("PLAN_OUT_BOUND_WEIGHT")
                .HasColumnType("decimal(15,6)");

            builder.Property(t => t.CreateTimeLoadList)
                .HasColumnName("CREATE_TIME_LOAD_LIST")
                .HasColumnType("datetime");

            builder.Property(t => t.EnterTime)
                .HasColumnName("ENTER_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.ArriveTime)
                .HasColumnName("ARRIVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.LeaveTime)
                .HasColumnName("LEAVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.IsFinished)
                .HasColumnName("IS_FINISHED")
                .HasColumnType("int(11)");

            builder.Property(t => t.Operator)
                .HasColumnName("OPERATOR")
                .HasColumnType("varchar(8)")
                .HasMaxLength(8);

            builder.Property(t => t.ResolveState)
                .HasColumnName("RESOLVE_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.AutoPreHint)
                .HasColumnName("AUTO_PRE_HINT")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckLoadList" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlTruckLoadList" /></summary>
            public const string Name = "t_pl_truck_load_list";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.OperationMark" /></summary>
            public const string OperationMark = "OPERATION_MARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.CardNo" /></summary>
            public const string CardNo = "CARD_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.TruckLoadingNo" /></summary>
            public const string TruckLoadingNo = "TRUCK_LOADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.MainTruckLoadingNo" /></summary>
            public const string MainTruckLoadingNo = "MAIN_TRUCK_LOADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.VehicleNo" /></summary>
            public const string VehicleNo = "VEHICLE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.SourceHouse" /></summary>
            public const string SourceHouse = "SOURCE_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.DeliveryOrderNo" /></summary>
            public const string DeliveryOrderNo = "DELIVERY_ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.ReplyInfo" /></summary>
            public const string ReplyInfo = "REPLY_INFO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.DetailNo" /></summary>
            public const string DetailNo = "DETAIL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.Count" /></summary>
            public const string Count = "COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.PlanOutBoundWeight" /></summary>
            public const string PlanOutBoundWeight = "PLAN_OUT_BOUND_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.CreateTimeLoadList" /></summary>
            public const string CreateTimeLoadList = "CREATE_TIME_LOAD_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.EnterTime" /></summary>
            public const string EnterTime = "ENTER_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.ArriveTime" /></summary>
            public const string ArriveTime = "ARRIVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.LeaveTime" /></summary>
            public const string LeaveTime = "LEAVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.IsFinished" /></summary>
            public const string IsFinished = "IS_FINISHED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.Operator" /></summary>
            public const string Operator = "OPERATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.ResolveState" /></summary>
            public const string ResolveState = "RESOLVE_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.AutoPreHint" /></summary>
            public const string AutoPreHint = "AUTO_PRE_HINT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlTruckLoadList.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
