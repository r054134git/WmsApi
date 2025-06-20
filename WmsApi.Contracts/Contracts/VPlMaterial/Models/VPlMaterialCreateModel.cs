using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class VPlMaterialCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'RecCreator'.
        /// '记录创建责任者'.
        /// </summary>
        /// <value>
        /// The property value for 'RecCreator'.
        /// </value>
        public string RecCreator { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecCreateTime'.
        /// '记录创建时刻'.
        /// </summary>
        /// <value>
        /// The property value for 'RecCreateTime'.
        /// </value>
        public string RecCreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecRevisor'.
        /// '记录修改责任者'.
        /// </summary>
        /// <value>
        /// The property value for 'RecRevisor'.
        /// </value>
        public string RecRevisor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecReviseTime'.
        /// '记录修改时刻'.
        /// </summary>
        /// <value>
        /// The property value for 'RecReviseTime'.
        /// </value>
        public string RecReviseTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RecCreateReason'.
        /// '记录创建原因 1:正常2:盘盈3:合包4:红冲'.
        /// </summary>
        /// <value>
        /// The property value for 'RecCreateReason'.
        /// </value>
        public int? RecCreateReason { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'No'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value for 'No'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MotherNo'.
        /// '母卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'MotherNo'.
        /// </value>
        public string MotherNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BundlePackageNo'.
        /// '捆包号'.
        /// </summary>
        /// <value>
        /// The property value for 'BundlePackageNo'.
        /// </value>
        public string BundlePackageNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProcessCode'.
        /// '机组代码'.
        /// </summary>
        /// <value>
        /// The property value for 'ProcessCode'.
        /// </value>
        public string ProcessCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NextProcessCode'.
        /// '下道机组代码'.
        /// </summary>
        /// <value>
        /// The property value for 'NextProcessCode'.
        /// </value>
        public string NextProcessCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Thick'.
        /// '材料厚度mm'.
        /// </summary>
        /// <value>
        /// The property value for 'Thick'.
        /// </value>
        public decimal Thick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Width'.
        /// '材料宽度mm'.
        /// </summary>
        /// <value>
        /// The property value for 'Width'.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Weight'.
        /// '产品卷重kg'.
        /// </summary>
        /// <value>
        /// The property value for 'Weight'.
        /// </value>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Length'.
        /// '产品长度'.
        /// </summary>
        /// <value>
        /// The property value for 'Length'.
        /// </value>
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Diameter'.
        /// '钢卷直径(外径)mm'.
        /// </summary>
        /// <value>
        /// The property value for 'Diameter'.
        /// </value>
        public int? Diameter { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InnerDiameter'.
        /// '内径'.
        /// </summary>
        /// <value>
        /// The property value for 'InnerDiameter'.
        /// </value>
        public int? InnerDiameter { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatShapeFlag'.
        /// '材料形态标志 3-钢卷'.
        /// </summary>
        /// <value>
        /// The property value for 'MatShapeFlag'.
        /// </value>
        public string MatShapeFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatStatus'.
        /// '材料状态码'.
        /// </summary>
        /// <value>
        /// The property value for 'MatStatus'.
        /// </value>
        public string MatStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTargThick'.
        /// '材料目标厚度'.
        /// </summary>
        /// <value>
        /// The property value for 'MatTargThick'.
        /// </value>
        public decimal? MatTargThick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTargWidth'.
        /// '材料目标宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'MatTargWidth'.
        /// </value>
        public int? MatTargWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTargLen'.
        /// '材料目标长度'.
        /// </summary>
        /// <value>
        /// The property value for 'MatTargLen'.
        /// </value>
        public int? MatTargLen { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatActWt'.
        /// '材料实际重量'.
        /// </summary>
        /// <value>
        /// The property value for 'MatActWt'.
        /// </value>
        public int? MatActWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatTheoryWt'.
        /// '材料理论重量'.
        /// </summary>
        /// <value>
        /// The property value for 'MatTheoryWt'.
        /// </value>
        public int? MatTheoryWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MeasureWtFlag'.
        /// '称重标记'.
        /// </summary>
        /// <value>
        /// The property value for 'MeasureWtFlag'.
        /// </value>
        public string MeasureWtFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductPackFlag'.
        /// '成品包装标志'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductPackFlag'.
        /// </value>
        public string ProductPackFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsDistributionShip'.
        /// '是否配船 0 不配船  1 配船'.
        /// </summary>
        /// <value>
        /// The property value for 'IsDistributionShip'.
        /// </value>
        public int? IsDistributionShip { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Pono'.
        /// '制造命令号'.
        /// </summary>
        /// <value>
        /// The property value for 'Pono'.
        /// </value>
        public string Pono { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HeatNo'.
        /// '熔炼号'.
        /// </summary>
        /// <value>
        /// The property value for 'HeatNo'.
        /// </value>
        public string HeatNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SteelGrade'.
        /// '钢品类别'.
        /// </summary>
        /// <value>
        /// The property value for 'SteelGrade'.
        /// </value>
        public string SteelGrade { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdTime'.
        /// '生产时刻'.
        /// </summary>
        /// <value>
        /// The property value for 'ProdTime'.
        /// </value>
        public string ProdTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdShiftNo'.
        /// '生产班次号'.
        /// </summary>
        /// <value>
        /// The property value for 'ProdShiftNo'.
        /// </value>
        public string ProdShiftNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdShiftGroup'.
        /// '生产班组'.
        /// </summary>
        /// <value>
        /// The property value for 'ProdShiftGroup'.
        /// </value>
        public string ProdShiftGroup { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SgSign'.
        /// '牌号（钢级）'.
        /// </summary>
        /// <value>
        /// The property value for 'SgSign'.
        /// </value>
        public string SgSign { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SgStd'.
        /// '标准'.
        /// </summary>
        /// <value>
        /// The property value for 'SgStd'.
        /// </value>
        public string SgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldSgSign'.
        /// '原牌号（钢级）'.
        /// </summary>
        /// <value>
        /// The property value for 'OldSgSign'.
        /// </value>
        public string OldSgSign { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldSgStd'.
        /// '原标准'.
        /// </summary>
        /// <value>
        /// The property value for 'OldSgStd'.
        /// </value>
        public string OldSgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderNo'.
        /// '合同号(订单号)'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldOrderNo'.
        /// '旧的合同号(订单号)'.
        /// </summary>
        /// <value>
        /// The property value for 'OldOrderNo'.
        /// </value>
        public string OldOrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDirection'.
        /// '材料去向(BMWM01 流向 U127)'.
        /// </summary>
        /// <value>
        /// The property value for 'MatDirection'.
        /// </value>
        public string MatDirection { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrnpModeCode'.
        /// '运输方式'.
        /// </summary>
        /// <value>
        /// The property value for 'TrnpModeCode'.
        /// </value>
        public string TrnpModeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackingTypeCode'.
        /// '包装类型代码'.
        /// </summary>
        /// <value>
        /// The property value for 'PackingTypeCode'.
        /// </value>
        public string PackingTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DecideThick'.
        /// '判定厚度'.
        /// </summary>
        /// <value>
        /// The property value for 'DecideThick'.
        /// </value>
        public decimal? DecideThick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DecideWidth'.
        /// '判定宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'DecideWidth'.
        /// </value>
        public int? DecideWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LabelDemand'.
        /// '标牌要求'.
        /// </summary>
        /// <value>
        /// The property value for 'LabelDemand'.
        /// </value>
        public string LabelDemand { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsOrdered'.
        /// '有无主，0：无，1：有'.
        /// </summary>
        /// <value>
        /// The property value for 'IsOrdered'.
        /// </value>
        public int? IsOrdered { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ReadyState'.
        /// '备货状态'.
        /// </summary>
        /// <value>
        /// The property value for 'ReadyState'.
        /// </value>
        public string ReadyState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdCode'.
        /// '品名代码'.
        /// </summary>
        /// <value>
        /// The property value for 'ProdCode'.
        /// </value>
        public string ProdCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdCname'.
        /// '品名中文'.
        /// </summary>
        /// <value>
        /// The property value for 'ProdCname'.
        /// </value>
        public string ProdCname { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdEname'.
        /// '品名英文'.
        /// </summary>
        /// <value>
        /// The property value for 'ProdEname'.
        /// </value>
        public string ProdEname { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldFlag'.
        /// '封锁标记 0 正常 2封锁'.
        /// </summary>
        /// <value>
        /// The property value for 'HoldFlag'.
        /// </value>
        public string HoldFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldCauseCode'.
        /// '封锁原因代码'.
        /// </summary>
        /// <value>
        /// The property value for 'HoldCauseCode'.
        /// </value>
        public string HoldCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldTime'.
        /// '封锁时刻'.
        /// </summary>
        /// <value>
        /// The property value for 'HoldTime'.
        /// </value>
        public string HoldTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldMaker'.
        /// '封锁责任者'.
        /// </summary>
        /// <value>
        /// The property value for 'HoldMaker'.
        /// </value>
        public string HoldMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ColorDemand'.
        /// '刷色要求'.
        /// </summary>
        /// <value>
        /// The property value for 'ColorDemand'.
        /// </value>
        public string ColorDemand { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldRemark'.
        /// '封锁注释'.
        /// </summary>
        /// <value>
        /// The property value for 'HoldRemark'.
        /// </value>
        public string HoldRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RelMaker'.
        /// '释放责任者'.
        /// </summary>
        /// <value>
        /// The property value for 'RelMaker'.
        /// </value>
        public string RelMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RelRemark'.
        /// '释放注释'.
        /// </summary>
        /// <value>
        /// The property value for 'RelRemark'.
        /// </value>
        public string RelRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RelTime'.
        /// '释放时刻'.
        /// </summary>
        /// <value>
        /// The property value for 'RelTime'.
        /// </value>
        public string RelTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainDecideCode'.
        /// '余材判定代码'.
        /// </summary>
        /// <value>
        /// The property value for 'RemainDecideCode'.
        /// </value>
        public string RemainDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainCauseCode'.
        /// '余材原因代码'.
        /// </summary>
        /// <value>
        /// The property value for 'RemainCauseCode'.
        /// </value>
        public string RemainCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainDecideTime'.
        /// '余材判定时刻'.
        /// </summary>
        /// <value>
        /// The property value for 'RemainDecideTime'.
        /// </value>
        public string RemainDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainDecideMaker'.
        /// '余材判定责任者'.
        /// </summary>
        /// <value>
        /// The property value for 'RemainDecideMaker'.
        /// </value>
        public string RemainDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RemainRemark'.
        /// '余材注释'.
        /// </summary>
        /// <value>
        /// The property value for 'RemainRemark'.
        /// </value>
        public string RemainRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Msc'.
        /// '冶金规范码'.
        /// </summary>
        /// <value>
        /// The property value for 'Msc'.
        /// </value>
        public string Msc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldMsc'.
        /// '原冶金规范码'.
        /// </summary>
        /// <value>
        /// The property value for 'OldMsc'.
        /// </value>
        public string OldMsc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Psc'.
        /// '产品规范码'.
        /// </summary>
        /// <value>
        /// The property value for 'Psc'.
        /// </value>
        public string Psc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldPsc'.
        /// '原产品规范码'.
        /// </summary>
        /// <value>
        /// The property value for 'OldPsc'.
        /// </value>
        public string OldPsc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Apn'.
        /// '产品最终用途码'.
        /// </summary>
        /// <value>
        /// The property value for 'Apn'.
        /// </value>
        public string Apn { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldApn'.
        /// '原产品用途码'.
        /// </summary>
        /// <value>
        /// The property value for 'OldApn'.
        /// </value>
        public string OldApn { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BillOfLadingNo'.
        /// '发货单号'.
        /// </summary>
        /// <value>
        /// The property value for 'BillOfLadingNo'.
        /// </value>
        public string BillOfLadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDisposeCode'.
        /// '物料质量处置代码'.
        /// </summary>
        /// <value>
        /// The property value for 'MatDisposeCode'.
        /// </value>
        public string MatDisposeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ComplexDecideCode'.
        /// '综合判定代码'.
        /// </summary>
        /// <value>
        /// The property value for 'ComplexDecideCode'.
        /// </value>
        public string ComplexDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderName'.
        /// '订货名称'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderName'.
        /// </value>
        public string OrderName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CustomerName'.
        /// '客户名称'.
        /// </summary>
        /// <value>
        /// The property value for 'CustomerName'.
        /// </value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CustomerCode'.
        /// '客户代码'.
        /// </summary>
        /// <value>
        /// The property value for 'CustomerCode'.
        /// </value>
        public string CustomerCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Status'.
        /// '0：无，1：已上包装线， 2：在库， 3：已出库 5：未找到库位'.
        /// </summary>
        /// <value>
        /// The property value for 'Status'.
        /// </value>
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SourceType'.
        /// '0：人工录入，1：二级系统，2：三级系统，3：ERP系统'.
        /// </summary>
        /// <value>
        /// The property value for 'SourceType'.
        /// </value>
        public int? SourceType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HeadDirection'.
        /// '带头的方向 0：正向 1：反向'.
        /// </summary>
        /// <value>
        /// The property value for 'HeadDirection'.
        /// </value>
        public int? HeadDirection { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsLoadEnable'.
        /// '0:无 1：可吊取 2：不可吊取'.
        /// </summary>
        /// <value>
        /// The property value for 'IsLoadEnable'.
        /// </value>
        public int? IsLoadEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Description'.
        /// '物料的备注信息'.
        /// </summary>
        /// <value>
        /// The property value for 'Description'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OnlineWeight'.
        /// '实际重量（在线称重重量）'.
        /// </summary>
        /// <value>
        /// The property value for 'OnlineWeight'.
        /// </value>
        public int? OnlineWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OfflineWeight'.
        /// '实际重量（离线称重重量）'.
        /// </summary>
        /// <value>
        /// The property value for 'OfflineWeight'.
        /// </value>
        public int? OfflineWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliveryDate'.
        /// '交货日期'.
        /// </summary>
        /// <value>
        /// The property value for 'DeliveryDate'.
        /// </value>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EndUserCode'.
        /// '最终用户代码'.
        /// </summary>
        /// <value>
        /// The property value for 'EndUserCode'.
        /// </value>
        public string EndUserCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StockType'.
        /// '存储状态，0：正常存储，1退回改判 ，2：需要移库'.
        /// </summary>
        /// <value>
        /// The property value for 'StockType'.
        /// </value>
        public int? StockType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DefectType'.
        /// '缺陷类型，0：无，1：提前进手包区，2：手包完成，3：重上包装线，4：包装异常，不自动下线，5：未判定合格不能入成品库，6：判定合格入成品库'.
        /// </summary>
        /// <value>
        /// The property value for 'DefectType'.
        /// </value>
        public int? DefectType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsHandleDefect'.
        /// '是否立即处理缺陷，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value for 'IsHandleDefect'.
        /// </value>
        public int? IsHandleDefect { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OnTrainType'.
        /// '火车装载类型，0： 无  1： 发货  2：退货 3： 配重'.
        /// </summary>
        /// <value>
        /// The property value for 'OnTrainType'.
        /// </value>
        public int? OnTrainType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ReturnReasonType'.
        /// '退货原因'.
        /// </summary>
        /// <value>
        /// The property value for 'ReturnReasonType'.
        /// </value>
        public int? ReturnReasonType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PickState'.
        /// '0：未挑库，1：移库预挑库，2：发货预挑库，3：发货已挑库'.
        /// </summary>
        /// <value>
        /// The property value for 'PickState'.
        /// </value>
        public int? PickState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PrepickTransferNo'.
        /// '移库单号预挑库'.
        /// </summary>
        /// <value>
        /// The property value for 'PrepickTransferNo'.
        /// </value>
        public string PrepickTransferNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliverPickState'.
        /// '替卷状态 0：无，1：被替的卷 2：顶替的卷（临时用，名称未更改）'.
        /// </summary>
        /// <value>
        /// The property value for 'DeliverPickState'.
        /// </value>
        public int? DeliverPickState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckLoadListId'.
        /// '装车清单ID'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckLoadListId'.
        /// </value>
        public string TruckLoadListId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DetailRequestCount'.
        /// '请求次数'.
        /// </summary>
        /// <value>
        /// The property value for 'DetailRequestCount'.
        /// </value>
        public int? DetailRequestCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DefectRecorder'.
        /// '缺陷记录人'.
        /// </summary>
        /// <value>
        /// The property value for 'DefectRecorder'.
        /// </value>
        public string DefectRecorder { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DefectRecordTime'.
        /// '缺陷记录时间'.
        /// </summary>
        /// <value>
        /// The property value for 'DefectRecordTime'.
        /// </value>
        public DateTime? DefectRecordTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DefectDesc'.
        /// '缺陷描述'.
        /// </summary>
        /// <value>
        /// The property value for 'DefectDesc'.
        /// </value>
        public string DefectDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WeightChangedTime'.
        /// '重量变更时间'.
        /// </summary>
        /// <value>
        /// The property value for 'WeightChangedTime'.
        /// </value>
        public DateTime? WeightChangedTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WeightChangedType'.
        /// '重量变更类型'.
        /// </summary>
        /// <value>
        /// The property value for 'WeightChangedType'.
        /// </value>
        public uint? WeightChangedType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayName'.
        /// '下线所在库区'.
        /// </summary>
        /// <value>
        /// The property value for 'BayName'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialLocationOwner'.
        /// '物料的实际库位所属单位，C3或Y8'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialLocationOwner'.
        /// </value>
        public string MaterialLocationOwner { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialBussinessOwner'.
        /// '物料的业务属性，P4L/P4/P5/P6/P7/P8'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialBussinessOwner'.
        /// </value>
        public string MaterialBussinessOwner { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LockMark'.
        /// '锁定标记 0 未锁定 1：已锁定'.
        /// </summary>
        /// <value>
        /// The property value for 'LockMark'.
        /// </value>
        public int? LockMark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LockReason'.
        /// '锁定原因'.
        /// </summary>
        /// <value>
        /// The property value for 'LockReason'.
        /// </value>
        public string LockReason { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PortLotNumber'.
        /// '港口批号（新）'.
        /// </summary>
        /// <value>
        /// The property value for 'PortLotNumber'.
        /// </value>
        public string PortLotNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Terminal'.
        /// '终点码头'.
        /// </summary>
        /// <value>
        /// The property value for 'Terminal'.
        /// </value>
        public string Terminal { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BelongTerminal'.
        /// '终点码头'.
        /// </summary>
        /// <value>
        /// The property value for 'BelongTerminal'.
        /// </value>
        public string BelongTerminal { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BelongDecideWidth'.
        /// '判定宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'BelongDecideWidth'.
        /// </value>
        public int? BelongDecideWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Type'.
        /// '状态, 0：空位，1：预排入库位，2：在库，3：锁定，4：倒运存储'.
        /// </summary>
        /// <value>
        /// The property value for 'Type'.
        /// </value>
        public int? Type { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationName'.
        /// '库位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'LocationName'.
        /// </value>
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerBussinessName'.
        /// '业务区域名称(P4/P5/P6/P7/P8)'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerBussinessName'.
        /// </value>
        public string OwnerBussinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '跨编码'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaCode'.
        /// '区编码'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaCode'.
        /// </value>
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ColNo'.
        /// '列号'.
        /// </summary>
        /// <value>
        /// The property value for 'ColNo'.
        /// </value>
        public int? ColNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RowNo'.
        /// '行号（垛）'.
        /// </summary>
        /// <value>
        /// The property value for 'RowNo'.
        /// </value>
        public int? RowNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FloorNo'.
        /// '层号'.
        /// </summary>
        /// <value>
        /// The property value for 'FloorNo'.
        /// </value>
        public int? FloorNo { get; set; }

        #endregion

    }
}
