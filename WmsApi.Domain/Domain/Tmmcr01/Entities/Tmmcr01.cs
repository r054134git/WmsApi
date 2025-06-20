using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 'tmmcr01'.
    /// </summary>
    public partial class Tmmcr01
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmmcr01"/> class.
        /// 
        /// </summary>
        public Tmmcr01()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_CREATOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_CREATOR'.
        /// </value>
        public string RecCreator { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_CREATE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_CREATE_TIME'.
        /// </value>
        public string RecCreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_REVISOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_REVISOR'.
        /// </value>
        public string RecRevisor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_REVISE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_REVISE_TIME'.
        /// </value>
        public string RecReviseTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_ERASOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_ERASOR'.
        /// </value>
        public string RecErasor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_ERASE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_ERASE_TIME'.
        /// </value>
        public string RecEraseTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ARCHIVE_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ARCHIVE_FLAG'.
        /// </value>
        public string ArchiveFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ARCHIVE_STAMP_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ARCHIVE_STAMP_NO'.
        /// </value>
        public string ArchiveStampNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_NO'.
        /// </value>
        public string MatNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ID'.
        /// </value>
        public string MatId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_TRACK_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_TRACK_NO'.
        /// </value>
        public string MatTrackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_LINE_TYPE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_LINE_TYPE'.
        /// </value>
        public string MatLineType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_KIND'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_KIND'.
        /// </value>
        public string MatKind { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNIT_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNIT_CODE'.
        /// </value>
        public string UnitCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NEXT_UNIT_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'NEXT_UNIT_CODE'.
        /// </value>
        public string NextUnitCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FACTORY_DIV'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'FACTORY_DIV'.
        /// </value>
        public string FactoryDiv { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_SHAPE_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_SHAPE_FLAG'.
        /// </value>
        public string MatShapeFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORIGIN_MAT_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORIGIN_MAT_NO'.
        /// </value>
        public string OriginMatNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RAW_ORIGIN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'RAW_ORIGIN'.
        /// </value>
        public string RawOrigin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ORIGIN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ORIGIN'.
        /// </value>
        public string MatOrigin { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_DESTION'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_DESTION'.
        /// </value>
        public string MatDestion { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCT_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCT_FLAG'.
        /// </value>
        public string ProductFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_STATUS'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_STATUS'.
        /// </value>
        public string MatStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_THICK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_THICK'.
        /// </value>
        public decimal? MatThick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_WIDTH'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_WIDTH'.
        /// </value>
        public decimal? MatWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_LEN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_LEN'.
        /// </value>
        public decimal? MatLen { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ACT_THICK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ACT_THICK'.
        /// </value>
        public decimal? MatActThick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ACT_WIDTH'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ACT_WIDTH'.
        /// </value>
        public decimal? MatActWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ACT_LEN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ACT_LEN'.
        /// </value>
        public decimal? MatActLen { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ACT_INNER_DIA'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ACT_INNER_DIA'.
        /// </value>
        public decimal? MatActInnerDia { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ACT_OUTER_DIA'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ACT_OUTER_DIA'.
        /// </value>
        public decimal? MatActOuterDia { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_TARG_THICK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_TARG_THICK'.
        /// </value>
        public decimal? MatTargThick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_TARG_WIDTH'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_TARG_WIDTH'.
        /// </value>
        public decimal? MatTargWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_TARG_LEN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_TARG_LEN'.
        /// </value>
        public decimal? MatTargLen { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ACT_WT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ACT_WT'.
        /// </value>
        public decimal? MatActWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_THEORY_WT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_THEORY_WT'.
        /// </value>
        public decimal? MatTheoryWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MEASURE_WT_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MEASURE_WT_FLAG'.
        /// </value>
        public string MeasureWtFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCT_PACK_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCT_PACK_FLAG'.
        /// </value>
        public string ProductPackFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PACK_UNIT_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PACK_UNIT_CODE'.
        /// </value>
        public string PackUnitCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PACK_TYPE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PACK_TYPE_CODE'.
        /// </value>
        public string PackTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_PACK_TYPE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_PACK_TYPE_CODE'.
        /// </value>
        public string OrderPackTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCT_PACK_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCT_PACK_TIME'.
        /// </value>
        public string ProductPackTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PACK_SHIFT_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PACK_SHIFT_NO'.
        /// </value>
        public string PackShiftNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PACK_SHIFT_GROUP'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PACK_SHIFT_GROUP'.
        /// </value>
        public string PackShiftGroup { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PACK_MAT_WT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PACK_MAT_WT'.
        /// </value>
        public decimal? PackMatWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_GROSS_WT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_GROSS_WT'.
        /// </value>
        public decimal? MatGrossWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PACK_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PACK_NO'.
        /// </value>
        public string PackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_THICK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_THICK'.
        /// </value>
        public decimal? OrderThick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_WIDTH'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_WIDTH'.
        /// </value>
        public decimal? OrderWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_LEN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_LEN'.
        /// </value>
        public decimal? OrderLen { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PONO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PONO'.
        /// </value>
        public string Pono { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HEAT_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'HEAT_NO'.
        /// </value>
        public string HeatNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ST_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ST_NO'.
        /// </value>
        public string StNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_MAKER'.
        /// </value>
        public string ProdMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_TIME'.
        /// </value>
        public string ProdTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_SHIFT_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_SHIFT_NO'.
        /// </value>
        public string ProdShiftNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_SHIFT_GROUP'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_SHIFT_GROUP'.
        /// </value>
        public string ProdShiftGroup { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STD_SG_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'STD_SG_CODE'.
        /// </value>
        public string StdSgCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SG_SIGN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SG_SIGN'.
        /// </value>
        public string SgSign { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SG_STD'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SG_STD'.
        /// </value>
        public string SgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SG_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SG_CODE'.
        /// </value>
        public string SgCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_STD_SG_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_STD_SG_CODE'.
        /// </value>
        public string OldStdSgCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_SG_STD'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_SG_STD'.
        /// </value>
        public string OldSgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_SG_SIGN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_SG_SIGN'.
        /// </value>
        public string OldSgSign { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PASS_BACKLOG_SEQ_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PASS_BACKLOG_SEQ_NO'.
        /// </value>
        public decimal? PassBacklogSeqNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WHOLE_BACKLOG_ACT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'WHOLE_BACKLOG_ACT'.
        /// </value>
        public string WholeBacklogAct { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FINAL_COIL_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'FINAL_COIL_FLAG'.
        /// </value>
        public string FinalCoilFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TAIL_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TAIL_FLAG'.
        /// </value>
        public string TailFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SHEET_NUM'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SHEET_NUM'.
        /// </value>
        public decimal? SheetNum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_ORDER_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_ORDER_NO'.
        /// </value>
        public string OldOrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVY_DATE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVY_DATE'.
        /// </value>
        public string DelivyDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FIN_CUST_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'FIN_CUST_CODE'.
        /// </value>
        public string FinCustCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WHOLE_BACKLOG_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'WHOLE_BACKLOG_NO'.
        /// </value>
        public decimal? WholeBacklogNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WHOLE_BACKLOG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'WHOLE_BACKLOG'.
        /// </value>
        public string WholeBacklog { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WHOLE_BACKLOG_SEQ'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'WHOLE_BACKLOG_SEQ'.
        /// </value>
        public decimal? WholeBacklogSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WHOLE_BACKLOG_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'WHOLE_BACKLOG_CODE'.
        /// </value>
        public string WholeBacklogCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NEXT_WHOLE_BACKLOG_SEQ'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'NEXT_WHOLE_BACKLOG_SEQ'.
        /// </value>
        public decimal? NextWholeBacklogSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NEXT_WHOLE_BACKLOG_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'NEXT_WHOLE_BACKLOG_CODE'.
        /// </value>
        public string NextWholeBacklogCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MSC'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MSC'.
        /// </value>
        public string Msc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_MSC'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_MSC'.
        /// </value>
        public string OldMsc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MSC_LINE_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MSC_LINE_NO'.
        /// </value>
        public string MscLineNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_MSC_LINE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_MSC_LINE'.
        /// </value>
        public string OldMscLine { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PSC'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PSC'.
        /// </value>
        public string Psc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_PSC'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_PSC'.
        /// </value>
        public string OldPsc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'APN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'APN'.
        /// </value>
        public string Apn { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_APN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_APN'.
        /// </value>
        public string OldApn { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_READY_DATE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_READY_DATE'.
        /// </value>
        public string ProdReadyDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BILL_OF_LADING_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BILL_OF_LADING_NO'.
        /// </value>
        public string BillOfLadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CONTRACT_NUM'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CONTRACT_NUM'.
        /// </value>
        public string ContractNum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_DISPOSE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_DISPOSE_CODE'.
        /// </value>
        public string MatDisposeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPOSE_SHIFT_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPOSE_SHIFT_NO'.
        /// </value>
        public string DisposeShiftNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DISPOSE_SHIFT_GROUP'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DISPOSE_SHIFT_GROUP'.
        /// </value>
        public string DisposeShiftGroup { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_FLAG'.
        /// </value>
        public string HoldFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_CAUSE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_CAUSE_CODE'.
        /// </value>
        public string HoldCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_TIME'.
        /// </value>
        public string HoldTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_MAKER'.
        /// </value>
        public string HoldMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_REMARK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_REMARK'.
        /// </value>
        public string HoldRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REL_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REL_MAKER'.
        /// </value>
        public string RelMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REL_REMARK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REL_REMARK'.
        /// </value>
        public string RelRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REL_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REL_TIME'.
        /// </value>
        public string RelTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_CAUSE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_CAUSE_CODE'.
        /// </value>
        public string RemainCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_DECIDE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_DECIDE_CODE'.
        /// </value>
        public string RemainDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_DECIDE_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_DECIDE_MAKER'.
        /// </value>
        public string RemainDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_DECIDE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_DECIDE_TIME'.
        /// </value>
        public string RemainDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_REMARK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_REMARK'.
        /// </value>
        public string RemainRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DROP_LEVEL_TYPE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DROP_LEVEL_TYPE'.
        /// </value>
        public string DropLevelType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DROP_LEVEL_REMARK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DROP_LEVEL_REMARK'.
        /// </value>
        public string DropLevelRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DROP_LEVEL_CAUSE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DROP_LEVEL_CAUSE_CODE'.
        /// </value>
        public string DropLevelCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCRAP_CAUSE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCRAP_CAUSE_CODE'.
        /// </value>
        public string ScrapCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCRAP_REMARK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCRAP_REMARK'.
        /// </value>
        public string ScrapRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCRAP_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCRAP_TIME'.
        /// </value>
        public string ScrapTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCRAP_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCRAP_MAKER'.
        /// </value>
        public string ScrapMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REPAIR_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REPAIR_FLAG'.
        /// </value>
        public string RepairFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REPAIR_BACKLOG_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REPAIR_BACKLOG_CODE'.
        /// </value>
        public string RepairBacklogCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REPAIR_REMARK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REPAIR_REMARK'.
        /// </value>
        public string RepairRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REPAIR_TYPE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'REPAIR_TYPE'.
        /// </value>
        public string RepairType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_REPAIR_REASON'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_REPAIR_REASON'.
        /// </value>
        public string MatRepairReason { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SURFACE_DECIDE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SURFACE_DECIDE_CODE'.
        /// </value>
        public string SurfaceDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SURFACE_DECIDE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SURFACE_DECIDE_TIME'.
        /// </value>
        public string SurfaceDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SURFACE_DECIDE_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SURFACE_DECIDE_MAKER'.
        /// </value>
        public string SurfaceDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COMPLEX_DECIDE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COMPLEX_DECIDE_CODE'.
        /// </value>
        public string ComplexDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COMPLEX_DECIDE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COMPLEX_DECIDE_TIME'.
        /// </value>
        public string ComplexDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COMPLEX_DECIDE_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COMPLEX_DECIDE_MAKER'.
        /// </value>
        public string ComplexDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_COMPLEX_DECIDE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_COMPLEX_DECIDE_CODE'.
        /// </value>
        public string OldComplexDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_COMPLEX_DECIDE_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_COMPLEX_DECIDE_TIME'.
        /// </value>
        public string OldComplexDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_COMPLEX_DECIDE_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_COMPLEX_DECIDE_MAKER'.
        /// </value>
        public string OldComplexDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NEW_TEST_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'NEW_TEST_NO'.
        /// </value>
        public string NewTestNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SAMPLE_LOT_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SAMPLE_LOT_NO'.
        /// </value>
        public string SampleLotNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SAMPLE_TAKEN_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SAMPLE_TAKEN_FLAG'.
        /// </value>
        public string SampleTakenFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEFECT_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEFECT_CODE'.
        /// </value>
        public string DefectCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEFECT_CLASS'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEFECT_CLASS'.
        /// </value>
        public string DefectClass { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_NO'.
        /// </value>
        public string PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSFER_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSFER_FLAG'.
        /// </value>
        public string TransferFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSFER_PLAN_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSFER_PLAN_NO'.
        /// </value>
        public string TransferPlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSFER_REJECT_CAUSE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSFER_REJECT_CAUSE'.
        /// </value>
        public string TransferRejectCause { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSFER_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSFER_MAKER'.
        /// </value>
        public string TransferMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSFER_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSFER_TIME'.
        /// </value>
        public string TransferTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'APP_DECIDE_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'APP_DECIDE_FLAG'.
        /// </value>
        public string AppDecideFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'APP_DECIDE_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'APP_DECIDE_NO'.
        /// </value>
        public string AppDecideNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'APP_DECIDE_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'APP_DECIDE_MAKER'.
        /// </value>
        public string AppDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STOCK_PLACE_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOCK_PLACE_NO'.
        /// </value>
        public string StockPlaceNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STOCK_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOCK_NO'.
        /// </value>
        public string StockNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HALL_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'HALL_NO'.
        /// </value>
        public string HallNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROWNO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROWNO'.
        /// </value>
        public string Rowno { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COLUMN_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'COLUMN_NO'.
        /// </value>
        public string ColumnNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LAYERNO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LAYERNO'.
        /// </value>
        public string Layerno { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_FLAG'.
        /// </value>
        public string InFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_STOCK_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_STOCK_TIME'.
        /// </value>
        public string InStockTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OUT_STOCK_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OUT_STOCK_TIME'.
        /// </value>
        public string OutStockTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CMD_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CMD_FLAG'.
        /// </value>
        public string CmdFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STOCK_PLACE_NO_PRE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOCK_PLACE_NO_PRE'.
        /// </value>
        public string StockPlaceNoPre { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CHOOSE_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CHOOSE_FLAG'.
        /// </value>
        public string ChooseFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SKID_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SKID_NO'.
        /// </value>
        public string SkidNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_MAT_NO_1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_MAT_NO_1'.
        /// </value>
        public string InMatNo1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_MAT_NO_2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_MAT_NO_2'.
        /// </value>
        public string InMatNo2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_MAT_1_WT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_MAT_1_WT'.
        /// </value>
        public decimal? InMat1Wt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_MAT_2_WT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_MAT_2_WT'.
        /// </value>
        public decimal? InMat2Wt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_MAT_1_TRACK_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_MAT_1_TRACK_NO'.
        /// </value>
        public string InMat1TrackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IN_MAT_2_TRACK_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IN_MAT_2_TRACK_NO'.
        /// </value>
        public string InMat2TrackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BETTER_SURF_WARD_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BETTER_SURF_WARD_CODE'.
        /// </value>
        public string BetterSurfWardCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ANNEAL_DIAGRAM_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ANNEAL_DIAGRAM_CODE'.
        /// </value>
        public string AnnealDiagramCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TOP_PLATE_TYPE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TOP_PLATE_TYPE_CODE'.
        /// </value>
        public string TopPlateTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BOT_PLATE_TYPE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BOT_PLATE_TYPE_CODE'.
        /// </value>
        public string BotPlateTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TOP_PLATE_WT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TOP_PLATE_WT'.
        /// </value>
        public decimal? TopPlateWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BOT_PLATE_WT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BOT_PLATE_WT'.
        /// </value>
        public decimal? BotPlateWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OIL_KIND_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OIL_KIND_CODE'.
        /// </value>
        public string OilKindCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OIL_QTY_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'OIL_QTY_CODE'.
        /// </value>
        public string OilQtyCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TOP_STRUC_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TOP_STRUC_CODE'.
        /// </value>
        public string TopStrucCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BOT_STRUC_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BOT_STRUC_CODE'.
        /// </value>
        public string BotStrucCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DUMMY_COIL_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DUMMY_COIL_FLAG'.
        /// </value>
        public string DummyCoilFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DUMMY_COIL_USE_TIMES'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DUMMY_COIL_USE_TIMES'.
        /// </value>
        public decimal? DummyCoilUseTimes { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_RETURN_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_RETURN_FLAG'.
        /// </value>
        public string MatReturnFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_RETURN_CAUSE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_RETURN_CAUSE_CODE'.
        /// </value>
        public string MatReturnCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_UNION_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_UNION_FLAG'.
        /// </value>
        public string MatUnionFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRIM_FLAG'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRIM_FLAG'.
        /// </value>
        public string TrimFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POST_PROC_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'POST_PROC_CODE'.
        /// </value>
        public string PostProcCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_CODE'.
        /// </value>
        public string ProdCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_CNAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_CNAME'.
        /// </value>
        public string ProdCname { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_ENAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_ENAME'.
        /// </value>
        public string ProdEname { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SURFACE_GRADE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SURFACE_GRADE_CODE'.
        /// </value>
        public string SurfaceGradeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORT_GRADE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORT_GRADE_CODE'.
        /// </value>
        public string SortGradeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SURFACE_ACCU_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SURFACE_ACCU_CODE'.
        /// </value>
        public string SurfaceAccuCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROUGH'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROUGH'.
        /// </value>
        public decimal? Rough { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STAGGER_WINDING'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'STAGGER_WINDING'.
        /// </value>
        public string StaggerWinding { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CORRECTION_CAUSE_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CORRECTION_CAUSE_CODE'.
        /// </value>
        public string CorrectionCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CORRECTION_MAKER'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CORRECTION_MAKER'.
        /// </value>
        public string CorrectionMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CORRECTION_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CORRECTION_TIME'.
        /// </value>
        public string CorrectionTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CORRECT_REMARK'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CORRECT_REMARK'.
        /// </value>
        public string CorrectRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_N1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_N1'.
        /// </value>
        public decimal? BackN1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_N2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_N2'.
        /// </value>
        public decimal? BackN2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_N3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_N3'.
        /// </value>
        public decimal? BackN3 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_N4'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_N4'.
        /// </value>
        public decimal? BackN4 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_N5'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_N5'.
        /// </value>
        public decimal? BackN5 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C1'.
        /// </value>
        public string BackC1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C2'.
        /// </value>
        public string BackC2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C3'.
        /// </value>
        public string BackC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C4'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C4'.
        /// </value>
        public string BackC4 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C5'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C5'.
        /// </value>
        public string BackC5 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C6'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C6'.
        /// </value>
        public string BackC6 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C7'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C7'.
        /// </value>
        public string BackC7 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C8'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C8'.
        /// </value>
        public string BackC8 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C9'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C9'.
        /// </value>
        public string BackC9 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BACK_C10'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BACK_C10'.
        /// </value>
        public string BackC10 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LABELNAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LABELNAME'.
        /// </value>
        public string Labelname { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STOCKING_PERIOD'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOCKING_PERIOD'.
        /// </value>
        public string StockingPeriod { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AUTO_JUDGE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'AUTO_JUDGE'.
        /// </value>
        public string AutoJudge { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FIN_CUST_CNAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'FIN_CUST_CNAME'.
        /// </value>
        public string FinCustCname { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PS_YN'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PS_YN'.
        /// </value>
        public string PsYn { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ZINC_SUFACE_CL'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ZINC_SUFACE_CL'.
        /// </value>
        public string ZincSufaceCl { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SKP_MODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SKP_MODE'.
        /// </value>
        public string SkpMode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPANGLE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPANGLE'.
        /// </value>
        public string Spangle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORD_COAT_WT_BOT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORD_COAT_WT_BOT'.
        /// </value>
        public decimal? OrdCoatWtBot { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORD_COAT_WT_TOP'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORD_COAT_WT_TOP'.
        /// </value>
        public decimal? OrdCoatWtTop { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PREPARESTUS'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PREPARESTUS'.
        /// </value>
        public string Preparestus { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
