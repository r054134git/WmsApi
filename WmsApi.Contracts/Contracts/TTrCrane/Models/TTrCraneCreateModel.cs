using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TTrCraneCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'CraneId'.
        /// '行车id'.
        /// </summary>
        /// <value>
        /// The property value for 'CraneId'.
        /// </value>
        public string CraneId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CraneName'.
        /// '行车名称'.
        /// </summary>
        /// <value>
        /// The property value for 'CraneName'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CranePlcName'.
        /// '后台通讯报文中的行车名称'.
        /// </summary>
        /// <value>
        /// The property value for 'CranePlcName'.
        /// </value>
        public string CranePlcName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'G'.
        /// '行车代数（二代：2，三代：3）'.
        /// </summary>
        /// <value>
        /// The property value for 'G'.
        /// </value>
        public int? G { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '库id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OpMode'.
        /// '操作模式 1：手动模式，2：半自动模式，3：自动模式，4：检修模式'.
        /// </summary>
        /// <value>
        /// The property value for 'OpMode'.
        /// </value>
        public int? OpMode { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'X'.
        /// 'X'.
        /// </summary>
        /// <value>
        /// The property value for 'X'.
        /// </value>
        public int? X { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Y'.
        /// 'Y'.
        /// </summary>
        /// <value>
        /// The property value for 'Y'.
        /// </value>
        public int? Y { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Z'.
        /// 'Z'.
        /// </summary>
        /// <value>
        /// The property value for 'Z'.
        /// </value>
        public int? Z { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'Weight'.
        /// '重量'.
        /// </summary>
        /// <value>
        /// The property value for 'Weight'.
        /// </value>
        public int? Weight { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'GantryCmd'.
        /// '大车动作命令 0：无动作；1:正向运行; 2:方向运行'.
        /// </summary>
        /// <value>
        /// The property value for 'GantryCmd'.
        /// </value>
        public int? GantryCmd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrolleyCmd'.
        /// '小车动作命令 0：无动作；1:正向运行; 2方向运行'.
        /// </summary>
        /// <value>
        /// The property value for 'TrolleyCmd'.
        /// </value>
        public int? TrolleyCmd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoistCmd'.
        /// '主钩升降命令  0：无动作；1:上升运行; 2:下降运行'.
        /// </summary>
        /// <value>
        /// The property value for 'HoistCmd'.
        /// </value>
        public int? HoistCmd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'SlingCmd'.
        /// '夹具打开命令  0：无动作；1夹具打开命令； 2 ：夹具夹紧命令'.
        /// </summary>
        /// <value>
        /// The property value for 'SlingCmd'.
        /// </value>
        public int? SlingCmd { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'HoistCurrent'.
        /// '主钩实际电流'.
        /// </summary>
        /// <value>
        /// The property value for 'HoistCurrent'.
        /// </value>
        public int? HoistCurrent { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TargetX'.
        /// '目标X'.
        /// </summary>
        /// <value>
        /// The property value for 'TargetX'.
        /// </value>
        public int? TargetX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TargetY'.
        /// '目标Y'.
        /// </summary>
        /// <value>
        /// The property value for 'TargetY'.
        /// </value>
        public int? TargetY { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadLocationName'.
        /// '吊卷库位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadLocationName'.
        /// </value>
        public string LoadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TargetLocationName'.
        /// '目标库位名称'.
        /// </summary>
        /// <value>
        /// The property value for 'TargetLocationName'.
        /// </value>
        public string TargetLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TargetLocationTips'.
        /// '目标库位的位置提示'.
        /// </summary>
        /// <value>
        /// The property value for 'TargetLocationTips'.
        /// </value>
        public string TargetLocationTips { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialId'.
        /// '钢卷id'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialId'.
        /// </value>
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// '钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialIdByUser'.
        /// '用户修改钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialIdByUser'.
        /// </value>
        public string MaterialIdByUser { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNoByUser'.
        /// '用户修改钢卷号'.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNoByUser'.
        /// </value>
        public string MaterialNoByUser { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'IsLoaded'.
        /// '是否已吊卷 0：未吊卷，1：已吊卷'.
        /// </summary>
        /// <value>
        /// The property value for 'IsLoaded'.
        /// </value>
        public int? IsLoaded { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TrackingIndex'.
        /// '追踪索引'.
        /// </summary>
        /// <value>
        /// The property value for 'TrackingIndex'.
        /// </value>
        public int? TrackingIndex { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadableCoils'.
        /// '当前区域可吊取的钢卷Id，以分号分隔'.
        /// </summary>
        /// <value>
        /// The property value for 'LoadableCoils'.
        /// </value>
        public string LoadableCoils { get; set; }

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
