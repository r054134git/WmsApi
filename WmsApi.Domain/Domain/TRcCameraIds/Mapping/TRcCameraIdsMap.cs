using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcCameraIds" />
    /// </summary>
    public partial class TRcCameraIdsMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcCameraIds>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcCameraIds" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcCameraIds> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_camera_ids");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.CameraCode)
                .HasColumnName("CAMERA_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.CameraName)
                .HasColumnName("CAMERA_NAME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.AlarmChannelName)
                .HasColumnName("ALARM_CHANNEL_NAME")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.AlarmType)
                .HasColumnName("ALARM_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlarmTime)
                .HasColumnName("ALARM_TIME")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.AlarmState)
                .HasColumnName("ALARM_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.AlarmPicture)
                .HasColumnName("ALARM_PICTURE")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.BayId)
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayName)
                .HasColumnName("BAY_NAME")
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
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcCameraIds" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcCameraIds" /></summary>
            public const string Name = "t_rc_camera_ids";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.CameraCode" /></summary>
            public const string CameraCode = "CAMERA_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.CameraName" /></summary>
            public const string CameraName = "CAMERA_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.AlarmChannelName" /></summary>
            public const string AlarmChannelName = "ALARM_CHANNEL_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.AlarmType" /></summary>
            public const string AlarmType = "ALARM_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.AlarmTime" /></summary>
            public const string AlarmTime = "ALARM_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.AlarmState" /></summary>
            public const string AlarmState = "ALARM_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.AlarmPicture" /></summary>
            public const string AlarmPicture = "ALARM_PICTURE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcCameraIds.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
