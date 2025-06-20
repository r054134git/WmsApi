using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TRcInventoryUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'PlanNo'.
        /// '计划批次号'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanNo'.
        /// </value>
        public string PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UserAccount'.
        /// '用户账号'.
        /// </summary>
        /// <value>
        /// The property value for 'UserAccount'.
        /// </value>
        public string UserAccount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UserName'.
        /// '姓名'.
        /// </summary>
        /// <value>
        /// The property value for 'UserName'.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// '库编号'.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ScanCount'.
        /// '扫描总数'.
        /// </summary>
        /// <value>
        /// The property value for 'ScanCount'.
        /// </value>
        public int ScanCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WmsCount'.
        /// '系统在库总数'.
        /// </summary>
        /// <value>
        /// The property value for 'WmsCount'.
        /// </value>
        public int WmsCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ScanNotInWmsCount'.
        /// '扫描不在库个数'.
        /// </summary>
        /// <value>
        /// The property value for 'ScanNotInWmsCount'.
        /// </value>
        public int ScanNotInWmsCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ScanInWmsCount'.
        /// '扫描在库个数'.
        /// </summary>
        /// <value>
        /// The property value for 'ScanInWmsCount'.
        /// </value>
        public int ScanInWmsCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WmsNotInScanCount'.
        /// '在库未扫描个数'.
        /// </summary>
        /// <value>
        /// The property value for 'WmsNotInScanCount'.
        /// </value>
        public int WmsNotInScanCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsFinished'.
        /// '0：未完成，1：已完成'.
        /// </summary>
        /// <value>
        /// The property value for 'IsFinished'.
        /// </value>
        public int IsFinished { get; set; }

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
