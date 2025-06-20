using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TWhTrainLocationCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'LocationId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'LocationId'.
        /// </value>
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'XInCar'.
        /// '车厢相对X坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'XInCar'.
        /// </value>
        public decimal? XInCar { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'YInCar'.
        /// '车厢相对Y坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'YInCar'.
        /// </value>
        public decimal? YInCar { get; set; }

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
