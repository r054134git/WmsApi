using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TScAppCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'AppType'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'AppType'.
        /// </value>
        public string AppType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AppVersion'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'AppVersion'.
        /// </value>
        public string AppVersion { get; set; }

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
