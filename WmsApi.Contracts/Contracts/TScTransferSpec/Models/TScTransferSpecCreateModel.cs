using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 数据字典表
    /// </summary>
    public partial class TScTransferSpecCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'SpecWidth'.
        /// '宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'SpecWidth'.
        /// </value>
        public int? SpecWidth { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BelongSpecWidth'.
        /// '归属宽度'.
        /// </summary>
        /// <value>
        /// The property value for 'BelongSpecWidth'.
        /// </value>
        public int? BelongSpecWidth { get; set; }

        #endregion

    }
}
