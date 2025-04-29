using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rc_telegram'.
    /// </summary>
    public partial class TRcTelegram
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRcTelegram"/> class.
        /// 
        /// </summary>
        public TRcTelegram()
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
        /// Gets or sets the property value representing column 'LOCAL_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCAL_CODE'.
        /// </value>
        public string LocalCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PARTNER_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PARTNER_CODE'.
        /// </value>
        public string PartnerCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RS_TYPE'.
        /// '收发类型，1接收，2发送'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RS_TYPE'.
        /// </value>
        public int? RsType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TELEGRAM_ID'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TELEGRAM_ID'.
        /// </value>
        public string TelegramId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TELEGRAM_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TELEGRAM_TIME'.
        /// </value>
        public DateTime? TelegramTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CONTENT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CONTENT'.
        /// </value>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RESULT'.
        /// '成功，失败'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RESULT'.
        /// </value>
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'RESPONSE'.
        /// '电文回应'.
        /// </summary>
        /// <value>
        /// The property value representing column 'RESPONSE'.
        /// </value>
        public string Response { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LAST_TIME'.
        /// '上一次电文发送时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LAST_TIME'.
        /// </value>
        public DateTime? LastTime { get; set; }

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
