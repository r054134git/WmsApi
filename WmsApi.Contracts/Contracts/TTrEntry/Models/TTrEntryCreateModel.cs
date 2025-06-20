using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 库区入口道闸状态的追踪
    /// </summary>
    public partial class TTrEntryCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'GateId'.
        /// '库区道闸id'.
        /// </summary>
        /// <value>
        /// The property value for 'GateId'.
        /// </value>
        public string GateId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '道闸名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Code'.
        /// '唯一代码'.
        /// </summary>
        /// <value>
        /// The property value for 'Code'.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GateState'.
        /// '库区道闸状态，0：关闭（杆落下），1：开启（杆抬起）'.
        /// </summary>
        /// <value>
        /// The property value for 'GateState'.
        /// </value>
        public int GateState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LedContent'.
        /// 'IP地址'.
        /// </summary>
        /// <value>
        /// The property value for 'LedContent'.
        /// </value>
        public string LedContent { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsUsing'.
        /// '库区道闸是否在使用，0：无，1：是'.
        /// </summary>
        /// <value>
        /// The property value for 'IsUsing'.
        /// </value>
        public int IsUsing { get; set; }

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
