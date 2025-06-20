using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 班次信息
    /// </summary>
    public partial class TUmShiftCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '班次名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StartTime'.
        /// '开始时间'.
        /// </summary>
        /// <value>
        /// The property value for 'StartTime'.
        /// </value>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EndTime'.
        /// '结束时间'.
        /// </summary>
        /// <value>
        /// The property value for 'EndTime'.
        /// </value>
        public DateTime EndTime { get; set; }

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
