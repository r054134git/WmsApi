using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TRcWorkModeCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CraneName'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CraneName'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FromMode'.
        /// '行车状态  1：手动 3：自动'.
        /// </summary>
        /// <value>
        /// The property value for 'FromMode'.
        /// </value>
        public int FromMode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ToMode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'ToMode'.
        /// </value>
        public int ToMode { get; set; }

        #endregion

    }
}
