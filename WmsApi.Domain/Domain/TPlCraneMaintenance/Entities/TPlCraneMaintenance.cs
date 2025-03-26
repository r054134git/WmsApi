using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_crane_maintenance'.
    /// </summary>
    public partial class TPlCraneMaintenance
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlCraneMaintenance"/> class.
        /// 
        /// </summary>
        public TPlCraneMaintenance()
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
        /// Gets or sets the property value representing column 'BAY_ID'.
        /// '跨id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_ID'.
        /// </value>
        public string BayId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_NAME'.
        /// '跨名称'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NAME'.
        /// </value>
        public string BayName { get; set; }

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
        /// Gets or sets the property value representing column 'AREA_MIX_X'.
        /// '停靠区域最小X坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_MIX_X'.
        /// </value>
        public decimal? AreaMixX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_MAX_X'.
        /// '停靠区域最大X坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_MAX_X'.
        /// </value>
        public decimal? AreaMaxX { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_Z'.
        /// '停靠区域Z坐标'.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_Z'.
        /// </value>
        public decimal? AreaZ { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'STATE'.
        /// '检修流程状态0-未开始 1-集控中心申请2-行车停靠固定位置3-按下操作台急停按钮4-领取检修牌5-按下行车登机盒急停6-挂好检修牌7-打开大车端梁门8-开始检修   9-关闭大车端梁门10-取下检修牌11-旋开登机盒急停按钮并复位钥匙开关12-归还检修牌13-旋开操作台急停按钮14-集控中心销案'.
        /// </summary>
        /// <value>
        /// The property value representing column 'STATE'.
        /// </value>
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'START_TIME'.
        /// '检修开始时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'START_TIME'.
        /// </value>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'END_TIME'.
        /// '检修结束时间'.
        /// </summary>
        /// <value>
        /// The property value representing column 'END_TIME'.
        /// </value>
        public DateTime? EndTime { get; set; }

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
        #endregion

    }
}
