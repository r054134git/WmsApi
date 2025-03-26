using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 安全门的跟踪
    /// </summary>
    public partial class TTrFenceDoorUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'FenceId'.
        /// '围栏区'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceId'.
        /// </value>
        public string FenceId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FenceDoorId'.
        /// '安全门'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceDoorId'.
        /// </value>
        public string FenceDoorId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FenceDoorCode'.
        /// '围栏区Code'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceDoorCode'.
        /// </value>
        public string FenceDoorCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FenceDoorState'.
        /// '安全门状态，0：未知，1：开  2：关 3：急停开'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceDoorState'.
        /// </value>
        public int FenceDoorState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FenceDoorRequest'.
        /// '当前有无请求，0：未知，1：开门请求，2：关门请求'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceDoorRequest'.
        /// </value>
        public int FenceDoorRequest { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RequestSource'.
        /// '请求方式，0：无，1：手持机，2：安全门按钮 3：按钮急停'.
        /// </summary>
        /// <value>
        /// The property value for 'RequestSource'.
        /// </value>
        public int RequestSource { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RequestUser'.
        /// '请求用户'.
        /// </summary>
        /// <value>
        /// The property value for 'RequestUser'.
        /// </value>
        public string RequestUser { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RequestTime'.
        /// '请求时间'.
        /// </summary>
        /// <value>
        /// The property value for 'RequestTime'.
        /// </value>
        public DateTime? RequestTime { get; set; }

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
