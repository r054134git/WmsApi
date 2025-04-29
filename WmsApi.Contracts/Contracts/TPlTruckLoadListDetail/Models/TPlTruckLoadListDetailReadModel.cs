using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 汽车发货通知单明细
    /// </summary>
    public partial class TPlTruckLoadListDetailReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TruckLoadingNo'.
        /// '装车清单号'.
        /// </summary>
        /// <value>
        /// The property value for 'TruckLoadingNo'.
        /// </value>
        public string TruckLoadingNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CoilNo'.
        /// '卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'CoilNo'.
        /// </value>
        public string CoilNo { get; set; }

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
