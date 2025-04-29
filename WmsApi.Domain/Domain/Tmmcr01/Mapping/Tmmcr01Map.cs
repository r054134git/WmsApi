using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WmsApi.Domain.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="WmsApi.Domain.Entities.Tmmcr01" />
    /// </summary>
    public partial class Tmmcr01Map
        : IEntityTypeConfiguration<WmsApi.Domain.Entities.Tmmcr01>
    {
        /// <summary>
        /// Configures the entity of type <see cref="WmsApi.Domain.Entities.Tmmcr01" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WmsApi.Domain.Entities.Tmmcr01> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tmmcr01");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

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

            builder.Property(t => t.RecErasor)
                .HasColumnName("REC_ERASOR")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.RecEraseTime)
                .HasColumnName("REC_ERASE_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.ArchiveFlag)
                .HasColumnName("ARCHIVE_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.ArchiveStampNo)
                .HasColumnName("ARCHIVE_STAMP_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.MatNo)
                .HasColumnName("MAT_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MatId)
                .HasColumnName("MAT_ID")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MatTrackNo)
                .HasColumnName("MAT_TRACK_NO")
                .HasColumnType("varchar(18)")
                .HasMaxLength(18);

            builder.Property(t => t.MatLineType)
                .HasColumnName("MAT_LINE_TYPE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.MatKind)
                .HasColumnName("MAT_KIND")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.UnitCode)
                .HasColumnName("UNIT_CODE")
                .HasColumnType("varchar(7)")
                .HasMaxLength(7);

            builder.Property(t => t.NextUnitCode)
                .HasColumnName("NEXT_UNIT_CODE")
                .HasColumnType("varchar(7)")
                .HasMaxLength(7);

            builder.Property(t => t.FactoryDiv)
                .HasColumnName("FACTORY_DIV")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.MatShapeFlag)
                .HasColumnName("MAT_SHAPE_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.OriginMatNo)
                .HasColumnName("ORIGIN_MAT_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.RawOrigin)
                .HasColumnName("RAW_ORIGIN")
                .HasColumnType("varchar(6)")
                .HasMaxLength(6);

            builder.Property(t => t.MatOrigin)
                .HasColumnName("MAT_ORIGIN")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.MatDestion)
                .HasColumnName("MAT_DESTION")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.ProductFlag)
                .HasColumnName("PRODUCT_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.MatStatus)
                .HasColumnName("MAT_STATUS")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.MatThick)
                .HasColumnName("MAT_THICK")
                .HasColumnType("decimal(10,6)");

            builder.Property(t => t.MatWidth)
                .HasColumnName("MAT_WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MatLen)
                .HasColumnName("MAT_LEN")
                .HasColumnType("decimal(10,0)");

            builder.Property(t => t.MatActThick)
                .HasColumnName("MAT_ACT_THICK")
                .HasColumnType("decimal(10,6)");

            builder.Property(t => t.MatActWidth)
                .HasColumnName("MAT_ACT_WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MatActLen)
                .HasColumnName("MAT_ACT_LEN")
                .HasColumnType("decimal(10,0)");

            builder.Property(t => t.MatActInnerDia)
                .HasColumnName("MAT_ACT_INNER_DIA")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MatActOuterDia)
                .HasColumnName("MAT_ACT_OUTER_DIA")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MatTargThick)
                .HasColumnName("MAT_TARG_THICK")
                .HasColumnType("decimal(10,6)");

            builder.Property(t => t.MatTargWidth)
                .HasColumnName("MAT_TARG_WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.MatTargLen)
                .HasColumnName("MAT_TARG_LEN")
                .HasColumnType("decimal(10,0)");

            builder.Property(t => t.MatActWt)
                .HasColumnName("MAT_ACT_WT")
                .HasColumnType("decimal(15,6)");

            builder.Property(t => t.MatTheoryWt)
                .HasColumnName("MAT_THEORY_WT")
                .HasColumnType("decimal(15,6)");

            builder.Property(t => t.MeasureWtFlag)
                .HasColumnName("MEASURE_WT_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.ProductPackFlag)
                .HasColumnName("PRODUCT_PACK_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PackUnitCode)
                .HasColumnName("PACK_UNIT_CODE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.PackTypeCode)
                .HasColumnName("PACK_TYPE_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.OrderPackTypeCode)
                .HasColumnName("ORDER_PACK_TYPE_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.ProductPackTime)
                .HasColumnName("PRODUCT_PACK_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.PackShiftNo)
                .HasColumnName("PACK_SHIFT_NO")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PackShiftGroup)
                .HasColumnName("PACK_SHIFT_GROUP")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PackMatWt)
                .HasColumnName("PACK_MAT_WT")
                .HasColumnType("decimal(16,6)");

            builder.Property(t => t.MatGrossWt)
                .HasColumnName("MAT_GROSS_WT")
                .HasColumnType("decimal(15,6)");

            builder.Property(t => t.PackNo)
                .HasColumnName("PACK_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OrderThick)
                .HasColumnName("ORDER_THICK")
                .HasColumnType("decimal(10,6)");

            builder.Property(t => t.OrderWidth)
                .HasColumnName("ORDER_WIDTH")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.OrderLen)
                .HasColumnName("ORDER_LEN")
                .HasColumnType("decimal(10,0)");

            builder.Property(t => t.Pono)
                .HasColumnName("PONO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.HeatNo)
                .HasColumnName("HEAT_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.StNo)
                .HasColumnName("ST_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ProdMaker)
                .HasColumnName("PROD_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

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

            builder.Property(t => t.StdSgCode)
                .HasColumnName("STD_SG_CODE")
                .HasColumnType("varchar(6)")
                .HasMaxLength(6);

            builder.Property(t => t.SgSign)
                .HasColumnName("SG_SIGN")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SgStd)
                .HasColumnName("SG_STD")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.SgCode)
                .HasColumnName("SG_CODE")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OldStdSgCode)
                .HasColumnName("OLD_STD_SG_CODE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.OldSgStd)
                .HasColumnName("OLD_SG_STD")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.OldSgSign)
                .HasColumnName("OLD_SG_SIGN")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.PassBacklogSeqNo)
                .HasColumnName("PASS_BACKLOG_SEQ_NO")
                .HasColumnType("decimal(4,0)");

            builder.Property(t => t.WholeBacklogAct)
                .HasColumnName("WHOLE_BACKLOG_ACT")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.FinalCoilFlag)
                .HasColumnName("FINAL_COIL_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.TailFlag)
                .HasColumnName("TAIL_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SheetNum)
                .HasColumnName("SHEET_NUM")
                .HasColumnType("decimal(4,0)");

            builder.Property(t => t.OrderNo)
                .HasColumnName("ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OldOrderNo)
                .HasColumnName("OLD_ORDER_NO")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DelivyDate)
                .HasColumnName("DELIVY_DATE")
                .HasColumnType("varchar(8)")
                .HasMaxLength(8);

            builder.Property(t => t.FinCustCode)
                .HasColumnName("FIN_CUST_CODE")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.WholeBacklogNo)
                .HasColumnName("WHOLE_BACKLOG_NO")
                .HasColumnType("decimal(2,0)");

            builder.Property(t => t.WholeBacklog)
                .HasColumnName("WHOLE_BACKLOG")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.WholeBacklogSeq)
                .HasColumnName("WHOLE_BACKLOG_SEQ")
                .HasColumnType("decimal(2,0)");

            builder.Property(t => t.WholeBacklogCode)
                .HasColumnName("WHOLE_BACKLOG_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.NextWholeBacklogSeq)
                .HasColumnName("NEXT_WHOLE_BACKLOG_SEQ")
                .HasColumnType("decimal(2,0)");

            builder.Property(t => t.NextWholeBacklogCode)
                .HasColumnName("NEXT_WHOLE_BACKLOG_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Msc)
                .HasColumnName("MSC")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OldMsc)
                .HasColumnName("OLD_MSC")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MscLineNo)
                .HasColumnName("MSC_LINE_NO")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.OldMscLine)
                .HasColumnName("OLD_MSC_LINE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

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

            builder.Property(t => t.ProdReadyDate)
                .HasColumnName("PROD_READY_DATE")
                .HasColumnType("varchar(8)")
                .HasMaxLength(8);

            builder.Property(t => t.BillOfLadingNo)
                .HasColumnName("BILL_OF_LADING_NO")
                .HasColumnType("varchar(13)")
                .HasMaxLength(13);

            builder.Property(t => t.ContractNum)
                .HasColumnName("CONTRACT_NUM")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MatDisposeCode)
                .HasColumnName("MAT_DISPOSE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.DisposeShiftNo)
                .HasColumnName("DISPOSE_SHIFT_NO")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.DisposeShiftGroup)
                .HasColumnName("DISPOSE_SHIFT_GROUP")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

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

            builder.Property(t => t.RemainCauseCode)
                .HasColumnName("REMAIN_CAUSE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.RemainDecideCode)
                .HasColumnName("REMAIN_DECIDE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.RemainDecideMaker)
                .HasColumnName("REMAIN_DECIDE_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.RemainDecideTime)
                .HasColumnName("REMAIN_DECIDE_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.RemainRemark)
                .HasColumnName("REMAIN_REMARK")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.DropLevelType)
                .HasColumnName("DROP_LEVEL_TYPE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.DropLevelRemark)
                .HasColumnName("DROP_LEVEL_REMARK")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.DropLevelCauseCode)
                .HasColumnName("DROP_LEVEL_CAUSE_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.ScrapCauseCode)
                .HasColumnName("SCRAP_CAUSE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.ScrapRemark)
                .HasColumnName("SCRAP_REMARK")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.ScrapTime)
                .HasColumnName("SCRAP_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.ScrapMaker)
                .HasColumnName("SCRAP_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.RepairFlag)
                .HasColumnName("REPAIR_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.RepairBacklogCode)
                .HasColumnName("REPAIR_BACKLOG_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.RepairRemark)
                .HasColumnName("REPAIR_REMARK")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.RepairType)
                .HasColumnName("REPAIR_TYPE")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.MatRepairReason)
                .HasColumnName("MAT_REPAIR_REASON")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.SurfaceDecideCode)
                .HasColumnName("SURFACE_DECIDE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SurfaceDecideTime)
                .HasColumnName("SURFACE_DECIDE_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.SurfaceDecideMaker)
                .HasColumnName("SURFACE_DECIDE_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.ComplexDecideCode)
                .HasColumnName("COMPLEX_DECIDE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.ComplexDecideTime)
                .HasColumnName("COMPLEX_DECIDE_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.ComplexDecideMaker)
                .HasColumnName("COMPLEX_DECIDE_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.OldComplexDecideCode)
                .HasColumnName("OLD_COMPLEX_DECIDE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.OldComplexDecideTime)
                .HasColumnName("OLD_COMPLEX_DECIDE_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.OldComplexDecideMaker)
                .HasColumnName("OLD_COMPLEX_DECIDE_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.NewTestNo)
                .HasColumnName("NEW_TEST_NO")
                .HasColumnType("varchar(6)")
                .HasMaxLength(6);

            builder.Property(t => t.SampleLotNo)
                .HasColumnName("SAMPLE_LOT_NO")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.SampleTakenFlag)
                .HasColumnName("SAMPLE_TAKEN_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.DefectCode)
                .HasColumnName("DEFECT_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.DefectClass)
                .HasColumnName("DEFECT_CLASS")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.PlanNo)
                .HasColumnName("PLAN_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.TransferFlag)
                .HasColumnName("TRANSFER_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.TransferPlanNo)
                .HasColumnName("TRANSFER_PLAN_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.TransferRejectCause)
                .HasColumnName("TRANSFER_REJECT_CAUSE")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.TransferMaker)
                .HasColumnName("TRANSFER_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.TransferTime)
                .HasColumnName("TRANSFER_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.AppDecideFlag)
                .HasColumnName("APP_DECIDE_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.AppDecideNo)
                .HasColumnName("APP_DECIDE_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.AppDecideMaker)
                .HasColumnName("APP_DECIDE_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.StockPlaceNo)
                .HasColumnName("STOCK_PLACE_NO")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.StockNo)
                .HasColumnName("STOCK_NO")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.HallNo)
                .HasColumnName("HALL_NO")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Rowno)
                .HasColumnName("ROWNO")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.ColumnNo)
                .HasColumnName("COLUMN_NO")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.Layerno)
                .HasColumnName("LAYERNO")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.InFlag)
                .HasColumnName("IN_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.InStockTime)
                .HasColumnName("IN_STOCK_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.OutStockTime)
                .HasColumnName("OUT_STOCK_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.CmdFlag)
                .HasColumnName("CMD_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.StockPlaceNoPre)
                .HasColumnName("STOCK_PLACE_NO_PRE")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.ChooseFlag)
                .HasColumnName("CHOOSE_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SkidNo)
                .HasColumnName("SKID_NO")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.InMatNo1)
                .HasColumnName("IN_MAT_NO_1")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.InMatNo2)
                .HasColumnName("IN_MAT_NO_2")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.InMat1Wt)
                .HasColumnName("IN_MAT_1_WT")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.InMat2Wt)
                .HasColumnName("IN_MAT_2_WT")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.InMat1TrackNo)
                .HasColumnName("IN_MAT_1_TRACK_NO")
                .HasColumnType("varchar(18)")
                .HasMaxLength(18);

            builder.Property(t => t.InMat2TrackNo)
                .HasColumnName("IN_MAT_2_TRACK_NO")
                .HasColumnType("varchar(18)")
                .HasMaxLength(18);

            builder.Property(t => t.BetterSurfWardCode)
                .HasColumnName("BETTER_SURF_WARD_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.AnnealDiagramCode)
                .HasColumnName("ANNEAL_DIAGRAM_CODE")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(t => t.TopPlateTypeCode)
                .HasColumnName("TOP_PLATE_TYPE_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.BotPlateTypeCode)
                .HasColumnName("BOT_PLATE_TYPE_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.TopPlateWt)
                .HasColumnName("TOP_PLATE_WT")
                .HasColumnType("decimal(10,1)");

            builder.Property(t => t.BotPlateWt)
                .HasColumnName("BOT_PLATE_WT")
                .HasColumnType("decimal(10,1)");

            builder.Property(t => t.OilKindCode)
                .HasColumnName("OIL_KIND_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.OilQtyCode)
                .HasColumnName("OIL_QTY_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.TopStrucCode)
                .HasColumnName("TOP_STRUC_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.BotStrucCode)
                .HasColumnName("BOT_STRUC_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.DummyCoilFlag)
                .HasColumnName("DUMMY_COIL_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.DummyCoilUseTimes)
                .HasColumnName("DUMMY_COIL_USE_TIMES")
                .HasColumnType("decimal(2,0)");

            builder.Property(t => t.MatReturnFlag)
                .HasColumnName("MAT_RETURN_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.MatReturnCauseCode)
                .HasColumnName("MAT_RETURN_CAUSE_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.MatUnionFlag)
                .HasColumnName("MAT_UNION_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.TrimFlag)
                .HasColumnName("TRIM_FLAG")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.PostProcCode)
                .HasColumnName("POST_PROC_CODE")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.ProdCode)
                .HasColumnName("PROD_CODE")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.ProdCname)
                .HasColumnName("PROD_CNAME")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.ProdEname)
                .HasColumnName("PROD_ENAME")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.SurfaceGradeCode)
                .HasColumnName("SURFACE_GRADE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.SortGradeCode)
                .HasColumnName("SORT_GRADE_CODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.SurfaceAccuCode)
                .HasColumnName("SURFACE_ACCU_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.Rough)
                .HasColumnName("ROUGH")
                .HasColumnType("decimal(3,0)");

            builder.Property(t => t.StaggerWinding)
                .HasColumnName("STAGGER_WINDING")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2);

            builder.Property(t => t.CorrectionCauseCode)
                .HasColumnName("CORRECTION_CAUSE_CODE")
                .HasColumnType("varchar(4)")
                .HasMaxLength(4);

            builder.Property(t => t.CorrectionMaker)
                .HasColumnName("CORRECTION_MAKER")
                .HasColumnType("varchar(24)")
                .HasMaxLength(24);

            builder.Property(t => t.CorrectionTime)
                .HasColumnName("CORRECTION_TIME")
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);

            builder.Property(t => t.CorrectRemark)
                .HasColumnName("CORRECT_REMARK")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.BackN1)
                .HasColumnName("BACK_N1")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BackN2)
                .HasColumnName("BACK_N2")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BackN3)
                .HasColumnName("BACK_N3")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BackN4)
                .HasColumnName("BACK_N4")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BackN5)
                .HasColumnName("BACK_N5")
                .HasColumnType("decimal(10,3)");

            builder.Property(t => t.BackC1)
                .HasColumnName("BACK_C1")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.BackC2)
                .HasColumnName("BACK_C2")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.BackC3)
                .HasColumnName("BACK_C3")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.BackC4)
                .HasColumnName("BACK_C4")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.BackC5)
                .HasColumnName("BACK_C5")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.BackC6)
                .HasColumnName("BACK_C6")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.BackC7)
                .HasColumnName("BACK_C7")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.BackC8)
                .HasColumnName("BACK_C8")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.BackC9)
                .HasColumnName("BACK_C9")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.BackC10)
                .HasColumnName("BACK_C10")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Labelname)
                .HasColumnName("LABELNAME")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StockingPeriod)
                .HasColumnName("STOCKING_PERIOD")
                .HasColumnType("varchar(8)")
                .HasMaxLength(8);

            builder.Property(t => t.AutoJudge)
                .HasColumnName("AUTO_JUDGE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.FinCustCname)
                .HasColumnName("FIN_CUST_CNAME")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200);

            builder.Property(t => t.PsYn)
                .HasColumnName("PS_YN")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.ZincSufaceCl)
                .HasColumnName("ZINC_SUFACE_CL")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SkpMode)
                .HasColumnName("SKP_MODE")
                .HasColumnType("varchar(1)")
                .HasMaxLength(1);

            builder.Property(t => t.Spangle)
                .HasColumnName("SPANGLE")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.OrdCoatWtBot)
                .HasColumnName("ORD_COAT_WT_BOT")
                .HasColumnType("decimal(10,1)");

            builder.Property(t => t.OrdCoatWtTop)
                .HasColumnName("ORD_COAT_WT_TOP")
                .HasColumnType("decimal(10,1)");

            builder.Property(t => t.Preparestus)
                .HasColumnName("PREPARESTUS")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="WmsApi.Domain.Entities.Tmmcr01" /></summary>
            public const string Schema = "";
            /// <summary>Table Name constant for entity <see cref="WmsApi.Domain.Entities.Tmmcr01" /></summary>
            public const string Name = "tmmcr01";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Id" /></summary>
            public const string Id = "ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RecCreator" /></summary>
            public const string RecCreator = "REC_CREATOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RecCreateTime" /></summary>
            public const string RecCreateTime = "REC_CREATE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RecRevisor" /></summary>
            public const string RecRevisor = "REC_REVISOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RecReviseTime" /></summary>
            public const string RecReviseTime = "REC_REVISE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RecErasor" /></summary>
            public const string RecErasor = "REC_ERASOR";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RecEraseTime" /></summary>
            public const string RecEraseTime = "REC_ERASE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ArchiveFlag" /></summary>
            public const string ArchiveFlag = "ARCHIVE_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ArchiveStampNo" /></summary>
            public const string ArchiveStampNo = "ARCHIVE_STAMP_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatNo" /></summary>
            public const string MatNo = "MAT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatId" /></summary>
            public const string MatId = "MAT_ID";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatTrackNo" /></summary>
            public const string MatTrackNo = "MAT_TRACK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatLineType" /></summary>
            public const string MatLineType = "MAT_LINE_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatKind" /></summary>
            public const string MatKind = "MAT_KIND";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.UnitCode" /></summary>
            public const string UnitCode = "UNIT_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.NextUnitCode" /></summary>
            public const string NextUnitCode = "NEXT_UNIT_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.FactoryDiv" /></summary>
            public const string FactoryDiv = "FACTORY_DIV";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatShapeFlag" /></summary>
            public const string MatShapeFlag = "MAT_SHAPE_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OriginMatNo" /></summary>
            public const string OriginMatNo = "ORIGIN_MAT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RawOrigin" /></summary>
            public const string RawOrigin = "RAW_ORIGIN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatOrigin" /></summary>
            public const string MatOrigin = "MAT_ORIGIN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatDestion" /></summary>
            public const string MatDestion = "MAT_DESTION";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProductFlag" /></summary>
            public const string ProductFlag = "PRODUCT_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatStatus" /></summary>
            public const string MatStatus = "MAT_STATUS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatThick" /></summary>
            public const string MatThick = "MAT_THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatWidth" /></summary>
            public const string MatWidth = "MAT_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatLen" /></summary>
            public const string MatLen = "MAT_LEN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatActThick" /></summary>
            public const string MatActThick = "MAT_ACT_THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatActWidth" /></summary>
            public const string MatActWidth = "MAT_ACT_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatActLen" /></summary>
            public const string MatActLen = "MAT_ACT_LEN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatActInnerDia" /></summary>
            public const string MatActInnerDia = "MAT_ACT_INNER_DIA";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatActOuterDia" /></summary>
            public const string MatActOuterDia = "MAT_ACT_OUTER_DIA";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatTargThick" /></summary>
            public const string MatTargThick = "MAT_TARG_THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatTargWidth" /></summary>
            public const string MatTargWidth = "MAT_TARG_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatTargLen" /></summary>
            public const string MatTargLen = "MAT_TARG_LEN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatActWt" /></summary>
            public const string MatActWt = "MAT_ACT_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatTheoryWt" /></summary>
            public const string MatTheoryWt = "MAT_THEORY_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MeasureWtFlag" /></summary>
            public const string MeasureWtFlag = "MEASURE_WT_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProductPackFlag" /></summary>
            public const string ProductPackFlag = "PRODUCT_PACK_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PackUnitCode" /></summary>
            public const string PackUnitCode = "PACK_UNIT_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PackTypeCode" /></summary>
            public const string PackTypeCode = "PACK_TYPE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OrderPackTypeCode" /></summary>
            public const string OrderPackTypeCode = "ORDER_PACK_TYPE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProductPackTime" /></summary>
            public const string ProductPackTime = "PRODUCT_PACK_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PackShiftNo" /></summary>
            public const string PackShiftNo = "PACK_SHIFT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PackShiftGroup" /></summary>
            public const string PackShiftGroup = "PACK_SHIFT_GROUP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PackMatWt" /></summary>
            public const string PackMatWt = "PACK_MAT_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatGrossWt" /></summary>
            public const string MatGrossWt = "MAT_GROSS_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PackNo" /></summary>
            public const string PackNo = "PACK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OrderThick" /></summary>
            public const string OrderThick = "ORDER_THICK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OrderWidth" /></summary>
            public const string OrderWidth = "ORDER_WIDTH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OrderLen" /></summary>
            public const string OrderLen = "ORDER_LEN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Pono" /></summary>
            public const string Pono = "PONO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.HeatNo" /></summary>
            public const string HeatNo = "HEAT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.StNo" /></summary>
            public const string StNo = "ST_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProdMaker" /></summary>
            public const string ProdMaker = "PROD_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProdTime" /></summary>
            public const string ProdTime = "PROD_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProdShiftNo" /></summary>
            public const string ProdShiftNo = "PROD_SHIFT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProdShiftGroup" /></summary>
            public const string ProdShiftGroup = "PROD_SHIFT_GROUP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.StdSgCode" /></summary>
            public const string StdSgCode = "STD_SG_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SgSign" /></summary>
            public const string SgSign = "SG_SIGN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SgStd" /></summary>
            public const string SgStd = "SG_STD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SgCode" /></summary>
            public const string SgCode = "SG_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldStdSgCode" /></summary>
            public const string OldStdSgCode = "OLD_STD_SG_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldSgStd" /></summary>
            public const string OldSgStd = "OLD_SG_STD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldSgSign" /></summary>
            public const string OldSgSign = "OLD_SG_SIGN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PassBacklogSeqNo" /></summary>
            public const string PassBacklogSeqNo = "PASS_BACKLOG_SEQ_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.WholeBacklogAct" /></summary>
            public const string WholeBacklogAct = "WHOLE_BACKLOG_ACT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.FinalCoilFlag" /></summary>
            public const string FinalCoilFlag = "FINAL_COIL_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TailFlag" /></summary>
            public const string TailFlag = "TAIL_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SheetNum" /></summary>
            public const string SheetNum = "SHEET_NUM";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OrderNo" /></summary>
            public const string OrderNo = "ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldOrderNo" /></summary>
            public const string OldOrderNo = "OLD_ORDER_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DelivyDate" /></summary>
            public const string DelivyDate = "DELIVY_DATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.FinCustCode" /></summary>
            public const string FinCustCode = "FIN_CUST_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.WholeBacklogNo" /></summary>
            public const string WholeBacklogNo = "WHOLE_BACKLOG_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.WholeBacklog" /></summary>
            public const string WholeBacklog = "WHOLE_BACKLOG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.WholeBacklogSeq" /></summary>
            public const string WholeBacklogSeq = "WHOLE_BACKLOG_SEQ";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.WholeBacklogCode" /></summary>
            public const string WholeBacklogCode = "WHOLE_BACKLOG_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.NextWholeBacklogSeq" /></summary>
            public const string NextWholeBacklogSeq = "NEXT_WHOLE_BACKLOG_SEQ";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.NextWholeBacklogCode" /></summary>
            public const string NextWholeBacklogCode = "NEXT_WHOLE_BACKLOG_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Msc" /></summary>
            public const string Msc = "MSC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldMsc" /></summary>
            public const string OldMsc = "OLD_MSC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MscLineNo" /></summary>
            public const string MscLineNo = "MSC_LINE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldMscLine" /></summary>
            public const string OldMscLine = "OLD_MSC_LINE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Psc" /></summary>
            public const string Psc = "PSC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldPsc" /></summary>
            public const string OldPsc = "OLD_PSC";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Apn" /></summary>
            public const string Apn = "APN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldApn" /></summary>
            public const string OldApn = "OLD_APN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProdReadyDate" /></summary>
            public const string ProdReadyDate = "PROD_READY_DATE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BillOfLadingNo" /></summary>
            public const string BillOfLadingNo = "BILL_OF_LADING_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ContractNum" /></summary>
            public const string ContractNum = "CONTRACT_NUM";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatDisposeCode" /></summary>
            public const string MatDisposeCode = "MAT_DISPOSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DisposeShiftNo" /></summary>
            public const string DisposeShiftNo = "DISPOSE_SHIFT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DisposeShiftGroup" /></summary>
            public const string DisposeShiftGroup = "DISPOSE_SHIFT_GROUP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.HoldFlag" /></summary>
            public const string HoldFlag = "HOLD_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.HoldCauseCode" /></summary>
            public const string HoldCauseCode = "HOLD_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.HoldTime" /></summary>
            public const string HoldTime = "HOLD_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.HoldMaker" /></summary>
            public const string HoldMaker = "HOLD_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.HoldRemark" /></summary>
            public const string HoldRemark = "HOLD_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RelMaker" /></summary>
            public const string RelMaker = "REL_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RelRemark" /></summary>
            public const string RelRemark = "REL_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RelTime" /></summary>
            public const string RelTime = "REL_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RemainCauseCode" /></summary>
            public const string RemainCauseCode = "REMAIN_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RemainDecideCode" /></summary>
            public const string RemainDecideCode = "REMAIN_DECIDE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RemainDecideMaker" /></summary>
            public const string RemainDecideMaker = "REMAIN_DECIDE_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RemainDecideTime" /></summary>
            public const string RemainDecideTime = "REMAIN_DECIDE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RemainRemark" /></summary>
            public const string RemainRemark = "REMAIN_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DropLevelType" /></summary>
            public const string DropLevelType = "DROP_LEVEL_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DropLevelRemark" /></summary>
            public const string DropLevelRemark = "DROP_LEVEL_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DropLevelCauseCode" /></summary>
            public const string DropLevelCauseCode = "DROP_LEVEL_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ScrapCauseCode" /></summary>
            public const string ScrapCauseCode = "SCRAP_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ScrapRemark" /></summary>
            public const string ScrapRemark = "SCRAP_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ScrapTime" /></summary>
            public const string ScrapTime = "SCRAP_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ScrapMaker" /></summary>
            public const string ScrapMaker = "SCRAP_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RepairFlag" /></summary>
            public const string RepairFlag = "REPAIR_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RepairBacklogCode" /></summary>
            public const string RepairBacklogCode = "REPAIR_BACKLOG_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RepairRemark" /></summary>
            public const string RepairRemark = "REPAIR_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.RepairType" /></summary>
            public const string RepairType = "REPAIR_TYPE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatRepairReason" /></summary>
            public const string MatRepairReason = "MAT_REPAIR_REASON";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SurfaceDecideCode" /></summary>
            public const string SurfaceDecideCode = "SURFACE_DECIDE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SurfaceDecideTime" /></summary>
            public const string SurfaceDecideTime = "SURFACE_DECIDE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SurfaceDecideMaker" /></summary>
            public const string SurfaceDecideMaker = "SURFACE_DECIDE_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ComplexDecideCode" /></summary>
            public const string ComplexDecideCode = "COMPLEX_DECIDE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ComplexDecideTime" /></summary>
            public const string ComplexDecideTime = "COMPLEX_DECIDE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ComplexDecideMaker" /></summary>
            public const string ComplexDecideMaker = "COMPLEX_DECIDE_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldComplexDecideCode" /></summary>
            public const string OldComplexDecideCode = "OLD_COMPLEX_DECIDE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldComplexDecideTime" /></summary>
            public const string OldComplexDecideTime = "OLD_COMPLEX_DECIDE_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OldComplexDecideMaker" /></summary>
            public const string OldComplexDecideMaker = "OLD_COMPLEX_DECIDE_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.NewTestNo" /></summary>
            public const string NewTestNo = "NEW_TEST_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SampleLotNo" /></summary>
            public const string SampleLotNo = "SAMPLE_LOT_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SampleTakenFlag" /></summary>
            public const string SampleTakenFlag = "SAMPLE_TAKEN_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DefectCode" /></summary>
            public const string DefectCode = "DEFECT_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DefectClass" /></summary>
            public const string DefectClass = "DEFECT_CLASS";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PlanNo" /></summary>
            public const string PlanNo = "PLAN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TransferFlag" /></summary>
            public const string TransferFlag = "TRANSFER_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TransferPlanNo" /></summary>
            public const string TransferPlanNo = "TRANSFER_PLAN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TransferRejectCause" /></summary>
            public const string TransferRejectCause = "TRANSFER_REJECT_CAUSE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TransferMaker" /></summary>
            public const string TransferMaker = "TRANSFER_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TransferTime" /></summary>
            public const string TransferTime = "TRANSFER_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.AppDecideFlag" /></summary>
            public const string AppDecideFlag = "APP_DECIDE_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.AppDecideNo" /></summary>
            public const string AppDecideNo = "APP_DECIDE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.AppDecideMaker" /></summary>
            public const string AppDecideMaker = "APP_DECIDE_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.StockPlaceNo" /></summary>
            public const string StockPlaceNo = "STOCK_PLACE_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.StockNo" /></summary>
            public const string StockNo = "STOCK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.HallNo" /></summary>
            public const string HallNo = "HALL_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Rowno" /></summary>
            public const string Rowno = "ROWNO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ColumnNo" /></summary>
            public const string ColumnNo = "COLUMN_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Layerno" /></summary>
            public const string Layerno = "LAYERNO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.InFlag" /></summary>
            public const string InFlag = "IN_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.InStockTime" /></summary>
            public const string InStockTime = "IN_STOCK_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OutStockTime" /></summary>
            public const string OutStockTime = "OUT_STOCK_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.CmdFlag" /></summary>
            public const string CmdFlag = "CMD_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.StockPlaceNoPre" /></summary>
            public const string StockPlaceNoPre = "STOCK_PLACE_NO_PRE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ChooseFlag" /></summary>
            public const string ChooseFlag = "CHOOSE_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SkidNo" /></summary>
            public const string SkidNo = "SKID_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.InMatNo1" /></summary>
            public const string InMatNo1 = "IN_MAT_NO_1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.InMatNo2" /></summary>
            public const string InMatNo2 = "IN_MAT_NO_2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.InMat1Wt" /></summary>
            public const string InMat1Wt = "IN_MAT_1_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.InMat2Wt" /></summary>
            public const string InMat2Wt = "IN_MAT_2_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.InMat1TrackNo" /></summary>
            public const string InMat1TrackNo = "IN_MAT_1_TRACK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.InMat2TrackNo" /></summary>
            public const string InMat2TrackNo = "IN_MAT_2_TRACK_NO";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BetterSurfWardCode" /></summary>
            public const string BetterSurfWardCode = "BETTER_SURF_WARD_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.AnnealDiagramCode" /></summary>
            public const string AnnealDiagramCode = "ANNEAL_DIAGRAM_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TopPlateTypeCode" /></summary>
            public const string TopPlateTypeCode = "TOP_PLATE_TYPE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BotPlateTypeCode" /></summary>
            public const string BotPlateTypeCode = "BOT_PLATE_TYPE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TopPlateWt" /></summary>
            public const string TopPlateWt = "TOP_PLATE_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BotPlateWt" /></summary>
            public const string BotPlateWt = "BOT_PLATE_WT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OilKindCode" /></summary>
            public const string OilKindCode = "OIL_KIND_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OilQtyCode" /></summary>
            public const string OilQtyCode = "OIL_QTY_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TopStrucCode" /></summary>
            public const string TopStrucCode = "TOP_STRUC_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BotStrucCode" /></summary>
            public const string BotStrucCode = "BOT_STRUC_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DummyCoilFlag" /></summary>
            public const string DummyCoilFlag = "DUMMY_COIL_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.DummyCoilUseTimes" /></summary>
            public const string DummyCoilUseTimes = "DUMMY_COIL_USE_TIMES";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatReturnFlag" /></summary>
            public const string MatReturnFlag = "MAT_RETURN_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatReturnCauseCode" /></summary>
            public const string MatReturnCauseCode = "MAT_RETURN_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.MatUnionFlag" /></summary>
            public const string MatUnionFlag = "MAT_UNION_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.TrimFlag" /></summary>
            public const string TrimFlag = "TRIM_FLAG";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PostProcCode" /></summary>
            public const string PostProcCode = "POST_PROC_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProdCode" /></summary>
            public const string ProdCode = "PROD_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProdCname" /></summary>
            public const string ProdCname = "PROD_CNAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ProdEname" /></summary>
            public const string ProdEname = "PROD_ENAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SurfaceGradeCode" /></summary>
            public const string SurfaceGradeCode = "SURFACE_GRADE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SortGradeCode" /></summary>
            public const string SortGradeCode = "SORT_GRADE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SurfaceAccuCode" /></summary>
            public const string SurfaceAccuCode = "SURFACE_ACCU_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Rough" /></summary>
            public const string Rough = "ROUGH";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.StaggerWinding" /></summary>
            public const string StaggerWinding = "STAGGER_WINDING";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.CorrectionCauseCode" /></summary>
            public const string CorrectionCauseCode = "CORRECTION_CAUSE_CODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.CorrectionMaker" /></summary>
            public const string CorrectionMaker = "CORRECTION_MAKER";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.CorrectionTime" /></summary>
            public const string CorrectionTime = "CORRECTION_TIME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.CorrectRemark" /></summary>
            public const string CorrectRemark = "CORRECT_REMARK";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackN1" /></summary>
            public const string BackN1 = "BACK_N1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackN2" /></summary>
            public const string BackN2 = "BACK_N2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackN3" /></summary>
            public const string BackN3 = "BACK_N3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackN4" /></summary>
            public const string BackN4 = "BACK_N4";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackN5" /></summary>
            public const string BackN5 = "BACK_N5";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC1" /></summary>
            public const string BackC1 = "BACK_C1";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC2" /></summary>
            public const string BackC2 = "BACK_C2";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC3" /></summary>
            public const string BackC3 = "BACK_C3";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC4" /></summary>
            public const string BackC4 = "BACK_C4";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC5" /></summary>
            public const string BackC5 = "BACK_C5";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC6" /></summary>
            public const string BackC6 = "BACK_C6";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC7" /></summary>
            public const string BackC7 = "BACK_C7";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC8" /></summary>
            public const string BackC8 = "BACK_C8";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC9" /></summary>
            public const string BackC9 = "BACK_C9";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.BackC10" /></summary>
            public const string BackC10 = "BACK_C10";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Labelname" /></summary>
            public const string Labelname = "LABELNAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.StockingPeriod" /></summary>
            public const string StockingPeriod = "STOCKING_PERIOD";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.AutoJudge" /></summary>
            public const string AutoJudge = "AUTO_JUDGE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.FinCustCname" /></summary>
            public const string FinCustCname = "FIN_CUST_CNAME";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.PsYn" /></summary>
            public const string PsYn = "PS_YN";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.ZincSufaceCl" /></summary>
            public const string ZincSufaceCl = "ZINC_SUFACE_CL";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.SkpMode" /></summary>
            public const string SkpMode = "SKP_MODE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Spangle" /></summary>
            public const string Spangle = "SPANGLE";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OrdCoatWtBot" /></summary>
            public const string OrdCoatWtBot = "ORD_COAT_WT_BOT";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.OrdCoatWtTop" /></summary>
            public const string OrdCoatWtTop = "ORD_COAT_WT_TOP";
            /// <summary>Column Name constant for property <see cref="WmsApi.Domain.Entities.Tmmcr01.Preparestus" /></summary>
            public const string Preparestus = "PREPARESTUS";
        }
        #endregion
    }
}
