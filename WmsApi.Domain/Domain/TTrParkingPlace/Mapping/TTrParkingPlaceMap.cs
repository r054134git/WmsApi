using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrParkingPlace" />
	/// </summary>
	public partial class TTrParkingPlaceMap
        : IEntityTypeConfiguration<Entities.TTrParkingPlace>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrParkingPlace" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrParkingPlace> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_parking_place");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ParkingPlaceId)
                .IsRequired()
                .HasColumnName("PARKING_PLACE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayCode)
                .IsRequired()
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ParkingPlaceName)
                .IsRequired()
                .HasColumnName("PARKING_PLACE_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.IsUsing)
                .IsRequired()
                .HasColumnName("IS_USING")
                .HasColumnType("int(1)");

            builder.Property(t => t.TransType)
                .IsRequired()
                .HasColumnName("TRANS_TYPE")
                .HasColumnType("int(1)");

            builder.Property(t => t.TransCode)
                .HasColumnName("TRANS_CODE")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CandidateTruck)
                .HasColumnName("CANDIDATE_TRUCK")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.GateId)
                .IsRequired()
                .HasColumnName("GATE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.GateState)
                .IsRequired()
                .HasColumnName("GATE_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.DispatchStepState)
                .HasColumnName("DISPATCH_STEP_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.HeadCenterX)
                .HasColumnName("HEAD_CENTER_X")
                .HasColumnType("int(10)");

            builder.Property(t => t.HeadCenterY)
                .HasColumnName("HEAD_CENTER_Y")
                .HasColumnType("int(10)");

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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrParkingPlace" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrParkingPlace" /></summary>
            public const string Name = "t_tr_parking_place";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.ParkingPlaceId" /></summary>
            public const string ParkingPlaceId = "PARKING_PLACE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.ParkingPlaceName" /></summary>
            public const string ParkingPlaceName = "PARKING_PLACE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.IsUsing" /></summary>
            public const string IsUsing = "IS_USING";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.TransType" /></summary>
            public const string TransType = "TRANS_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.TransCode" /></summary>
            public const string TransCode = "TRANS_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.CandidateTruck" /></summary>
            public const string CandidateTruck = "CANDIDATE_TRUCK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.GateId" /></summary>
            public const string GateId = "GATE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.GateState" /></summary>
            public const string GateState = "GATE_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.DispatchStepState" /></summary>
            public const string DispatchStepState = "DISPATCH_STEP_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.HeadCenterX" /></summary>
            public const string HeadCenterX = "HEAD_CENTER_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.HeadCenterY" /></summary>
            public const string HeadCenterY = "HEAD_CENTER_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrParkingPlace.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
