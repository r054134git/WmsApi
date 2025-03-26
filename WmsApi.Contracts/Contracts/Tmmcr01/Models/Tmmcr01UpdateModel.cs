using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class Tmmcr01UpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'RecCreator'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RecCreator'.
        /// </value>
        public string RecCreator { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecCreateTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RecCreateTime'.
        /// </value>
        public string RecCreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecRevisor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RecRevisor'.
        /// </value>
        public string RecRevisor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecReviseTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RecReviseTime'.
        /// </value>
        public string RecReviseTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecErasor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RecErasor'.
        /// </value>
        public string RecErasor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecEraseTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RecEraseTime'.
        /// </value>
        public string RecEraseTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ArchiveFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ArchiveFlag'.
        /// </value>
        public string ArchiveFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ArchiveStampNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ArchiveStampNo'.
        /// </value>
        public string ArchiveStampNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatNo'.
        /// </value>
        public string MatNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatId'.
        /// </value>
        public string MatId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTrackNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatTrackNo'.
        /// </value>
        public string MatTrackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatLineType'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatLineType'.
        /// </value>
        public string MatLineType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatKind'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatKind'.
        /// </value>
        public string MatKind { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnitCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'UnitCode'.
        /// </value>
        public string UnitCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NextUnitCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'NextUnitCode'.
        /// </value>
        public string NextUnitCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FactoryDiv'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'FactoryDiv'.
        /// </value>
        public string FactoryDiv { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatShapeFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatShapeFlag'.
        /// </value>
        public string MatShapeFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OriginMatNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OriginMatNo'.
        /// </value>
        public string OriginMatNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RawOrigin'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RawOrigin'.
        /// </value>
        public string RawOrigin { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatOrigin'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatOrigin'.
        /// </value>
        public string MatOrigin { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDestion'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatDestion'.
        /// </value>
        public string MatDestion { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProductFlag'.
        /// </value>
        public string ProductFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatStatus'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatStatus'.
        /// </value>
        public string MatStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatThick'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatThick'.
        /// </value>
        public decimal? MatThick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatWidth'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatWidth'.
        /// </value>
        public decimal? MatWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatLen'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatLen'.
        /// </value>
        public decimal? MatLen { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatActThick'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatActThick'.
        /// </value>
        public decimal? MatActThick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatActWidth'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatActWidth'.
        /// </value>
        public decimal? MatActWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatActLen'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatActLen'.
        /// </value>
        public decimal? MatActLen { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatActInnerDia'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatActInnerDia'.
        /// </value>
        public decimal? MatActInnerDia { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatActOuterDia'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatActOuterDia'.
        /// </value>
        public decimal? MatActOuterDia { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTargThick'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatTargThick'.
        /// </value>
        public decimal? MatTargThick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTargWidth'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatTargWidth'.
        /// </value>
        public decimal? MatTargWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTargLen'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatTargLen'.
        /// </value>
        public decimal? MatTargLen { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatActWt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatActWt'.
        /// </value>
        public decimal? MatActWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTheoryWt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatTheoryWt'.
        /// </value>
        public decimal? MatTheoryWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MeasureWtFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MeasureWtFlag'.
        /// </value>
        public string MeasureWtFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductPackFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProductPackFlag'.
        /// </value>
        public string ProductPackFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackUnitCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PackUnitCode'.
        /// </value>
        public string PackUnitCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackTypeCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PackTypeCode'.
        /// </value>
        public string PackTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderPackTypeCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OrderPackTypeCode'.
        /// </value>
        public string OrderPackTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductPackTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProductPackTime'.
        /// </value>
        public string ProductPackTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackShiftNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PackShiftNo'.
        /// </value>
        public string PackShiftNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackShiftGroup'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PackShiftGroup'.
        /// </value>
        public string PackShiftGroup { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackMatWt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PackMatWt'.
        /// </value>
        public decimal? PackMatWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatGrossWt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatGrossWt'.
        /// </value>
        public decimal? MatGrossWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PackNo'.
        /// </value>
        public string PackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderThick'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OrderThick'.
        /// </value>
        public decimal? OrderThick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderWidth'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OrderWidth'.
        /// </value>
        public decimal? OrderWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderLen'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OrderLen'.
        /// </value>
        public decimal? OrderLen { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Pono'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Pono'.
        /// </value>
        public string Pono { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HeatNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'HeatNo'.
        /// </value>
        public string HeatNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'StNo'.
        /// </value>
        public string StNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProdMaker'.
        /// </value>
        public string ProdMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProdTime'.
        /// </value>
        public string ProdTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdShiftNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProdShiftNo'.
        /// </value>
        public string ProdShiftNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdShiftGroup'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProdShiftGroup'.
        /// </value>
        public string ProdShiftGroup { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StdSgCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'StdSgCode'.
        /// </value>
        public string StdSgCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SgSign'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SgSign'.
        /// </value>
        public string SgSign { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SgStd'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SgStd'.
        /// </value>
        public string SgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SgCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SgCode'.
        /// </value>
        public string SgCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldStdSgCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldStdSgCode'.
        /// </value>
        public string OldStdSgCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldSgStd'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldSgStd'.
        /// </value>
        public string OldSgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldSgSign'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldSgSign'.
        /// </value>
        public string OldSgSign { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PassBacklogSeqNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PassBacklogSeqNo'.
        /// </value>
        public decimal? PassBacklogSeqNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WholeBacklogAct'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'WholeBacklogAct'.
        /// </value>
        public string WholeBacklogAct { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FinalCoilFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'FinalCoilFlag'.
        /// </value>
        public string FinalCoilFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TailFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TailFlag'.
        /// </value>
        public string TailFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SheetNum'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SheetNum'.
        /// </value>
        public decimal? SheetNum { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldOrderNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldOrderNo'.
        /// </value>
        public string OldOrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DelivyDate'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DelivyDate'.
        /// </value>
        public string DelivyDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FinCustCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'FinCustCode'.
        /// </value>
        public string FinCustCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WholeBacklogNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'WholeBacklogNo'.
        /// </value>
        public decimal? WholeBacklogNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WholeBacklog'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'WholeBacklog'.
        /// </value>
        public string WholeBacklog { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WholeBacklogSeq'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'WholeBacklogSeq'.
        /// </value>
        public decimal? WholeBacklogSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WholeBacklogCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'WholeBacklogCode'.
        /// </value>
        public string WholeBacklogCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NextWholeBacklogSeq'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'NextWholeBacklogSeq'.
        /// </value>
        public decimal? NextWholeBacklogSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NextWholeBacklogCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'NextWholeBacklogCode'.
        /// </value>
        public string NextWholeBacklogCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Msc'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Msc'.
        /// </value>
        public string Msc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldMsc'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldMsc'.
        /// </value>
        public string OldMsc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MscLineNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MscLineNo'.
        /// </value>
        public string MscLineNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldMscLine'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldMscLine'.
        /// </value>
        public string OldMscLine { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Psc'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Psc'.
        /// </value>
        public string Psc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldPsc'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldPsc'.
        /// </value>
        public string OldPsc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Apn'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Apn'.
        /// </value>
        public string Apn { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldApn'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldApn'.
        /// </value>
        public string OldApn { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdReadyDate'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProdReadyDate'.
        /// </value>
        public string ProdReadyDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BillOfLadingNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BillOfLadingNo'.
        /// </value>
        public string BillOfLadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ContractNum'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ContractNum'.
        /// </value>
        public string ContractNum { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDisposeCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatDisposeCode'.
        /// </value>
        public string MatDisposeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DisposeShiftNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DisposeShiftNo'.
        /// </value>
        public string DisposeShiftNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DisposeShiftGroup'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DisposeShiftGroup'.
        /// </value>
        public string DisposeShiftGroup { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'HoldFlag'.
        /// </value>
        public string HoldFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldCauseCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'HoldCauseCode'.
        /// </value>
        public string HoldCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'HoldTime'.
        /// </value>
        public string HoldTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'HoldMaker'.
        /// </value>
        public string HoldMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldRemark'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'HoldRemark'.
        /// </value>
        public string HoldRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RelMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RelMaker'.
        /// </value>
        public string RelMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RelRemark'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RelRemark'.
        /// </value>
        public string RelRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RelTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RelTime'.
        /// </value>
        public string RelTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainCauseCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RemainCauseCode'.
        /// </value>
        public string RemainCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainDecideCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RemainDecideCode'.
        /// </value>
        public string RemainDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainDecideMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RemainDecideMaker'.
        /// </value>
        public string RemainDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainDecideTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RemainDecideTime'.
        /// </value>
        public string RemainDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainRemark'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RemainRemark'.
        /// </value>
        public string RemainRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DropLevelType'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DropLevelType'.
        /// </value>
        public string DropLevelType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DropLevelRemark'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DropLevelRemark'.
        /// </value>
        public string DropLevelRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DropLevelCauseCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DropLevelCauseCode'.
        /// </value>
        public string DropLevelCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ScrapCauseCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ScrapCauseCode'.
        /// </value>
        public string ScrapCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ScrapRemark'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ScrapRemark'.
        /// </value>
        public string ScrapRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ScrapTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ScrapTime'.
        /// </value>
        public string ScrapTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ScrapMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ScrapMaker'.
        /// </value>
        public string ScrapMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RepairFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RepairFlag'.
        /// </value>
        public string RepairFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RepairBacklogCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RepairBacklogCode'.
        /// </value>
        public string RepairBacklogCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RepairRemark'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RepairRemark'.
        /// </value>
        public string RepairRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RepairType'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RepairType'.
        /// </value>
        public string RepairType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatRepairReason'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatRepairReason'.
        /// </value>
        public string MatRepairReason { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SurfaceDecideCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SurfaceDecideCode'.
        /// </value>
        public string SurfaceDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SurfaceDecideTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SurfaceDecideTime'.
        /// </value>
        public string SurfaceDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SurfaceDecideMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SurfaceDecideMaker'.
        /// </value>
        public string SurfaceDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ComplexDecideCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ComplexDecideCode'.
        /// </value>
        public string ComplexDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ComplexDecideTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ComplexDecideTime'.
        /// </value>
        public string ComplexDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ComplexDecideMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ComplexDecideMaker'.
        /// </value>
        public string ComplexDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldComplexDecideCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldComplexDecideCode'.
        /// </value>
        public string OldComplexDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldComplexDecideTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldComplexDecideTime'.
        /// </value>
        public string OldComplexDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldComplexDecideMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OldComplexDecideMaker'.
        /// </value>
        public string OldComplexDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NewTestNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'NewTestNo'.
        /// </value>
        public string NewTestNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SampleLotNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SampleLotNo'.
        /// </value>
        public string SampleLotNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SampleTakenFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SampleTakenFlag'.
        /// </value>
        public string SampleTakenFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DefectCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DefectCode'.
        /// </value>
        public string DefectCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DefectClass'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DefectClass'.
        /// </value>
        public string DefectClass { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PlanNo'.
        /// </value>
        public string PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransferFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TransferFlag'.
        /// </value>
        public string TransferFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransferPlanNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TransferPlanNo'.
        /// </value>
        public string TransferPlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransferRejectCause'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TransferRejectCause'.
        /// </value>
        public string TransferRejectCause { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransferMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TransferMaker'.
        /// </value>
        public string TransferMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransferTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TransferTime'.
        /// </value>
        public string TransferTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AppDecideFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'AppDecideFlag'.
        /// </value>
        public string AppDecideFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AppDecideNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'AppDecideNo'.
        /// </value>
        public string AppDecideNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AppDecideMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'AppDecideMaker'.
        /// </value>
        public string AppDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StockPlaceNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'StockPlaceNo'.
        /// </value>
        public string StockPlaceNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StockNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'StockNo'.
        /// </value>
        public string StockNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HallNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'HallNo'.
        /// </value>
        public string HallNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Rowno'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Rowno'.
        /// </value>
        public string Rowno { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ColumnNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ColumnNo'.
        /// </value>
        public string ColumnNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Layerno'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Layerno'.
        /// </value>
        public string Layerno { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'InFlag'.
        /// </value>
        public string InFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InStockTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'InStockTime'.
        /// </value>
        public string InStockTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OutStockTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OutStockTime'.
        /// </value>
        public string OutStockTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CmdFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CmdFlag'.
        /// </value>
        public string CmdFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StockPlaceNoPre'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'StockPlaceNoPre'.
        /// </value>
        public string StockPlaceNoPre { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ChooseFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ChooseFlag'.
        /// </value>
        public string ChooseFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SkidNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SkidNo'.
        /// </value>
        public string SkidNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InMatNo1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'InMatNo1'.
        /// </value>
        public string InMatNo1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InMatNo2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'InMatNo2'.
        /// </value>
        public string InMatNo2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InMat1Wt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'InMat1Wt'.
        /// </value>
        public decimal? InMat1Wt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InMat2Wt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'InMat2Wt'.
        /// </value>
        public decimal? InMat2Wt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InMat1TrackNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'InMat1TrackNo'.
        /// </value>
        public string InMat1TrackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InMat2TrackNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'InMat2TrackNo'.
        /// </value>
        public string InMat2TrackNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BetterSurfWardCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BetterSurfWardCode'.
        /// </value>
        public string BetterSurfWardCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AnnealDiagramCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'AnnealDiagramCode'.
        /// </value>
        public string AnnealDiagramCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TopPlateTypeCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TopPlateTypeCode'.
        /// </value>
        public string TopPlateTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BotPlateTypeCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BotPlateTypeCode'.
        /// </value>
        public string BotPlateTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TopPlateWt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TopPlateWt'.
        /// </value>
        public decimal? TopPlateWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BotPlateWt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BotPlateWt'.
        /// </value>
        public decimal? BotPlateWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OilKindCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OilKindCode'.
        /// </value>
        public string OilKindCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OilQtyCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OilQtyCode'.
        /// </value>
        public string OilQtyCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TopStrucCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TopStrucCode'.
        /// </value>
        public string TopStrucCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BotStrucCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BotStrucCode'.
        /// </value>
        public string BotStrucCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DummyCoilFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DummyCoilFlag'.
        /// </value>
        public string DummyCoilFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DummyCoilUseTimes'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'DummyCoilUseTimes'.
        /// </value>
        public decimal? DummyCoilUseTimes { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatReturnFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatReturnFlag'.
        /// </value>
        public string MatReturnFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatReturnCauseCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatReturnCauseCode'.
        /// </value>
        public string MatReturnCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatUnionFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MatUnionFlag'.
        /// </value>
        public string MatUnionFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrimFlag'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TrimFlag'.
        /// </value>
        public string TrimFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PostProcCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PostProcCode'.
        /// </value>
        public string PostProcCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProdCode'.
        /// </value>
        public string ProdCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdCname'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProdCname'.
        /// </value>
        public string ProdCname { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdEname'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ProdEname'.
        /// </value>
        public string ProdEname { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SurfaceGradeCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SurfaceGradeCode'.
        /// </value>
        public string SurfaceGradeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SortGradeCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SortGradeCode'.
        /// </value>
        public string SortGradeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SurfaceAccuCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SurfaceAccuCode'.
        /// </value>
        public string SurfaceAccuCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Rough'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Rough'.
        /// </value>
        public decimal? Rough { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StaggerWinding'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'StaggerWinding'.
        /// </value>
        public string StaggerWinding { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CorrectionCauseCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CorrectionCauseCode'.
        /// </value>
        public string CorrectionCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CorrectionMaker'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CorrectionMaker'.
        /// </value>
        public string CorrectionMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CorrectionTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CorrectionTime'.
        /// </value>
        public string CorrectionTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CorrectRemark'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CorrectRemark'.
        /// </value>
        public string CorrectRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackN1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackN1'.
        /// </value>
        public decimal? BackN1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackN2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackN2'.
        /// </value>
        public decimal? BackN2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackN3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackN3'.
        /// </value>
        public decimal? BackN3 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackN4'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackN4'.
        /// </value>
        public decimal? BackN4 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackN5'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackN5'.
        /// </value>
        public decimal? BackN5 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC1'.
        /// </value>
        public string BackC1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC2'.
        /// </value>
        public string BackC2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC3'.
        /// </value>
        public string BackC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC4'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC4'.
        /// </value>
        public string BackC4 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC5'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC5'.
        /// </value>
        public string BackC5 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC6'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC6'.
        /// </value>
        public string BackC6 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC7'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC7'.
        /// </value>
        public string BackC7 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC8'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC8'.
        /// </value>
        public string BackC8 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC9'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC9'.
        /// </value>
        public string BackC9 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BackC10'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BackC10'.
        /// </value>
        public string BackC10 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Labelname'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Labelname'.
        /// </value>
        public string Labelname { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StockingPeriod'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'StockingPeriod'.
        /// </value>
        public string StockingPeriod { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AutoJudge'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'AutoJudge'.
        /// </value>
        public string AutoJudge { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FinCustCname'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'FinCustCname'.
        /// </value>
        public string FinCustCname { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PsYn'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PsYn'.
        /// </value>
        public string PsYn { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ZincSufaceCl'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ZincSufaceCl'.
        /// </value>
        public string ZincSufaceCl { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SkpMode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SkpMode'.
        /// </value>
        public string SkpMode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Spangle'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Spangle'.
        /// </value>
        public string Spangle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrdCoatWtBot'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OrdCoatWtBot'.
        /// </value>
        public decimal? OrdCoatWtBot { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrdCoatWtTop'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OrdCoatWtTop'.
        /// </value>
        public decimal? OrdCoatWtTop { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Preparestus'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Preparestus'.
        /// </value>
        public string Preparestus { get; set; }

        #endregion

    }
}
