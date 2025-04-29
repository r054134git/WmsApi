using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 汽车移库单
    /// </summary>
    public partial class TPlTruckTransferUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'OperationMark'.
        /// 'MES操作标记    N:新增，D:删除、C：生效 F：取消生效'.
        /// </summary>
        /// <value>
        /// The property value for 'OperationMark'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TransferNo'.
        /// '移库单号(WMS自动补全)'.
        /// </summary>
        /// <value>
        /// The property value for 'TransferNo'.
        /// </value>
        public string TransferNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderNo'.
        /// '订单号'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PickCount'.
        /// '件数(WMS自动补全)'.
        /// </summary>
        /// <value>
        /// The property value for 'PickCount'.
        /// </value>
        public int? PickCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WeightMax'.
        /// 'MES汽车载重(kg)'.
        /// </summary>
        /// <value>
        /// The property value for 'WeightMax'.
        /// </value>
        public int? WeightMax { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CardNo'.
        /// 'MES卡号(基本不用)'.
        /// </summary>
        /// <value>
        /// The property value for 'CardNo'.
        /// </value>
        public string CardNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckNo'.
        /// 'MES车牌号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckNo'.
        /// </value>
        public string TruckNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SourceHouse'.
        /// 'MES出库库房（P5/P6/P7/P8）'.
        /// </summary>
        /// <value>
        /// The property value for 'SourceHouse'.
        /// </value>
        public string SourceHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FakeLoadingNo'.
        /// 'MES虚假装车清单号 （下发车辆信息时用于扫码）'.
        /// </summary>
        /// <value>
        /// The property value for 'FakeLoadingNo'.
        /// </value>
        public string FakeLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DestHouse'.
        /// '目的库房(WMS人工补全)'.
        /// </summary>
        /// <value>
        /// The property value for 'DestHouse'.
        /// </value>
        public string DestHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SaddlesCount'.
        /// '鞍座数量(WMS人工补全)'.
        /// </summary>
        /// <value>
        /// The property value for 'SaddlesCount'.
        /// </value>
        public int? SaddlesCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CreateTimeTransfer'.
        /// '移库单创建时间'.
        /// </summary>
        /// <value>
        /// The property value for 'CreateTimeTransfer'.
        /// </value>
        public DateTime? CreateTimeTransfer { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PickState'.
        /// '移库预挑库状态，0：初始化 1：移库单下发，2：收到应答  3：移库单完成(WMS自动补全) 4:已取消'.
        /// </summary>
        /// <value>
        /// The property value for 'PickState'.
        /// </value>
        public int? PickState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsSpecifyCoilNo'.
        /// '是否指定钢卷号。Y：指定材料号，N：不指定'.
        /// </summary>
        /// <value>
        /// The property value for 'IsSpecifyCoilNo'.
        /// </value>
        public string IsSpecifyCoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PrepickType'.
        /// '预配数据类型 1=内贸 2=外贸 3=水汽联运'.
        /// </summary>
        /// <value>
        /// The property value for 'PrepickType'.
        /// </value>
        public int? PrepickType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsDirectTruck'.
        /// '是否是直装车辆 1=是'.
        /// </summary>
        /// <value>
        /// The property value for 'IsDirectTruck'.
        /// </value>
        public int? IsDirectTruck { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsReplaceCoil'.
        /// '装车前是否换卷 1=更换 '.
        /// </summary>
        /// <value>
        /// The property value for 'IsReplaceCoil'.
        /// </value>
        public int? IsReplaceCoil { get; set; }

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
