using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TRcInventoryDetailUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'PlanId'.
        /// '盘库批次'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanId'.
        /// </value>
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BundleNo'.
        /// '捆包号'.
        /// </summary>
        /// <value>
        /// The property value for 'BundleNo'.
        /// </value>
        public string BundleNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsScan'.
        /// '是否扫描，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value for 'IsScan'.
        /// </value>
        public int? IsScan { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsWms'.
        /// '是否在库，0：否，1：是'.
        /// </summary>
        /// <value>
        /// The property value for 'IsWms'.
        /// </value>
        public int? IsWms { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WmsLocationName'.
        /// '系统内库位号'.
        /// </summary>
        /// <value>
        /// The property value for 'WmsLocationName'.
        /// </value>
        public string WmsLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UserLocationName'.
        /// '用户输入库位号'.
        /// </summary>
        /// <value>
        /// The property value for 'UserLocationName'.
        /// </value>
        public string UserLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SystemComment'.
        /// '系统分析备注'.
        /// </summary>
        /// <value>
        /// The property value for 'SystemComment'.
        /// </value>
        public string SystemComment { get; set; }

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
