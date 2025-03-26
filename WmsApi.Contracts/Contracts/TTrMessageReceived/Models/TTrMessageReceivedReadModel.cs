using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 电文发送跟踪
    /// </summary>
    public partial class TTrMessageReceivedReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'MessageId'.
        /// '电文ID'.
        /// </summary>
        /// <value>
        /// The property value for 'MessageId'.
        /// </value>
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MessageContent'.
        /// '电文内容，JSON'.
        /// </summary>
        /// <value>
        /// The property value for 'MessageContent'.
        /// </value>
        public string MessageContent { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SummaryInfo'.
        /// '电文唯一标识（sha1摘要）'.
        /// </summary>
        /// <value>
        /// The property value for 'SummaryInfo'.
        /// </value>
        public string SummaryInfo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SendState'.
        /// '是否发送完成，1：已发送，2：发送完成'.
        /// </summary>
        /// <value>
        /// The property value for 'SendState'.
        /// </value>
        public int SendState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SendCount'.
        /// '总发送次数'.
        /// </summary>
        /// <value>
        /// The property value for 'SendCount'.
        /// </value>
        public int? SendCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SendTime'.
        /// '发送时间'.
        /// </summary>
        /// <value>
        /// The property value for 'SendTime'.
        /// </value>
        public DateTime? SendTime { get; set; }

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
