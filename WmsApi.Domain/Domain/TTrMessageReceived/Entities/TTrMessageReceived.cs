using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_message_received'.
    /// </summary>
    public partial class TTrMessageReceived
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrMessageReceived"/> class.
        /// 电文发送跟踪
        /// </summary>
        public TTrMessageReceived()
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
        /// Gets or sets the property value representing column 'MESSAGE_ID'.
        /// '电文ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MESSAGE_ID'.
        /// </value>
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MESSAGE_CONTENT'.
        /// '电文内容，JSON'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MESSAGE_CONTENT'.
        /// </value>
        public string MessageContent { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SUMMARY_INFO'.
        /// '电文唯一标识（sha1摘要）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SUMMARY_INFO'.
        /// </value>
        public string SummaryInfo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SEND_STATE'.
        /// '是否发送完成，1：已发送，2：发送完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SEND_STATE'.
        /// </value>
        public int SendState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SEND_COUNT'.
        /// '总发送次数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SEND_COUNT'.
        /// </value>
        public int? SendCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SEND_TIME'.
        /// '发送时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SEND_TIME'.
        /// </value>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE'.
        /// '是否可用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE'.
        /// </value>
        public int IsEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_USER'.
        /// '创建人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_USER'.
        /// </value>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_TIME'.
        /// '更新时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_TIME'.
        /// </value>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_USER'.
        /// '更新人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_USER'.
        /// </value>
        public string UpdateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMARK'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMARK'.
        /// </value>
        public string Remark { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
