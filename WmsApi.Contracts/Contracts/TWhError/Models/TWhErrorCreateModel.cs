using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TWhErrorCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'SourceType'.
        /// '0：无，1：行车PLC，2：过跨车，3：地面PLC'.
        /// </summary>
        /// <value>
        /// The property value for 'SourceType'.
        /// </value>
        public int SourceType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ErrorCode'.
        /// '错误代码'.
        /// </summary>
        /// <value>
        /// The property value for 'ErrorCode'.
        /// </value>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ErrorMessage'.
        /// '错误描述'.
        /// </summary>
        /// <value>
        /// The property value for 'ErrorMessage'.
        /// </value>
        public string ErrorMessage { get; set; }

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
