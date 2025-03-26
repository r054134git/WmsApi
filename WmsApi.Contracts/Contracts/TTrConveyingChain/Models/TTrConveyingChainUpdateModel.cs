using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 运输链跟踪表
    /// </summary>
    public partial class TTrConveyingChainUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'MaterialId'.
        /// '物料ID'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialId'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationId'.
        /// '当前库位ID'.
        /// </summary>
        /// <value>
        /// The property value for 'LocationId'.
        /// </value>
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OnlineTime'.
        /// '上线时间'.
        /// </summary>
        /// <value>
        /// The property value for 'OnlineTime'.
        /// </value>
        public DateTime? OnlineTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ConveyorId'.
        /// '运输工具ID'.
        /// </summary>
        /// <value>
        /// The property value for 'ConveyorId'.
        /// </value>
        public string ConveyorId { get; set; }

        #endregion

    }
}
