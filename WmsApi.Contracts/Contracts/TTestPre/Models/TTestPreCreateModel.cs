using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TTestPreCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LocationName'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'LocationName'.
        /// </value>
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FloorNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'FloorNo'.
        /// </value>
        public int? FloorNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Weight'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Weight'.
        /// </value>
        public decimal? Weight { get; set; }

        #endregion

    }
}
