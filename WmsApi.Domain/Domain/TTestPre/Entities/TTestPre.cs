using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_test_pre'.
    /// </summary>
    public partial class TTestPre
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTestPre"/> class.
        /// 
        /// </summary>
        public TTestPre()
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
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCATION_NAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCATION_NAME'.
        /// </value>
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FLOOR_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'FLOOR_NO'.
        /// </value>
        public int? FloorNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT'.
        /// </value>
        public decimal? Weight { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
