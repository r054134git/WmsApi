using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TRcLocationsRateCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'Dt'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Dt'.
        /// </value>
        public DateTime Dt { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayCode'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'BayCode'.
        /// </value>
        public string BayCode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CountCoilsFloor1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CountCoilsFloor1'.
        /// </value>
        public int CountCoilsFloor1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CountLocationsFloor1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CountLocationsFloor1'.
        /// </value>
        public int CountLocationsFloor1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CountCoilsFloor2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CountCoilsFloor2'.
        /// </value>
        public int CountCoilsFloor2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CountLocationsFloor2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CountLocationsFloor2'.
        /// </value>
        public int CountLocationsFloor2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RateFloor1'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RateFloor1'.
        /// </value>
        public decimal RateFloor1 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RateFloor2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RateFloor2'.
        /// </value>
        public decimal RateFloor2 { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'RateAll'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'RateAll'.
        /// </value>
        public decimal? RateAll { get; set; }

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
