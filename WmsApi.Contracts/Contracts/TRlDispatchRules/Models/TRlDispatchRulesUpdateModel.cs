using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 调度规则表
    /// </summary>
    public partial class TRlDispatchRulesUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'NextProcess'.
        /// '下一工序'.
        /// </summary>
        /// <value>
        /// The property value for 'NextProcess'.
        /// </value>
        public string NextProcess { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WidthMin'.
        /// '宽度最小值'.
        /// </summary>
        /// <value>
        /// The property value for 'WidthMin'.
        /// </value>
        public decimal? WidthMin { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'WidthMax'.
        /// '宽度最大值'.
        /// </summary>
        /// <value>
        /// The property value for 'WidthMax'.
        /// </value>
        public decimal? WidthMax { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ThickMin'.
        /// '厚度最小值'.
        /// </summary>
        /// <value>
        /// The property value for 'ThickMin'.
        /// </value>
        public decimal? ThickMin { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ThickMax'.
        /// '厚度最大值'.
        /// </summary>
        /// <value>
        /// The property value for 'ThickMax'.
        /// </value>
        public decimal? ThickMax { get; set; }

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
