using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 行车吊运任务计划表
    /// </summary>
    public partial class TRcCraneTaskCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'TaskNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'TaskNo'.
        /// </value>
        public string TaskNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CraneName'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CraneName'.
        /// </value>
        public string CraneName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'MaterialNo'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'MaterialNo'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanTypeName'.
        /// '吊运类型'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanTypeName'.
        /// </value>
        public string PlanTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'LoadLocationName'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'LoadLocationName'.
        /// </value>
        public string LoadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnloadLocationName'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'UnloadLocationName'.
        /// </value>
        public string UnloadLocationName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'CreateTypeDesc'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'CreateTypeDesc'.
        /// </value>
        public string CreateTypeDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UpdateTypeDesc'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'UpdateTypeDesc'.
        /// </value>
        public string UpdateTypeDesc { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'BayName'.
        /// '起点跨'.
        /// </summary>
        /// <value>
        /// The property value for 'BayName'.
        /// </value>
        public string BayName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ExecState'.
        /// '执行状态  0：未执行 1：正在执行 2：已完成'.
        /// </summary>
        /// <value>
        /// The property value for 'ExecState'.
        /// </value>
        public int? ExecState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'StartTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'StartTime'.
        /// </value>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'EndTime'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value for 'EndTime'.
        /// </value>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'TeamName'.
        /// '班组ID'.
        /// </summary>
        /// <value>
        /// The property value for 'TeamName'.
        /// </value>
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ShiftName'.
        /// '班别ID'.
        /// </summary>
        /// <value>
        /// The property value for 'ShiftName'.
        /// </value>
        public string ShiftName { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UserName'.
        /// '用户ID'.
        /// </summary>
        /// <value>
        /// The property value for 'UserName'.
        /// </value>
        public string UserName { get; set; }

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
