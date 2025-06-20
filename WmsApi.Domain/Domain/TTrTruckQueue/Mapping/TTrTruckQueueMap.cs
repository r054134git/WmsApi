using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrTruckQueue" />
	/// </summary>
	public partial class TTrTruckQueueMap
        : IEntityTypeConfiguration<Entities.TTrTruckQueue>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrTruckQueue" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrTruckQueue> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_truck_queue");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TruckCode)
                .IsRequired()
                .HasColumnName("TRUCK_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TransType)
                .IsRequired()
                .HasColumnName("TRANS_TYPE")
                .HasColumnType("int(1)");

            builder.Property(t => t.ListNo)
                .IsRequired()
                .HasColumnName("LIST_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.IsInFactory)
                .IsRequired()
                .HasColumnName("IS_IN_FACTORY")
                .HasColumnType("int(1)");

            builder.Property(t => t.EntryFactoryTime)
                .HasColumnName("ENTRY_FACTORY_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.DispatchParkingPlaceId)
                .HasColumnName("DISPATCH_PARKING_PLACE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.DispatchBayId)
                .HasColumnName("DISPATCH_BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.DispatchStepState)
                .IsRequired()
                .HasColumnName("DISPATCH_STEP_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.EntryBayIdList)
                .HasColumnName("ENTRY_BAY_ID_LIST")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IsInBay)
                .IsRequired()
                .HasColumnName("IS_IN_BAY")
                .HasColumnType("int(1)");

            builder.Property(t => t.EntryBayId)
                .HasColumnName("ENTRY_BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.EntryBayTime)
                .HasColumnName("ENTRY_BAY_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.Priority)
                .IsRequired()
                .HasColumnName("PRIORITY")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrTruckQueue" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrTruckQueue" /></summary>
            public const string Name = "t_tr_truck_queue";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.TruckCode" /></summary>
            public const string TruckCode = "TRUCK_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.TransType" /></summary>
            public const string TransType = "TRANS_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.ListNo" /></summary>
            public const string ListNo = "LIST_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.IsInFactory" /></summary>
            public const string IsInFactory = "IS_IN_FACTORY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.EntryFactoryTime" /></summary>
            public const string EntryFactoryTime = "ENTRY_FACTORY_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.DispatchParkingPlaceId" /></summary>
            public const string DispatchParkingPlaceId = "DISPATCH_PARKING_PLACE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.DispatchBayId" /></summary>
            public const string DispatchBayId = "DISPATCH_BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.DispatchStepState" /></summary>
            public const string DispatchStepState = "DISPATCH_STEP_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.EntryBayIdList" /></summary>
            public const string EntryBayIdList = "ENTRY_BAY_ID_LIST";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.IsInBay" /></summary>
            public const string IsInBay = "IS_IN_BAY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.EntryBayId" /></summary>
            public const string EntryBayId = "ENTRY_BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.EntryBayTime" /></summary>
            public const string EntryBayTime = "ENTRY_BAY_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.Priority" /></summary>
            public const string Priority = "PRIORITY";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTruckQueue.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
