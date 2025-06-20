using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 安全围栏的跟踪
    /// </summary>
    public partial class TTrFenceAreaCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'FenceId'.
        /// '围栏区'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceId'.
        /// </value>
        public string FenceId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FenceSpaceState'.
        /// '围栏区管控状态，0：无管控，可通行，1：禁止通行'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceSpaceState'.
        /// </value>
        public int FenceSpaceState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'FenceUsers'.
        /// '围栏内的所有用户'.
        /// </summary>
        /// <value>
        /// The property value for 'FenceUsers'.
        /// </value>
        public string FenceUsers { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '所属跨id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

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
