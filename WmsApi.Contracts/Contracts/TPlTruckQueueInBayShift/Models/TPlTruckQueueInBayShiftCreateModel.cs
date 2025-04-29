using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库内排队信息，进库车辆信息有变更时发送（倒运）
    /// </summary>
    public partial class TPlTruckQueueInBayShiftCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'OperationMark'.
        /// '操作标记      N:新增,D：删除'.
        /// </summary>
        /// <value>
        /// The property value for 'OperationMark'.
        /// </value>
        public string OperationMark { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OutHouse'.
        /// '出库库房'.
        /// </summary>
        /// <value>
        /// The property value for 'OutHouse'.
        /// </value>
        public string OutHouse { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CardNo'.
        /// '卡号'.
        /// </summary>
        /// <value>
        /// The property value for 'CardNo'.
        /// </value>
        public string CardNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'VehicleNo'.
        /// '车辆号'.
        /// </summary>
        /// <value>
        /// The property value for 'VehicleNo'.
        /// </value>
        public string VehicleNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ArriveNo'.
        /// '报道号'.
        /// </summary>
        /// <value>
        /// The property value for 'ArriveNo'.
        /// </value>
        public string ArriveNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckLoadingNo'.
        /// '装车清单号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckLoadingNo'.
        /// </value>
        public string TruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TruckLoad'.
        /// '载重'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckLoad'.
        /// </value>
        public decimal? TruckLoad { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EntryHouse'.
        /// '入库库房'.
        /// </summary>
        /// <value>
        /// The property value for 'EntryHouse'.
        /// </value>
        public string EntryHouse { get; set; }

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
        /// '明细号（订单项次）'.
        /// </summary>
        /// <value>
        /// The property value for 'DetailNo'.
        /// </value>
        public string DetailNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'No'.
        /// '材料号'.
        /// </summary>
        /// <value>
        /// The property value for 'No'.
        /// </value>
        public string No { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ItemCount'.
        /// '计划件数'.
        /// </summary>
        /// <value>
        /// The property value for 'ItemCount'.
        /// </value>
        public decimal? ItemCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WeightTotal'.
        /// '计划重量'.
        /// </summary>
        /// <value>
        /// The property value for 'WeightTotal'.
        /// </value>
        public decimal? WeightTotal { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// '备注 '.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion

    }
}
