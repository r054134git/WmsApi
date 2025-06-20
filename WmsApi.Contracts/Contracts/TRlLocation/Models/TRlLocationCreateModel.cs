using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库位规则表
    /// </summary>
    public partial class TRlLocationCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'SortIndex'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SortIndex'.
        /// </value>
        public int? SortIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HandleDesc'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'HandleDesc'.
        /// </value>
        public string HandleDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ScriptCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ScriptCode'.
        /// </value>
        public string ScriptCode { get; set; }

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
