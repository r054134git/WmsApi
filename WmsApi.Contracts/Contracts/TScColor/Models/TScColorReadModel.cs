using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 3D画面颜色配置信息
    /// </summary>
    public partial class TScColorReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'NormalCoilColor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'NormalCoilColor'.
        /// </value>
        public string NormalCoilColor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SelectedCoilColor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SelectedCoilColor'.
        /// </value>
        public string SelectedCoilColor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanCoilColor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'PlanCoilColor'.
        /// </value>
        public string PlanCoilColor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LockedCoilColor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'LockedCoilColor'.
        /// </value>
        public string LockedCoilColor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NormalLocationColor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'NormalLocationColor'.
        /// </value>
        public string NormalLocationColor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SelectedLocationColor'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'SelectedLocationColor'.
        /// </value>
        public string SelectedLocationColor { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Name'.
        /// '配色方案名称'.
        /// </summary>
        /// <value>
        /// The property value for 'Name'.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsDefault'.
        /// '0：非默认 1：默认'.
        /// </summary>
        /// <value>
        /// The property value for 'IsDefault'.
        /// </value>
        public int? IsDefault { get; set; }

        #endregion

    }
}
