using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库内排队信息，进库车辆信息有变更时发送（汽运）
    /// </summary>
    public partial class TPlTruckQueueInBayOutReadModel
        : EntityReadModel
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
        /// Gets or sets the property value for 'TruckLoadingNo'.
        /// '装车清单号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckLoadingNo'.
        /// </value>
        public string TruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'DoorNo'.
        /// '门号'.
        /// </summary>
        /// <value>
        /// The property value for 'DoorNo'.
        /// </value>
        public string DoorNo { get; set; }

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
        /// Gets or sets the property value for 'Location'.
        /// '储位'.
        /// </summary>
        /// <value>
        /// The property value for 'Location'.
        /// </value>
        public string Location { get; set; }

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
