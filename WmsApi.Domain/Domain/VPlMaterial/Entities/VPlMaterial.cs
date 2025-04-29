using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 'v_pl_material'.
    /// </summary>
    public partial class VPlMaterial
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VPlMaterial"/> class.
        /// 
        /// </summary>
        public VPlMaterial()
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
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_CREATOR'.
        /// '记录创建责任者'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_CREATOR'.
        /// </value>
        public string RecCreator { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_CREATE_TIME'.
        /// '记录创建时刻'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_CREATE_TIME'.
        /// </value>
        public string RecCreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_REVISOR'.
        /// '记录修改责任者'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_REVISOR'.
        /// </value>
        public string RecRevisor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_REVISE_TIME'.
        /// '记录修改时刻'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_REVISE_TIME'.
        /// </value>
        public string RecReviseTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REC_CREATE_REASON'.
        /// '记录创建原因 1:正常2:盘盈3:合包4:红冲'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REC_CREATE_REASON'.
        /// </value>
        public int? RecCreateReason { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NO'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NO'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MOTHER_NO'.
        /// '母卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MOTHER_NO'.
        /// </value>
        public string MotherNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BUNDLE_PACKAGE_NO'.
        /// '捆包号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BUNDLE_PACKAGE_NO'.
        /// </value>
        public string BundlePackageNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROCESS_CODE'.
        /// '机组代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROCESS_CODE'.
        /// </value>
        public string ProcessCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NEXT_PROCESS_CODE'.
        /// '下道机组代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NEXT_PROCESS_CODE'.
        /// </value>
        public string NextProcessCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'THICK'.
        /// '材料厚度mm'.
        /// </summary>
        /// <value>
        /// The property value representing column 'THICK'.
        /// </value>
        public decimal Thick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH'.
        /// '材料宽度mm'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH'.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT'.
        /// '产品卷重kg'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT'.
        /// </value>
        public int Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LENGTH'.
        /// '产品长度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LENGTH'.
        /// </value>
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DIAMETER'.
        /// '钢卷直径(外径)mm'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DIAMETER'.
        /// </value>
        public int? Diameter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'INNER_DIAMETER'.
        /// '内径'.
        /// </summary>
        /// <value>
        /// The property value representing column 'INNER_DIAMETER'.
        /// </value>
        public int? InnerDiameter { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_SHAPE_FLAG'.
        /// '材料形态标志 3-钢卷'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_SHAPE_FLAG'.
        /// </value>
        public string MatShapeFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_STATUS'.
        /// '材料状态码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_STATUS'.
        /// </value>
        public string MatStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_TARG_THICK'.
        /// '材料目标厚度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_TARG_THICK'.
        /// </value>
        public decimal? MatTargThick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_TARG_WIDTH'.
        /// '材料目标宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_TARG_WIDTH'.
        /// </value>
        public int? MatTargWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_TARG_LEN'.
        /// '材料目标长度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_TARG_LEN'.
        /// </value>
        public int? MatTargLen { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_ACT_WT'.
        /// '材料实际重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_ACT_WT'.
        /// </value>
        public int? MatActWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_THEORY_WT'.
        /// '材料理论重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_THEORY_WT'.
        /// </value>
        public int? MatTheoryWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MEASURE_WT_FLAG'.
        /// '称重标记'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MEASURE_WT_FLAG'.
        /// </value>
        public string MeasureWtFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCT_PACK_FLAG'.
        /// '成品包装标志'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCT_PACK_FLAG'.
        /// </value>
        public string ProductPackFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_DISTRIBUTION_SHIP'.
        /// '是否配船 0 不配船  1 配船'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_DISTRIBUTION_SHIP'.
        /// </value>
        public int? IsDistributionShip { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PONO'.
        /// '制造命令号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PONO'.
        /// </value>
        public string Pono { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HEAT_NO'.
        /// '熔炼号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HEAT_NO'.
        /// </value>
        public string HeatNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STEEL_GRADE'.
        /// '钢品类别'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STEEL_GRADE'.
        /// </value>
        public string SteelGrade { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_TIME'.
        /// '生产时刻'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_TIME'.
        /// </value>
        public string ProdTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_SHIFT_NO'.
        /// '生产班次号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_SHIFT_NO'.
        /// </value>
        public string ProdShiftNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_SHIFT_GROUP'.
        /// '生产班组'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_SHIFT_GROUP'.
        /// </value>
        public string ProdShiftGroup { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SG_SIGN'.
        /// '牌号（钢级）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SG_SIGN'.
        /// </value>
        public string SgSign { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SG_STD'.
        /// '标准'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SG_STD'.
        /// </value>
        public string SgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_SG_SIGN'.
        /// '原牌号（钢级）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_SG_SIGN'.
        /// </value>
        public string OldSgSign { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_SG_STD'.
        /// '原标准'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_SG_STD'.
        /// </value>
        public string OldSgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// '合同号(订单号)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_ORDER_NO'.
        /// '旧的合同号(订单号)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_ORDER_NO'.
        /// </value>
        public string OldOrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_DIRECTION'.
        /// '材料去向(BMWM01 流向 U127)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_DIRECTION'.
        /// </value>
        public string MatDirection { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRNP_MODE_CODE'.
        /// '运输方式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRNP_MODE_CODE'.
        /// </value>
        public string TrnpModeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PACKING_TYPE_CODE'.
        /// '包装类型代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PACKING_TYPE_CODE'.
        /// </value>
        public string PackingTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DECIDE_THICK'.
        /// '判定厚度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DECIDE_THICK'.
        /// </value>
        public decimal? DecideThick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DECIDE_WIDTH'.
        /// '判定宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DECIDE_WIDTH'.
        /// </value>
        public int? DecideWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LABEL_DEMAND'.
        /// '标牌要求'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LABEL_DEMAND'.
        /// </value>
        public string LabelDemand { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ORDERED'.
        /// '有无主，0：无，1：有'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ORDERED'.
        /// </value>
        public int? IsOrdered { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'READY_STATE'.
        /// '备货状态'.
        /// </summary>
        /// <value>
        /// The property value representing column 'READY_STATE'.
        /// </value>
        public string ReadyState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_CODE'.
        /// '品名代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_CODE'.
        /// </value>
        public string ProdCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_CNAME'.
        /// '品名中文'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_CNAME'.
        /// </value>
        public string ProdCname { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PROD_ENAME'.
        /// '品名英文'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PROD_ENAME'.
        /// </value>
        public string ProdEname { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_FLAG'.
        /// '封锁标记 0 正常 2封锁'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_FLAG'.
        /// </value>
        public string HoldFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_CAUSE_CODE'.
        /// '封锁原因代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_CAUSE_CODE'.
        /// </value>
        public string HoldCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_TIME'.
        /// '封锁时刻'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_TIME'.
        /// </value>
        public string HoldTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_MAKER'.
        /// '封锁责任者'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_MAKER'.
        /// </value>
        public string HoldMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COLOR_DEMAND'.
        /// '刷色要求'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COLOR_DEMAND'.
        /// </value>
        public string ColorDemand { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_REMARK'.
        /// '封锁注释'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOLD_REMARK'.
        /// </value>
        public string HoldRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REL_MAKER'.
        /// '释放责任者'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REL_MAKER'.
        /// </value>
        public string RelMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REL_REMARK'.
        /// '释放注释'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REL_REMARK'.
        /// </value>
        public string RelRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REL_TIME'.
        /// '释放时刻'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REL_TIME'.
        /// </value>
        public string RelTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_DECIDE_CODE'.
        /// '余材判定代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_DECIDE_CODE'.
        /// </value>
        public string RemainDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_CAUSE_CODE'.
        /// '余材原因代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_CAUSE_CODE'.
        /// </value>
        public string RemainCauseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_DECIDE_TIME'.
        /// '余材判定时刻'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_DECIDE_TIME'.
        /// </value>
        public string RemainDecideTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_DECIDE_MAKER'.
        /// '余材判定责任者'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_DECIDE_MAKER'.
        /// </value>
        public string RemainDecideMaker { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMAIN_REMARK'.
        /// '余材注释'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMAIN_REMARK'.
        /// </value>
        public string RemainRemark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MSC'.
        /// '冶金规范码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MSC'.
        /// </value>
        public string Msc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_MSC'.
        /// '原冶金规范码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_MSC'.
        /// </value>
        public string OldMsc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PSC'.
        /// '产品规范码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PSC'.
        /// </value>
        public string Psc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_PSC'.
        /// '原产品规范码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_PSC'.
        /// </value>
        public string OldPsc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'APN'.
        /// '产品最终用途码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'APN'.
        /// </value>
        public string Apn { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_APN'.
        /// '原产品用途码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_APN'.
        /// </value>
        public string OldApn { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BILL_OF_LADING_NO'.
        /// '发货单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BILL_OF_LADING_NO'.
        /// </value>
        public string BillOfLadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_DISPOSE_CODE'.
        /// '物料质量处置代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_DISPOSE_CODE'.
        /// </value>
        public string MatDisposeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COMPLEX_DECIDE_CODE'.
        /// '综合判定代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COMPLEX_DECIDE_CODE'.
        /// </value>
        public string ComplexDecideCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NAME'.
        /// '订货名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NAME'.
        /// </value>
        public string OrderName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CUSTOMER_NAME'.
        /// '客户名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CUSTOMER_NAME'.
        /// </value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CUSTOMER_CODE'.
        /// '客户代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CUSTOMER_CODE'.
        /// </value>
        public string CustomerCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STATUS'.
        /// '0：无，1：已上包装线， 2：在库， 3：已出库 5：未找到库位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STATUS'.
        /// </value>
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE_TYPE'.
        /// '0：人工录入，1：二级系统，2：三级系统，3：ERP系统'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE_TYPE'.
        /// </value>
        public int? SourceType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HEAD_DIRECTION'.
        /// '带头的方向 0：正向 1：反向'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HEAD_DIRECTION'.
        /// </value>
        public int? HeadDirection { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_LOAD_ENABLE'.
        /// '0:无 1：可吊取 2：不可吊取'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_LOAD_ENABLE'.
        /// </value>
        public int? IsLoadEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DESCRIPTION'.
        /// '物料的备注信息'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DESCRIPTION'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ONLINE_WEIGHT'.
        /// '实际重量（在线称重重量）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ONLINE_WEIGHT'.
        /// </value>
        public int? OnlineWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OFFLINE_WEIGHT'.
        /// '实际重量（离线称重重量）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OFFLINE_WEIGHT'.
        /// </value>
        public int? OfflineWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVERY_DATE'.
        /// '交货日期'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVERY_DATE'.
        /// </value>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'END_USER_CODE'.
        /// '最终用户代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'END_USER_CODE'.
        /// </value>
        public string EndUserCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STOCK_TYPE'.
        /// '存储状态，0：正常存储，1退回改判 ，2：需要移库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOCK_TYPE'.
        /// </value>
        public int? StockType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEFECT_TYPE'.
        /// '缺陷类型，0：无，1：提前进手包区，2：手包完成，3：重上包装线，4：包装异常，不自动下线，5：未判定合格不能入成品库，6：判定合格入成品库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEFECT_TYPE'.
        /// </value>
        public int? DefectType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_HANDLE_DEFECT'.
        /// '是否立即处理缺陷，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_HANDLE_DEFECT'.
        /// </value>
        public int? IsHandleDefect { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ON_TRAIN_TYPE'.
        /// '火车装载类型，0： 无  1： 发货  2：退货 3： 配重'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ON_TRAIN_TYPE'.
        /// </value>
        public int? OnTrainType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RETURN_REASON_TYPE'.
        /// '退货原因'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RETURN_REASON_TYPE'.
        /// </value>
        public int? ReturnReasonType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PICK_STATE'.
        /// '0：未挑库，1：移库预挑库，2：发货预挑库，3：发货已挑库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PICK_STATE'.
        /// </value>
        public int? PickState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PREPICK_TRANSFER_NO'.
        /// '移库单号预挑库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PREPICK_TRANSFER_NO'.
        /// </value>
        public string PrepickTransferNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVER_PICK_STATE'.
        /// '替卷状态 0：无，1：被替的卷 2：顶替的卷（临时用，名称未更改）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVER_PICK_STATE'.
        /// </value>
        public int? DeliverPickState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRUCK_LOAD_LIST_ID'.
        /// '装车清单ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_LOAD_LIST_ID'.
        /// </value>
        public string TruckLoadListId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DETAIL_REQUEST_COUNT'.
        /// '请求次数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DETAIL_REQUEST_COUNT'.
        /// </value>
        public int? DetailRequestCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEFECT_RECORDER'.
        /// '缺陷记录人'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEFECT_RECORDER'.
        /// </value>
        public string DefectRecorder { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEFECT_RECORD_TIME'.
        /// '缺陷记录时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEFECT_RECORD_TIME'.
        /// </value>
        public DateTime? DefectRecordTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEFECT_DESC'.
        /// '缺陷描述'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEFECT_DESC'.
        /// </value>
        public string DefectDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT_CHANGED_TIME'.
        /// '重量变更时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT_CHANGED_TIME'.
        /// </value>
        public DateTime? WeightChangedTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT_CHANGED_TYPE'.
        /// '重量变更类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT_CHANGED_TYPE'.
        /// </value>
        public uint? WeightChangedType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_NAME'.
        /// '下线所在库区'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NAME'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_LOCATION_OWNER'.
        /// '物料的实际库位所属单位，C3或Y8'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_LOCATION_OWNER'.
        /// </value>
        public string MaterialLocationOwner { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_BUSSINESS_OWNER'.
        /// '物料的业务属性，P4L/P4/P5/P6/P7/P8'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_BUSSINESS_OWNER'.
        /// </value>
        public string MaterialBussinessOwner { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE'.
        /// '是否可用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE'.
        /// </value>
        public int IsEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_USER'.
        /// '创建人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_USER'.
        /// </value>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_TIME'.
        /// '更新时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_TIME'.
        /// </value>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_USER'.
        /// '更新人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_USER'.
        /// </value>
        public string UpdateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCK_MARK'.
        /// '锁定标记 0 未锁定 1：已锁定'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCK_MARK'.
        /// </value>
        public int? LockMark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCK_REASON'.
        /// '锁定原因'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCK_REASON'.
        /// </value>
        public string LockReason { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PORT_LOT_NUMBER'.
        /// '港口批号（新）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PORT_LOT_NUMBER'.
        /// </value>
        public string PortLotNumber { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TERMINAL'.
        /// '终点码头'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TERMINAL'.
        /// </value>
        public string Terminal { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BELONG_TERMINAL'.
        /// '终点码头'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BELONG_TERMINAL'.
        /// </value>
        public string BelongTerminal { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BELONG_DECIDE_WIDTH'.
        /// '判定宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BELONG_DECIDE_WIDTH'.
        /// </value>
        public int? BelongDecideWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMARK'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMARK'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TYPE'.
        /// '状态, 0：空位，1：预排入库位，2：在库，3：锁定，4：倒运存储'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE'.
        /// </value>
        public int? Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_ID'.
        /// '库位ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_ID'.
        /// </value>
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_X'.
        /// '与基准点的相对坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_X'.
        /// </value>
        public decimal? PointX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_Y'.
        /// '与基准点的相对坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_Y'.
        /// </value>
        public decimal? PointY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_NAME'.
        /// '库位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_NAME'.
        /// </value>
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_BUSSINESS_NAME'.
        /// '业务区域名称(P4/P5/P6/P7/P8)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_BUSSINESS_NAME'.
        /// </value>
        public string OwnerBussinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '跨编码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_CODE'.
        /// '区编码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_CODE'.
        /// </value>
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COL_NO'.
        /// '列号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COL_NO'.
        /// </value>
        public int? ColNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ROW_NO'.
        /// '行号（垛）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROW_NO'.
        /// </value>
        public int? RowNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FLOOR_NO'.
        /// '层号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FLOOR_NO'.
        /// </value>
        public int? FloorNo { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
