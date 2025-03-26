using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TPlBackRepackUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '物料号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PackCode'.
        /// '包装线代码'.
        /// </summary>
        /// <value>
        /// The property value for 'PackCode'.
        /// </value>
        public string PackCode { get; set; }

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
