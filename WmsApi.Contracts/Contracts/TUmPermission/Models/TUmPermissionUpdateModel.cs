using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 权限信息
    /// </summary>
    public partial class TUmPermissionUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Seq'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Seq'.
        /// </value>
        public string Seq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Key'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Key'.
        /// </value>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

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
