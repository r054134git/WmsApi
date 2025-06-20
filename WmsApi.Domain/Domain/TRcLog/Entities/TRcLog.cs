using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_log'.
    /// </summary>
    public partial class TRcLog
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcLog"/> class.
        /// 日志记录表
        /// </summary>
        public TRcLog()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DT'.
        /// </value>
        public DateTime Dt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EVENT_NO'.
        /// '事件编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EVENT_NO'.
        /// </value>
        public string EventNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WARNING_LEVEL'.
        /// '告警级别'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WARNING_LEVEL'.
        /// </value>
        public string WarningLevel { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MESSAGE'.
        /// '消息'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MESSAGE'.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DESCRIPTION'.
        /// '说明'.
        /// </summary>
        /// <value>
        /// The property value representing column 'DESCRIPTION'.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SOURCE'.
        /// '消息源 CDS/CTS/CLIENT'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SOURCE'.
        /// </value>
        public string Source { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
