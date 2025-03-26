using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 日志记录表
    /// </summary>
    public partial class TRcLogReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Dt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Dt'.
        /// </value>
        public DateTime Dt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EventNo'.
        /// '事件编号'.
        /// </summary>
        /// <value>
        /// The property value for 'EventNo'.
        /// </value>
        public string EventNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WarningLevel'.
        /// '告警级别'.
        /// </summary>
        /// <value>
        /// The property value for 'WarningLevel'.
        /// </value>
        public string WarningLevel { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Message'.
        /// '消息'.
        /// </summary>
        /// <value>
        /// The property value for 'Message'.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Description'.
        /// '说明'.
        /// </summary>
        /// <value>
        /// The property value for 'Description'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Source'.
        /// '消息源 CDS/CTS/CLIENT'.
        /// </summary>
        /// <value>
        /// The property value for 'Source'.
        /// </value>
        public string Source { get; set; }

        #endregion

    }
}
