using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TRcTrainNode" />
	/// </summary>
	public partial class TRcTrainNodeMap
        : IEntityTypeConfiguration<Entities.TRcTrainNode>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TRcTrainNode" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TRcTrainNode> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_train_node");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.TrainName)
                .IsRequired()
                .HasColumnName("TRAIN_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.NodeName)
                .HasColumnName("NODE_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ArriveTime)
                .HasColumnName("ARRIVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.LeaveTime)
                .HasColumnName("LEAVE_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.Direction)
                .HasColumnName("DIRECTION")
                .HasColumnType("int(11)");

            builder.Property(t => t.CreateTime)
                .IsRequired()
                .HasColumnName("CREATE_TIME")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcTrainNode" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcTrainNode" /></summary>
            public const string Name = "t_rc_train_node";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainNode.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainNode.TrainName" /></summary>
            public const string TrainName = "TRAIN_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainNode.NodeName" /></summary>
            public const string NodeName = "NODE_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainNode.ArriveTime" /></summary>
            public const string ArriveTime = "ARRIVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainNode.LeaveTime" /></summary>
            public const string LeaveTime = "LEAVE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainNode.Direction" /></summary>
            public const string Direction = "DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcTrainNode.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
        }
        #endregion
    }
}
