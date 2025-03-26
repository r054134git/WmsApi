using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_truck_delivery'.
    /// </summary>
    public partial class TPlTruckDelivery
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlTruckDelivery"/> class.
        /// 汽车发货通知单
        /// </summary>
        public TPlTruckDelivery()
        {
            #region Generated Constructor
            OwnerTPlTruckDeliveryDetails = new HashSet<TPlTruckDeliveryDetail>();
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// '主键'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OPERATION_MARK'.
        /// '操作标记   N：新增 C：结案   D：删除 '.
        /// </summary>
        /// <value>
        /// The property value representing column 'OPERATION_MARK'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVERY_ORDER_NO'.
        /// '发货通知单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVERY_ORDER_NO'.
        /// </value>
        public string DeliveryOrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ITEM_COUNT'.
        /// '发货项目数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ITEM_COUNT'.
        /// </value>
        public decimal? ItemCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT_TOTAL'.
        /// '发货总重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT_TOTAL'.
        /// </value>
        public decimal? WeightTotal { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_WEIGHTING'.
        /// '是否过磅'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_WEIGHTING'.
        /// </value>
        public string IsWeighting { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CUSTOMER_NO'.
        /// '客户编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CUSTOMER_NO'.
        /// </value>
        public string CustomerNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CHINESE_CUSTOMER'.
        /// '客户中文'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CHINESE_CUSTOMER'.
        /// </value>
        public string ChineseCustomer { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DELIVERY_TYPE'.
        /// '发货类别？移库单Y;发货单B '.
        /// </summary>
        /// <value>
        /// The property value representing column 'DELIVERY_TYPE'.
        /// </value>
        public string DeliveryType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SALES_TYPE'.
        /// '销售方式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SALES_TYPE'.
        /// </value>
        public string SalesType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCT_TYPE'.
        /// '产品形态'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCT_TYPE'.
        /// </value>
        public string ProductType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCT_TYPE_CHINESE'.
        /// '产品形态中文'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCT_TYPE_CHINESE'.
        /// </value>
        public string ProductTypeChinese { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FREIGHT_BEAR'.
        /// '运费担当'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FREIGHT_BEAR'.
        /// </value>
        public string FreightBear { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRANSPORT_TYPE'.
        /// '运输方式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRANSPORT_TYPE'.
        /// </value>
        public string TransportType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE_HOUSE'.
        /// '起点仓库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE_HOUSE'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_HOUSE'.
        /// '终点仓库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_HOUSE'.
        /// </value>
        public string DestHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE_CODE'.
        /// '起点代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE_CODE'.
        /// </value>
        public string SourceCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_CODE'.
        /// '终点代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_CODE'.
        /// </value>
        public string DestCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE_PORT_CODE'.
        /// '起点港口代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE_PORT_CODE'.
        /// </value>
        public string SourcePortCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DEST_PORT_CODE'.
        /// '终点港口代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DEST_PORT_CODE'.
        /// </value>
        public string DestPortCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRIVATE_LINE_CODE'.
        /// '专用线代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRIVATE_LINE_CODE'.
        /// </value>
        public string PrivateLineCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_BILLING_TWO'.
        /// '是否计算两段运费'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_BILLING_TWO'.
        /// </value>
        public string IsBillingTwo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PORT_BATCH_NO'.
        /// '港口批号（新）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PORT_BATCH_NO'.
        /// </value>
        public string PortBatchNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CARRIER_COMPANY_A'.
        /// '承运公司A'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CARRIER_COMPANY_A'.
        /// </value>
        public string CarrierCompanyA { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CARRIER_COMPANY_B'.
        /// '承运公司B'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CARRIER_COMPANY_B'.
        /// </value>
        public string CarrierCompanyB { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NOTE'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NOTE'.
        /// </value>
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CONTRACT_NO'.
        /// '合同号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CONTRACT_NO'.
        /// </value>
        public string ContractNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CONTRACT_ITEM_NO'.
        /// '合同项次号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CONTRACT_ITEM_NO'.
        /// </value>
        public string ContractItemNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// '订单号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DETAIL_NO'.
        /// '明细号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DETAIL_NO'.
        /// </value>
        public string DetailNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STEEL_GRADE_NO'.
        /// '牌号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STEEL_GRADE_NO'.
        /// </value>
        public string SteelGradeNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'THICKNESS'.
        /// '厚度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'THICKNESS'.
        /// </value>
        public decimal? Thickness { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WIDTH'.
        /// '宽度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WIDTH'.
        /// </value>
        public decimal? Width { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LENGTH'.
        /// '长度'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LENGTH'.
        /// </value>
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GRADE'.
        /// '品级'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GRADE'.
        /// </value>
        public string Grade { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TYPE_CODE'.
        /// '型码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TYPE_CODE'.
        /// </value>
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SIZE_MESSAGE'.
        /// '尺寸讯息'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SIZE_MESSAGE'.
        /// </value>
        public string SizeMessage { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SIZE_MESSAGE_CHINESE'.
        /// '尺寸讯息中文'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SIZE_MESSAGE_CHINESE'.
        /// </value>
        public string SizeMessageChinese { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_NO'.
        /// '计划件数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_NO'.
        /// </value>
        public decimal? PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_WEIGHT'.
        /// '计划重'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_WEIGHT'.
        /// </value>
        public decimal? PlanWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_SPECIFY_COIL_NO'.
        /// '是否指定钢卷号。Y：按件 N：按重'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_SPECIFY_COIL_NO'.
        /// </value>
        public string IsSpecifyCoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_LAST'.
        /// '是否最后一笔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_LAST'.
        /// </value>
        public string IsLast { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OLD_PORT_BATCH_NO'.
        /// '旧港口批次号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OLD_PORT_BATCH_NO'.
        /// </value>
        public string OldPortBatchNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIFICATION'.
        /// '规格'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIFICATION'.
        /// </value>
        public string Specification { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CAR_TYPE'.
        /// '车型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CAR_TYPE'.
        /// </value>
        public string CarType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'VIRTUAL_SHIPMENT'.
        /// '虚拟出货'.
        /// </summary>
        /// <value>
        /// The property value representing column 'VIRTUAL_SHIPMENT'.
        /// </value>
        public string VirtualShipment { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PIECE_WEIGHT_UPPER_LIMIT'.
        /// '单重上限'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PIECE_WEIGHT_UPPER_LIMIT'.
        /// </value>
        public decimal? PieceWeightUpperLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PIECE_WEIGHT_FLOOR_LIMIT'.
        /// '单重下限'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PIECE_WEIGHT_FLOOR_LIMIT'.
        /// </value>
        public decimal? PieceWeightFloorLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PSRNO'.
        /// 'psrNo'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PSRNO'.
        /// </value>
        public string Psrno { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MARBIA_STANDARD_CODE'.
        /// '制造标准代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MARBIA_STANDARD_CODE'.
        /// </value>
        public string MarbiaStandardCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PACKAGE_TYPE'.
        /// '包装方式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PACKAGE_TYPE'.
        /// </value>
        public string PackageType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_1'.
        /// '特殊需求1'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_1'.
        /// </value>
        public string SpecialRequest1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_2'.
        /// </value>
        public string SpecialRequest2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_3'.
        /// </value>
        public string SpecialRequest3 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_4'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_4'.
        /// </value>
        public string SpecialRequest4 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_5'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_5'.
        /// </value>
        public string SpecialRequest5 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_6'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_6'.
        /// </value>
        public string SpecialRequest6 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_7'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_7'.
        /// </value>
        public string SpecialRequest7 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_8'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_8'.
        /// </value>
        public string SpecialRequest8 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_9'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_9'.
        /// </value>
        public string SpecialRequest9 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_10'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_10'.
        /// </value>
        public string SpecialRequest10 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_11'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_11'.
        /// </value>
        public string SpecialRequest11 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_12'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_12'.
        /// </value>
        public string SpecialRequest12 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_13'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_13'.
        /// </value>
        public string SpecialRequest13 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_14'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_14'.
        /// </value>
        public string SpecialRequest14 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SPECIAL_REQUEST_15'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SPECIAL_REQUEST_15'.
        /// </value>
        public string SpecialRequest15 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USE_CODE'.
        /// '用途码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USE_CODE'.
        /// </value>
        public string UseCode { get; set; }

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

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation collection for entity <see cref="TPlTruckDeliveryDetail" />.
        /// </summary>
        /// <value>
        /// The the navigation collection for entity <see cref="TPlTruckDeliveryDetail" />.
        /// </value>
        public virtual ICollection<TPlTruckDeliveryDetail> OwnerTPlTruckDeliveryDetails { get; set; }

        #endregion

    }
}
