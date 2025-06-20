using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.TTrLocationMaterial" />
    /// </summary>
    public partial class TTrLocationMaterialMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.TTrLocationMaterial>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.TTrLocationMaterial" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.TTrLocationMaterial> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("t_tr_location_material");

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

            builder.Property(t => t.BundlePackageNo)
                .HasColumnName("BUNDLE_PACKAGE_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

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

            builder.Property(t => t.DecideThick)
                .HasColumnName("DECIDE_THICK")
                .HasColumnType("decimal(7,2)");

            builder.Property(t => t.DecideWidth)
                .HasColumnName("DECIDE_WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.ProductPackFlag)
                .HasColumnName("PRODUCT_PACK_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PackingTypeCode)
                .HasColumnName("PACKING_TYPE_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.ProductPackTime)
                .HasColumnName("PRODUCT_PACK_TIME")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.IsDistributionShip)
                .HasColumnName("IS_DISTRIBUTION_SHIP")
                .HasColumnType("int(11)");

            builder.Property(t => t.TrnpModeCode)
                .HasColumnName("TRNP_MODE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SteelGrade)
                .HasColumnName("STEEL_GRADE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.TrimFlag)
                .HasColumnName("TRIM_FLAG")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

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

            builder.Property(t => t.Terminal)
                .HasColumnName("TERMINAL")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.PortLotNumber)
                .HasColumnName("PORT_LOT_NUMBER")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

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

            builder.Property(t => t.LockMark)
                .HasColumnName("LOCK_MARK")
                .HasColumnType("int(11)");

            builder.Property(t => t.LockReason)
                .HasColumnName("LOCK_REASON")
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
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.TTrLocationMaterial" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.TTrLocationMaterial" /></summary>
            public const string Name = "t_tr_location_material";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.WarehouseId" /></summary>
            public const string WarehouseId = "WAREHOUSE_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.BayId" /></summary>
            public const string BayId = "BAY_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.AreaId" /></summary>
            public const string AreaId = "AREA_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.StackId" /></summary>
            public const string StackId = "STACK_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.LocationId" /></summary>
            public const string LocationId = "LOCATION_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.LocationName" /></summary>
            public const string LocationName = "LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.AreaCode" /></summary>
            public const string AreaCode = "AREA_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.RowNo" /></summary>
            public const string RowNo = "ROW_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.ColNo" /></summary>
            public const string ColNo = "COL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.FloorNo" /></summary>
            public const string FloorNo = "FLOOR_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.IsVirtual" /></summary>
            public const string IsVirtual = "IS_VIRTUAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.OwnerBussinessName" /></summary>
            public const string OwnerBussinessName = "OWNER_BUSSINESS_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.IsSharedToC3" /></summary>
            public const string IsSharedToC3 = "IS_SHARED_TO_C3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.AreaCodeC3" /></summary>
            public const string AreaCodeC3 = "AREA_CODE_C3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.PointX" /></summary>
            public const string PointX = "POINT_X";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.PointY" /></summary>
            public const string PointY = "POINT_Y";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.PointZ" /></summary>
            public const string PointZ = "POINT_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.MaxZ" /></summary>
            public const string MaxZ = "MAX_Z";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Angle" /></summary>
            public const string Angle = "ANGLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Orientation" /></summary>
            public const string Orientation = "ORIENTATION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.BaseWidth" /></summary>
            public const string BaseWidth = "BASE_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.BaseLength" /></summary>
            public const string BaseLength = "BASE_LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.BaseHeight" /></summary>
            public const string BaseHeight = "BASE_HEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.StorageType" /></summary>
            public const string StorageType = "STORAGE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.LoadType" /></summary>
            public const string LoadType = "LOAD_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.MaterialId" /></summary>
            public const string MaterialId = "MATERIAL_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.MaterialNo" /></summary>
            public const string MaterialNo = "MATERIAL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.MaterialOwner" /></summary>
            public const string MaterialOwner = "MATERIAL_OWNER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.BundlePackageNo" /></summary>
            public const string BundlePackageNo = "BUNDLE_PACKAGE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.ProcessCode" /></summary>
            public const string ProcessCode = "PROCESS_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.NextProcessCode" /></summary>
            public const string NextProcessCode = "NEXT_PROCESS_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Thick" /></summary>
            public const string Thick = "THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Weight" /></summary>
            public const string Weight = "WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Length" /></summary>
            public const string Length = "LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Diameter" /></summary>
            public const string Diameter = "DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.InnerDiameter" /></summary>
            public const string InnerDiameter = "INNER_DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.DecideThick" /></summary>
            public const string DecideThick = "DECIDE_THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.DecideWidth" /></summary>
            public const string DecideWidth = "DECIDE_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.ProductPackFlag" /></summary>
            public const string ProductPackFlag = "PRODUCT_PACK_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.PackingTypeCode" /></summary>
            public const string PackingTypeCode = "PACKING_TYPE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.ProductPackTime" /></summary>
            public const string ProductPackTime = "PRODUCT_PACK_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.IsDistributionShip" /></summary>
            public const string IsDistributionShip = "IS_DISTRIBUTION_SHIP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.TrnpModeCode" /></summary>
            public const string TrnpModeCode = "TRNP_MODE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.SteelGrade" /></summary>
            public const string SteelGrade = "STEEL_GRADE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.TrimFlag" /></summary>
            public const string TrimFlag = "TRIM_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.ProdTime" /></summary>
            public const string ProdTime = "PROD_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.SgSign" /></summary>
            public const string SgSign = "SG_SIGN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.SgStd" /></summary>
            public const string SgStd = "SG_STD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.MatDirection" /></summary>
            public const string MatDirection = "MAT_DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.MatStatus" /></summary>
            public const string MatStatus = "MAT_STATUS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.MatDisposeCode" /></summary>
            public const string MatDisposeCode = "MAT_DISPOSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.IsOrdered" /></summary>
            public const string IsOrdered = "IS_ORDERED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.HoldFlag" /></summary>
            public const string HoldFlag = "HOLD_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.HoldCauseCode" /></summary>
            public const string HoldCauseCode = "HOLD_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.HoldRemark" /></summary>
            public const string HoldRemark = "HOLD_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.RelMaker" /></summary>
            public const string RelMaker = "REL_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.RelRemark" /></summary>
            public const string RelRemark = "REL_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.RelTime" /></summary>
            public const string RelTime = "REL_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.BillOfLadingNo" /></summary>
            public const string BillOfLadingNo = "BILL_OF_LADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.ComplexDecideCode" /></summary>
            public const string ComplexDecideCode = "COMPLEX_DECIDE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.OrderName" /></summary>
            public const string OrderName = "ORDER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.CustomerName" /></summary>
            public const string CustomerName = "CUSTOMER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.CustomerCode" /></summary>
            public const string CustomerCode = "CUSTOMER_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Terminal" /></summary>
            public const string Terminal = "TERMINAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.PortLotNumber" /></summary>
            public const string PortLotNumber = "PORT_LOT_NUMBER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Status" /></summary>
            public const string Status = "STATUS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.SourceType" /></summary>
            public const string SourceType = "SOURCE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.HeadDirection" /></summary>
            public const string HeadDirection = "HEAD_DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.IsLoadEnable" /></summary>
            public const string IsLoadEnable = "IS_LOAD_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Description" /></summary>
            public const string Description = "DESCRIPTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.PickState" /></summary>
            public const string PickState = "PICK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.PrepickTransferNo" /></summary>
            public const string PrepickTransferNo = "PREPICK_TRANSFER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.TruckLoadListId" /></summary>
            public const string TruckLoadListId = "TRUCK_LOAD_LIST_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.StockSyncTime" /></summary>
            public const string StockSyncTime = "STOCK_SYNC_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.LockMark" /></summary>
            public const string LockMark = "LOCK_MARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.LockReason" /></summary>
            public const string LockReason = "LOCK_REASON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.TTrLocationMaterial.Remark" /></summary>
            public const string Remark = "REMARK";
        }
        #endregion
    }
}
