using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_location_material'.
    /// </summary>
    public partial class TRcLocationMaterial
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLocationMaterial"/> class.
        /// 库位物料跟踪表
        /// </summary>
        public TRcLocationMaterial()
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
        /// Gets or sets the property value representing column 'TYPE'.
        /// '状态, 0：空位，1：预排入库位，2：在库，3：锁定，4：倒运存储'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WAREHOUSE_ID'.
        /// '库id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WAREHOUSE_ID'.
        /// </value>
        public string WarehouseId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_ID'.
        /// '区id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_ID'.
        /// </value>
        public string AreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STACK_ID'.
        /// '垛id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STACK_ID'.
        /// </value>
        public string StackId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_ID'.
        /// '库位ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_ID'.
        /// </value>
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_NAME'.
        /// '库位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_NAME'.
        /// </value>
        public string LocationName { get; set; }

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
        /// Gets or sets the property value representing column 'ROW_NO'.
        /// '行号（垛）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ROW_NO'.
        /// </value>
        public int? RowNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'COL_NO'.
        /// '列号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'COL_NO'.
        /// </value>
        public int ColNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FLOOR_NO'.
        /// '层号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FLOOR_NO'.
        /// </value>
        public int FloorNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_VIRTUAL'.
        /// '是否虚拟区'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_VIRTUAL'.
        /// </value>
        public int IsVirtual { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OWNER_BUSSINESS_NAME'.
        /// '业务区域名称(P4/P5/P6/P7/P8)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OWNER_BUSSINESS_NAME'.
        /// </value>
        public string OwnerBussinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SHARED_TO_C3'.
        /// '是否共享给C3，0：不共享，1：共享'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SHARED_TO_C3'.
        /// </value>
        public int IsSharedToC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_CODE_C3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_CODE_C3'.
        /// </value>
        public string AreaCodeC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_X'.
        /// '与基准点的相对坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_X'.
        /// </value>
        public decimal PointX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_Y'.
        /// '与基准点的相对坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_Y'.
        /// </value>
        public decimal PointY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_Z'.
        /// '与基准点的相对坐标Z(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_Z'.
        /// </value>
        public decimal PointZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAX_Z'.
        /// '钢卷上沿的高度（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAX_Z'.
        /// </value>
        public decimal? MaxZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ANGLE'.
        /// '鞍座的角度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ANGLE'.
        /// </value>
        public int Angle { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORIENTATION'.
        /// '方向 1: 吊具角度与X轴平行  2：吊具角度与Y轴平行'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORIENTATION'.
        /// </value>
        public int Orientation { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BASE_WIDTH'.
        /// '基座宽度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BASE_WIDTH'.
        /// </value>
        public decimal BaseWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BASE_LENGTH'.
        /// '基座长度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BASE_LENGTH'.
        /// </value>
        public decimal BaseLength { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BASE_HEIGHT'.
        /// '基座高度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BASE_HEIGHT'.
        /// </value>
        public decimal BaseHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STORAGE_TYPE'.
        /// '库位类型，  0：无意义，  1：一般存储，  2：废卷存储，  3：倒垛临时占用，  4：任务接力，  5：安全预留，  101：汽车倒运，  102：火车倒运，  103：步进梁鞍座区，  104：电平车鞍座区，  105：过跨车鞍座区，  201：托卷小车出口鞍座区,   202：托卷小车入口鞍座区, '.
        /// </summary>
        /// <value>
        /// The property value representing column 'STORAGE_TYPE'.
        /// </value>
        public int StorageType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_TYPE'.
        /// '鞍座可吊取类型，  0：无意义，  1：起吊，  2：落吊，  3：起吊和落吊'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_TYPE'.
        /// </value>
        public int LoadType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_ID'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_OWNER'.
        /// '物料所属单位，C3或Y8'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_OWNER'.
        /// </value>
        public string MaterialOwner { get; set; }

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
        public decimal? Thick { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH'.
        /// '材料宽度mm'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH'.
        /// </value>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT'.
        /// '产品卷重kg'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT'.
        /// </value>
        public int? Weight { get; set; }

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
        /// '钢卷直径mm'.
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
        /// Gets or sets the property value representing column 'STEEL_GRADE'.
        /// '内部钢种'.
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
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// '合同号(订单号)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_DIRECTION'.
        /// '材料去向'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_DIRECTION'.
        /// </value>
        public string MatDirection { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_STATUS'.
        /// '材料状态码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_STATUS'.
        /// </value>
        public string MatStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_DISPOSE_CODE'.
        /// '物料质量处置代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_DISPOSE_CODE'.
        /// </value>
        public string MatDisposeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ORDERED'.
        /// '有无主，0：无，1：有'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ORDERED'.
        /// </value>
        public int? IsOrdered { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOLD_FLAG'.
        /// '封锁标记'.
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
        /// Gets or sets the property value representing column 'BILL_OF_LADING_NO'.
        /// '发货单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BILL_OF_LADING_NO'.
        /// </value>
        public string BillOfLadingNo { get; set; }

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
        /// '0：无，1：计划， 2：在库， 3：已出库，4：确认已出库'.
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
        /// '物料吊取类型 0:无 1：可吊取 2：不可吊取'.
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
        /// Gets or sets the property value representing column 'PICK_STATE'.
        /// '0：未挑库，1：移库预挑库，2：移库已挑库，3发货预挑库，4：发货已挑库'.
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
        /// Gets or sets the property value representing column 'TRUCK_LOAD_LIST_ID'.
        /// '装车清单NO'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRUCK_LOAD_LIST_ID'.
        /// </value>
        public string TruckLoadListId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STOCK_SYNC_TIME'.
        /// '请求库存同步时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOCK_SYNC_TIME'.
        /// </value>
        public DateTime? StockSyncTime { get; set; }

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
        /// Gets or sets the property value representing column 'REMARK'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMARK'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SHIFT_STRAT_TIME'.
        /// '接班时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SHIFT_STRAT_TIME'.
        /// </value>
        public DateTime? ShiftStratTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SHIFT_END_TIME'.
        /// '交班时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SHIFT_END_TIME'.
        /// </value>
        public DateTime? ShiftEndTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SHIFT_DAY_NIGHT'.
        /// '班次名（白班/夜班）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SHIFT_DAY_NIGHT'.
        /// </value>
        public string ShiftDayNight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SHIFT_NAME'.
        /// '班组名（甲、乙、丙、丁）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SHIFT_NAME'.
        /// </value>
        public string ShiftName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_LOCKED_FLAG'.
        /// '0：未锁定；1：已锁定'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_LOCKED_FLAG'.
        /// </value>
        public string MaterialLockedFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_CMD_C3'.
        /// 'C3排定的运输指令'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_CMD_C3'.
        /// </value>
        public string PlanCmdC3 { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
