using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_tr_crane'.
    /// </summary>
    public partial class TTrCrane
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TTrCrane"/> class.
        /// 
        /// </summary>
        public TTrCrane()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'ID'.
        /// 'id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ID'.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_ID'.
        /// '行车id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_ID'.
        /// </value>
        public string CraneId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_NAME'.
        /// '行车名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_NAME'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_PLC_NAME'.
        /// '后台通讯报文中的行车名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_PLC_NAME'.
        /// </value>
        public string CranePlcName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'G'.
        /// '行车代数（二代：2，三代：3）'.
        /// </summary>
        /// <value>
        /// The property value representing column 'G'.
        /// </value>
        public int? G { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '库id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'OP_MODE'.
        /// '操作模式 1：手动模式，2：半自动模式，3：自动模式，4：检修模式'.
        /// </summary>
        /// <value>
        /// The property value representing column 'OP_MODE'.
        /// </value>
        public int? OpMode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'X'.
        /// 'X'.
        /// </summary>
        /// <value>
        /// The property value representing column 'X'.
        /// </value>
        public int? X { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Y'.
        /// 'Y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Y'.
        /// </value>
        public int? Y { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'Z'.
        /// 'Z'.
        /// </summary>
        /// <value>
        /// The property value representing column 'Z'.
        /// </value>
        public int? Z { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'WEIGHT'.
        /// '重量'.
        /// </summary>
        /// <value>
        /// The property value representing column 'WEIGHT'.
        /// </value>
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'GANTRY_CMD'.
        /// '大车动作命令 0：无动作；1:正向运行; 2:方向运行'.
        /// </summary>
        /// <value>
        /// The property value representing column 'GANTRY_CMD'.
        /// </value>
        public int? GantryCmd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TROLLEY_CMD'.
        /// '小车动作命令 0：无动作；1:正向运行; 2方向运行'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TROLLEY_CMD'.
        /// </value>
        public int? TrolleyCmd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOIST_CMD'.
        /// '主钩升降命令  0：无动作；1:上升运行; 2:下降运行'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOIST_CMD'.
        /// </value>
        public int? HoistCmd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SLING_CMD'.
        /// '夹具打开命令  0：无动作；1夹具打开命令； 2 ：夹具夹紧命令'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SLING_CMD'.
        /// </value>
        public int? SlingCmd { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'HOIST_CURRENT'.
        /// '主钩实际电流'.
        /// </summary>
        /// <value>
        /// The property value representing column 'HOIST_CURRENT'.
        /// </value>
        public int? HoistCurrent { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TARGET_X'.
        /// '目标X'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TARGET_X'.
        /// </value>
        public int? TargetX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TARGET_Y'.
        /// '目标Y'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TARGET_Y'.
        /// </value>
        public int? TargetY { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_LOCATION_NAME'.
        /// '吊卷库位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_LOCATION_NAME'.
        /// </value>
        public string LoadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TARGET_LOCATION_NAME'.
        /// '目标库位名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TARGET_LOCATION_NAME'.
        /// </value>
        public string TargetLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TARGET_LOCATION_TIPS'.
        /// '目标库位的位置提示'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TARGET_LOCATION_TIPS'.
        /// </value>
        public string TargetLocationTips { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_ID'.
        /// '钢卷id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_ID'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_ID__BY_USER'.
        /// '用户修改钢卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_ID__BY_USER'.
        /// </value>
        public string MaterialIdByUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO_BY_USER'.
        /// '用户修改钢卷号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO_BY_USER'.
        /// </value>
        public string MaterialNoByUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_LOADED'.
        /// '是否已吊卷 0：未吊卷，1：已吊卷'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_LOADED'.
        /// </value>
        public int? IsLoaded { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TRACKING_INDEX'.
        /// '追踪索引'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TRACKING_INDEX'.
        /// </value>
        public int? TrackingIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOADABLE_COILS'.
        /// '当前区域可吊取的钢卷Id，以分号分隔'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOADABLE_COILS'.
        /// </value>
        public string LoadableCoils { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'IS_ENABLE'.
        /// '是否可用'.
        /// </summary>
        /// <value>
        /// The property value representing column 'IS_ENABLE'.
        /// </value>
        public int IsEnable { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TIME'.
        /// '创建时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TIME'.
        /// </value>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_USER'.
        /// '创建人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_USER'.
        /// </value>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_TIME'.
        /// '更新时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_TIME'.
        /// </value>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_USER'.
        /// '更新人账号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_USER'.
        /// </value>
        public string UpdateUser { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'REMARK'.
        /// '备注'.
        /// </summary>
        /// <value>
        /// The property value representing column 'REMARK'.
        /// </value>
        public string Remark { get; set; }

        #endregion

        #region Generated Relationships
        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TWhBay" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TWhBay" />.
        /// </value>
        /// <seealso cref="BayId" />
        public virtual TWhBay BayTWhBay { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for entity <see cref="TEqCrane" />.
        /// </summary>
        /// <value>
        /// The the navigation property for entity <see cref="TEqCrane" />.
        /// </value>
        /// <seealso cref="CraneId" />
        public virtual TEqCrane CraneTEqCrane { get; set; }

        #endregion

    }
}
