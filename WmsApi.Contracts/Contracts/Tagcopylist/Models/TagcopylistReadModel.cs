using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TagcopylistReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CoilNo'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'CoilNo'.
        /// </value>
        public string CoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdCName'.
        /// '品名'.
        /// </summary>
        /// <value>
        /// The property value for 'ProdCName'.
        /// </value>
        public string ProdCName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SgStd'.
        /// '标准'.
        /// </summary>
        /// <value>
        /// The property value for 'SgStd'.
        /// </value>
        public string SgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Edge'.
        /// '规格'.
        /// </summary>
        /// <value>
        /// The property value for 'Edge'.
        /// </value>
        public string Edge { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NewWt'.
        /// '实绩重量'.
        /// </summary>
        /// <value>
        /// The property value for 'NewWt'.
        /// </value>
        public double? NewWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GgossWt'.
        /// '毛重'.
        /// </summary>
        /// <value>
        /// The property value for 'GgossWt'.
        /// </value>
        public double? GgossWt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CodeDesc1Content'.
        /// '质量等级'.
        /// </summary>
        /// <value>
        /// The property value for 'CodeDesc1Content'.
        /// </value>
        public string CodeDesc1Content { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProdTime'.
        /// '生产时间'.
        /// </summary>
        /// <value>
        /// The property value for 'ProdTime'.
        /// </value>
        public string ProdTime { get; set; }

        #endregion

    }
}
