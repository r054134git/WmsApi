using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.VPlMaterial" />
    /// </summary>
    public partial class VPlMaterialMap
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.VPlMaterial>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.VPlMaterial" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.VPlMaterial> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("v_pl_material");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.RecCreator)
                .HasColumnName("REC_CREATOR")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.RecCreateTime)
                .HasColumnName("REC_CREATE_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.RecRevisor)
                .HasColumnName("REC_REVISOR")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.RecReviseTime)
                .HasColumnName("REC_REVISE_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.RecCreateReason)
                .HasColumnName("REC_CREATE_REASON")
                .HasColumnType("int(11)");

            builder.Property(t => t.No)
                .IsRequired()
                .HasColumnName("NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MotherNo)
                .HasColumnName("MOTHER_NO")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

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
                .IsRequired()
                .HasColumnName("THICK")
                .HasColumnType("decimal(7,2)");

            builder.Property(t => t.Width)
                .IsRequired()
                .HasColumnName("WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.Weight)
                .IsRequired()
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

            builder.Property(t => t.MatShapeFlag)
                .HasColumnName("MAT_SHAPE_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.MatStatus)
                .HasColumnName("MAT_STATUS")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.MatTargThick)
                .HasColumnName("MAT_TARG_THICK")
                .HasColumnType("decimal(7,3)");

            builder.Property(t => t.MatTargWidth)
                .HasColumnName("MAT_TARG_WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.MatTargLen)
                .HasColumnName("MAT_TARG_LEN")
                .HasColumnType("int(11)");

            builder.Property(t => t.MatActWt)
                .HasColumnName("MAT_ACT_WT")
                .HasColumnType("int(11)");

            builder.Property(t => t.MatTheoryWt)
                .HasColumnName("MAT_THEORY_WT")
                .HasColumnType("int(11)");

            builder.Property(t => t.MeasureWtFlag)
                .HasColumnName("MEASURE_WT_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.ProductPackFlag)
                .HasColumnName("PRODUCT_PACK_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.IsDistributionShip)
                .HasColumnName("IS_DISTRIBUTION_SHIP")
                .HasColumnType("int(11)");

            builder.Property(t => t.Pono)
                .HasColumnName("PONO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.HeatNo)
                .HasColumnName("HEAT_NO")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.SteelGrade)
                .HasColumnName("STEEL_GRADE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ProdTime)
                .HasColumnName("PROD_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.ProdShiftNo)
                .HasColumnName("PROD_SHIFT_NO")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.ProdShiftGroup)
                .HasColumnName("PROD_SHIFT_GROUP")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SgSign)
                .HasColumnName("SG_SIGN")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SgStd)
                .HasColumnName("SG_STD")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.OldSgSign)
                .HasColumnName("OLD_SG_SIGN")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.OldSgStd)
                .HasColumnName("OLD_SG_STD")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.OrderNo)
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OldOrderNo)
                .HasColumnName("OLD_ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MatDirection)
                .HasColumnName("MAT_DIRECTION")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.TrnpModeCode)
                .HasColumnName("TRNP_MODE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PackingTypeCode)
                .HasColumnName("PACKING_TYPE_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.DecideThick)
                .HasColumnName("DECIDE_THICK")
                .HasColumnType("decimal(7,2)");

            builder.Property(t => t.DecideWidth)
                .HasColumnName("DECIDE_WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.LabelDemand)
                .HasColumnName("LABEL_DEMAND")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IsOrdered)
                .HasColumnName("IS_ORDERED")
                .HasColumnType("int(11)");

            builder.Property(t => t.ReadyState)
                .HasColumnName("READY_STATE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.ProdCode)
                .HasColumnName("PROD_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.ProdCname)
                .HasColumnName("PROD_CNAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.ProdEname)
                .HasColumnName("PROD_ENAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.HoldFlag)
                .HasColumnName("HOLD_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.HoldCauseCode)
                .HasColumnName("HOLD_CAUSE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.HoldTime)
                .HasColumnName("HOLD_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.HoldMaker)
                .HasColumnName("HOLD_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.ColorDemand)
                .HasColumnName("COLOR_DEMAND")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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

            builder.Property(t => t.RemainDecideCode)
                .HasColumnName("REMAIN_DECIDE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.RemainCauseCode)
                .HasColumnName("REMAIN_CAUSE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.RemainDecideTime)
                .HasColumnName("REMAIN_DECIDE_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.RemainDecideMaker)
                .HasColumnName("REMAIN_DECIDE_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.RemainRemark)
                .HasColumnName("REMAIN_REMARK")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.Msc)
                .HasColumnName("MSC")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OldMsc)
                .HasColumnName("OLD_MSC")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Psc)
                .HasColumnName("PSC")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.OldPsc)
                .HasColumnName("OLD_PSC")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.Apn)
                .HasColumnName("APN")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.OldApn)
                .HasColumnName("OLD_APN")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.BillOfLadingNo)
                .HasColumnName("BILL_OF_LADING_NO")
                .HasColumnType("varchar(13)")
                .HasMaxLength(13);

            builder.Property(t => t.MatDisposeCode)
                .HasColumnName("MAT_DISPOSE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

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

            builder.Property(t => t.OnlineWeight)
                .HasColumnName("ONLINE_WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.OfflineWeight)
                .HasColumnName("OFFLINE_WEIGHT")
                .HasColumnType("int(11)");

            builder.Property(t => t.DeliveryDate)
                .HasColumnName("DELIVERY_DATE")
                .HasColumnType("varchar(8)")
                .HasMaxLength(8);

            builder.Property(t => t.EndUserCode)
                .HasColumnName("END_USER_CODE")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.StockType)
                .HasColumnName("STOCK_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.DefectType)
                .HasColumnName("DEFECT_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.IsHandleDefect)
                .HasColumnName("IS_HANDLE_DEFECT")
                .HasColumnType("int(11)");

            builder.Property(t => t.OnTrainType)
                .HasColumnName("ON_TRAIN_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.ReturnReasonType)
                .HasColumnName("RETURN_REASON_TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.PickState)
                .HasColumnName("PICK_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.PrepickTransferNo)
                .HasColumnName("PREPICK_TRANSFER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DeliverPickState)
                .HasColumnName("DELIVER_PICK_STATE")
                .HasColumnType("int(11)");

            builder.Property(t => t.TruckLoadListId)
                .HasColumnName("TRUCK_LOAD_LIST_ID")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.DetailRequestCount)
                .HasColumnName("DETAIL_REQUEST_COUNT")
                .HasColumnType("int(11)");

            builder.Property(t => t.DefectRecorder)
                .HasColumnName("DEFECT_RECORDER")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DefectRecordTime)
                .HasColumnName("DEFECT_RECORD_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.DefectDesc)
                .HasColumnName("DEFECT_DESC")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.WeightChangedTime)
                .HasColumnName("WEIGHT_CHANGED_TIME")
                .HasColumnType("datetime");

            builder.Property(t => t.WeightChangedType)
                .HasColumnName("WEIGHT_CHANGED_TYPE")
                .HasColumnType("int(11) unsigned zerofill");

            builder.Property(t => t.BayName)
                .HasColumnName("BAY_NAME")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MaterialLocationOwner)
                .IsRequired()
                .HasColumnName("MATERIAL_LOCATION_OWNER")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.MaterialBussinessOwner)
                .HasColumnName("MATERIAL_BUSSINESS_OWNER")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

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

            builder.Property(t => t.LockMark)
                .HasColumnName("LOCK_MARK")
                .HasColumnType("int(11)");

            builder.Property(t => t.LockReason)
                .HasColumnName("LOCK_REASON")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.PortLotNumber)
                .HasColumnName("PORT_LOT_NUMBER")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.Terminal)
                .HasColumnName("TERMINAL")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.BelongTerminal)
                .HasColumnName("BELONG_TERMINAL")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.BelongDecideWidth)
                .HasColumnName("BELONG_DECIDE_WIDTH")
                .HasColumnType("int(11)");

            builder.Property(t => t.Remark)
                .HasColumnName("REMARK")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Type)
                .HasColumnName("TYPE")
                .HasColumnType("int(11)");

            builder.Property(t => t.LocationName)
                .HasColumnName("LOCATION_NAME")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.OwnerBussinessName)
                .HasColumnName("OWNER_BUSSINESS_NAME")
                .HasColumnType("varchar(32)")
                .HasMaxLength(32);

            builder.Property(t => t.BayCode)
                .HasColumnName("BAY_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.AreaCode)
                .HasColumnName("AREA_CODE")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.ColNo)
                .HasColumnName("COL_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.RowNo)
                .HasColumnName("ROW_NO")
                .HasColumnType("int(11)");

            builder.Property(t => t.FloorNo)
                .HasColumnName("FLOOR_NO")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.VPlMaterial" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.VPlMaterial" /></summary>
            public const string Name = "v_pl_material";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RecCreator" /></summary>
            public const string RecCreator = "REC_CREATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RecCreateTime" /></summary>
            public const string RecCreateTime = "REC_CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RecRevisor" /></summary>
            public const string RecRevisor = "REC_REVISOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RecReviseTime" /></summary>
            public const string RecReviseTime = "REC_REVISE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RecCreateReason" /></summary>
            public const string RecCreateReason = "REC_CREATE_REASON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.No" /></summary>
            public const string No = "NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MotherNo" /></summary>
            public const string MotherNo = "MOTHER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.BundlePackageNo" /></summary>
            public const string BundlePackageNo = "BUNDLE_PACKAGE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ProcessCode" /></summary>
            public const string ProcessCode = "PROCESS_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.NextProcessCode" /></summary>
            public const string NextProcessCode = "NEXT_PROCESS_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Thick" /></summary>
            public const string Thick = "THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Width" /></summary>
            public const string Width = "WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Weight" /></summary>
            public const string Weight = "WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Length" /></summary>
            public const string Length = "LENGTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Diameter" /></summary>
            public const string Diameter = "DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.InnerDiameter" /></summary>
            public const string InnerDiameter = "INNER_DIAMETER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatShapeFlag" /></summary>
            public const string MatShapeFlag = "MAT_SHAPE_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatStatus" /></summary>
            public const string MatStatus = "MAT_STATUS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatTargThick" /></summary>
            public const string MatTargThick = "MAT_TARG_THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatTargWidth" /></summary>
            public const string MatTargWidth = "MAT_TARG_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatTargLen" /></summary>
            public const string MatTargLen = "MAT_TARG_LEN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatActWt" /></summary>
            public const string MatActWt = "MAT_ACT_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatTheoryWt" /></summary>
            public const string MatTheoryWt = "MAT_THEORY_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MeasureWtFlag" /></summary>
            public const string MeasureWtFlag = "MEASURE_WT_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ProductPackFlag" /></summary>
            public const string ProductPackFlag = "PRODUCT_PACK_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.IsDistributionShip" /></summary>
            public const string IsDistributionShip = "IS_DISTRIBUTION_SHIP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Pono" /></summary>
            public const string Pono = "PONO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.HeatNo" /></summary>
            public const string HeatNo = "HEAT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.SteelGrade" /></summary>
            public const string SteelGrade = "STEEL_GRADE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ProdTime" /></summary>
            public const string ProdTime = "PROD_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ProdShiftNo" /></summary>
            public const string ProdShiftNo = "PROD_SHIFT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ProdShiftGroup" /></summary>
            public const string ProdShiftGroup = "PROD_SHIFT_GROUP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.SgSign" /></summary>
            public const string SgSign = "SG_SIGN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.SgStd" /></summary>
            public const string SgStd = "SG_STD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OldSgSign" /></summary>
            public const string OldSgSign = "OLD_SG_SIGN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OldSgStd" /></summary>
            public const string OldSgStd = "OLD_SG_STD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OldOrderNo" /></summary>
            public const string OldOrderNo = "OLD_ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatDirection" /></summary>
            public const string MatDirection = "MAT_DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.TrnpModeCode" /></summary>
            public const string TrnpModeCode = "TRNP_MODE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.PackingTypeCode" /></summary>
            public const string PackingTypeCode = "PACKING_TYPE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DecideThick" /></summary>
            public const string DecideThick = "DECIDE_THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DecideWidth" /></summary>
            public const string DecideWidth = "DECIDE_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.LabelDemand" /></summary>
            public const string LabelDemand = "LABEL_DEMAND";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.IsOrdered" /></summary>
            public const string IsOrdered = "IS_ORDERED";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ReadyState" /></summary>
            public const string ReadyState = "READY_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ProdCode" /></summary>
            public const string ProdCode = "PROD_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ProdCname" /></summary>
            public const string ProdCname = "PROD_CNAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ProdEname" /></summary>
            public const string ProdEname = "PROD_ENAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.HoldFlag" /></summary>
            public const string HoldFlag = "HOLD_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.HoldCauseCode" /></summary>
            public const string HoldCauseCode = "HOLD_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.HoldTime" /></summary>
            public const string HoldTime = "HOLD_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.HoldMaker" /></summary>
            public const string HoldMaker = "HOLD_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ColorDemand" /></summary>
            public const string ColorDemand = "COLOR_DEMAND";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.HoldRemark" /></summary>
            public const string HoldRemark = "HOLD_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RelMaker" /></summary>
            public const string RelMaker = "REL_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RelRemark" /></summary>
            public const string RelRemark = "REL_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RelTime" /></summary>
            public const string RelTime = "REL_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RemainDecideCode" /></summary>
            public const string RemainDecideCode = "REMAIN_DECIDE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RemainCauseCode" /></summary>
            public const string RemainCauseCode = "REMAIN_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RemainDecideTime" /></summary>
            public const string RemainDecideTime = "REMAIN_DECIDE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RemainDecideMaker" /></summary>
            public const string RemainDecideMaker = "REMAIN_DECIDE_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RemainRemark" /></summary>
            public const string RemainRemark = "REMAIN_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Msc" /></summary>
            public const string Msc = "MSC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OldMsc" /></summary>
            public const string OldMsc = "OLD_MSC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Psc" /></summary>
            public const string Psc = "PSC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OldPsc" /></summary>
            public const string OldPsc = "OLD_PSC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Apn" /></summary>
            public const string Apn = "APN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OldApn" /></summary>
            public const string OldApn = "OLD_APN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.BillOfLadingNo" /></summary>
            public const string BillOfLadingNo = "BILL_OF_LADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MatDisposeCode" /></summary>
            public const string MatDisposeCode = "MAT_DISPOSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ComplexDecideCode" /></summary>
            public const string ComplexDecideCode = "COMPLEX_DECIDE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OrderName" /></summary>
            public const string OrderName = "ORDER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.CustomerName" /></summary>
            public const string CustomerName = "CUSTOMER_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.CustomerCode" /></summary>
            public const string CustomerCode = "CUSTOMER_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Status" /></summary>
            public const string Status = "STATUS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.SourceType" /></summary>
            public const string SourceType = "SOURCE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.HeadDirection" /></summary>
            public const string HeadDirection = "HEAD_DIRECTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.IsLoadEnable" /></summary>
            public const string IsLoadEnable = "IS_LOAD_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Description" /></summary>
            public const string Description = "DESCRIPTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OnlineWeight" /></summary>
            public const string OnlineWeight = "ONLINE_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OfflineWeight" /></summary>
            public const string OfflineWeight = "OFFLINE_WEIGHT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DeliveryDate" /></summary>
            public const string DeliveryDate = "DELIVERY_DATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.EndUserCode" /></summary>
            public const string EndUserCode = "END_USER_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.StockType" /></summary>
            public const string StockType = "STOCK_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DefectType" /></summary>
            public const string DefectType = "DEFECT_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.IsHandleDefect" /></summary>
            public const string IsHandleDefect = "IS_HANDLE_DEFECT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OnTrainType" /></summary>
            public const string OnTrainType = "ON_TRAIN_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ReturnReasonType" /></summary>
            public const string ReturnReasonType = "RETURN_REASON_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.PickState" /></summary>
            public const string PickState = "PICK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.PrepickTransferNo" /></summary>
            public const string PrepickTransferNo = "PREPICK_TRANSFER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DeliverPickState" /></summary>
            public const string DeliverPickState = "DELIVER_PICK_STATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.TruckLoadListId" /></summary>
            public const string TruckLoadListId = "TRUCK_LOAD_LIST_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DetailRequestCount" /></summary>
            public const string DetailRequestCount = "DETAIL_REQUEST_COUNT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DefectRecorder" /></summary>
            public const string DefectRecorder = "DEFECT_RECORDER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DefectRecordTime" /></summary>
            public const string DefectRecordTime = "DEFECT_RECORD_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.DefectDesc" /></summary>
            public const string DefectDesc = "DEFECT_DESC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.WeightChangedTime" /></summary>
            public const string WeightChangedTime = "WEIGHT_CHANGED_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.WeightChangedType" /></summary>
            public const string WeightChangedType = "WEIGHT_CHANGED_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.BayName" /></summary>
            public const string BayName = "BAY_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MaterialLocationOwner" /></summary>
            public const string MaterialLocationOwner = "MATERIAL_LOCATION_OWNER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.MaterialBussinessOwner" /></summary>
            public const string MaterialBussinessOwner = "MATERIAL_BUSSINESS_OWNER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.IsEnable" /></summary>
            public const string IsEnable = "IS_ENABLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.CreateTime" /></summary>
            public const string CreateTime = "CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.CreateUser" /></summary>
            public const string CreateUser = "CREATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.UpdateTime" /></summary>
            public const string UpdateTime = "UPDATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.UpdateUser" /></summary>
            public const string UpdateUser = "UPDATE_USER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.LockMark" /></summary>
            public const string LockMark = "LOCK_MARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.LockReason" /></summary>
            public const string LockReason = "LOCK_REASON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.PortLotNumber" /></summary>
            public const string PortLotNumber = "PORT_LOT_NUMBER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Terminal" /></summary>
            public const string Terminal = "TERMINAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.BelongTerminal" /></summary>
            public const string BelongTerminal = "BELONG_TERMINAL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.BelongDecideWidth" /></summary>
            public const string BelongDecideWidth = "BELONG_DECIDE_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Remark" /></summary>
            public const string Remark = "REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.Type" /></summary>
            public const string Type = "TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.LocationName" /></summary>
            public const string LocationName = "LOCATION_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.OwnerBussinessName" /></summary>
            public const string OwnerBussinessName = "OWNER_BUSSINESS_NAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.BayCode" /></summary>
            public const string BayCode = "BAY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.AreaCode" /></summary>
            public const string AreaCode = "AREA_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.ColNo" /></summary>
            public const string ColNo = "COL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.RowNo" /></summary>
            public const string RowNo = "ROW_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.VPlMaterial.FloorNo" /></summary>
            public const string FloorNo = "FLOOR_NO";
        }
        #endregion
    }
}
