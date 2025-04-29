using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 'v_compare_name_no'.
    /// </summary>
    public partial class VCompareNameNo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCompareNameNo"/> class.
        /// 
        /// </summary>
        public VCompareNameNo()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_NAME_WMS'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_NAME_WMS'.
        /// </value>
        public string LocationNameWms { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_NAME_MES'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_NAME_MES'.
        /// </value>
        public string LocationNameMes { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_NO_WMS'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_NO_WMS'.
        /// </value>
        public string MatNoWms { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MAT_NO_MES'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MAT_NO_MES'.
        /// </value>
        public string MatNoMes { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE_WMS'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE_WMS'.
        /// </value>
        public int IsEnableWms { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID_WMS'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID_WMS'.
        /// </value>
        public string BayIdWms { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STOCK_NO_WMS'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOCK_NO_WMS'.
        /// </value>
        public string StockNoWms { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STOCK_NO_MES'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'STOCK_NO_MES'.
        /// </value>
        public string StockNoMes { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'type'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'type'.
        /// </value>
        public long Type { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
