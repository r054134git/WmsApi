using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
	/// <summary>
	/// Allows configuration for an entity type <see cref="Entities.TPlBackReturn" />
	/// </summary>
	public partial class TPlBackReturnMap
        : IEntityTypeConfiguration<Entities.TPlBackReturn>
    {
		/// <summary>
		/// Configures the entity of type <see cref="Entities.TPlBackReturn" />
		/// </summary>
		/// <param name="builder">The builder to be used to configure the entity type.</param>
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entities.TPlBackReturn> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_pl_back_return");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialNo)
                .IsRequired()
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Mode)
                .IsRequired()
                .HasColumnName("MODE")
                .HasColumnType("int(1)");

            builder.Property(t => t.Reason)
                .HasColumnName("REASON")
                .HasColumnType("int(1)");

            builder.Property(t => t.RetReason)
                .HasColumnName("RET_REASON")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.VehicleType)
                .HasColumnName("VEHICLE_TYPE")
                .HasColumnType("int(1)");

            builder.Property(t => t.RetType)
                .HasColumnName("RET_TYPE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.RequestSource)
                .HasColumnName("REQUEST_SOURCE")
                .HasColumnType("int(1)");

            builder.Property(t => t.RetSource)
                .HasColumnName("RET_SOURCE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.IsRequestCofirm)
                .HasColumnName("IS_REQUEST_COFIRM")
                .HasColumnType("int(1)");

            builder.Property(t => t.RetLocation)
                .HasColumnName("RET_LOCATION")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.BackLocation)
                .HasColumnName("BACK_LOCATION")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.PlanState)
                .HasColumnName("PLAN_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ExecState)
                .HasColumnName("EXEC_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ResolveState)
                .HasColumnName("RESOLVE_STATE")
                .HasColumnType("int(1)");

            builder.Property(t => t.PriorityOperator)
                .HasColumnName("PRIORITY_OPERATOR")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TPlBackReturn" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TPlBackReturn" /></summary>
            public const string Name = "t_pl_back_return";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.Mode" /></summary>
            public const string Mode = "MODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.Reason" /></summary>
            public const string Reason = "REASON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.RetReason" /></summary>
            public const string RetReason = "RET_REASON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.VehicleType" /></summary>
            public const string VehicleType = "VEHICLE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.RetType" /></summary>
            public const string RetType = "RET_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.RequestSource" /></summary>
            public const string RequestSource = "REQUEST_SOURCE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.RetSource" /></summary>
            public const string RetSource = "RET_SOURCE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.IsRequestCofirm" /></summary>
            public const string IsRequestCofirm = "IS_REQUEST_COFIRM";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.RetLocation" /></summary>
            public const string RetLocation = "RET_LOCATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.BackLocation" /></summary>
            public const string BackLocation = "BACK_LOCATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.PlanState" /></summary>
            public const string PlanState = "PLAN_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.ExecState" /></summary>
            public const string ExecState = "EXEC_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.ResolveState" /></summary>
            public const string ResolveState = "RESOLVE_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.PriorityOperator" /></summary>
            public const string PriorityOperator = "PRIORITY_OPERATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TPlBackReturn.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
