using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TTrLocationMaterialEventReadModel
        : EntityReadModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '钢卷'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CraneName'.
        /// '行车'.
        /// </summary>
        /// <value>
        /// The property value for 'CraneName'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadLocationNo'.
        /// '起吊库位'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadLocationNo'.
        /// </value>
        public string LoadLocationNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadX'.
        /// '起吊X'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadX'.
        /// </value>
        public int? LoadX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadY'.
        /// '起吊Y'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadY'.
        /// </value>
        public int? LoadY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadLocationNo'.
        /// '落吊库位'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadLocationNo'.
        /// </value>
        public string UnloadLocationNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadX'.
        /// '落吊X'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadX'.
        /// </value>
        public int? UnloadX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadY'.
        /// '落吊Y'.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadY'.
        /// </value>
        public int? UnloadY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayName'.
        /// '库'.
        /// </summary>
        /// <value>
        /// The property value for 'BayName'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsConfirmed'.
        /// '是否确认'.
        /// </summary>
        /// <value>
        /// The property value for 'IsConfirmed'.
        /// </value>
        public int? IsConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ConfirmTime'.
        /// '确认时间'.
        /// </summary>
        /// <value>
        /// The property value for 'ConfirmTime'.
        /// </value>
        public DateTime? ConfirmTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Description'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'Description'.
        /// </value>
        public string Description { get; set; }

        #endregion

    }
}
