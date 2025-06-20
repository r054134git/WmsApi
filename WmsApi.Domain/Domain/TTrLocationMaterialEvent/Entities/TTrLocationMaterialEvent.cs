using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_location_material_event'.
    /// </summary>
    public partial class TTrLocationMaterialEvent
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrLocationMaterialEvent"/> class.
        /// 
        /// </summary>
        public TTrLocationMaterialEvent()
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
        /// '钢卷'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_NAME'.
        /// '行车'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_NAME'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_LOCATION_NO'.
        /// '起吊库位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_LOCATION_NO'.
        /// </value>
        public string LoadLocationNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_X'.
        /// '起吊X'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_X'.
        /// </value>
        public int? LoadX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_Y'.
        /// '起吊Y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_Y'.
        /// </value>
        public int? LoadY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_LOCATION_NO'.
        /// '落吊库位'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_LOCATION_NO'.
        /// </value>
        public string UnloadLocationNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_X'.
        /// '落吊X'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_X'.
        /// </value>
        public int? UnloadX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_Y'.
        /// '落吊Y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_Y'.
        /// </value>
        public int? UnloadY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_NAME'.
        /// '库'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NAME'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_CONFIRMED'.
        /// '是否确认'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_CONFIRMED'.
        /// </value>
        public int? IsConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CONFIRM_TIME'.
        /// '确认时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CONFIRM_TIME'.
        /// </value>
        public DateTime? ConfirmTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'DESCRIPTION'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'DESCRIPTION'.
        /// </value>
        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
