using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 
    /// </summary>
    public partial class TPlCraneMaintenanceUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'BayId'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value for 'BayId'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayName'.
        /// '跨名称'.
        /// </summary>
        /// <value>
        /// The property value for 'BayName'.
        /// </value>
        public string BayName { get; set; }

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
        /// Gets or sets the property value for 'AreaMixX'.
        /// '停靠区域最小X坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaMixX'.
        /// </value>
        public decimal? AreaMixX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaMaxX'.
        /// '停靠区域最大X坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaMaxX'.
        /// </value>
        public decimal? AreaMaxX { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'AreaZ'.
        /// '停靠区域Z坐标'.
        /// </summary>
        /// <value>
        /// The property value for 'AreaZ'.
        /// </value>
        public decimal? AreaZ { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'State'.
        /// '检修流程状态0-未开始 1-集控中心申请2-行车停靠固定位置3-按下操作台急停按钮4-领取检修牌5-按下行车登机盒急停6-挂好检修牌7-打开大车端梁门8-开始检修   9-关闭大车端梁门10-取下检修牌11-旋开登机盒急停按钮并复位钥匙开关12-归还检修牌13-旋开操作台急停按钮14-集控中心销案'.
        /// </summary>
        /// <value>
        /// The property value for 'State'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StartTime'.
        /// '检修开始时间'.
        /// </summary>
        /// <value>
        /// The property value for 'StartTime'.
        /// </value>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EndTime'.
        /// '检修结束时间'.
        /// </summary>
        /// <value>
        /// The property value for 'EndTime'.
        /// </value>
        public DateTime? EndTime { get; set; }

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
