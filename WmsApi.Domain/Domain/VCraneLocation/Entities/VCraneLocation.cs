using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 'v_crane_location'.
    /// </summary>
    public partial class VCraneLocation
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VCraneLocation"/> class.
        /// 
        /// </summary>
        public VCraneLocation()
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
        /// Gets or sets the property value representing column 'TASK_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'TASK_NO'.
        /// </value>
        public string TaskNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CRANE_NAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CRANE_NAME'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME'.
        /// '吊运类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME'.
        /// </value>
        public string PlanTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'LOAD_LOCATION_NAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'LOAD_LOCATION_NAME'.
        /// </value>
        public string LoadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_LOCATION_NAME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_LOCATION_NAME'.
        /// </value>
        public string UnloadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'CREATE_TYPE_DESC'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'CREATE_TYPE_DESC'.
        /// </value>
        public string CreateTypeDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UPDATE_TYPE_DESC'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'UPDATE_TYPE_DESC'.
        /// </value>
        public string UpdateTypeDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'BAY_NAME'.
        /// '起点跨'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_NAME'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'EXEC_STATE'.
        /// '执行状态  0：未执行 1：正在执行 2：已完成'.
        /// </summary>
        /// <value>
        /// The property value representing column 'EXEC_STATE'.
        /// </value>
        public int? ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'START_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'START_TIME'.
        /// </value>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'END_TIME'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'END_TIME'.
        /// </value>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'TEAM_NAME'.
        /// '班组ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'TEAM_NAME'.
        /// </value>
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SHIFT_NAME'.
        /// '班别ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SHIFT_NAME'.
        /// </value>
        public string ShiftName { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'USER_NAME'.
        /// '用户ID'.
        /// </summary>
        /// <value>
        /// The property value representing column 'USER_NAME'.
        /// </value>
        public string UserName { get; set; }

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

        /// <summary>
        /// Gets or sets the property value representing column 'POINT_X'.
        /// '与基准点的相对坐标X(单位:m)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'POINT_X'.
        /// </value>
        public decimal PointX { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
