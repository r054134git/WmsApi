using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 汽车发货通知单
    /// </summary>
    public partial class TPlTruckDeliveryCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'OperationMark'.
        /// '操作标记   N：新增 C：结案   D：删除 '.
        /// </summary>
        /// <value>
        /// The property value for 'OperationMark'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliveryOrderNo'.
        /// '发货通知单号'.
        /// </summary>
        /// <value>
        /// The property value for 'DeliveryOrderNo'.
        /// </value>
        public string DeliveryOrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ItemCount'.
        /// '发货项目数'.
        /// </summary>
        /// <value>
        /// The property value for 'ItemCount'.
        /// </value>
        public decimal? ItemCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WeightTotal'.
        /// '发货总重量'.
        /// </summary>
        /// <value>
        /// The property value for 'WeightTotal'.
        /// </value>
        public decimal? WeightTotal { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsWeighting'.
        /// '是否过磅'.
        /// </summary>
        /// <value>
        /// The property value for 'IsWeighting'.
        /// </value>
        public string IsWeighting { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CustomerNo'.
        /// '客户编号'.
        /// </summary>
        /// <value>
        /// The property value for 'CustomerNo'.
        /// </value>
        public string CustomerNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ChineseCustomer'.
        /// '客户中文'.
        /// </summary>
        /// <value>
        /// The property value for 'ChineseCustomer'.
        /// </value>
        public string ChineseCustomer { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DeliveryType'.
        /// '发货类别？移库单Y;发货单B '.
        /// </summary>
        /// <value>
        /// The property value for 'DeliveryType'.
        /// </value>
        public string DeliveryType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SalesType'.
        /// '销售方式'.
        /// </summary>
        /// <value>
        /// The property value for 'SalesType'.
        /// </value>
        public string SalesType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductType'.
        /// '产品形态'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductType'.
        /// </value>
        public string ProductType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductTypeChinese'.
        /// '产品形态中文'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductTypeChinese'.
        /// </value>
        public string ProductTypeChinese { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FreightBear'.
        /// '运费担当'.
        /// </summary>
        /// <value>
        /// The property value for 'FreightBear'.
        /// </value>
        public string FreightBear { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransportType'.
        /// '运输方式'.
        /// </summary>
        /// <value>
        /// The property value for 'TransportType'.
        /// </value>
        public string TransportType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SourceHouse'.
        /// '起点仓库'.
        /// </summary>
        /// <value>
        /// The property value for 'SourceHouse'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestHouse'.
        /// '终点仓库'.
        /// </summary>
        /// <value>
        /// The property value for 'DestHouse'.
        /// </value>
        public string DestHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SourceCode'.
        /// '起点代码'.
        /// </summary>
        /// <value>
        /// The property value for 'SourceCode'.
        /// </value>
        public string SourceCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestCode'.
        /// '终点代码'.
        /// </summary>
        /// <value>
        /// The property value for 'DestCode'.
        /// </value>
        public string DestCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SourcePortCode'.
        /// '起点港口代码'.
        /// </summary>
        /// <value>
        /// The property value for 'SourcePortCode'.
        /// </value>
        public string SourcePortCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestPortCode'.
        /// '终点港口代码'.
        /// </summary>
        /// <value>
        /// The property value for 'DestPortCode'.
        /// </value>
        public string DestPortCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PrivateLineCode'.
        /// '专用线代码'.
        /// </summary>
        /// <value>
        /// The property value for 'PrivateLineCode'.
        /// </value>
        public string PrivateLineCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsBillingTwo'.
        /// '是否计算两段运费'.
        /// </summary>
        /// <value>
        /// The property value for 'IsBillingTwo'.
        /// </value>
        public string IsBillingTwo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PortBatchNo'.
        /// '港口批号（新）'.
        /// </summary>
        /// <value>
        /// The property value for 'PortBatchNo'.
        /// </value>
        public string PortBatchNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CarrierCompanyA'.
        /// '承运公司A'.
        /// </summary>
        /// <value>
        /// The property value for 'CarrierCompanyA'.
        /// </value>
        public string CarrierCompanyA { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CarrierCompanyB'.
        /// '承运公司B'.
        /// </summary>
        /// <value>
        /// The property value for 'CarrierCompanyB'.
        /// </value>
        public string CarrierCompanyB { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Note'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Note'.
        /// </value>
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ContractNo'.
        /// '合同号'.
        /// </summary>
        /// <value>
        /// The property value for 'ContractNo'.
        /// </value>
        public string ContractNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ContractItemNo'.
        /// '合同项次号'.
        /// </summary>
        /// <value>
        /// The property value for 'ContractItemNo'.
        /// </value>
        public string ContractItemNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderNo'.
        /// '订单号'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DetailNo'.
        /// '明细号'.
        /// </summary>
        /// <value>
        /// The property value for 'DetailNo'.
        /// </value>
        public string DetailNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SteelGradeNo'.
        /// '牌号'.
        /// </summary>
        /// <value>
        /// The property value for 'SteelGradeNo'.
        /// </value>
        public string SteelGradeNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Thickness'.
        /// '厚度'.
        /// </summary>
        /// <value>
        /// The property value for 'Thickness'.
        /// </value>
        public decimal? Thickness { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Width'.
        /// '宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'Width'.
        /// </value>
        public decimal? Width { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Length'.
        /// '长度'.
        /// </summary>
        /// <value>
        /// The property value for 'Length'.
        /// </value>
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Grade'.
        /// '品级'.
        /// </summary>
        /// <value>
        /// The property value for 'Grade'.
        /// </value>
        public string Grade { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TypeCode'.
        /// '型码'.
        /// </summary>
        /// <value>
        /// The property value for 'TypeCode'.
        /// </value>
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SizeMessage'.
        /// '尺寸讯息'.
        /// </summary>
        /// <value>
        /// The property value for 'SizeMessage'.
        /// </value>
        public string SizeMessage { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SizeMessageChinese'.
        /// '尺寸讯息中文'.
        /// </summary>
        /// <value>
        /// The property value for 'SizeMessageChinese'.
        /// </value>
        public string SizeMessageChinese { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanNo'.
        /// '计划件数'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanNo'.
        /// </value>
        public decimal? PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanWeight'.
        /// '计划重'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanWeight'.
        /// </value>
        public decimal? PlanWeight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsSpecifyCoilNo'.
        /// '是否指定钢卷号。Y：按件 N：按重'.
        /// </summary>
        /// <value>
        /// The property value for 'IsSpecifyCoilNo'.
        /// </value>
        public string IsSpecifyCoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsLast'.
        /// '是否最后一笔'.
        /// </summary>
        /// <value>
        /// The property value for 'IsLast'.
        /// </value>
        public string IsLast { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OldPortBatchNo'.
        /// '旧港口批次号'.
        /// </summary>
        /// <value>
        /// The property value for 'OldPortBatchNo'.
        /// </value>
        public string OldPortBatchNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Specification'.
        /// '规格'.
        /// </summary>
        /// <value>
        /// The property value for 'Specification'.
        /// </value>
        public string Specification { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CarType'.
        /// '车型'.
        /// </summary>
        /// <value>
        /// The property value for 'CarType'.
        /// </value>
        public string CarType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VirtualShipment'.
        /// '虚拟出货'.
        /// </summary>
        /// <value>
        /// The property value for 'VirtualShipment'.
        /// </value>
        public string VirtualShipment { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PieceWeightUpperLimit'.
        /// '单重上限'.
        /// </summary>
        /// <value>
        /// The property value for 'PieceWeightUpperLimit'.
        /// </value>
        public decimal? PieceWeightUpperLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PieceWeightFloorLimit'.
        /// '单重下限'.
        /// </summary>
        /// <value>
        /// The property value for 'PieceWeightFloorLimit'.
        /// </value>
        public decimal? PieceWeightFloorLimit { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Psrno'.
        /// 'psrNo'.
        /// </summary>
        /// <value>
        /// The property value for 'Psrno'.
        /// </value>
        public string Psrno { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MarbiaStandardCode'.
        /// '制造标准代码'.
        /// </summary>
        /// <value>
        /// The property value for 'MarbiaStandardCode'.
        /// </value>
        public string MarbiaStandardCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackageType'.
        /// '包装方式'.
        /// </summary>
        /// <value>
        /// The property value for 'PackageType'.
        /// </value>
        public string PackageType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest1'.
        /// '特殊需求1'.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest1'.
        /// </value>
        public string SpecialRequest1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest2'.
        /// </value>
        public string SpecialRequest2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest3'.
        /// </value>
        public string SpecialRequest3 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest4'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest4'.
        /// </value>
        public string SpecialRequest4 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest5'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest5'.
        /// </value>
        public string SpecialRequest5 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest6'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest6'.
        /// </value>
        public string SpecialRequest6 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest7'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest7'.
        /// </value>
        public string SpecialRequest7 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest8'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest8'.
        /// </value>
        public string SpecialRequest8 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest9'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest9'.
        /// </value>
        public string SpecialRequest9 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest10'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest10'.
        /// </value>
        public string SpecialRequest10 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest11'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest11'.
        /// </value>
        public string SpecialRequest11 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest12'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest12'.
        /// </value>
        public string SpecialRequest12 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest13'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest13'.
        /// </value>
        public string SpecialRequest13 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest14'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest14'.
        /// </value>
        public string SpecialRequest14 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SpecialRequest15'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SpecialRequest15'.
        /// </value>
        public string SpecialRequest15 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UseCode'.
        /// '用途码'.
        /// </summary>
        /// <value>
        /// The property value for 'UseCode'.
        /// </value>
        public string UseCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion

    }
}
