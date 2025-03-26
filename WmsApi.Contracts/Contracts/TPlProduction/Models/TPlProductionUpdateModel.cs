using System;
using System.Collections.Generic;

namespace WmsApi.Contracts.Models
{
    /// <summary>
    /// View Model class
    /// 来自ERP或L3管理系统的生产计划
    /// </summary>
    public partial class TPlProductionUpdateModel
        : EntityUpdateModel
    {
        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value for 'ProductionNo'.
        /// '计划号'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductionNo'.
        /// </value>
        public string ProductionNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'ProductionSeq'.
        /// '计划执行顺序号'.
        /// </summary>
        /// <value>
        /// The property value for 'ProductionSeq'.
        /// </value>
        public int? ProductionSeq { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanState'.
        /// '计划状态 04-正式计划 06-释放  08-下发 33-已上料'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanState'.
        /// </value>
        public string PlanState { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'PlanCount'.
        /// '计划总卷数'.
        /// </summary>
        /// <value>
        /// The property value for 'PlanCount'.
        /// </value>
        public int? PlanCount { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'UnitNo'.
        /// '机组号'.
        /// </summary>
        /// <value>
        /// The property value for 'UnitNo'.
        /// </value>
        public string UnitNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'NextProcessId'.
        /// '吊运类型'.
        /// </summary>
        /// <value>
        /// The property value for 'NextProcessId'.
        /// </value>
        public string NextProcessId { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderNo'.
        /// '订单编号'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderNo'.
        /// </value>
        public string OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the property value for 'OrderItemNo'.
        /// '订单项次'.
        /// </summary>
        /// <value>
        /// The property value for 'OrderItemNo'.
        /// </value>
        public int? OrderItemNo { get; set; }

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
