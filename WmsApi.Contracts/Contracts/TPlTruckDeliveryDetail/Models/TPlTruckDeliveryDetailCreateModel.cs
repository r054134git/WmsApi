using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TPlTruckDeliveryDetailCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CoilNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CoilNo'.
        /// </value>
        public string CoilNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsPicked'.
        /// '是否已挑库，0：未挑库，1：已挑库'.
        /// </summary>
        /// <value>
        /// The property value for 'IsPicked'.
        /// </value>
        public int? IsPicked { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PikcedTime'.
        /// '挑库时间'.
        /// </summary>
        /// <value>
        /// The property value for 'PikcedTime'.
        /// </value>
        public DateTime? PikcedTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OwnerId'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'OwnerId'.
        /// </value>
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsLoaded'.
        /// '是否已装车，0：未装车，1：已装车'.
        /// </summary>
        /// <value>
        /// The property value for 'IsLoaded'.
        /// </value>
        public int? IsLoaded { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadedTime'.
        /// '装车时间'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadedTime'.
        /// </value>
        public DateTime? LoadedTime { get; set; }

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
