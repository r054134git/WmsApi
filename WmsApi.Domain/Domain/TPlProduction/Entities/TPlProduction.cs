using System;
using System.Collections.Generic;

namespace WmsApi.Domain.Entities
{
    /// <summary>
    /// Entity class representing data for table 't_pl_production'.
    /// </summary>
    public partial class TPlProduction
        : IHaveIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlProduction"/> class.
        /// 来自ERP或L3管理系统的生产计划
        /// </summary>
        public TPlProduction()
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
        /// Gets or sets the property value representing column 'PRODUCTION_NO'.
        /// '计划号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCTION_NO'.
        /// </value>
        public string ProductionNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PRODUCTION_SEQ'.
        /// '计划执行顺序号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PRODUCTION_SEQ'.
        /// </value>
        public int? ProductionSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_STATE'.
        /// '计划状态 04-正式计划 06-释放  08-下发 33-已上料'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_STATE'.
        /// </value>
        public string PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'PLAN_COUNT'.
        /// '计划总卷数'.
        /// </summary>
        /// <value>
        /// The property value representing column 'PLAN_COUNT'.
        /// </value>
        public int? PlanCount { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'UNIT_NO'.
        /// '机组号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'UNIT_NO'.
        /// </value>
        public string UnitNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'NEXT_PROCESS_ID'.
        /// '吊运类型'.
        /// </summary>
        /// <value>
        /// The property value representing column 'NEXT_PROCESS_ID'.
        /// </value>
        public string NextProcessId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_NO'.
        /// '订单编号'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_NO'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'ORDER_ITEM_NO'.
        /// '订单项次'.
        /// </summary>
        /// <value>
        /// The property value representing column 'ORDER_ITEM_NO'.
        /// </value>
        public int? OrderItemNo { get; set; }

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
