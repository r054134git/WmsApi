using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库位物料跟踪表
    /// </summary>
    public partial class TRcLocationMaterialReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Type'.
        /// '状态, 0：空位，1：预排入库位，2：在库，3：锁定，4：倒运存储'.
        /// </summary>
        /// <value>
        /// The property value for 'Type'.
        /// </value>
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WarehouseId'.
        /// '库id'.
        /// </summary>
        /// <value>
        /// The property value for 'WarehouseId'.
        /// </value>
        public string WarehouseId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaId'.
        /// '区id'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaId'.
        /// </value>
        public string AreaId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StackId'.
        /// '垛id'.
        /// </summary>
        /// <value>
        /// The property value for 'StackId'.
        /// </value>
        public string StackId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationId'.
        /// '库位ID'.
        /// </summary>
        /// <value>
        /// The property value for 'LocationId'.
        /// </value>
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationName'.
        /// '库位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'LocationName'.
        /// </value>
        public string LocationName { get; set; }

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
        /// Gets or sets the property value for 'RowNo'.
        /// '行号（垛）'.
        /// </summary>
        /// <value>
        /// The property value for 'RowNo'.
        /// </value>
        public int? RowNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ColNo'.
        /// '列号'.
        /// </summary>
        /// <value>
        /// The property value for 'ColNo'.
        /// </value>
        public int ColNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FloorNo'.
        /// '层号'.
        /// </summary>
        /// <value>
        /// The property value for 'FloorNo'.
        /// </value>
        public int FloorNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsVirtual'.
        /// '是否虚拟区'.
        /// </summary>
        /// <value>
        /// The property value for 'IsVirtual'.
        /// </value>
        public int IsVirtual { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerBussinessName'.
        /// '业务区域名称(P4/P5/P6/P7/P8)'.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerBussinessName'.
        /// </value>
        public string OwnerBussinessName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsSharedToC3'.
        /// '是否共享给C3，0：不共享，1：共享'.
        /// </summary>
        /// <value>
        /// The property value for 'IsSharedToC3'.
        /// </value>
        public int IsSharedToC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaCodeC3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'AreaCodeC3'.
        /// </value>
        public string AreaCodeC3 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PointX'.
        /// '与基准点的相对坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'PointX'.
        /// </value>
        public decimal PointX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PointY'.
        /// '与基准点的相对坐标Y(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'PointY'.
        /// </value>
        public decimal PointY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PointZ'.
        /// '与基准点的相对坐标Z(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'PointZ'.
        /// </value>
        public decimal PointZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaxZ'.
        /// '钢卷上沿的高度（单位：m）'.
        /// </summary>
        /// <value>
        /// The property value for 'MaxZ'.
        /// </value>
        public decimal? MaxZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Angle'.
        /// '鞍座的角度'.
        /// </summary>
        /// <value>
        /// The property value for 'Angle'.
        /// </value>
        public int Angle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Orientation'.
        /// '方向 1: 吊具角度与X轴平行  2：吊具角度与Y轴平行'.
        /// </summary>
        /// <value>
        /// The property value for 'Orientation'.
        /// </value>
        public int Orientation { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BaseWidth'.
        /// '基座宽度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'BaseWidth'.
        /// </value>
        public decimal BaseWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BaseLength'.
        /// '基座长度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'BaseLength'.
        /// </value>
        public decimal BaseLength { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BaseHeight'.
        /// '基座高度(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value for 'BaseHeight'.
        /// </value>
        public decimal BaseHeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StorageType'.
        /// '库位类型，  0：无意义，  1：一般存储，  2：废卷存储，  3：倒垛临时占用，  4：任务接力，  5：安全预留，  101：汽车倒运，  102：火车倒运，  103：步进梁鞍座区，  104：电平车鞍座区，  105：过跨车鞍座区，  201：托卷小车出口鞍座区,   202：托卷小车入口鞍座区, '.
        /// </summary>
        /// <value>
        /// The property value for 'StorageType'.
        /// </value>
        public int StorageType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadType'.
        /// '鞍座可吊取类型，  0：无意义，  1：起吊，  2：落吊，  3：起吊和落吊'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadType'.
        /// </value>
        public int LoadType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialId'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialOwner'.
        /// '物料所属单位，C3或Y8'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialOwner'.
        /// </value>
        public string MaterialOwner { get; set; }

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
        public decimal? Thick { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Width'.
        /// '材料宽度mm'.
        /// </summary>
        /// <value>
        /// The property value for 'Width'.
        /// </value>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Weight'.
        /// '产品卷重kg'.
        /// </summary>
        /// <value>
        /// The property value for 'Weight'.
        /// </value>
        public int? Weight { get; set; }

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
        /// '钢卷直径mm'.
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
        /// Gets or sets the property value for 'SteelGrade'.
        /// '内部钢种'.
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
        /// Gets or sets the property value for 'OrderNo'.
        /// '合同号(订单号)'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDirection'.
        /// '材料去向'.
        /// </summary>
        /// <value>
        /// The property value for 'MatDirection'.
        /// </value>
        public string MatDirection { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatStatus'.
        /// '材料状态码'.
        /// </summary>
        /// <value>
        /// The property value for 'MatStatus'.
        /// </value>
        public string MatStatus { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MatDisposeCode'.
        /// '物料质量处置代码'.
        /// </summary>
        /// <value>
        /// The property value for 'MatDisposeCode'.
        /// </value>
        public string MatDisposeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsOrdered'.
        /// '有无主，0：无，1：有'.
        /// </summary>
        /// <value>
        /// The property value for 'IsOrdered'.
        /// </value>
        public int? IsOrdered { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoldFlag'.
        /// '封锁标记'.
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
        /// Gets or sets the property value for 'BillOfLadingNo'.
        /// '发货单号'.
        /// </summary>
        /// <value>
        /// The property value for 'BillOfLadingNo'.
        /// </value>
        public string BillOfLadingNo { get; set; }

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
        /// '0：无，1：计划， 2：在库， 3：已出库，4：确认已出库'.
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
        /// '物料吊取类型 0:无 1：可吊取 2：不可吊取'.
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
        /// Gets or sets the property value for 'PickState'.
        /// '0：未挑库，1：移库预挑库，2：移库已挑库，3发货预挑库，4：发货已挑库'.
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
        /// Gets or sets the property value for 'TruckLoadListId'.
        /// '装车清单NO'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckLoadListId'.
        /// </value>
        public string TruckLoadListId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StockSyncTime'.
        /// '请求库存同步时间'.
        /// </summary>
        /// <value>
        /// The property value for 'StockSyncTime'.
        /// </value>
        public DateTime? StockSyncTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ShiftStratTime'.
        /// '接班时间'.
        /// </summary>
        /// <value>
        /// The property value for 'ShiftStratTime'.
        /// </value>
        public DateTime? ShiftStratTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ShiftEndTime'.
        /// '交班时间'.
        /// </summary>
        /// <value>
        /// The property value for 'ShiftEndTime'.
        /// </value>
        public DateTime? ShiftEndTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ShiftDayNight'.
        /// '班次名（白班/夜班）'.
        /// </summary>
        /// <value>
        /// The property value for 'ShiftDayNight'.
        /// </value>
        public string ShiftDayNight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ShiftName'.
        /// '班组名（甲、乙、丙、丁）'.
        /// </summary>
        /// <value>
        /// The property value for 'ShiftName'.
        /// </value>
        public string ShiftName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialLockedFlag'.
        /// '0：未锁定；1：已锁定'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialLockedFlag'.
        /// </value>
        public string MaterialLockedFlag { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanCmdC3'.
        /// 'C3排定的运输指令'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanCmdC3'.
        /// </value>
        public string PlanCmdC3 { get; set; }

        #endregion

    }
}
