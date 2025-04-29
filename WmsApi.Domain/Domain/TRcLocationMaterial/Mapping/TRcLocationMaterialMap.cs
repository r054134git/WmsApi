using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TRcLocationMaterial" />
    /// </summary>
    public partial class TRcLocationMaterialMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TRcLocationMaterial>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TRcLocationMaterial" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TRcLocationMaterial> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_rc_location_material");

            // key
            builder.HasKey(t => new { t.Id, t.BayId });

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.WarehouseId)
                .IsRequired()
                .HasColumnName("WAREHOUSE_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayId)
                .IsRequired()
                .HasColumnName("BAY_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.AreaId)
                .IsRequired()
                .HasColumnName("AREA_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.StackId)
                .IsRequired()
                .HasColumnName("STACK_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LocationId)
                .IsRequired()
                .HasColumnName("LOCATION_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.LocationName)
                .IsRequired()
                .HasColumnName("LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.AreaCode)
                .IsRequired()
                .HasColumnName("AREA_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.RowNo)
                .HasColumnName("ROW_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.ColNo)
                .IsRequired()
                .HasColumnName("COL_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.FloorNo)
                .IsRequired()
                .HasColumnName("FLOOR_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsVirtual)
                .IsRequired()
                .HasColumnName("IS_VIRTUAL")
                .HasColumnType("int(1)");

            builder.Property(t => t.OwnerBussinessName)
                .IsRequired()
                .HasColumnName("OWNER_BUSSINESS_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.IsSharedToC3)
                .IsRequired()
                .HasColumnName("IS_SHARED_TO_C3")
                .HasColumnType("int(1)");

            builder.Property(t => t.AreaCodeC3)
                .HasColumnName("AREA_CODE_C3")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PointX)
                .IsRequired()
                .HasColumnName("POINT_X")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.PointY)
                .IsRequired()
                .HasColumnName("POINT_Y")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.PointZ)
                .IsRequired()
                .HasColumnName("POINT_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MaxZ)
                .HasColumnName("MAX_Z")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.Angle)
                .IsRequired()
                .HasColumnName("ANGLE")
                .HasColumnType("int(11)");

            builder.Property(t => t.Orientation)
                .IsRequired()
                .HasColumnName("ORIENTATION")
                .HasColumnType("int(11)");

            builder.Property(t => t.BaseWidth)
                .IsRequired()
                .HasColumnName("BASE_WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BaseLength)
                .IsRequired()
                .HasColumnName("BASE_LENGTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BaseHeight)
                .IsRequired()
                .HasColumnName("BASE_HEIGHT")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.StorageType)
                .IsRequired()
                .HasColumnName("STORAGE_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.LoadType)
                .IsRequired()
                .HasColumnName("LOAD_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.MaterialId)
                .HasColumnName("MATERIAL_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MaterialNo)
                .HasColumnName("MATERIAL_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MaterialOwner)
                .HasColumnName("MATERIAL_OWNER")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.ProcessCode)
                .HasColumnName("PROCESS_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.NextProcessCode)
                .HasColumnName("NEXT_PROCESS_CODE")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Thick)
                .HasColumnName("THICK")
                .HasColumnType("decimal(7,2)");

            builder.Property(t => t.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.Weight)
                .HasColumnName("WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.Length)
                .HasColumnName("LENGTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.Diameter)
                .HasColumnName("DIAMETER")
                .HasColumnType("int(11)");

            builder.Property(t => t.InnerDiameter)
                .HasColumnName("INNER_DIAMETER")
                .HasColumnType("int(11)");

            builder.Property(t => t.ProductPackFlag)
                .HasColumnName("PRODUCT_PACK_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.IsDistributionShip)
                .HasColumnName("IS_DISTRIBUTION_SHIP")
                .HasColumnType("int(11)");

            builder.Property(t => t.SteelGrade)
                .HasColumnName("STEEL_GRADE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ProdTime)
                .HasColumnName("PROD_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.SgSign)
                .HasColumnName("SG_SIGN")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SgStd)
                .HasColumnName("SG_STD")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.OrderNo)
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MatDirection)
                .HasColumnName("MAT_DIRECTION")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.MatStatus)
                .HasColumnName("MAT_STATUS")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.MatDisposeCode)
                .HasColumnName("MAT_DISPOSE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.IsOrdered)
                .HasColumnName("IS_ORDERED")
                .HasColumnType("int(11)");

            builder.Property(t => t.HoldFlag)
                .HasColumnName("HOLD_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.HoldCauseCode)
                .HasColumnName("HOLD_CAUSE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.HoldRemark)
                .HasColumnName("HOLD_REMARK")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.RelMaker)
                .HasColumnName("REL_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.RelRemark)
                .HasColumnName("REL_REMARK")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.RelTime)
                .HasColumnName("REL_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.BillOfLadingNo)
                .HasColumnName("BILL_OF_LADING_NO")
                .HasColumnType("varchar(13)")
                .HasMaxLength(13);

            builder.Property(t => t.ComplexDecideCode)
                .HasColumnName("COMPLEX_DECIDE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.OrderName)
                .HasColumnName("ORDER_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CustomerName)
                .HasColumnName("CUSTOMER_NAME")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.CustomerCode)
                .HasColumnName("CUSTOMER_CODE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Status)
                .HasColumnName("STATUS")
                .HasColumnType("int(11)");

            builder.Property(t => t.SourceType)
                .HasColumnName("SOURCE_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.HeadDirection)
                .HasColumnName("HEAD_DIRECTION")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsLoadEnable)
                .HasColumnName("IS_LOAD_ENABLE")
                .HasColumnType("int(11)");

            builder.Property(t => t.Description)
                .HasColumnName("DESCRIPTION")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PickState)
                .HasColumnName("PICK_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.PrepickTransferNo)
                .HasColumnName("PREPICK_TRANSFER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.TruckLoadListId)
                .HasColumnName("TRUCK_LOAD_LIST_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.StockSyncTime)
                .HasColumnName("STOCK_SYNC_TIME")
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

            builder.Property(t => t.ShiftStratTime)
                .HasColumnName("SHIFT_STRAT_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.ShiftEndTime)
                .HasColumnName("SHIFT_END_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.ShiftDayNight)
                .HasColumnName("SHIFT_DAY_NIGHT")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.ShiftName)
                .HasColumnName("SHIFT_NAME")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.MaterialLockedFlag)
                .IsRequired()
                .HasColumnName("MATERIAL_LOCKED_FLAG")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2)
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.PlanCmdC3)
                .HasColumnName("PLAN_CMD_C3")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TRcLocationMaterial" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TRcLocationMaterial" /></summary>
            public const string Name = "t_rc_location_material";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.WarehouseId" /></summary>
            public const string WarehouseId = "WAREHOUSE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.AreaId" /></summary>
            public const string AreaId = "AREA_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.StackId" /></summary>
            public const string StackId = "STACK_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.LocationId" /></summary>
            public const string LocationId = "LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.LocationName" /></summary>
            public const string LocationName = "LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.AreaCode" /></summary>
            public const string AreaCode = "AREA_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.RowNo" /></summary>
            public const string RowNo = "ROW_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ColNo" /></summary>
            public const string ColNo = "COL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.FloorNo" /></summary>
            public const string FloorNo = "FLOOR_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.IsVirtual" /></summary>
            public const string IsVirtual = "IS_VIRTUAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.OwnerBussinessName" /></summary>
            public const string OwnerBussinessName = "OWNER_BUSSINESS_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.IsSharedToC3" /></summary>
            public const string IsSharedToC3 = "IS_SHARED_TO_C3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.AreaCodeC3" /></summary>
            public const string AreaCodeC3 = "AREA_CODE_C3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.PointX" /></summary>
            public const string PointX = "POINT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.PointY" /></summary>
            public const string PointY = "POINT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.PointZ" /></summary>
            public const string PointZ = "POINT_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.MaxZ" /></summary>
            public const string MaxZ = "MAX_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Angle" /></summary>
            public const string Angle = "ANGLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Orientation" /></summary>
            public const string Orientation = "ORIENTATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.BaseWidth" /></summary>
            public const string BaseWidth = "BASE_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.BaseLength" /></summary>
            public const string BaseLength = "BASE_LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.BaseHeight" /></summary>
            public const string BaseHeight = "BASE_HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.StorageType" /></summary>
            public const string StorageType = "STORAGE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.LoadType" /></summary>
            public const string LoadType = "LOAD_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.MaterialOwner" /></summary>
            public const string MaterialOwner = "MATERIAL_OWNER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ProcessCode" /></summary>
            public const string ProcessCode = "PROCESS_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.NextProcessCode" /></summary>
            public const string NextProcessCode = "NEXT_PROCESS_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Thick" /></summary>
            public const string Thick = "THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Weight" /></summary>
            public const string Weight = "WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Length" /></summary>
            public const string Length = "LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Diameter" /></summary>
            public const string Diameter = "DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.InnerDiameter" /></summary>
            public const string InnerDiameter = "INNER_DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ProductPackFlag" /></summary>
            public const string ProductPackFlag = "PRODUCT_PACK_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.IsDistributionShip" /></summary>
            public const string IsDistributionShip = "IS_DISTRIBUTION_SHIP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.SteelGrade" /></summary>
            public const string SteelGrade = "STEEL_GRADE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ProdTime" /></summary>
            public const string ProdTime = "PROD_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.SgSign" /></summary>
            public const string SgSign = "SG_SIGN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.SgStd" /></summary>
            public const string SgStd = "SG_STD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.MatDirection" /></summary>
            public const string MatDirection = "MAT_DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.MatStatus" /></summary>
            public const string MatStatus = "MAT_STATUS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.MatDisposeCode" /></summary>
            public const string MatDisposeCode = "MAT_DISPOSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.IsOrdered" /></summary>
            public const string IsOrdered = "IS_ORDERED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.HoldFlag" /></summary>
            public const string HoldFlag = "HOLD_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.HoldCauseCode" /></summary>
            public const string HoldCauseCode = "HOLD_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.HoldRemark" /></summary>
            public const string HoldRemark = "HOLD_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.RelMaker" /></summary>
            public const string RelMaker = "REL_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.RelRemark" /></summary>
            public const string RelRemark = "REL_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.RelTime" /></summary>
            public const string RelTime = "REL_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.BillOfLadingNo" /></summary>
            public const string BillOfLadingNo = "BILL_OF_LADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ComplexDecideCode" /></summary>
            public const string ComplexDecideCode = "COMPLEX_DECIDE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.OrderName" /></summary>
            public const string OrderName = "ORDER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.CustomerName" /></summary>
            public const string CustomerName = "CUSTOMER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.CustomerCode" /></summary>
            public const string CustomerCode = "CUSTOMER_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Status" /></summary>
            public const string Status = "STATUS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.SourceType" /></summary>
            public const string SourceType = "SOURCE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.HeadDirection" /></summary>
            public const string HeadDirection = "HEAD_DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.IsLoadEnable" /></summary>
            public const string IsLoadEnable = "IS_LOAD_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Description" /></summary>
            public const string Description = "DESCRIPTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.PickState" /></summary>
            public const string PickState = "PICK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.PrepickTransferNo" /></summary>
            public const string PrepickTransferNo = "PREPICK_TRANSFER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.TruckLoadListId" /></summary>
            public const string TruckLoadListId = "TRUCK_LOAD_LIST_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.StockSyncTime" /></summary>
            public const string StockSyncTime = "STOCK_SYNC_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.Remark" /></summary>
            public const string Remark = "REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ShiftStratTime" /></summary>
            public const string ShiftStratTime = "SHIFT_STRAT_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ShiftEndTime" /></summary>
            public const string ShiftEndTime = "SHIFT_END_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ShiftDayNight" /></summary>
            public const string ShiftDayNight = "SHIFT_DAY_NIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.ShiftName" /></summary>
            public const string ShiftName = "SHIFT_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.MaterialLockedFlag" /></summary>
            public const string MaterialLockedFlag = "MATERIAL_LOCKED_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TRcLocationMaterial.PlanCmdC3" /></summary>
            public const string PlanCmdC3 = "PLAN_CMD_C3";
        }
        #endregion
    }
}
