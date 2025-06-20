using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TRcTelegramReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'LocalCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'LocalCode'.
        /// </value>
        public string LocalCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PartnerCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PartnerCode'.
        /// </value>
        public string PartnerCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RsType'.
        /// '收发类型，1接收，2发送'.
        /// </summary>
        /// <value>
        /// The property value for 'RsType'.
        /// </value>
        public int? RsType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TelegramId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TelegramId'.
        /// </value>
        public string TelegramId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TelegramTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TelegramTime'.
        /// </value>
        public DateTime? TelegramTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Content'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Content'.
        /// </value>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Result'.
        /// '成功，失败'.
        /// </summary>
        /// <value>
        /// The property value for 'Result'.
        /// </value>
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Response'.
        /// '电文回应'.
        /// </summary>
        /// <value>
        /// The property value for 'Response'.
        /// </value>
        public string Response { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LastTime'.
        /// '上一次电文发送时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LastTime'.
        /// </value>
        public DateTime? LastTime { get; set; }

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
