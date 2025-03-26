using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TTrTrain" />
	/// </summary>
	public partial class TTrTrainMap
        : IEntityTypeConfiguration<Entities.TTrTrain>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TTrTrain" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TTrTrain> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_train");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TrainId)
                .HasColumnName("TRAIN_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.HouseId)
                .HasColumnName("HOUSE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.DispatchState)
                .HasColumnName("DISPATCH_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.PositionId)
                .HasColumnName("POSITION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Direction)
                .HasColumnName("DIRECTION")
                .HasColumnType("int(11)");

            builder.Property(t => t.DestHouse)
                .HasColumnName("DEST_HOUSE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.LoadType)
                .HasColumnName("LOAD_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.SourceHouse)
                .HasColumnName("SOURCE_HOUSE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.TrainHeadState)
                .HasColumnName("TRAIN_HEAD_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.InboundCheckState)
                .HasColumnName("INBOUND_CHECK_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsPickedCoilConfirmed)
                .HasColumnName("IS_PICKED_COIL_CONFIRMED")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsLoadPlansConfirmed)
                .HasColumnName("IS_LOAD_PLANS_CONFIRMED")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsFault)
                .HasColumnName("IS_FAULT")
                .HasColumnType("int(11)");

            builder.Property(t => t.TrainNo)
                .HasColumnName("TRAIN_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.CurrentTeamConfirmed)
                .HasColumnName("CURRENT_TEAM_CONFIRMED")
                .HasColumnType("int(11)");

            builder.Property(t => t.TrainIndex)
                .HasColumnName("TRAIN_INDEX")
                .HasColumnType("int(11)");

            builder.Property(t => t.BeforeTrainId)
                .HasColumnName("BEFORE_TRAIN_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LaserDistance)
                .HasColumnName("LASER_DISTANCE")
                .HasColumnType("int(11)");

            builder.Property(t => t.PickCoilsMode)
                .HasColumnName("PICK_COILS_MODE")
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
            builder.HasOne(t => t.HouseTWhBay)
                .WithMany(t => t.HouseTTrTrains)
                .HasForeignKey(d => d.HouseId)
                .HasConstraintName("FK_TR_HOUSE_ID");

            builder.HasOne(t => t.PositionTScDictionary)
                .WithMany(t => t.PositionTTrTrains)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_TR_POSITION_ID");

            builder.HasOne(t => t.TrainTEqTrain)
                .WithMany(t => t.TrainTTrTrains)
                .HasForeignKey(d => d.TrainId)
                .HasConstraintName("FK_TR_TRAIN_ID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrTrain" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrTrain" /></summary>
            public const string Name = "t_tr_train";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.TrainId" /></summary>
            public const string TrainId = "TRAIN_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.HouseId" /></summary>
            public const string HouseId = "HOUSE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.DispatchState" /></summary>
            public const string DispatchState = "DISPATCH_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.PositionId" /></summary>
            public const string PositionId = "POSITION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.Direction" /></summary>
            public const string Direction = "DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.DestHouse" /></summary>
            public const string DestHouse = "DEST_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.LoadType" /></summary>
            public const string LoadType = "LOAD_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.SourceHouse" /></summary>
            public const string SourceHouse = "SOURCE_HOUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.TrainHeadState" /></summary>
            public const string TrainHeadState = "TRAIN_HEAD_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.InboundCheckState" /></summary>
            public const string InboundCheckState = "INBOUND_CHECK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.IsPickedCoilConfirmed" /></summary>
            public const string IsPickedCoilConfirmed = "IS_PICKED_COIL_CONFIRMED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.IsLoadPlansConfirmed" /></summary>
            public const string IsLoadPlansConfirmed = "IS_LOAD_PLANS_CONFIRMED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.IsFault" /></summary>
            public const string IsFault = "IS_FAULT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.TrainNo" /></summary>
            public const string TrainNo = "TRAIN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.CurrentTeamConfirmed" /></summary>
            public const string CurrentTeamConfirmed = "CURRENT_TEAM_CONFIRMED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.TrainIndex" /></summary>
            public const string TrainIndex = "TRAIN_INDEX";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.BeforeTrainId" /></summary>
            public const string BeforeTrainId = "BEFORE_TRAIN_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.LaserDistance" /></summary>
            public const string LaserDistance = "LASER_DISTANCE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.PickCoilsMode" /></summary>
            public const string PickCoilsMode = "PICK_COILS_MODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrTrain.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
