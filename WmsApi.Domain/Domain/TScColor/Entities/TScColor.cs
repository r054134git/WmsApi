using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_sc_color'.
    /// </summary>
    public partial class TScColor
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TScColor"/> class.
        /// 3D画面颜色配置信息
        /// </summary>
        public TScColor()
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
        /// Gets or sets the property value representing column 'NORMAL_COIL_COLOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'NORMAL_COIL_COLOR'.
        /// </value>
        public string NormalCoilColor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SELECTED_COIL_COLOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SELECTED_COIL_COLOR'.
        /// </value>
        public string SelectedCoilColor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_COIL_COLOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_COIL_COLOR'.
        /// </value>
        public string PlanCoilColor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOCKED_COIL_COLOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOCKED_COIL_COLOR'.
        /// </value>
        public string LockedCoilColor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NORMAL_LOCATION_COLOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'NORMAL_LOCATION_COLOR'.
        /// </value>
        public string NormalLocationColor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SELECTED_LOCATION_COLOR'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'SELECTED_LOCATION_COLOR'.
        /// </value>
        public string SelectedLocationColor { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NAME'.
        /// '配色方案名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NAME'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_DEFAULT'.
        /// '0：非默认 1：默认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_DEFAULT'.
        /// </value>
        public int? IsDefault { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
