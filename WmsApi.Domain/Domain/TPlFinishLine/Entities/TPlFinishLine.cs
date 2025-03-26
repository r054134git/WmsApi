using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_finish_line'.
    /// </summary>
    public partial class TPlFinishLine
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlFinishLine"/> class.
        /// 
        /// </summary>
        public TPlFinishLine()
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
        /// Gets or sets the property value representing column 'LINE_NO'.
        /// '产线编号(机组号)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'LINE_NO'.
        /// </value>
        public string LineNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_NO'.
        /// '计划编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_NO'.
        /// </value>
        public string PlanNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_STATE'.
        /// '计划状态 N :上料  D:取消上料'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_STATE'.
        /// </value>
        public string PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE'.
        /// '计划类型 (CSL：横切，RCL：纵切，ZQL：重卷)'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE'.
        /// </value>
        public string PlanType { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_NO'.
        /// '物料编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_NO'.
        /// </value>
        public string MaterialNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'MATERIAL_SORT_INDEX'.
        /// '物料顺序'.
        /// </summary>
        /// <value>
        /// The property value representing column 'MATERIAL_SORT_INDEX'.
        /// </value>
        public int? MaterialSortIndex { get; set; }

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
