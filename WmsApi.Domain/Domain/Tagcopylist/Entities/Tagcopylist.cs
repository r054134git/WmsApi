using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 'tagcopylist'.
    /// </summary>
    public partial class Tagcopylist
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tagcopylist"/> class.
        /// 
        /// </summary>
        public Tagcopylist()
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
        /// Gets or sets the property value representing column 'CoilNo'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CoilNo'.
        /// </value>
        public string CoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProdCName'.
        /// '品名'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProdCName'.
        /// </value>
        public string ProdCName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SgStd'.
        /// '标准'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SgStd'.
        /// </value>
        public string SgStd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Edge'.
        /// '规格'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Edge'.
        /// </value>
        public string Edge { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NewWt'.
        /// '实绩重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NewWt'.
        /// </value>
        public double? NewWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GgossWt'.
        /// '毛重'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GgossWt'.
        /// </value>
        public double? GgossWt { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CodeDesc1Content'.
        /// '质量等级'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CodeDesc1Content'.
        /// </value>
        public string CodeDesc1Content { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ProdTime'.
        /// '生产时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ProdTime'.
        /// </value>
        public string ProdTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
