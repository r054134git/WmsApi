using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 一般参数跟踪表
    /// </summary>
    public partial class TTrUserUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'ClientName'.
        /// '客户端名称'.
        /// </summary>
        /// <value>
        /// The property value for 'ClientName'.
        /// </value>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoginUserId'.
        /// '操作用户ID'.
        /// </summary>
        /// <value>
        /// The property value for 'LoginUserId'.
        /// </value>
        public string LoginUserId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TeamId'.
        /// '当前班组ID'.
        /// </summary>
        /// <value>
        /// The property value for 'TeamId'.
        /// </value>
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ShiftId'.
        /// '班别Id'.
        /// </summary>
        /// <value>
        /// The property value for 'ShiftId'.
        /// </value>
        public string ShiftId { get; set; }

        #endregion

    }
}
