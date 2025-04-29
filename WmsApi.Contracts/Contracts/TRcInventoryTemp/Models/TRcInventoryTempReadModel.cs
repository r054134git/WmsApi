using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TRcInventoryTempReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'PlanNo'.
        /// '盘库批次'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanNo'.
        /// </value>
        public string PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '跨编码'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationName'.
        /// '库位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'LocationName'.
        /// </value>
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Remark'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Remark'.
        /// </value>
        public string Remark { get; set; }

        #endregion

    }
}
