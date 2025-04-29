using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 自动编码信息表
    /// </summary>
    public partial class TPlAutoCodeCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CodeType'.
        /// '序列号类型'.
        /// </summary>
        /// <value>
        /// The property value for 'CodeType'.
        /// </value>
        public string CodeType { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Owner'.
        /// '序列号所有者'.
        /// </summary>
        /// <value>
        /// The property value for 'Owner'.
        /// </value>
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InitNum'.
        /// '序列号初值'.
        /// </summary>
        /// <value>
        /// The property value for 'InitNum'.
        /// </value>
        public string InitNum { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'InitCycle'.
        /// '序列号递增'.
        /// </summary>
        /// <value>
        /// The property value for 'InitCycle'.
        /// </value>
        public string InitCycle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CurSernum'.
        /// '序列号'.
        /// </summary>
        /// <value>
        /// The property value for 'CurSernum'.
        /// </value>
        public string CurSernum { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ZeroFlg'.
        /// '序列号长度'.
        /// </summary>
        /// <value>
        /// The property value for 'ZeroFlg'.
        /// </value>
        public string ZeroFlg { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SequenceStyle'.
        /// '序列号样式'.
        /// </summary>
        /// <value>
        /// The property value for 'SequenceStyle'.
        /// </value>
        public string SequenceStyle { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Memo'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value for 'Memo'.
        /// </value>
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LastDate'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'LastDate'.
        /// </value>
        public DateTime? LastDate { get; set; }

        #endregion

    }
}
