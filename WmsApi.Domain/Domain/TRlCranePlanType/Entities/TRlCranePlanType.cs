using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_rl_crane_plan_type'.
    /// </summary>
    public partial class TRlCranePlanType
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TRlCranePlanType"/> class.
        /// 
        /// </summary>
        public TRlCranePlanType()
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
        /// Gets or sets the property value representing column 'BAY_CODE'.
        /// '跨代码'.
        /// </summary>
        /// <value>
        /// The property value representing column 'BAY_CODE'.
        /// </value>
        public string BayCode { get; set; }

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
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME1'.
        /// '计划类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME1'.
        /// </value>
        public string PlanTypeName1 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME2'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME2'.
        /// </value>
        public string PlanTypeName2 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME3'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME3'.
        /// </value>
        public string PlanTypeName3 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME4'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME4'.
        /// </value>
        public string PlanTypeName4 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME5'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME5'.
        /// </value>
        public string PlanTypeName5 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME6'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME6'.
        /// </value>
        public string PlanTypeName6 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME7'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME7'.
        /// </value>
        public string PlanTypeName7 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME8'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME8'.
        /// </value>
        public string PlanTypeName8 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME9'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME9'.
        /// </value>
        public string PlanTypeName9 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME10'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME10'.
        /// </value>
        public string PlanTypeName10 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME11'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME11'.
        /// </value>
        public string PlanTypeName11 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_TYPE_NAME12'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_TYPE_NAME12'.
        /// </value>
        public string PlanTypeName12 { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'AREA_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'AREA_CODE'.
        /// </value>
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNLOAD_AREA_CODE'.
        /// ''.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNLOAD_AREA_CODE'.
        /// </value>
        public string UnloadAreaCode { get; set; }

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
